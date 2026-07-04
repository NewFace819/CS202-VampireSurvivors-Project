# Project Development Report

### Prompt #1: Phase 1 (Week 1) - Engine Foundation & Spatial Hash Grid
- **Objective:** Set up C++/SFML environment, GameManager FSM, and Spatial Hash Grid.
- **Solution/Implementation:** Initialize SFML game loop and window. Create `GameManager` for state transitions. Implement $O(1)$ collision detection using a Spatial Hash Grid.
- **Affected Files:** `src/main.cpp`, `src/GameManager.h`, `src/GameManager.cpp`, `src/SpatialHashGrid.h`, `src/SpatialHashGrid.cpp`

### Prompt #2: Phase 1 (Week 2) - Entity Logic & Object Pooling
- **Objective:** Create abstract Entity/EnemyBase and Bounded Dynamic Object Pool.
- **Solution/Implementation:** Implement base entity classes for 8-directional movement. Build a memory-safe object pool to prevent fragmentation during mass spawning.
- **Affected Files:** `src/Entity.h`, `src/Entity.cpp`, `src/EnemyBase.h`, `src/EnemyBase.cpp`, `src/ObjectPool.h`

### Prompt #3: Phase 1 (Week 3) - Weapons, Combat & Knockback
- **Objective:** Develop WeaponBase abstraction and mass-based knockback physics.
- **Solution/Implementation:** Decouple weapons from projectiles. Add velocity and mass logic to process swarm knockback smoothly.
- **Affected Files:** `src/WeaponBase.h`, `src/Projectile.h`, `src/Physics.h`

### Prompt #4: Phase 1 (Week 4) - Event-Driven Systems & Progression
- **Objective:** Create StatsManager, EXP gem collection, and Observer Pattern UI.
- **Solution/Implementation:** Drive Health/EXP bars via events instead of polling. Implement magnet-based EXP collection and the level-up pause menu.
- **Affected Files:** `src/StatsManager.h`, `src/Observer.h`, `src/LevelUpUI.h`

### Prompt #5: Phase 1 (Week 5) - Time-based Spawner & Session Persistence
- **Objective:** Code data-driven Timeline Spawner and Mid-Game Save/Load.
- **Solution/Implementation:** Parse timeline data to increase density. Use C++ File I/O to serialize game state.
- **Affected Files:** `src/TimelineSpawner.h`, `src/SaveManager.h`

### Prompt: Asset Manager & Spritesheet Support
- **Objective:** Provide a mechanism to handle large, merged texture atlases (spritesheets) instead of extracting them.
- **Solution/Implementation:** Created a Singleton `ResourceManager` and a `SpriteSheet` utility to slice textures via `sf::IntRect`.
- **Affected Files:** `src/Engine/ResourceManager.h/cpp`, `src/Engine/SpriteSheet.h`

### Prompt: Bug Fix - Black Screen on Startup
- **Objective:** Fix the SFML `Unable to open file` runtime error and black screen.
- **Solution/Implementation:** Added a `POST_BUILD` command in `CMakeLists.txt` to copy `assets/` to the build folder, and rendered `title.png` in `MainMenuState`.
- **Affected Files:** `CMakeLists.txt`, `src/State/MainMenuState.h/cpp`

### Prompt: Integration - Basic Gameplay Loop
- **Objective:** Wire up the entities and object pool so the game actually runs in `PlayingState`.
- **Solution/Implementation:** Created the `Player` class with WASD movement. Integrated `ObjectPool<EnemyBase>` into `PlayingState.cpp` to continuously spawn tracking enemies every 0.5s.
- **Affected Files:** `src/Entities/Player.h/cpp`, `src/State/PlayingState.h/cpp`

### Prompt #4: Phase 1 (Week 4) - Event-Driven Systems & Progression (Execution)
- **Objective:** Create StatsManager, EXP gem collection, and Observer Pattern UI.
- **Solution/Implementation:** Implemented the `Observer` pattern to decouple UI from gameplay logic. Built `StatsManager` to handle player progression, level-ups, and trigger the `LevelUpUI` pause state when EXP thresholds are met.
- **Affected Files:** `src/Engine/Observer.h`, `src/Engine/StatsManager.h/cpp`, `src/State/LevelUpState.h/cpp`, `src/Entities/ExpGem.h`

### Prompt: Character Animation Sync and Weapon VFX Fix
- **Objective:** Fix the character walk animation frames and correct the VFX sprites for the Axe, Magic Wand, Knife, and Whip.
- **Solution/Implementation:** Use correct dynamically sized `sf::IntRect` walkFrames per character. Point weapons to their accurate icon representations in `items.png` and `vfx.png`.
- **Affected Files:** `src/State/PlayingState.cpp`, `src/Weapons/Axe.h`, `src/Weapons/Knife.h`, `src/Weapons/MagicWand.h`, `src/Weapons/Whip.h`

### Prompt: Fix Character Select Skip & Inverted Weapon Sprites
- **Objective:** Fix the immediate click-through bug on Character Select, and fix the inverted Y-coordinates for weapon textures.
- **Solution/Implementation:** Added a `m_timeInState` delay to `CharacterSelectState` to prevent mouse events from bleeding over from `MainMenuState`. Fixed the SFML texture Y-coordinates (Top-Left) against Unity's `.asset` values (Bottom-Left) for Axe, Knife, MagicWand, and Whip.
- **Affected Files:** `src/State/CharacterSelectState.h`, `src/State/CharacterSelectState.cpp`, `src/Weapons/Axe.h`, `src/Weapons/Knife.h`, `src/Weapons/MagicWand.h`, `src/Weapons/Whip.h`

### Prompt: Weapon Projectile VFX Adjustments
- **Objective:** Change the projectile visual representation of Whip and Magic Wand from their UI icons to their actual VFX sprites (slash and sparkle).
- **Solution/Implementation:** Reverted Whip to use `vfx.png` with `slash.asset` and Magic Wand to use `vfx.png` with `ProjectileBlue1.asset`, applying the proper SFML Y-coordinate conversion (SFML top-left vs Unity bottom-left).
- **Affected Files:** `src/Weapons/Whip.h`, `src/Weapons/MagicWand.h`

### Prompt: Level-Up Weapon Choice System
- **Objective:** Implement a full level-up screen where the player can choose to upgrade an owned weapon or acquire a new one.
- **Solution/Implementation:** Added `getName()`, `getUpgradeDescription()`, and wiki-accurate `levelUp()` overrides to all 5 weapons. Added `m_amount` multi-fire burst support to `WeaponBase`. Rewrote `LevelUpState` to display up to 3 styled cards drawn from a pool of upgradeable owned weapons and unowned new weapons (shuffled). `PlayingState` detects `StatsManager` level-ups each frame and pushes `LevelUpState` with a pointer to itself. `LevelUpState::isTransparent()` enables `GameManager` to draw `PlayingState` behind the overlay. The `GameManager` draw loop was updated to render the state below when the top is transparent.
- **Affected Files:** `src/Weapons/WeaponBase.h`, `src/Weapons/Whip.h`, `src/Weapons/MagicWand.h`, `src/Weapons/Knife.h`, `src/Weapons/FireWand.h`, `src/Weapons/Axe.h`, `src/State/PlayingState.h`, `src/State/PlayingState.cpp`, `src/State/LevelUpState.h`, `src/State/LevelUpState.cpp`, `src/State/GameState.h`, `src/Engine/GameManager.cpp`
