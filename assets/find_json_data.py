import os
import json

# --- CẤU HÌNH ---
SEARCH_ROOT = '.'  # Thư mục chứa các file json
KEYWORDS = ['chest', 'treasure', 'box']

def search_in_jsons():
    for root, dirs, files in os.walk(SEARCH_ROOT):
        for file in files:
            if file.endswith('.json'):
                file_path = os.path.join(root, file)
                try:
                    with open(file_path, 'r', encoding='utf-8') as f:
                        content = f.read().lower()
                        if any(kw in content for kw in KEYWORDS):
                            print(f"[MATCH FOUND] File: {file_path}")
                            # In ra một đoạn ngắn xung quanh từ khóa để bạn check
                            # (chỉ in 200 ký tự đầu tiên để tránh tràn màn hình)
                            idx = content.find('chest')
                            if idx != -1:
                                print(f"  -> Context: ...{content[idx-50:idx+50]}...")
                            print("-" * 50)
                except Exception as e:
                    continue

if __name__ == "__main__":
    search_in_jsons()