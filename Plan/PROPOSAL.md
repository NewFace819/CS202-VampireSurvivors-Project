**PROJECT PROPOSAL --- VAMPIRE SURVIVORS**
---
CS202 - Programming System

- **Student:** Do Gia Huy
- **Student ID:** 25125013

- **Submission Date:** June 2, 2026

---
# 1. Project Overview & Goals

## 1.1 Game Title & Genre

**Project Name:** *Vampire Survivors Clone* (Top-down Horde Survival / Rogue-lite)  
**Primary Goal:** To design and build a fully operational 2D top-down rogue-lite survival game utilizing C++ and the SFML library. This project strictly follows Object-Oriented Programming (OOP) core concepts (Encapsulation, Inheritance, Polymorphism, Abstraction) and implements at least five well-known Design Patterns. By changing to a top-down perspective, the engine's primary challenge shifts from standard platformer physics to managing a huge number of active entities (over 1000) and intricate data-driven progression mechanics.

## 1.2 Reason for Topic Change (Moving away from Super Mario Bros.)

Although *Super Mario Bros.* provides a solid basis for typical platformer mechanics, its linear design restricts opportunities for substantial modular growth. To fulfill the requirement of producing a project with **double the features** of a standard 4-person team, we are pivoting to the Horde Survival genre due to the following technical considerations:
* **Modular Expansion:** The Rogue-lite genre relies heavily on data-driven architecture. Implementing new characters, weapons, and enemy variants doesn't demand changes to the underlying physics engine. It only requires extending abstract base classes and setting new parameters, which lets us effortlessly double the feature volume without structural hazards.
* **Large-Scale Optimization:** Rather than handling a small number of entities, this project pushes the developers to render, update, and process collisions for upwards of 1,000 simultaneous enemies and projectiles while maintaining a steady 60 FPS. This demands sophisticated memory management and optimization strategies that are far more technically complex than basic 2D platformer logic.

## 1.3 Pair-Group Structure & Collaboration Efficiency

Considering the requirement for a 2-person group to handle a project with double the scope, our team has a demonstrated history of technical proficiency and execution to warrant this arrangement.

* **Proven Execution Ability:** In past advanced courses, the members of this team have independently and successfully managed the full software development lifecycle for complex technical projects—most notably the *Advanced Data Structure Visualizer* (built with C++/SFML) and a fully operational *Go Game Engine*. The collaboration of two closely aligned developers with this practical experience offers strong assurance that the double-feature scope can be delivered on time.
* **Minimized Overhead & Shared Architecture:** Since both members have previous experience with the necessary C++/SFML stack, the initial "learning curve" is greatly reduced. Furthermore, a highly organized two-person dynamic significantly cuts down on communication delays and integration issues. This enables the team to dedicate their energy entirely to quick architectural decisions, algorithm optimization, and smooth code merging.

# 2. Rubric Alignment & Scope Validation

To guarantee full compliance with the course grading criteria while asking for a special 2-person team structure, we have carefully matched our planned features against the standard CS202 Final Project Rubric.

## 2.1 Quantitative Feature Growth (Proof of Double Scope)

The main rationale for assigning this project to a 2-person team is the massive jump in technical difficulty and feature quantity. The table below illustrates how the *Vampire Survivors Clone* not only meets the essential Rubric demands but effectively doubles the coding workload by swapping basic platformer mechanics for complex, data-driven systems.

**Quantitative Comparison: Standard (4-Person) vs. Proposed (2-Person)**

| #   | Feature Name & Rubric Mapping                                 | Technical Details                                                              | Required | Extra |
| --- | ------------------------------------------------------------- | ------------------------------------------------------------------------------ | :-------: | :--------: |
| 1   | **8-Directional Movement** <br>*(Rubric: Player Inputs)*      | Normalized movement vectors to keep velocity consistent across 8 directions.   |    ✔️     |            |
| 2   | **Dual-Collision System** <br>*(Rubric: Collision)*           | Circle-Circle for characters and AABB axis-separated checks for terrain.       |    ✔️     |            |
| 3   | **Basic Swarm Logic** <br>*(Rubric: Enemy Behavior)*          | Distance-based tracking and pathing for standard enemies.                      |    ✔️     |            |
| 4   | **Items & EXP Gathering** <br>*(Rubric: Power-Ups/Items)*     | Magnetic EXP orbs and dynamic stat changes upon pickup.                        |    ✔️     |            |
| 5   | **Time-Based Scaling** <br>*(Rubric: 3 Level Completion)*     | 3 unique difficulty phases controlled by a dynamic spawning timeline.          |    ✔️     |            |
| 6   | **State Persistence** <br>*(Rubric: Game State)*              | Mid-game saving of timers, positions, and current equipment.                   |    ✔️     |            |
| 7   | **Foundational Audio** <br>*(Rubric: Sounds)*                 | Centralized SFX buffering and BGM streaming for delay-free playback.           |    ✔️     |            |
| 8   | **Multi-phase Boss AI** <br>*(Rubric: Advanced AI)*           | Hierarchical FSM controlling telegraphed moves and health-triggered phases.    |           |     ✔️     |
| 9   | **Class-Based Characters** <br>*(Rubric: Multiple Players)*   | 4 polymorphic classes featuring distinct passive traits and starting weapons.  |           |     ✔️     |
| 10  | **Spatial Hash Grid**<br>_(Extension)_                        | $O(1)$ lookup algorithmic optimization for handling 1000+ entity collisions.   |           |     ✔️     |
| 11  | **Weapon Synergies** <br>*(Extension)*                        | Data-driven upgrading mechanic needing specific active/passive pairings.       |           |     ✔️     |
| 12  | **Meta-Progression Store** <br>*(Extension)*                  | Cross-session account saving system for lasting stat boosts.                   |           |     ✔️     |
| 13  | **Mass-Based Knockback** <br>*(Extension)*                    | Newtonian physics resolution separated from movement vectors.                  |           |     ✔️     |
| 14  | **Local Co-op Mode** <br>*(Stretch Goal)*                     | Dual-input support and shared-screen swarm targeting.                          |           |     ✔️     |

As shown in the table, shifting from a handful of entities in a linear platformer to a dynamic, large-scale rogue-lite setting demands sophisticated architectural design. This workload easily justifies the 200% scope prerequisite for a 2-person group.

## 2.2 Suggested Role & Task Allocation

Because the final 2-person team will be confirmed by the instructors, this proposal provides a theoretical division of responsibilities focused on architectural subsystems instead of standalone features. This modular strategy ensures both developers can work simultaneously, heavily reducing Git merge conflicts and integration hold-ups.

To facilitate smooth teamwork, the subsystem borders are deliberately planned so that **Developer B** communicates with the core engine purely through clear interfaces and APIs provided by **Developer A's** modules. This ensures loose coupling and strong cohesion throughout the codebase.

* **Developer A (Core Engine & Optimization):** Concentrates on low-level system architecture and hardware efficiency.
  * Implementation of a Spatial Hash Grid (Uniform Grid).
  * Object Pool Memory Management for handling massive entity counts.
  * Mathematical Collision Processing (Circle-Circle and AABB).
* **Developer B (Gameplay & Progression Mechanics):** Concentrates on data-driven game logic, UI integration, and player interactions.
  * Weapon Evolution & Synergy Mechanics (Strategy Pattern).
  * Character Classes & Dynamic Stat Tracking.
  * Meta-Progression Store and C++ File I/O (Mid-game Save/Load functionality).
* **Shared Milestones:**
  * **AI Integration:** Collaboratively using Developer A's spatial systems and Developer B's entity data to build the Swarm and Multi-phase Boss AI (FSM).
  * **System Interconnection:** Implementing the Observer Pattern across modules to manage Event-driven UI and Audio cues.


## 3. Core Scope - Essential Features

The Minimum Viable Product outlines the strict, underlying architecture needed to produce a fully functional _Top-down Horde Survival_ game. This portion details the essential subsystems that ensure the project meets the rubric's basic requirements (physics, entity management, and state tracking) before adding stretch goals.

### 3.1 [Feature 1 & 2] 8-Directional Movement & Dual-Collision System

**Goal:** Deliver smooth player movement and reliable collision detection to handle large enemy crowds without major frame-rate drops.

**Core Elements:**
- **Normalized Kinematic Vectors:** Directional inputs are transformed into normalized 2D vectors, ensuring a steady speed in all directions and eliminating diagonal speed boosts.    
- **Circle-Circle Collision (Living Entities):** Uses highly optimized squared-distance math ($\Delta x^2 + \Delta y^2 \leq (R_1 + R_2)^2$) for fast CPU hitbox detection between the player, enemies, and EXP gems.
- **AABB Collision (Static Terrain):** Axis-Aligned Bounding Boxes are used strictly for non-moving environmental walls.
- **Axis-Separated Resolution:** Checks X-axis and Y-axis collisions separately to enable smooth sliding along walls and totally prevent the "corner-snagging" issue.

**Acceptance Criteria:**
- The player moves seamlessly in all 8 directions at a consistent speed.
- Huge enemy swarms can overlap and interact with the player without major lag.
- The player character slides smoothly against boundaries without getting stuck.

### 3.2 [Feature 3] Foundational Swarm Logic & Target Seeking

**Goal:** Build the basic pathfinding and entity control for large enemy groups using an inheritance-focused class structure.

**Core Elements:**
- **Enemy Class Hierarchy (Inheritance & Polymorphism):** An abstract `EnemyBase` class fully hides internal physics attributes (health, speed, damage). Concrete derived classes (e.g., `Bat`, `Zombie`, `Skeleton`) inherit these properties and override the virtual `updateAI()` function, showcasing Polymorphism with unique movement patterns.
- **Swarm Tracking:** Enemies utilize a distance-based tracking method, constantly altering their velocity vectors to move directly toward the player.

**Acceptance Criteria:**
- Polymorphic AI patterns run smoothly without logic errors.
- Massive enemy hordes can chase the player without causing significant FPS drops.

### 3.3 [Feature 4] Items, EXP Gathering & Dynamic Leveling

**Goal:** Meet the "Power-Ups and Items" rubric criteria by building a dynamic progression cycle centered on item collection, automatic attacks, and strict stat management.

**Core Elements:**
- **Magnetic Pickups:** EXP gems and dropped loot are drawn to the player based solely on the player's active _Magnet_ radius.
- **Active Arsenal (Auto-Combat):** The main combat system serves as the primary "Power-ups." It includes abstract automatic weapons (e.g., constant Melee AoE, Auto-aim shots) that level up with the player and fire automatically based on internal timers.
- **Encapsulated Stat Tracking:** A centralized, heavily protected data structure (`StatsManager`) controls 6 main attributes: _MoveSpeed, Might (Damage boost), Armor, Cooldown (Attack speed), Area (Size), and Magnet (Pickup range)_.
- **Level-Based Progression:** Collecting EXP fills a progress bar. Hitting the cap triggers a global state change in the Finite State Machine (FSM), pausing gameplay to start the level-up sequence.
- **RNG-Driven Upgrade UI:** The game uses a Random Number Generator (RNG) to offer 3 upgrade options from the available pool. The chosen buff is safely applied to the stat manager.

**Acceptance Criteria:**
- EXP gems are pulled to the player according to their _Magnet_ radius.
- The game engine and AI pause completely and safely during the Level-Up screen.
- Picking an upgrade immediately updates multipliers and changes gameplay (e.g., larger weapon size or faster movement).

### 3.4 [Feature 5] Time-Based Scaling (Dynamic Spawning)

**Goal:** Handle enemy lifespans, difficulty increases, and automatic entity creation via a timer-driven system to meet the "3 Level Completion" criteria.

**Core Elements:**
- **Data-driven Spawner:** A central manager that processes an internal timeline schedule. As the game clock advances (e.g., Minute 1 vs. Minute 5), the system adjusts spawn probabilities to introduce tougher enemy types in greater numbers.

**Acceptance Criteria:**
- Enemy types, health limits, and spawn rates naturally increase as time passes, creating a smooth difficulty ramp.
    

### 3.5 [Feature 6] Mid-game Persistence (Save/Load Functionality)

**Goal:** Fulfill the file handling rubric requirement by creating a reliable saving mechanism. This allows players to pause, write their exact progress to disk, and continue playing later.

**Core Elements:**
- **State Encapsulation:** The `GameManager` safely stores all changing session details, such as the exact game timer, player position, current level, stat multipliers, and gathered EXP.
- **Serialization & File I/O:** Using standard C++ file streams (`std::ofstream`, `std::ifstream`) to save and load data in a clear format (like Key-Value pairs), ensuring data persists between sessions.
- **Dynamic Arsenal Rebuilding:** When a save file is loaded, the game dynamically reconstructs the player's weapons by reading IDs and creating the proper weapon classes using a Factory pattern.

**Acceptance Criteria:**
- The player can pick "Save & Quit" during a match, creating a proper `.dat` or `.txt` file without memory issues.
- Choosing "Continue" from the menu correctly reads the file, bringing back the exact timer, position, health, and equipment.
- **Error Handling:** The system safely catches file errors (like missing or broken saves) and stops crashes, returning the player to the Main Menu.

### 3.6 [Feature 7] Foundational Audio & Resource Handling

**Goal:** Meet the audio requirements by delivering dependable, delay-free sound effects (SFX) and memory-friendly background music (BGM), ensuring audio matches gameplay without causing lag.

**Core Elements:**
- **Central Resource Manager:** To avoid massive lag spikes during intense combat, the game forbids reading audio files from the disk right when they need to play. An `AssetManager` pre-loads all small `.wav`/`.ogg` files into `sf::SoundBuffer` objects once during startup.
- **BGM vs. SFX Separation:** The system strictly separates long music tracks from short sound effects. Background music uses `sf::Music` to stream big files from the hard drive, saving RAM. In contrast, combat sounds use `sf::Sound` with pre-loaded buffers for instant playback.
- **State-Aware Audio:** The main audio channels are linked to the game state to keep audio consistent (e.g., pausing or playing music based on whether the player is fighting or in a menu).

**Acceptance Criteria:**
- Background music starts and loops smoothly when gameplay begins.
- Combat SFX (like hits, EXP pickups, enemy deaths) play on the exact frame the collision happens.
- All audio correctly pauses or silences when moving to the `PauseState` or `MainMenuState`.


## 4. Advanced Features & Technical Extensions

After completing the 7 essential features, the project will grow to include advanced systems meant to greatly increase software depth, gameplay complexity, and structural elegance. These additions focus heavily on deep Object-Oriented Design (OOD), strict use of Design Patterns, and data-driven flexibility. By building these extensions, the project evolves from a basic survival game into a highly flexible, scalable application, completely justifying the workload for an elite 2-person team.

### 4.1 [Feature 8] Multi-phase Boss AI & Telegraphed Attacks

**Goal:** Create a multi-stage boss enemy that uses a hierarchical State-Strategy setup, telegraphed attack sequences, and health-triggered phase changes for a structured challenge.

**Core Elements:**
- **Macro-State Control (FSM):** The boss's overall behavior is controlled by a core Finite State Machine (FSM) using abstract `BossState` classes (like `IdleState`, `ChaseState`, `AttackingState`), handling high-level choices and movement.
- **Micro-Pipeline using Strategy Pattern:** When entering the `AttackingState`, the FSM passes execution to an `AttackStrategy` interface. Concrete strategies (e.g., `LaserSweepStrategy`, `DashImpactStrategy`) manage their own timing parameters, running a _Windup (Telegraph) $\rightarrow$ Execution $\rightarrow$ Recovery_ loop without linking data back to the main FSM.
- **Delayed Phase Changes (Memory Safety):** By monitoring health via callbacks, hitting specific HP levels queues a phase change. To avoid memory errors or Undefined Behavior (like deleting a running attack strategy), the FSM uses a secure _Deferred Transition_ system. The actual switch only happens when the current `AttackStrategy` finishes cleanly and returns the boss to `IdleState`.

**Technical Importance:**
This system directly applies the **State Pattern** and **Strategy Pattern** to create a unified Hierarchical AI. It offers a scalable, memory-safe way to manage complex boss patterns without adding messy "if-else" statements into the main update loop.

### 4.2 [Feature 9] Class-Based Character System (Multiple Players)

**Goal:** Meet the "Multiple Players" criteria not by just changing character art, but by building a highly scalable, polymorphic character framework. This setup integrates with the Factory Pattern and Account Progression system to offer unique, enclosed mechanics for 4 distinct classes (Tank, Ranger, Mage, Gambler).

**Core Elements:**
- **Polymorphic Trait Encapsulation:** Instead of just changing base stats, unique passive skills are built as polymorphic behaviors. By overriding virtual functions (like `virtual void applyPassive()`), each class runs specific logic: `Tank` overrides damage taken for flat armor reduction, while `Gambler` overrides EXP/Gold gains to add a randomized multiplier.
- **Factory Initialization:** Character creation is handled by a `CharacterFactory`. When given a `ClassID` from the menu, the factory allocates memory for the right class, assigns textures, and automatically gives the class its starting weapon (e.g., the _Magic Wand_ for the Mage).
- **Stat Aggregation:** To avoid clashing with the Meta-Progression Store (Section 4.5), stats follow a strict formula: $\text{LiveStats} = \text{BaseStats}_{\text{Class}} + \text{PermanentUpgrades}_{\text{Account}}$. This ensures class baselines stack properly with global upgrades.
- **Abstract UI Connection:** The UI (health/EXP bars) never links directly to specific classes like `Tank` or `Mage`. It only watches the abstract `PlayerBase` interface, keeping the UI completely separate from the actual class logic.
- **Safe Memory Lifecycles:** The player character is managed by a smart pointer (`std::unique_ptr<PlayerBase>`) in the `GameManager`. This guarantees that moving between the menu and a game automatically and safely deletes the old entity, avoiding memory leaks from manual `delete` commands.

**Technical Importance:**
This setup strongly demonstrates **Polymorphism**, the **Factory Pattern**, and **Smart Pointer Memory Safety**. By separating the UI from specific classes and creating a clean stat-combining system, the project builds a framework where new classes can be easily added without changing core code.

### 4.3 [Feature 10] Spatial Hash Grid (Uniform Grid)

**Goal:** While the game keeps the 2D style of Horde Survival games, moving to this genre brings a huge engineering challenge. To justify the 2-person team scope, the project includes an advanced data structure to handle high-density collisions.

**Core Elements:**
- **The Processing Bottleneck:** With 1,000+ enemies and projectiles active, a basic brute-force collision system would need hundreds of thousands of checks every frame. This would severely bottleneck the CPU and ruin the frame rate.
- **The Grid Solution:** To fix this, we will build a Spatial Hash Grid. The world is divided into a fixed 2D array of cells based on a set `CELL_SIZE`. Each cell acts as a bucket holding references to entities currently inside it.
- **Algorithmic Efficiency:** Instead of checking every pair of objects, the game maps an entity's coordinates directly to a grid cell. Objects are only tested against others in their own cell and the 8 adjacent cells, achieving O(1) lookup times and maximizing CPU cache locality.

**Technical Importance:**
Implementing a highly optimized Spatial Hash Grid requires sophisticated memory and array management in C++. By shifting from pointer-heavy tree structures to cache-friendly contiguous memory, this design validates the project's advanced nature and emphasis on system-level performance.

### 4.4 [Feature 11] Weapon Synergies & Evolution

**Goal:** Expand the basic weapon system by adding a data-driven evolution mechanic that upgrades max-level weapons into much stronger versions based on specific item combinations.

![](Attachments/weapon-evolution-synergy-system.png)

**Core Elements:**
- **Data-Driven Rules Dictionary:** An external map (like `std::map` or JSON) that defines the exact pairing needed between an active max-level weapon and a specific passive item.
- **Real-time Evolution Checks:** The inventory system watches the player's items. When opening a chest, the system checks current items against the Rules Dictionary in $O(1)$ time to see if an evolution should happen.
- **Polymorphic Weapon Swapping:** If an evolution is triggered, the system uses a **Factory Pattern** to create the new, upgraded weapon class. The old weapon is safely deleted and replaced via a base pointer (`WeaponBase*`), taking over the combat loop smoothly.

**Technical Importance:**
This shows advanced use of **Inheritance** and **Polymorphism**. By treating all weapons as abstract objects, the system can drastically change projectile behaviors during gameplay. The data-driven approach also follows the **Open/Closed Principle (OCP)**—new evolutions can be added forever without changing the core inventory code.

### 4.5 [Feature 12] Meta-Progression Store (Account Saving)

**Goal:** Build a secure, cross-session upgrade system where players can boost base stats permanently using gold collected across runs. This is completely separate from the mid-game saving discussed in Section 3.5.

**Core Elements:**
- **Separation of Concerns:** While the MVP (Section 3.5) deals with temporary _Run-specific data_ (like position and timer), this system manages _Account-level data_ (like total gold and permanent upgrades). This keeps data safe across the whole application.
- **Total Encapsulation & Singleton Control:** Permanent stats are safely hidden inside a `PlayerProfile` class. To prevent cheating or errors, the UI cannot change variables like `gold` directly. Instead, a `ProfileManager` (using the **Singleton Pattern**) handles all purchases and data changes securely.
- **Data-Driven Setup (OCP Compliant):** Instead of writing separate code for every stat, the shop's items are loaded dynamically into an array of `UpgradeNode` structures. Adding a new stat just means adding a new node to the database. This perfectly follows the **Open/Closed Principle (OCP)**, allowing easy expansion without changing core logic.
- **Event-Driven UI & Safe Saving:** The shop UI uses the **Observer Pattern** for loose coupling. The UI catches clicks and sends buy requests to the `ProfileManager`. If the buy works, the manager sends a `Notify()` signal, telling the UI to update the displayed gold. To prevent file corruption, saving only happens at safe moments (like leaving the shop) and is protected by C++ Exception Handling.

**Technical Importance:**
This system focuses on **Strict Encapsulation** and **Data-driven Architecture** rather than Inheritance. By using the **Singleton Pattern** for profiles and the **Observer Pattern** for UI updates, it effectively separates the visuals from the underlying logic, showing a professional approach to data saving.

### 4.6 [Feature 13] Mass-Based Physics & Knockback

*Goal:** Design a highly efficient, physics-based knockback system for massive enemy crowds. This ensures that pushback effects work smoothly with swarm AI and walls without hurting CPU speed.

**Core Elements:**
- **Velocity Decoupling:** Changing an enemy's pathfinding vector directly causes AI glitches. Instead, movement is split into two parts: $\vec{v}_{\text{total}} = \vec{v}_{\text{steering}} + \vec{v}_{\text{impulse}}$. The $\vec{v}_{\text{impulse}}$ hits its peak on impact and fades over time using friction, creating a smooth slowdown.
- **Mass-Based Scaling (Newton's Second Law):** Knockback isn't hardcoded. The `EnemyBase` class has a `mass` variable. When hit, acceleration is calculated dynamically: $a_{\text{knockback}} = \frac{F_{\text{weapon}}}{m_{\text{enemy}}}$. This means heavy bosses resist knockback, while small enemies fly backward.
- **Grid Syncing:** Knockback moves enemies quickly. To stop them from skipping collision checks, the system instantly updates their cell registration in the Spatial Hash Grid to maintain accuracy.
- **AABB Wall Clipping Fix:** Fast knockback could push enemies through walls. The game prevents this by running the Axis-Separated Resolution algorithm on the impulse vector. If pushed into a wall, the force moving into the wall is canceled, making the enemy slide along it instead.
- **Zero-Allocation Math:** To keep 60 FPS during huge fights, knockback math uses fast `sf::Vector2f` calculations. No dynamic memory (`new`/`delete`) is used for physics, completely avoiding memory slowdowns.

**Technical Importance:**
This bridges **Data-driven Architecture** with **Mathematical Physics**. By separating AI movement from knockback and keeping the Spatial Hash Grid updated, the system handles complex math for 1,000+ entities without bugs like wall-clipping or slowing down the game.

### 4.7 [Feature 14] Local Co-op Mode (Stretch Goal)

**Goal:** Add a local two-player cooperative mode to prove the engine's flexibility and strength. This changes the game from a single-player focus to handling multiple player entities, proving the engine runs well even when sharing a screen.

**Core Elements:**
- **De-singularized Engine:** The core code drops the standard single-player pointer. Instead, the `GameManager` holds a list of players (`std::vector<std::unique_ptr<PlayerBase>>`). All systems (UI, Spawners, Audio) check player data through this list, removing the reliance on a single player object.
- **Dynamic Swarm Targeting:** The enemy AI is updated to chase multiple targets. Each `EnemyBase` checks its squared distance ($d^2 = \Delta x^2 + \Delta y^2$) to all active players. The AI locks onto the nearest player, letting huge swarms naturally split up and surround both players without messy hardcoded logic.
- **Flexible Input System:** To stop keyboard jamming, the game uses an `InputController` interface. Player 1 gets a `KeyboardController` (WASD), and Player 2 gets a `GamepadController` (using `sf::Joystick`) or different keys. The player movement code doesn't care which hardware is used.
- **Shared Camera & Boundaries:** Splitting the screen would double rendering demands, causing lag with 1,000+ enemies. Instead, the game uses a Shared Camera where the view centers perfectly between both players ($X_{\text{camera}} = \frac{x_1 + x_2}{2}$). To keep things fair, a boundary system stops players from moving off-screen.
- **Shared EXP & UI Sync:** Both players share one EXP and Gold pool. When they level up, the global FSM pauses the game. The **Observer Pattern** manages the UI, showing upgrade choices without causing data errors or crashes.

**Technical Importance:**
This stretch goal heavily tests the software's design. By using **Dependency Injection** for controls, removing single-player limits, and handling camera math, it proves the framework is scalable, loosely coupled, and capable of complex data synchronization.


# 5. Object-Oriented System Architecture

This part acts as the comprehensive Architecture Map for the game. Instead of just listing features, these sections explain how the software is structured as a whole. The engine is built using **Loose Coupling** and **High Cohesion**. Different systems communicate purely through abstract interfaces and events to prevent messy circular dependencies. 

To keep the code clean and scalable, it's divided into three main layers:
* **Domain/Entity Layer:** Holds the core game rules, physics, and changing data for characters, enemies, and weapons.
* **System/Control Layer:** Handles heavy lifting like the Spatial Hash Grid, memory pools, and the overall Finite State Machine (FSM) that runs the game.
* **Boundary/Presentation Layer:** Manages all outside inputs and outputs, keeping SFML drawing, UI updates, and sound separate from the core game logic.

## 5.1 Entities & Enemy Swarms

**Goal:** Build a highly efficient system to handle over 1,000 active swarm enemies. This area solves the huge CPU and RAM drain common in Horde Survival games by using structural and behavioral Design Patterns.

![](Attachments/entity-enemy-swarm-sub-system.png)

**Core Elements:**
* **Deep Inheritance & State Control:** Everything starts with an abstract `Agent` class that holds basic physics (`sf::Vector2f position`, `velocity`) and sets required functions (`update()`, `draw()`). The `EnemyBase` class builds on this, adding combat stats like health and damage. Specific enemies (like `Zombie`, `Bat`) inherit from `EnemyBase`. Crucially, it uses **Strict Encapsulation**: other systems can't change an enemy's health directly. They must use `takeDamage()`, letting the enemy handle its own death or knockback.
  
* **RAM Saving via Flyweight Pattern:** Creating 1,000 unique zombies with full graphical data would crash the computer's memory. To fix this, data is split:
  * *Intrinsic State (Shared):* Unchanging data like `sf::Texture`, animations, and base stats are stored once in an `EnemySharedData` object.
  * *Extrinsic State (Unique):* Changing data like position, current health, and movement vectors stay separate for each enemy.
  This turns 1,000 heavy enemy objects into 1,000 tiny pointers referencing one *Flyweight* data block, shrinking memory use from Megabytes to Kilobytes.
  
* **Dynamic AI via Strategy Pattern:** Hardcoding movement into the `update()` function makes code messy and hard to change (violating the Open/Closed Principle). Instead, movement is separated into a `MovementStrategy` interface. Specific strategies (like `DirectChaseStrategy`, `FlankingStrategy`) are assigned to enemies using `std::unique_ptr`. This lets an enemy's behavior change instantly (like switching to `EvadingStrategy` at low health) without altering the enemy's main code.

**Technical Importance:**
This perfectly combines Structural and Behavioral patterns. The **Flyweight Pattern** saves RAM, while the **Strategy Pattern** saves CPU power. Combined with strong **Encapsulation**, they turn a massive swarm into a fast, manageable, and easily expandable system.

## 5.2 Weapons & Dynamic Combat

**Goal:** Design a highly flexible combat system that can run many different weapons at once without messy code branching. This focuses on Abstraction and Polymorphism to easily add new weapons, separate projectiles, and handle evolutions.

**Core Elements:**
* **Weapon Abstraction (Base Class):** All weapons fall under an abstract `WeaponBase` class. It safely holds shared data (level, cooldowns, and a link to the player's stats) and requires specific functions: `virtual void update(float dt, const sf::Vector2f& playerPos) = 0;` and `virtual void fire(const sf::Vector2f& playerPos) = 0;`. The player just keeps a list of these base pointers (`std::vector<std::unique_ptr<WeaponBase>>`), running all weapons in a simple loop without needing to know exactly what weapon it is.
* **Polymorphic Action (Late Binding):** The system completely avoids messy `if-else` or `switch` statements to figure out weapon types. Specific weapons override the required functions with their own rules:
  * *Aura Weapons (e.g., Garlic):* Overrides `update()` to attach a permanent `sf::CircleShape` damage zone to the player.
  * *Auto-Aim Weapons (e.g., Magic Wand):* Overrides `fire()` to ask the *Spatial Hash Grid* for the closest enemy and shoots a projectile at them.
  * *Random Strikes (e.g., Lightning):* Overrides `fire()` to hit a random spot inside the current camera view.
* **Separating Weapons and Projectiles:** A major design choice is keeping the *Spawner* (Weapon) separate from the *Payload* (Projectile). `WeaponBase` only handles timers and spawning. When `fire()` is called, independent `Projectile` objects are created (or pulled from the Object Pool) and manage their own movement and collisions.
* **Polymorphic Upgrades (OCP Compliance):** Working with the Weapon Evolution feature (Section 4.1), upgrading means simply swapping the `unique_ptr` (e.g., replacing `WandWeapon` with `EvolvedWandWeapon`). Since both inherit from `WeaponBase`, the game keeps running smoothly, strictly following the **Open/Closed Principle (OCP)**.
* **Safe Combat Interactions:** When a projectile hits an enemy, the system avoids risky `dynamic_cast` checks. It just calls the basic interface `enemy->takeDamage(calculatedDamage, knockbackImpulse)`. The enemy then figures out its own armor, death, and knockback, keeping the projectile completely separate from combat math.

**Technical Importance:**
This clearly shows how **Abstraction** and **Polymorphism** improve game architecture. By separating weapons from projectiles and using C++ dynamic dispatch, the design avoids messy type-checking, keeping the combat system safe, stable, and endlessly expandable.

## 5.3 Resource & Performance Optimization (Object Pool Pattern)

**Goal:** Fix the major hardware slowdown in Horde Survival games—specifically, the massive CPU stutters and memory issues caused by constantly creating and destroying objects (`new`/`delete`). This system builds a highly efficient memory setup to handle thousands of projectiles and enemies at once.

![](Attachments/resource-performance-object-pool-lifecycle.png)

**Core Elements:**
* **Removing Allocation Lag:** Instead of deleting an object when it's done (like a bullet flying off-screen or an enemy dying), it gets marked as *Inactive* and moved to a resting line. When the game needs a new object, it "wakes up" an inactive one instead of asking the computer for new memory. This happens instantly in $O(1)$ time. 
* **Cache-Friendly Design:** The pools use contiguous arrays (`std::vector`). By keeping data physically close together in RAM, the system maximizes CPU efficiency during fast update loops, greatly cutting down memory delay.
* **Clean State Reset:** Reusing memory can cause bugs if old data is left behind (like keeping old health or knockback velocity). To ensure safety, all pooled objects must have a `reset(const sf::Vector2f& newPos, ...)` function. This forces all changing variables to clear out before the object becomes *Active* again.
* **Safe Expansion Limits:** The system uses a Bounded Dynamic Pool. It starts with a set size but can grow (e.g., by 50%) if the game gets chaotic. However, to prevent Out-of-Memory crashes, it has a strict maximum limit. If the limit is hit, the pool safely replaces the oldest active projectile or simply refuses to spawn a new one.
* **Clean Connections & Grid Syncing:** 
  * *Factory Link:* Weapons don't touch memory directly. They only ask the `ProjectilePool` for an object. The Pool acts as a manager, only asking the `CharacterFactory` to make new objects if the resting line is empty and the limit hasn't been reached.
  * *Grid Link:* When an object goes *Inactive*, it immediately deregisters itself from the *Spatial Hash Grid*. This perfectly prevents "Ghost Collisions" where the game wastes time checking collisions on invisible, inactive objects.

**Technical Importance:**
This is a prime example of the **Object Pool Pattern** used for deep hardware optimization. By stopping memory fragmentation, forcing clean resets, and linking directly with spatial data, the structure ensures a smooth 60 FPS even under massive stress.

## 5.4 Spatial Hash Grid (Uniform Grid)

**Goal:** Provide a smart, highly optimized fix to the massive CPU slowdown caused by checking every single collision in huge enemy swarms. By dividing the 2D world into fixed cells, this system shifts the lookup complexity to $O(1)$ and maximizes CPU cache locality, serving as a major technical achievement for the project.

![](Attachments/spatial-hash-grid-sub-system.png)

**Core Elements:**
* **Fixed Cellular Mapping:** The world is conceptually divided by a set `CELL_SIZE` (e.g., slightly larger than the maximum entity radius). When an entity is updated, its position is integer-divided to produce a specific `(gridX, gridY)` coordinate, placing it instantly into its respective cell.
* **Cache-Friendly Storage:** The grid uses a flat 1D array (`std::vector`) structured to represent the 2D map. This contiguous memory layout avoids the pointer-hopping delays inherent in tree structures, drastically improving CPU execution time during the update loop.
* **O(1) Neighbor Lookup:** When a weapon or entity checks for collisions, it doesn't traverse a tree. It simply looks at its current cell and the 8 surrounding neighbor cells in constant time, instantly acquiring a small, focused list of "Collision Candidates."
* **Fast Re-registration:** Because enemies move constantly, their cell registrations must stay updated. The grid provides a high-speed `updateEntityCell(Entity*)` function that instantly moves an entity's pointer from its old cell bucket to a new one if it crosses a cell boundary.
* **Safe Pointers (Lifecycle Sync):** This grid works hand-in-hand with the Object Pool (Section 5.3). When an entity becomes *Inactive*, it instantly deregisters its pointer from its active Grid Cell. This strict cleanup completely stops "Dangling Pointers" and "Ghost Collisions" that would otherwise crash the game.

**Technical Importance:**
This system is the mathematical foundation of the game engine's scaling capability. By building a highly optimized Spatial Hash Grid that prioritizes cache locality and $O(1)$ lookups over traditional trees, the project shows an exceptional understanding of **Hardware-Level Optimization and Advanced Data Structures (DSA)**, perfectly meeting the high engineering standards of a system-level class.

## 5.5 Game Flow & Core States (FSM State Pattern)

**Goal:** Manage the whole application from start to finish (Menus, Gameplay, Leveling up, Game Over) using a high-level Finite State Machine (FSM). This entirely removes huge, messy `switch-case` statements and stops the `GameManager` from becoming an overloaded "God Object".

![](Attachments/game-flow-fsm-state-pattern.png)

**Core Elements:**
* **Stack-Based Control:** The engine uses an abstract `GameState` interface requiring standard functions: `enter()`, `update(dt)`, `draw(window)`, and `exit()`. Importantly, the FSM doesn't just hold one active state. It uses a stack (`std::stack<std::unique_ptr<GameState>>`). When a player pauses, a `PauseState` is pushed on top. The `PlayingState` underneath stays safely in memory, picking right back up when the pause is removed.
* **Safe Freeze Protocol (Level-Up):** Linking with the Progression System (Section 3.2), getting enough EXP pushes the `LevelUpState` onto the stack. This new state takes over the update loop but completely ignores the `PlayingState` underneath. This safely and totally freezes all enemies, projectiles, and physics while the upgrade menu works, preventing any background bugs.
* **Delayed Transitions (Memory Safety):** Trying to change states directly inside a state's `update()` function will crash the game (because it deletes the code it's currently running). To be safe, the FSM uses a *Deferred Transition Layer*. State changes are queued up and only happen at the *End-of-Frame*, after all drawing and updating are completely finished.
* **Macro vs. Micro FSM Distinction:** It is important to know the difference between this overall Game FSM and the specific Boss FSM from Section 4.2. The Boss FSM controls small combat actions, while this FSM controls the entire application. They are completely separate.
* **Saving & Loading Integration:** The FSM controls the mid-game saving (Section 3.5). Choosing "Save & Quit" in the `PauseState` tells the game to save the hidden `PlayingState`. Likewise, clicking "Continue" on the Main Menu creates a blank `PlayingState`, loads the save file to rebuild the game world, and pushes it onto the active stack.

**Technical Importance:**
This system is a perfect example of combining the **State Pattern** with **Stack-based Memory Management**. By delaying state changes and keeping macro/micro logic separate, the design ensures a stable, crash-free experience that smoothly handles menus, gameplay, and saving.

## 5.6 Event-Driven UI & Sound (Observer Pattern)

**Goal:** Achieve total Loose Coupling by keeping the main game logic completely separate from UI graphics and Sound. This system uses an Event-Driven setup to stop messy code where game rules directly trigger hardware or drawing commands.

![](Attachments/event-driven-ui-audio-observer-pattern.png)

**Core Elements:**
* **Subject/Observer Setup:** The design uses an abstract `Observer` interface requiring an `onNotify(const Event& event)` function. Game objects (like enemies or the GameManager) act as *Subjects*, keeping a list of observer pointers. To share data cleanly, they use an `Event` structure, combining an `EventType` (like `PLAYER_DAMAGED`) with simple data (like coordinates or damage numbers).
* **Total Independence:** The core game objects know nothing about SFML graphics or audio. When an enemy dies, it simply shouts out `notify(Event(ENEMY_KILLED, ...))` and goes inactive. It has zero links to `sf::Sound` or `sf::Text`, totally separating game rules from visuals and sound.
* **Spatial Audio & Spam Filtering:** The `SoundManager` listens for these events. However, with 1,000+ enemies, a massive explosion would trigger hundreds of sounds at once, crashing the audio hardware. To fix this, the manager uses a throttle filter—ignoring duplicate sounds within a split-second window. It also reads the `Event` coordinates to adjust 2D spatial audio volume.
* **Zero-Polling UI Updates:** Bad UI designs constantly check the player's health every frame, wasting CPU power. Using the Observer Pattern, the `UIManager` only acts when told to. Health and EXP bars are only recalculated and redrawn when they get a specific state-change alert, saving a lot of processing time.
* **Preventing Crashes (Memory Safety):** A common C++ crash with the Observer Pattern happens when an observer (like a temporary UI screen) gets deleted but stays on the Subject's alert list, causing a Segmentation Fault. This design forces safety: the destructor of every observer (`virtual ~Observer()`) automatically calls `subject->removeObserver(this)`, guaranteeing perfect memory safety.

**Technical Importance:**
This system is the ultimate example of **Loose Coupling** and **Event-Driven Architecture**. By using the **Observer Pattern** with strict audio limiting and memory safety rules, it ensures that massive in-game events can trigger UI and sounds perfectly without risking lag or broken code connections.

# 6. Development Timeline (9-Week Sprint)

To ensure smooth collaboration and strict adherence to the project scope, the development cycle is divided into a **5-Week MVP phase** focusing on essential architecture, followed by a **4-Week Expansion phase** for adding advanced mechanics, polish, and balancing.

## Phase 1: Core Engine & MVP Mechanics (Weeks 1 - 5)
*Goal: Build a fully playable, memory-safe loop featuring movement, combat, and scaling difficulty.*

* **Week 1: Engine Foundation & Spatial Hash Grid**
  * Set up C++/SFML environment, window scaling, and the `GameManager` FSM (Finite State Machine).
  * Build the core **Spatial Hash Grid** and implement $O(1)$ Circle-Circle/AABB collision mathematics.
* **Week 2: Entity Logic & Object Pooling**
  * Create the abstract `Entity`/`EnemyBase` hierarchy and basic 8-directional player movement.
  * Implement the **Bounded Dynamic Object Pool** to handle bulk projectile/enemy spawning without memory fragmentation (`new`/`delete` lag).
* **Week 3: Weapons, Combat & Knockback**
  * Develop the `WeaponBase` abstraction, decoupling weapons (spawners) from projectiles (payloads).
  * Implement mass-based physics and velocity decoupling to process smooth swarm knockback.
* **Week 4: Event-Driven Systems & Progression**
  * Create the `StatsManager` and magnet-based EXP gem collection.
  * Implement the **Observer Pattern** to drive the UI (health/EXP bars) and SFX without polling.
  * Build the Level-Up Pause State and the randomized 3-choice upgrade UI.
* **Week 5: Time-based Spawner & Session Persistence**
  * Code the data-driven Timeline Spawner to seamlessly increase enemy density over time.
  * Implement Mid-Game State Persistence (using C++ File I/O to serialize/deserialize game saves).
  * **Milestone:** A complete, lag-free gameplay loop handling 1,000+ entities with working save functionality.

## Phase 2: Advanced Features, Expansion & Polish (Weeks 6 - 9)
*Goal: Implement rubric stretch goals, polish the gameplay, and rigorously stress-test the engine.*

* **Week 6: Class Framework & Meta-Progression**
  * Develop the 4 polymorphic character classes (`Tank`, `Ranger`, `Mage`, `Gambler`) with unique passives.
  * Implement the cross-session Meta-Progression Store (Account Saving) using a Singleton `ProfileManager`.
* **Week 7: Weapon Evolutions & Boss AI**
  * Build the data-driven Weapon Synergy dictionary and implement polymorphic weapon swapping (Factory Pattern).
  * Code the Multi-phase Boss AI using a hierarchical FSM and separated telegraphed `AttackStrategy` patterns.
* **Week 8: Local Co-Op Integration (Stretch Goal)**
  * Refactor single-player singletons to an array (`std::vector<std::unique_ptr<PlayerBase>>`).
  * Implement dynamic split-swarm pathfinding, shared camera bounds, and dual controller mapping.
* **Week 9: Stress Testing, Balancing & Submission Prep**
  * Extensive frame-rate profiling to guarantee 60 FPS under max load in the Spatial Hash Grid.
  * Gameplay balancing (enemy health scaling, weapon damage tweaking, audio mixing).
  * Code cleanup, memory leak hunting, and final documentation for submission.