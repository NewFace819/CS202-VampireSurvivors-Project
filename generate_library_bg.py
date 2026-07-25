from PIL import Image
import os

# Paths to the texture sheet and output background
SHEET_PATH = r"assets\ExportedProject\Assets\Texture2D\LibraryTexturePacked.png"
OUTPUT_PATH = r"assets\ExportedProject\Assets\App\Art\Sprites\Addressable\backgrounds\bg_library.png"

if not os.path.exists(SHEET_PATH):
    print(f"Error: Could not find {SHEET_PATH}. Make sure you run this script from the project root folder.")
    exit(1)

img = Image.open(SHEET_PATH)
sheet_w, sheet_h = img.size  # Note: The raw PNG file is 512x512 pixels

# ==============================================================================
# HELPER FUNCTIONS TO CROP TILES (You can use either method below!)
# ==============================================================================

def crop_from_unity_coords(x, y, w, h, target_size=None, rotate_angle=0, color_multipliers=(1.0, 1.0, 1.0)):
    """
    Crops using Unity Asset coordinates (0 to 1024 space, where Y=0 is bottom).
    This is what is found in .asset files like Tile_Carpet.asset.
    """
    scale = sheet_w / 1024.0  # Usually 0.5 since PNG is 512x512
    left = int(round(x * scale))
    bottom = int(round(sheet_h - (y * scale)))
    top = int(round(sheet_h - ((y + h) * scale)))
    right = int(round((x + w) * scale))
    return process_crop(img.crop((left, top, right, bottom)), target_size, rotate_angle, color_multipliers)

def crop_from_pixels(left, top, width, height, target_size=None, rotate_angle=0, color_multipliers=(1.0, 1.0, 1.0)):
    """
    Crops using normal image pixel coordinates (0 to 512 space, where (0,0) is top-left).
    Use this if you are finding coordinates using an image editor or Paint!
    """
    right = left + width
    bottom = top + height
    return process_crop(img.crop((left, top, right, bottom)), target_size, rotate_angle, color_multipliers)

def process_crop(cropped, target_size, rotate_angle, color_multipliers):
    cropped = cropped.convert("RGBA")
    
    # Apply color brightness adjustment (e.g. (2.51, 2.83, 2.55) for original game warmth)
    if color_multipliers != (1.0, 1.0, 1.0):
        pixels = list(cropped.getdata())
        new_pixels = []
        mr, mg, mb = color_multipliers
        for r, g, b, a in pixels:
            new_pixels.append((min(255, int(r * mr)), min(255, int(g * mg)), min(255, int(b * mb)), a))
        cropped.putdata(new_pixels)
        
    if rotate_angle == 90:
        cropped = cropped.transpose(Image.Transpose.ROTATE_90)
    elif rotate_angle == 180:
        cropped = cropped.transpose(Image.Transpose.ROTATE_180)
    elif rotate_angle == 270:
        cropped = cropped.transpose(Image.Transpose.ROTATE_270)
        
    if target_size:
        cropped = cropped.resize(target_size, Image.Resampling.NEAREST)
    return cropped

# ==============================================================================
# 1. DEFINE YOUR FLOOR TILES HERE!
# ==============================================================================
# Color multiplier to convert dark sheet texture to bright in-game wood colors:
COLOR_TINT = (2.51, 2.83, 2.55)  # Set to (1.0, 1.0, 1.0) if you don't want color adjustments

# Option A: Using Unity Asset coordinates (x, y, w, h in 1024 space)
carpet_tile      = crop_from_unity_coords(x=480, y=431, w=32, h=32, target_size=(64, 64), color_multipliers=COLOR_TINT)
herringbone_tile = crop_from_unity_coords(x=512, y=431, w=32, h=32, target_size=(64, 64), color_multipliers=COLOR_TINT)
border_top       = crop_from_unity_coords(x=448, y=528, w=32, h=64, target_size=(64, 32), rotate_angle=90,  color_multipliers=COLOR_TINT)
border_bottom    = crop_from_unity_coords(x=448, y=528, w=32, h=64, target_size=(64, 32), rotate_angle=270, color_multipliers=COLOR_TINT)

# Option B Example: If you want to crop by normal pixel coordinates (left, top, w, h in 512 space):
# herringbone_tile = crop_from_pixels(left=256, top=280, width=16, height=16, target_size=(64, 64), color_multipliers=COLOR_TINT)

# ==============================================================================
# 2. DEFINE BOOKSHELF & WALL TILES HERE
# ==============================================================================
wall_coords = [
    {"x": 320, "y": 881, "w": 128, "h": 112},  # Wall1
    {"x": 320, "y": 769, "w": 128, "h": 112},  # Wall2
    {"x": 320, "y": 657, "w": 128, "h": 112},  # Wall3
    {"x": 320, "y": 545, "w": 128, "h": 112},  # Wall4
    {"x": 320, "y": 433, "w": 128, "h": 112},  # Wall5 (Wood Alcove)
    {"x": 320, "y": 321, "w": 128, "h": 112},  # Wall6
    {"x": 0,   "y": 272, "w": 128, "h": 112},  # Wall7
    {"x": 128, "y": 272, "w": 128, "h": 112},  # Wall8
]
walls = [crop_from_unity_coords(c["x"], c["y"], c["w"], c["h"], target_size=(256, 224)) for c in wall_coords]
overlay = crop_from_unity_coords(x=256, y=289, w=128, h=32, target_size=(256, 64), color_multipliers=COLOR_TINT)

# ==============================================================================
# 3. STITCH THE 1024x1024 BACKGROUND CANVAS
# ==============================================================================
bg = Image.new("RGBA", (1024, 1024))

# --- FLOOR AREA (Y = 288 to 736) ---
# Fill the entire corridor floor with your primary tile (herringbone_tile)
for y in range(288, 736, 64):
    for x in range(0, 1024, 64):
        bg.paste(herringbone_tile, (x, y))

# Paste top floor border strip (Y = 288 to 320)
for x in range(0, 1024, 64):
    bg.paste(border_top, (x, 288))

# Paste bottom floor border strip (Y = 704 to 736)
for x in range(0, 1024, 64):
    bg.paste(border_bottom, (x, 704))

# Paste central carpet stripe (Y = 480 to 544)
for x in range(0, 1024, 64):
    bg.paste(carpet_tile, (x, 480))

# --- TOP WALL AREA (Y = 0 to 288) ---
top_sequence = [0, 4, 1, 2]  # Wall1, Wall5, Wall2, Wall3
for col in range(4):
    bg.paste(walls[top_sequence[col]], (col * 256, 0))
    bg.paste(overlay, (col * 256, 224))

# --- BOTTOM WALL AREA (Y = 736 to 1024) ---
bottom_sequence = [3, 0, 1, 2]  # Wall4, Wall1, Wall2, Wall3
for col in range(4):
    bg.paste(walls[bottom_sequence[col]], (col * 256, 800))
    flipped_overlay = overlay.transpose(Image.Transpose.FLIP_TOP_BOTTOM)
    bg.paste(flipped_overlay, (col * 256, 736))

# Save the stitched background image
bg.save(OUTPUT_PATH)
print(f"Success! Stitched background saved to {OUTPUT_PATH}")
