# Weekly Development Report

## 1. General Information

- Group ID: 54
- Project Name: Vampire Survivors Clone
- Date Range: 2026-07-06 – 2026-07-11 (Week 05)

---

## 2. Tasks Completed This Week

### 25125011 – Vo Thanh Hai (Developer B - NewFace819)
- **Task A: Weapon Evolution & Synergy Dictionary**
  - Designed the recipe registry in `src/Items/EvolutionRegistry.h` to check for max-level base weapons paired with required passive items.
  - Coded the evolved weapon class `BloodyTear.h` which implements the Whip evolution, featuring a lifesteal logic (recovers +8 HP on hit).
  - Developed the `TreasureChest` entity that drops upon defeating the boss (Purple bat spawned at 0:30), allowing the player to collect it to trigger weapon evolution or get a free level-up.
- **Task B: Shop UI & Account Saving**
  - Created the `ProfileManager` singleton class that manages cross-session progression. Implemented serialization/deserialization to `save.txt` using C++ file streams.
  - Implemented the `ShopState` UI which renders a Shop menu. Players can spend gold earned from runs on permanent upgrades (Max Health, Armor, Recovery, Greed, and Revival) or refund their upgrades.
- **Evidence**
  - Commits under username `NewFace819` (`vothanhhai2007@gmail.com`): `first draft of the shop (profile manager) and account saving`, `adding synergy mechanic`.
  - Source files: [EvolutionRegistry.h](../src/Items/EvolutionRegistry.h), [BloodyTear.h](../src/Weapons/BloodyTear.h), [TreasureChest.h](../src/Entities/TreasureChest.h), [ProfileManager.h](../src/Engine/ProfileManager.h), [ProfileManager.cpp](../src/Engine/ProfileManager.cpp), [ShopState.h](../src/State/ShopState.h), [ShopState.cpp](../src/State/ShopState.cpp).

### 25125013 – Do Gia Huy (Developer A - wii)
- **Task A: Swarm Physics & Enemy Animations**
  - Integrated the timeline wave system in `PlayingState.cpp` to scale enemy spawning density and speed over time (Wave 1: brown bats, Wave 2: high density blue bats).
  - Refactored `EnemyBase` to remove hardcoded collision radii, allowing sprites to use their actual texture bounding boxes.
  - Fixed bat walking and death frame configurations to sync spritesheet coordinate transitions cleanly.
- **Task B: Polished UI States & Build Optimizations**
  - Redesigned `LevelUpState` using a transparent overlay that showcases 3 upgrade cards dynamically selected from available weapons and passives.
  - Refactored `CharacterSelectState` to present a clean selection grid representing 6 playable characters (Antonio, Imelda, Gennaro, Arca, Lama, Queen Sigma) with their specific stats and starting items.
  - Added interaction delays (`m_timeInState`) in state entries to prevent mouse clicks from accidentally double-triggering state changes.
  - Optimized the CMake compilation step using local directory junctions for asset paths instead of copying folder contents, drastically reducing build times and saving ~1GB of disk usage.
- **Evidence**
  - Commits under username `wii` (`wiih05217@gmail.com`): `Update character animation frames for Arca, Lama, and others`, `Restore teammate's wave mode and collisions logic lost during assets revert`, `UI: Update LevelUpState and CharacterSelectState design`, `Enemies: Fix bat animations, remove hardcoded collision radius, and enable swarming`, `CMake: Optimize asset directory copying by using a directory junction`.
  - Source files: [EnemyBase.cpp](../src/Entities/EnemyBase.cpp), [EnemyBase.h](../src/Entities/EnemyBase.h), [LevelUpState.cpp](../src/State/LevelUpState.cpp), [LevelUpState.h](../src/State/LevelUpState.h), [CharacterSelectState.cpp](../src/State/CharacterSelectState.cpp), [CharacterSelectState.h](../src/State/CharacterSelectState.h), [CMakeLists.txt](../CMakeLists.txt).

---

## 3. AI Usage Declaration

Our group utilized AI assistance (specifically Google DeepMind's Antigravity assistant) during this week to:
1. Debug cross-platform directory junction generation commands in CMake.
2. Review object lifetime policies when dynamically transitioning game states over transparent overlays.
3. Structuring HTML layout design for documentation reports.

---

## 4. Tasks Planned for Next Week (Week 06)

### 25125011 – Vo Thanh Hai
- **Task A: Weapon Evolution Expansion**
  - Implement the remaining evolved weapon classes (Holy Wand, Thousand Edge, Hellfire, Death Spiral) and hook them into the Evolution Registry.
- **Task B: Boss AI & Attack Strategy Patterns**
  - Code polymorphic boss behaviors using a state machine and implement telegraphed combat cues.

### 25125013 – Do Gia Huy
- **Task A: Local Co-Op Framework Setup**
  - Refactor player references to dynamic arrays (`std::vector<std::unique_ptr<PlayerBase>>`) to lay the groundwork for local cooperative play.
  - Wire dual gamepad/keyboard input configurations.
- **Task B: Map Boundaries & Scrolling Tiled Backgrounds**
  - Implement scrolling tilemaps or background grid wrapping so player movement feels continuous over an infinite plane.

---

## 5. Issues

1. **Issue:** SSL/TLS certificate verification failures occurred on CMake setup when attempting to download SFML packages over secure connections on restricted networks.
   - *Resolution:* Configured the CMake run parameters to skip TLS certificate verification (`CMAKE_TLS_VERIFY=OFF`) since the SFML archive is fetched from trusted sources.
2. **Issue:** Mouse click events from the main menu were leaking through and instantly selecting characters or state options on the succeeding screen.
   - *Resolution:* Added an input delay timer (`m_timeInState`) inside the update loop of transition states to ignore click registers during the first 200ms.
3. **Issue:** Axe, Magic Wand, Knife, and Whip projectile textures were drawing upside down or mapping to wrong sprite offsets due to differences in coordinate spaces.
   - *Resolution:* Re-mapped the source rectangle coordinates (`sf::IntRect`) based on top-left offsets matching the target spritesheets.
