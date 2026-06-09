# Week 1: Short-Term Development Plan
**Goal:** Establish the core C++/SFML framework, initialize the FSM (State Machine), and build the highly optimized Spatial Hash Grid for collision detection.

### **Day 1: Project Setup & SFML Integration**
* **Tasks:**
  * Configure the build environment (CMakeLists.txt or Visual Studio project).
  * Link SFML libraries (Graphics, Window, System, Audio).
  * Build the core `Application` or `Engine` class that handles the main game loop (`while (window.isOpen())`) and delta-time (`dt`) calculation.
* **Deliverable:** A compiling project that opens a resizable window and renders a basic background (e.g., a solid color or simple grid).

### **Day 2: Game State Machine (FSM)**
* **Tasks:**
  * Create the abstract `GameState` interface with pure virtual functions: `enter()`, `update(dt)`, `draw(window)`, and `exit()`.
  * Implement the state controller using `std::stack<std::unique_ptr<GameState>>` to allow states to pause and resume (e.g., pausing gameplay without deleting it).
  * Build primitive states: `MainMenuState`, `PlayingState`, and `PauseState`.
* **Deliverable:** The ability to navigate between the Main Menu, Gameplay, and Pause screens using keyboard inputs seamlessly.

### **Day 3: Spatial Hash Grid Construction**
* **Tasks:**
  * Define the `SpatialHashGrid` class and set the `CELL_SIZE` constant.
  * Structure the contiguous memory bucket system (e.g., a flattened 1D `std::vector` simulating a 2D map) to ensure cache-friendliness.
  * Write the core registration functions: `insertEntity(Entity*)`, `removeEntity(Entity*)`, and `updateEntityCell(Entity*)`.
* **Deliverable:** A fully functional background grid that can accept coordinates and assign them to specific memory buckets in $O(1)$ time.

### **Day 4: Core Math & Collision Logic**
* **Tasks:**
  * Implement the Circle-Circle collision math using squared distance ($\Delta x^2 + \Delta y^2 \leq (R_1 + R_2)^2$) to avoid expensive square root calculations.
  * Implement AABB (Axis-Aligned Bounding Box) algorithms for static terrain and map boundaries.
  * Write the `getNeighbors(x, y)` grid function to retrieve only the entities in the current and 8 adjacent cells.
* **Deliverable:** An optimized collision utility class capable of processing physical intersections without nested $O(n^2)$ loops.

### **Day 5: Integration & Stress Testing**
* **Tasks:**
  * Create a lightweight, dummy `Entity` class (rendering a simple `sf::CircleShape`).
  * Populate the `PlayingState` with 2,000+ dummy entities that register themselves into the Spatial Hash Grid.
  * Run a visual collision test: Have the entities query their grid neighbors and turn red if they are colliding.
* **Deliverable:** A successful stress test proving the engine can render and check collisions for thousands of entities at a stable 60 FPS.
