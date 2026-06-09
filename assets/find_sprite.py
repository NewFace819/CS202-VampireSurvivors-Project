import cv2
import numpy as np
import os
import shutil

# --- CẤU HÌNH ---
TEMPLATE_FILE = 'item_template.png' 
SEARCH_ROOT = '.'                   # Bắt đầu tìm từ thư mục hiện tại
OUTPUT_DIR = 'found_results'        # Nơi copy ảnh tìm thấy về
THRESHOLD = 0.85                    # Hạ độ khớp xuống 65% để dễ tìm hơn

def find_items():
    if not os.path.exists(TEMPLATE_FILE):
        print(f"Lỗi: Không tìm thấy file mẫu '{TEMPLATE_FILE}'")
        return

    if not os.path.exists(OUTPUT_DIR):
        os.makedirs(OUTPUT_DIR)

    # Đảm bảo cả template và ảnh gốc đều là 3 kênh màu (BGR)
    template = cv2.imread(TEMPLATE_FILE, cv2.IMREAD_COLOR)
    if template is None:
        print(f"Lỗi: Không thể đọc file mẫu '{TEMPLATE_FILE}'")
        return
        
    count = 0

    # Quét toàn bộ thư mục con
    for root, dirs, files in os.walk(SEARCH_ROOT):
        for file in files:
            if file.lower().endswith(('.png', '.jpg', '.jpeg')):
                file_path = os.path.join(root, file)
                
                # Bỏ qua file mẫu và các file đã nằm trong thư mục output
                if file == TEMPLATE_FILE or OUTPUT_DIR in file_path:
                    continue

                # Load ảnh gốc dưới dạng 3 kênh màu (BGR)
                img = cv2.imread(file_path, cv2.IMREAD_COLOR)
                if img is None: continue

                # Mở rộng dải kích thước từ 50% đến 150% (5 bước)
                for scale in np.linspace(0.4, 1.3, 10):
                    w = int(template.shape[1] * scale)
                    h = int(template.shape[0] * scale)
                    
                    # Nếu mẫu to hơn ảnh gốc thì bỏ qua bước này
                    if h > img.shape[0] or w > img.shape[1]: continue

                    resized_template = cv2.resize(template, (w, h))
                    result = cv2.matchTemplate(img, resized_template, cv2.TM_CCOEFF_NORMED)
                    
                    _, max_val, _, _ = cv2.minMaxLoc(result)
                    if max_val >= THRESHOLD:
                        print(f"[FOUND] {file} trong {root} (Độ khớp: {max_val:.2f})")
                        
                        # Tạo tên file mới để tránh bị ghi đè khi trùng tên trong các thư mục con
                        # Ví dụ: "folderA_sprite.png", "folderB_sprite.png"
                        new_name = f"{os.path.basename(root)}_{file}"
                        shutil.copy(file_path, os.path.join(OUTPUT_DIR, new_name))
                        count += 1
                        break # Tìm thấy rồi thì không cần quét các scale khác nữa

    print(f"\nXong! Tìm thấy {count} tấm ảnh. Kiểm tra thư mục '{OUTPUT_DIR}'.")

if __name__ == "__main__":
    find_items()