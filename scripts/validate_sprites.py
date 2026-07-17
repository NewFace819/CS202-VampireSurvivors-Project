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

def validate_assets():
    enemies_json_path = os.path.join("assets", "data", "enemies.json")
    atlas_json_path = os.path.join("assets", "enemies_atlas.json")
    spritesheet_path = os.path.join("assets", "ExportedProject", "Assets", "Resources", "spritesheets", "enemies.png")

    print("==================================================")
    print("        Vampire Survivors Sprite Validator        ")
    print("==================================================\n")

    # 1. Load PNG size
    if not os.path.exists(spritesheet_path):
        print(f"[ERROR] Spritesheet not found at {spritesheet_path}")
        return
    
    png_size = get_png_size(spritesheet_path)
    if not png_size:
        print(f"[ERROR] Could not parse PNG dimensions for {spritesheet_path}")
        return
    
    tex_w, tex_h = png_size
    print(f"[OK] Loaded enemies.png: {tex_w}x{tex_h} pixels.")

    # 2. Load atlas JSON
    if not os.path.exists(atlas_json_path):
        print(f"[ERROR] Atlas JSON not found at {atlas_json_path}")
        return
    
    try:
        with open(atlas_json_path, 'r', encoding='utf-8') as f:
            atlas = json.load(f)
        print(f"[OK] Loaded atlas JSON containing {len(atlas)} sprite definitions.")
    except Exception as e:
        print(f"[ERROR] Failed to parse atlas JSON: {e}")
        return

    # 3. Load enemies JSON
    if not os.path.exists(enemies_json_path):
        print(f"[ERROR] Enemies database not found at {enemies_json_path}")
        return
    
    try:
        with open(enemies_json_path, 'r', encoding='utf-8') as f:
            enemies_data = json.load(f)
        enemies_db = enemies_data.get("enemies", enemies_data)
        print(f"[OK] Loaded enemies database containing {len(enemies_db)} enemy types.\n")
    except Exception as e:
        print(f"[ERROR] Failed to parse enemies database: {e}")
        return

    # 4. Perform validation
    warnings = 0
    errors = 0

    print("--- Starting Verification ---")
    for enemy_name, stats in enemies_db.items():
        # Check hardcoded walkRects/deathRects
        has_hardcoded = False
        
        for rect_type in ["walkRects", "deathRects"]:
            if rect_type in stats:
                has_hardcoded = True
                print(f"[WARNING] Enemy '{enemy_name}' uses hardcoded '{rect_type}'. "
                      f"Consider using atlas prefix mapping instead to prevent desyncs.")
                warnings += 1
                
                for idx, r in enumerate(stats[rect_type]):
                    if len(r) != 4:
                        print(f"  [ERROR] '{rect_type}' frame {idx} has invalid format (must be [x, y, w, h]).")
                        errors += 1
                        continue
                    x, y, w, h = r
                    if x < 0 or y < 0 or x + w > tex_w or y + h > tex_h:
                        print(f"  [ERROR] '{rect_type}' frame {idx} coordinate [{x}, {y}, {w}, {h}] is out of bounds for {tex_w}x{tex_h} texture!")
                        errors += 1

        # Check atlas prefix mapping
        walk_prefix = stats.get("spriteWalkPrefix", "")
        death_prefix = stats.get("spriteDeathPrefix", "")

        if not has_hardcoded:
            if not walk_prefix:
                print(f"[WARNING] Enemy '{enemy_name}' has no walk prefix or walk rects defined.")
                warnings += 1
            else:
                walk_frames = stats.get("walkFrames", 0)
                for i in range(1, walk_frames + 1):
                    frame_key = f"{walk_prefix}{i}"
                    if frame_key not in atlas:
                        # Try fallback representation
                        frame_key_alt = f"{walk_prefix}{i:02d}"
                        if frame_key_alt in atlas:
                            frame_key = frame_key_alt
                        else:
                            print(f"  [ERROR] Walk frame key '{frame_key}' (or '{frame_key_alt}') not found in atlas for '{enemy_name}'!")
                            errors += 1
                            continue
                    
                    # Validate bounds in atlas
                    rect = atlas[frame_key]
                    x, y, w, h = rect["x"], rect["y"], rect["width"], rect["height"]
                    if x < 0 or y < 0 or x + w > tex_w or y + h > tex_h:
                        print(f"  [ERROR] Atlas frame '{frame_key}' coordinate [{x}, {y}, {w}, {h}] out of bounds for {tex_w}x{tex_h} texture!")
                        errors += 1

            if death_prefix:
                death_frames = stats.get("deathFrames", 0)
                for i in range(0, death_frames):
                    frame_key = f"{death_prefix}{i}"
                    if frame_key not in atlas:
                        frame_key_alt = f"{death_prefix}{i:02d}"
                        if frame_key_alt in atlas:
                            frame_key = frame_key_alt
                        else:
                            # Death frames often start at 1, let's check i+1
                            frame_key_alt2 = f"{death_prefix}{i+1}"
                            if frame_key_alt2 in atlas:
                                frame_key = frame_key_alt2
                            else:
                                print(f"  [ERROR] Death frame key '{frame_key}' (or fallback) not found in atlas for '{enemy_name}'!")
                                errors += 1
                                continue
                    
                    rect = atlas[frame_key]
                    x, y, w, h = rect["x"], rect["y"], rect["width"], rect["height"]
                    if x < 0 or y < 0 or x + w > tex_w or y + h > tex_h:
                        print(f"  [ERROR] Atlas frame '{frame_key}' coordinate [{x}, {y}, {w}, {h}] out of bounds for {tex_w}x{tex_h} texture!")
                        errors += 1

    print("\n--------------------------------------------------")
    print(f"Verification finished with: {errors} Errors, {warnings} Warnings.")
    print("--------------------------------------------------")
    if errors > 0:
        print("[ERROR] Action required: Fix out-of-bounds/missing keys above.")
    else:
        print("[OK] Spritesheet mappings are fully valid!")

if __name__ == "__main__":
    validate_assets()
