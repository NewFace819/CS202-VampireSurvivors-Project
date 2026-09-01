# Kịch bản quay video demo (bản rút gọn)

**Môn:** CS202 — Lập trình Hướng đối tượng
**Đồ án:** Vampire Survivors Clone (C++20 / SFML 2.6)
**Nhóm:** 54 — Đỗ Gia Huy (25125013), Võ Thành Hải (25125011)

> Một video duy nhất, **7 phút**, vẫn thể hiện **đủ 40 tính năng** và **cả 3 màn chơi**.
> Số trong ngoặc `(n)` là số thứ tự trong [`FEATURE_LIST.md`](FEATURE_LIST.md).

---

## Nguyên tắc để quay nhanh

| Nguyên tắc | Lý do |
|---|---|
| **Dùng cheat ngay từ đầu** — `Alt+C` cho toàn bộ vũ khí max level | Không phải chơi 10 phút để lên cấp. Nói rõ: *"đây là cheat để kiểm thử, không phải cơ chế của game"* |
| **Không chơi hết màn** | Chỉ cần vào màn, thể hiện đúng tính năng đặc trưng rồi thoát ra |
| **Vừa thao tác vừa nói** | Đừng chơi im lặng rồi mới giải thích — sẽ mất gấp đôi thời gian |
| **Không quay lại từ đầu khi lỡ tay** | Cứ nói "em làm lại thao tác này" rồi tiếp tục, cắt sau |

### Chuẩn bị trước khi bấm ghi

- Build **Release**: `cmake --build build` (bản Debug sẽ giật khi đông quái)
- Xóa `build/save.txt` và `build/save_data.json` (để demo được phần mua lần đầu)
- OBS 1920×1080, 60 fps, thu cả tiếng game
- Mở sẵn `FEATURE_LIST.md` ở màn hình phụ

### Phím cheat

| Phím | Tác dụng |
|---|---|
| `Alt + C` | Toàn bộ vũ khí + passive, max level |
| `Alt + E` | Whip + Hollow Heart (chuẩn bị tiến hóa) |
| `Alt + T` | Sinh rương báu cạnh nhân vật |
| `Alt + H` | Sinh đợt quái lớn (giữ phím để sinh tiếp) |
| `Alt + J` | Sinh 12 **quái bắn xa** ngay cạnh nhân vật |

---

## 0:00 – 0:20 · Mở đầu

> "Em là ... và ..., nhóm 54. Đây là đồ án Vampire Survivors Clone viết bằng C++20 và SFML.
> Sau đây em demo toàn bộ tính năng."

- Mở game, lướt nhanh qua Intro/Title **(38)**, dừng ở **Main Menu** **(1)**

---

## 0:20 – 1:10 · Shop và lưu tiến trình

> "Đây là hệ thống nâng cấp vĩnh viễn, lưu ra file nên còn sau khi tắt game."

1. Vào **Shop** — 14 loại power-up, giá tăng theo rank **(4)**
2. Mua 2–3 rank (đừng mua hết, mất thời gian)
3. Bấm **Refund All** → hoàn lại toàn bộ vàng **(36)**, rồi mua lại vài rank
4. **Tắt game, mở lại** → vàng và rank vẫn còn **(5)**
   → *Đây là bằng chứng cho tính năng lưu file. Làm chậm, đừng cắt.*

---

## 1:10 – 1:40 · Chọn nhân vật

1. Cuộn nhanh danh sách **hơn 40 nhân vật** **(2)**
2. Chỉ vào chân dung, bảng chỉ số, vũ khí khởi đầu
3. Cho thấy một nhân vật **đang khóa** (ẩn chỉ số, hiện giá) → **mua mở khóa** **(35)**
4. Nói lướt: *"toàn bộ icon vũ khí và passive lấy từ atlas dùng chung qua IconManager"* **(29, 32)**

---

## 1:40 – 3:20 · Màn 1 — Mad Forest *(phần dài nhất)*

1. **Stage Select** — cho thấy **cả 3 màn** rồi chọn Mad Forest **(3)**, qua **Stage Loading** **(37)**
2. Di chuyển **8 hướng**, animation đổi hướng **(7, 31)**
3. Chạy một đoạn → **nền lặp vô hạn**, không thấy mép **(6)**
4. Giết quái → **gem kinh nghiệm**, **bán kính hút đồ** **(8, 21)**
5. Lên cấp → **màn hình Level Up**: 4 lá bài, **Reroll / Skip / Banish** **(12, 28)**
   - Bấm **Reroll** một lần, **Banish** một món — chỉ cần mỗi thứ một lần
6. **`Alt + C`** → nhận hết vũ khí max level
   → *nói rõ đây là cheat kiểm thử*
   - Chỉ vào **nhiều vũ khí bắn cùng lúc**, **loạt đạn cách nhau 0.1 giây** **(9, 13)**
   - Chỉ vào **vệt đuôi đạn và hạt particle** **(18, 30)**
   - Chỉ vào **hàng icon passive trên HUD** **(11, 24)**
7. **`Esc`** → **Pause** → bỏ pause **(23)**
8. **Giữ `Alt + H`** vài giây → hàng nghìn quái, game vẫn mượt
   > "Nhờ Object Pool 10.000 đối tượng và Spatial Hash Grid cho va chạm." **(17, 19, 14)**
9. Đợi/ép **boss** xuất hiện, hạ boss **(15)**
10. Để nhân vật **chết** → **Game Over** → **Summary**: số quái, thời gian, sát thương từng vũ khí **(25, 26)**

---

## 3:20 – 4:00 · Tiến hóa vũ khí

> "Vũ khí max level cộng passive tương ứng, mở rương sẽ tiến hóa."

1. Vào lại một màn, **`Alt + E`** → Whip + Hollow Heart
2. Lên level cho **Whip max**
3. **`Alt + T`** → mở rương → **Whip → Bloody Tear** **(10, 22)**
4. **Làm lại với cặp khác** (Magic Wand + Empty Tome → Holy Wand)
   → *chứng minh hệ thống tổng quát, không hard-code*
5. Nói lướt: *"tổng cộng 11 công thức tiến hóa, 15 passive đều có hiệu ứng chỉ số thật"*

---

## 4:00 – 4:45 · Màn 2 — Inlaid Library

1. Chọn **Inlaid Library** **(3)**
2. **`Alt + J`** → sinh ngay **quái bắn xa** (ShooterEnemy) — né vài viên đạn **(16)**
   → *Quái bắn xa chỉ tự xuất hiện từ phút thứ 1 trong dữ liệu wave, nên dùng cheat cho nhanh.*
3. **Hiệu ứng 2.5D — quay kỹ:** đi **lên phía sau** bàn ghế → nhân vật **bị che**;
   đi **xuống phía trước** → nhân vật **hiện lên trên** **(20)**
4. Đi sát vật cản → **va chạm trượt**, không kẹt **(19)**
5. Nhặt **Coin / Floor Chicken** **(21)**

---

## 4:45 – 5:30 · Màn 3 — Green Acres

1. Chọn **Green Acres** **(3)**
2. Bản đồ vẽ bằng **lưới tile mesh (VertexArray)** **(20)**
3. **Đi vào tường** → không qua được
4. **Giữ `Alt + H`** → quái **cũng không xuyên tường**, và **không có vật phẩm rơi trong vùng bị chặn** **(19)**

---

## 5:30 – 6:45 · Chế độ 2 người chơi *(phần quan trọng nhất)*

> Đây là tính năng khó nhất. Đừng cắt ngắn phần này.

> "Chế độ 2 người trên cùng máy. Mỗi người có vũ khí, kinh nghiệm, cấp độ, passive và máu riêng."

1. Chọn **co-op**, chọn nhân vật cho **cả hai**
2. Vào game — **camera bám cả hai**, giãn ra khi đi xa nhau
3. **Vũ khí riêng** — HUD mỗi người khác nhau **(27)**
4. **EXP / cấp độ riêng** — hai thanh EXP, nhãn `P1 LV n` / `P2 LV n`; cho **một người ăn gem**, chỉ thanh người đó tăng **(8)**
5. **Máu riêng** — cho **một người bị đánh**, chỉ thanh máu người đó giảm
6. **Vũ khí bám đúng chủ** — một người cầm **Garlic / King Bible**, **đi thật xa nhau**
   → hiệu ứng vẫn bám đúng người, không bị kéo về giữa màn hình
7. **Gục và hồi sinh** — để **một người chết**:
   - người đó **gục, vũ khí ngừng bắn**
   - **người kia vẫn chơi bình thường**, game **không kết thúc**
8. Để **cả hai cùng gục** → lúc đó mới hiện **Summary** **(26)**

---

## 6:45 – 7:00 · Kết

> "Về thiết kế hướng đối tượng, đồ án áp dụng 8 mẫu: Finite State Machine, Template Method,
> Factory Method, Observer, Object Pool, Singleton, Strategy và Spatial Hash Grid — chi tiết
> ở phần 4 của báo cáo. Kiến trúc chia 4 tầng Core / Entities / States / UI. Em cảm ơn thầy/cô."
> **(33, 34, 39, 40)**

---

## Bảng đối chiếu tính năng

| Phần | Tính năng |
|---|---|
| Mở đầu | 1, 38 |
| Shop | 4, 5, 36 |
| Chọn nhân vật | 2, 29, 32, 35 |
| Màn 1 | 3, 6, 7, 8, 9, 11, 12, 13, 14, 15, 17, 18, 19, 21, 23, 24, 25, 26, 28, 30, 31, 37 |
| Tiến hóa | 10, 11, 22 |
| Màn 2 | 3, 16, 19, 20, 21 |
| Màn 3 | 3, 19, 20 |
| Co-op | 8, 26, 27 |
| Kết | 33, 34, 39, 40 |

> **5 tính năng không quay trực tiếp được** — 24 (HUD), 33 (cheat), 34 (Observer),
> 39 (UI module hóa), 40 (data-driven). Phải **nói bằng lời** đúng lúc đi qua, như đã ghi
> trong kịch bản. Đừng bỏ qua, vì mỗi tính năng là 0.25 điểm.

---

## Nếu cần ngắn hơn 7 phút

Cắt theo thứ tự sau, **dừng lại khi đã đủ ngắn**:

1. **Refund All** trong Shop (–15 giây) — nhưng mất tính năng **36**
2. Phần **mua mở khóa nhân vật** (–20 giây) — mất tính năng **35**
3. Tiến hóa **lần thứ hai** (–20 giây) — vẫn còn tính năng 10, chỉ kém thuyết phục hơn
4. **Boss** ở màn 1 (–30 giây) — mất tính năng **15**

> **Không cắt:** phần lưu tiến trình (tắt/mở lại game) và phần co-op. Đó là hai thứ khó
> làm nhất và dễ ghi điểm nhất.
