# Kịch bản quay video demo

**Môn:** CS202 — Lập trình Hướng đối tượng
**Đồ án:** Vampire Survivors Clone (C++20 / SFML 2.6)
**Nhóm:** 54 — Đỗ Gia Huy (25125013), Võ Thành Hải (25125011)

> Một video duy nhất, quay liền mạch, thể hiện **toàn bộ 40 tính năng** và **cả 3 màn chơi**.
> Thời lượng mục tiêu: **12–15 phút**.
> Số trong ngoặc `(n)` là số thứ tự tính năng trong [`FEATURE_LIST.md`](FEATURE_LIST.md) —
> đọc to hoặc hiện lên màn hình để giám khảo đối chiếu được từng tính năng.

---

## Chuẩn bị trước khi quay

| Việc | Ghi chú |
|---|---|
| Build bản Release | `cmake --build build` — bản Debug chạy chậm hơn nhiều lần, sẽ giật khi demo đông quái |
| Xóa file save | Xóa `build/save.txt` và `build/save_data.json` để demo được phần "mua lần đầu" trong Shop |
| Ghi hình | OBS, 1920×1080, 60 fps. Thu cả tiếng game |
| Cỡ cửa sổ | Để nguyên mặc định, đừng phóng to hết cỡ (tránh chữ HUD bị nhỏ trên video) |
| Chuẩn bị sẵn | Mở `FEATURE_LIST.md` ở màn hình phụ để không quên tính năng nào |

### Phím cheat (dùng để demo cho nhanh, **nên nói rõ đây là cheat dành cho việc kiểm thử**)

| Phím | Tác dụng |
|---|---|
| `Alt + C` | Nhận toàn bộ vũ khí và passive, lên max level |
| `Alt + E` | Nhận Whip + Hollow Heart (chuẩn bị cho tiến hóa) |
| `Alt + T` | Sinh ra một rương báu ngay cạnh nhân vật |
| `Alt + H` | Sinh ra một đợt quái lớn (giữ phím để sinh liên tục) |

---

## Phần 1 — Mở đầu và menu chính *(0:00 – 1:00)*

**Lời thoại gợi ý:**
> "Xin chào thầy/cô. Em là ... và ..., nhóm 54. Đây là đồ án Vampire Survivors Clone,
> viết bằng C++20 và thư viện SFML. Sau đây em xin demo toàn bộ tính năng của đồ án."

**Thao tác:**
1. Mở game — quay màn hình Intro / Title **(38)**
2. Dừng ở **Main Menu**, chỉ vào nền động, các nút Start / Shop / Quit **(1)**

---

## Phần 2 — Shop và hệ thống lưu tiến trình *(1:00 – 2:30)*

**Lời thoại gợi ý:**
> "Trước tiên là phần Shop — đây là hệ thống nâng cấp vĩnh viễn, dữ liệu được lưu ra file
> nên vẫn còn sau khi tắt game."

**Thao tác:**
1. Vào **Shop** — cho thấy 14 loại power-up, giá tăng dần theo rank **(4)**
2. Mua vài rank (Might, Armor, Move Speed) — chỉ vào số vàng giảm đi
3. Bấm **Refund All** — cho thấy được hoàn lại toàn bộ vàng **(36)**
4. Mua lại vài rank
5. **Thoát hẳn game, mở lại** → vào Shop → vàng và rank vẫn còn **(5)**
   → *Đây là bằng chứng rõ nhất cho tính năng lưu file, nên làm thật chậm.*

---

## Phần 3 — Chọn nhân vật *(2:30 – 3:30)*

**Thao tác:**
1. Vào **Character Select** — cuộn qua danh sách hơn 40 nhân vật **(2)**
2. Chỉ vào: chân dung, bảng chỉ số, vũ khí khởi đầu của từng nhân vật
3. Cho thấy nhân vật **đang khóa** (hiện giá tiền, ẩn chỉ số) và nhân vật **đã mở**
4. **Mua/mở khóa một nhân vật** bằng vàng **(35)**
5. Chỉ vào icon vũ khí, icon passive — tất cả lấy từ atlas dùng chung **(29, 32)**

---

## Phần 4 — Màn 1: Mad Forest *(3:30 – 7:00)*

**Lời thoại gợi ý:**
> "Đây là màn đầu tiên. Nhân vật tự động tấn công, người chơi chỉ điều khiển di chuyển."

**Thao tác theo thứ tự:**
1. Vào **Stage Select**, cho thấy **cả 3 màn** rồi chọn Mad Forest **(3)**
2. Màn hình **Stage Loading** **(37)**
3. Di chuyển **8 hướng**, chỉ vào animation nhân vật đổi hướng **(7, 31)**
4. Chỉ vào **nền lặp vô hạn** — chạy xa một đoạn để thấy nền nối liền, không có mép **(6)**
5. Giết quái → nhặt **gem kinh nghiệm**, cho thấy **bán kính hút đồ** **(8, 21)**
6. **Lên cấp** → màn hình Level Up: 4 lá bài, nút **Reroll / Skip / Banish** và số lượt còn lại **(12, 28)**
   - Bấm thử **Reroll** một lần
   - Bấm thử **Banish** một món để cho thấy nó không xuất hiện lại nữa
7. Chơi tiếp cho có **nhiều vũ khí** — chỉ vào nhịp bắn theo loạt 0.1 giây **(9, 13)**
8. Chỉ vào **hiệu ứng VFX**: vệt đuôi đạn, hạt particle **(18, 30)**
9. Nhấn `Esc` → **màn hình Pause** **(23)**
10. Chơi tiếp đến khi **wave tăng độ khó** → **boss xuất hiện** → hạ boss **(14, 15)**
11. `Alt + H` giữ vài giây → cho thấy game vẫn mượt với **hàng nghìn quái**
    → nói rõ: *"đây là nhờ Object Pool 10.000 đối tượng và Spatial Hash Grid"* **(17, 19)**
12. Để nhân vật **chết** → **Game Over** → **Summary**: số quái, thời gian, sát thương từng vũ khí **(25, 26)**

---

## Phần 5 — Tiến hóa vũ khí *(7:00 – 8:30)*

**Lời thoại gợi ý:**
> "Hệ thống tiến hóa: vũ khí lên max level, cộng với passive tương ứng, mở rương sẽ tiến hóa."

**Thao tác:**
1. Vào một màn bất kỳ
2. `Alt + E` → nhận Whip + Hollow Heart
3. Lên level cho **Whip đạt max**
4. `Alt + T` → mở rương → **Whip tiến hóa thành Bloody Tear** **(10, 22)**
5. Chỉ vào **icon vũ khí mới trên HUD**
6. **Làm lại lần nữa với cặp khác** (ví dụ Magic Wand + Empty Tome → Holy Wand)
   → *chứng minh hệ thống tổng quát, không phải hard-code từng trường hợp*
7. Có thể nói thêm: *"tổng cộng có 11 công thức tiến hóa, và 15 passive đều có hiệu ứng chỉ số thật"* **(11)**

---

## Phần 6 — Màn 2: Inlaid Library *(8:30 – 10:00)*

**Lời thoại gợi ý:**
> "Màn 2 có bản đồ dựng từ file JSON và loại quái biết bắn."

**Thao tác:**
1. Chọn **Inlaid Library** **(3)**
2. Cho thấy **quái bắn đạn** (ShooterEnemy) — né đạn của chúng **(16)**
3. **Quan trọng — hiệu ứng 2.5D:** đi **lên phía sau** bàn ghế → nhân vật bị che khuất;
   đi **xuống phía trước** → nhân vật hiện lên trên **(20)**
4. Đi sát vào bàn ghế → cho thấy **va chạm trượt** dọc theo vật cản, không bị kẹt **(19)**
5. Nhặt **Coin, Floor Chicken, rương** **(21)**

---

## Phần 7 — Màn 3: Green Acres (Plant Map) *(10:00 – 11:30)*

**Thao tác:**
1. Chọn **Green Acres** **(3)**
2. Cho thấy bản đồ được vẽ bằng **lưới tile mesh (VertexArray)** **(20)**
3. **Đi vào tường** → không qua được **(19)**
4. `Alt + H` sinh quái → cho thấy **quái cũng không đi xuyên tường**, và **không có vật phẩm nào rơi trong khu vực bị chặn**
   → nói rõ: *"tường chặn cả người chơi lẫn quái, và vật phẩm không rơi vào vùng không tới được"*

---

## Phần 8 — Chế độ 2 người chơi *(11:30 – 14:00)*

> **Phần quan trọng nhất — quay kỹ và chậm.** Đây là tính năng khó nhất của đồ án.

**Lời thoại gợi ý:**
> "Cuối cùng là chế độ 2 người chơi trên cùng một máy. Mỗi người có vũ khí, kinh nghiệm,
> cấp độ, passive và máu riêng biệt."

**Thao tác theo thứ tự:**
1. Chọn chế độ **co-op**, chọn nhân vật cho **cả hai người**
2. Vào game — chỉ vào **camera bám theo cả hai**, tự giãn ra khi hai người đi xa nhau
3. **Vũ khí riêng:** cho thấy mỗi người có bộ vũ khí khác nhau trên HUD **(27)**
4. **EXP và cấp độ riêng:** chỉ vào **hai thanh EXP** và nhãn `P1 LV n` / `P2 LV n` ở dưới màn hình **(8)**
5. Cho **một người ăn gem** → chỉ thanh EXP của người đó tăng
6. **Lên cấp riêng:** khi P2 lên cấp, màn hình Level Up chỉ áp dụng cho P2
7. **Máu riêng:** cho **một người bị quái đánh** → chỉ thanh máu của người đó giảm
8. **Vũ khí bám đúng người:** cho một người dùng **Garlic / King Bible**, rồi **đi thật xa nhau**
   → hiệu ứng vẫn bám đúng chủ, không bị kéo vào giữa màn hình
9. **Gục và hồi sinh:** để **một người chết** →
   - người đó **gục, vũ khí ngừng bắn**
   - **người còn lại vẫn chơi bình thường**, game **không kết thúc**
   - nếu còn lượt hồi sinh thì cho thấy hồi sinh
10. Để **cả hai cùng gục** → lúc này mới hiện **Summary** **(26)**

---

## Phần 9 — Kết *(14:00 – 15:00)*

**Lời thoại gợi ý:**
> "Về mặt thiết kế hướng đối tượng, đồ án áp dụng 8 mẫu thiết kế: Finite State Machine,
> Template Method, Factory Method, Observer, Object Pool, Singleton, Strategy và Spatial
> Hash Grid. Chi tiết nằm trong phần 4 của báo cáo.
> Em xin cảm ơn thầy/cô đã theo dõi."

**Có thể chèn thêm (không bắt buộc):** vài giây lướt qua sơ đồ lớp trong báo cáo để minh họa
kiến trúc phân tầng `Core / Entities / States / UI`.

---

## Bảng đối chiếu — đảm bảo không sót tính năng nào

| Phần | Tính năng được thể hiện |
|---|---|
| 1 | 1, 38 |
| 2 | 4, 5, 36 |
| 3 | 2, 29, 32, 35 |
| 4 | 3, 6, 7, 8, 9, 12, 13, 14, 15, 17, 18, 19, 21, 23, 25, 26, 28, 30, 31, 37 |
| 5 | 10, 11, 22 |
| 6 | 3, 16, 19, 20, 21 |
| 7 | 3, 19, 20 |
| 8 | 8, 26, 27 |
| 9 | 33, 34, 39, 40 (nói bằng lời + chỉ vào báo cáo) |

> **Lưu ý:** các tính năng 24 (HUD), 33 (cheat code), 34 (Observer), 39 (UI module hóa),
> 40 (data-driven) không quay trực tiếp được — hãy **nhắc bằng lời** khi đi qua phần liên quan,
> hoặc mở nhanh file mã nguồn / báo cáo để minh chứng.
