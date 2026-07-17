#!/usr/bin/env python3
import os
import json
import struct

def get_png_size(filepath):
    """Reads PNG file header to determine width and height without external dependencies."""
    try:
        with open(filepath, 'rb') as f:
            data = f.read(24)
            # Verify PNG signature
            if data[:8] != b'\x89PNG\r\n\x1a\n':
                return None
            # Extract width and height from IHDR chunk
            w, h = struct.unpack('>II', data[16:24])
            return w, h
    except Exception as e:
        print(f"Error reading image header for {filepath}: {e}")
        return None

def validate_ui_assets():
    atlas_json_path = os.path.join("assets", "ui_atlas.json")
    spritesheet_path = os.path.join("assets", "ExportedProject", "Assets", "Resources", "spritesheets", "UI.png")

    print("==================================================")
    print("           Vampire Survivors UI Validator         ")
    print("==================================================\n")

    # 1. Load PNG size
    if not os.path.exists(spritesheet_path):
        print(f"[ERROR] UI Spritesheet not found at {spritesheet_path}")
        return False
    
    png_size = get_png_size(spritesheet_path)
    if not png_size:
        print(f"[ERROR] Could not parse PNG dimensions for {spritesheet_path}")
        return False
    
    tex_w, tex_h = png_size
    print(f"[OK] Loaded UI.png: {tex_w}x{tex_h} pixels.")

    # 2. Load atlas JSON
    if not os.path.exists(atlas_json_path):
        print(f"[ERROR] UI Atlas JSON not found at {atlas_json_path}")
        return False
    
    try:
        with open(atlas_json_path, 'r', encoding='utf-8') as f:
            atlas = json.load(f)
        print(f"[OK] Loaded UI atlas JSON containing {len(atlas)} sprite definitions.")
    except Exception as e:
        print(f"[ERROR] Failed to parse UI atlas JSON: {e}")
        return False

    # 3. Perform validation
    warnings = 0
    errors = 0

    print("\n--- Starting Verification ---")
    for sprite_name, rect in atlas.items():
        if not all(k in rect for k in ["x", "y", "width", "height"]):
            print(f"  [ERROR] Sprite '{sprite_name}' definition is missing coordinate fields!")
            errors += 1
            continue
            
        x, y, w, h = rect["x"], rect["y"], rect["width"], rect["height"]
        if x < 0 or y < 0 or w <= 0 or h <= 0:
            print(f"  [ERROR] Sprite '{sprite_name}' has invalid dimensions: [{x}, {y}, {w}, {h}]")
            errors += 1
            continue

        if x + w > tex_w or y + h > tex_h:
            print(f"  [ERROR] Sprite '{sprite_name}' coordinate [{x}, {y}, {w}, {h}] is out of bounds for {tex_w}x{tex_h} texture!")
            errors += 1

    print("\n--------------------------------------------------")
    print(f"Verification finished with: {errors} Errors, {warnings} Warnings.")
    print("--------------------------------------------------")
    if errors > 0:
        print("[ERROR] Action required: Fix out-of-bounds/invalid definitions above.")
        return False
    else:
        print("[OK] UI spritesheet mappings are fully valid!")
        return True

if __name__ == "__main__":
    import sys
    success = validate_ui_assets()
    sys.exit(0 if success else 1)
