import os
import re
import json

# GUID chính xác của UI.png lấy từ file meta của ông
TARGET_GUID = "2ec3378c249dda0449a3fe2365107cef"
SPRITE_DIR = "ExportedProject/Assets/Texture2D" 
OUTPUT_JSON = "illustration_atlas.json"

atlas_data = {}
total_scanned = 0
matched_guid_count = 0
parsed_sprites = 0

print("Đang cấu trúc lại bộ quét, tiến hành bóc tách tọa độ gốc...")

for root, dirs, files in os.walk(SPRITE_DIR):
    for file in files:
        if file.endswith(".asset"):
            total_scanned += 1
            file_path = os.path.join(root, file)
            
            try:
                with open(file_path, "r", encoding="utf-8", errors="ignore") as f:
                    content = f.read()
                    
                    # 1. Lọc đúng các file thuộc về UI.png
                    if TARGET_GUID in content:
                        matched_guid_count += 1
                        
                        # 2. Lấy tên định danh của UI Element (Ví dụ: button_start, border_01)
                        name_match = re.search(r"m_Name:\s*(.+)", content)
                        if name_match:
                            sprite_name = name_match.group(1).strip()
                            
                            # 3. Quét khối m_Rect của Unity để lấy dữ liệu tọa độ thực tế
                            rect_block = re.search(r"m_Rect:\s*\n((?:\s+.*\n?)+)", content)
                            if rect_block:
                                block_text = rect_block.group(1)
                                
                                x_m = re.search(r"x:\s*([\d\.-]+)", block_text)
                                y_m = re.search(r"y:\s*([\d\.-]+)", block_text)
                                w_m = re.search(r"width:\s*([\d\.-]+)", block_text)
                                h_m = re.search(r"height:\s*([\d\.-]+)", block_text)
                                
                                if x_m and y_m and w_m and h_m:
                                    # Ép kiểu float và làm tròn thành int để nạp thẳng vào sf::IntRect của SFML
                                    x = int(round(float(x_m.group(1))))
                                    y = int(round(float(y_m.group(1))))
                                    w = int(round(float(w_m.group(1))))
                                    h = int(round(float(h_m.group(1))))
                                    
                                    atlas_data[sprite_name] = {
                                        "x": x,
                                        "y": y,
                                        "width": w,
                                        "height": h
                                    }
                                    parsed_sprites += 1
            except Exception as e:
                pass

# Xuất thành phẩm JSON
with open(OUTPUT_JSON, "w", encoding="utf-8") as out_f:
    json.dump(atlas_data, out_f, indent=4)

print("\n--- BÁO CÁO KẾT QUẢ MỚI ---")
print(f"1. Tổng số file .asset đã quét: {total_scanned}")
print(f"2. Số file khớp mã GUID của UI.png: {matched_guid_count}")
print(f"3. Số lượng sprite trích xuất thành công: {parsed_sprites}")
print(f"Nhiệm vụ hoàn thành! Check ngay file: {OUTPUT_JSON}")