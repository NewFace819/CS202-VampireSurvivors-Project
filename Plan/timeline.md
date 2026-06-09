# Development Timeline (9-Week Sprint)

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
