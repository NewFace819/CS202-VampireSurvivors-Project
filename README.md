# Vampire Survivors Clone (CS202 Project)

This is a 2D top-down rogue-lite survival game built from scratch using **C++20** and the **SFML** graphics library.

## How to Run the Project (Windows)

Because this project uses modern CMake (`FetchContent`), **you do NOT need to manually install or link the SFML library!** CMake will automatically download the correct version of SFML from GitHub and link it statically to the executable when you build the project.

### Method 1: Using Visual Studio 2022 (Recommended)
This is the easiest method.
1. Make sure you have Visual Studio installed with the **"Desktop development with C++"** workload.
2. Open Visual Studio and click **"Open a local folder"**.
3. Select this repository folder (`CS202-VampireSurvivors-Project`).
4. Wait a few moments for the "Output" window to say `CMake generation finished`. (It is downloading SFML in the background during this step).
5. At the top toolbar, ensure the Startup Item dropdown is set to `VampireSurvivorsClone.exe`.
6. Click the Green **Play** button to compile and run the game!

### Method 2: Using the Command Line (Terminal / PowerShell)
If you prefer the command line, you must have **CMake** and a C++ compiler (like MinGW or MSVC) installed and added to your system PATH.

1. Open your terminal and navigate to the project folder.
2. Generate the build files:
   ```powershell
   cmake -S . -B build
   ```
3. Compile the code:
   ```powershell
   cmake --build build --config Release
   ```
4. Run the executable:
   ```powershell
   .\build\Release\VampireSurvivorsClone.exe
   ```
   *(Note: If using MinGW, the executable might be located at `.\build\VampireSurvivorsClone.exe`)*

## Project Architecture
This project strictly adheres to OOP principles and utilizes advanced system architecture:
- **Finite State Machine (FSM):** The game flow is managed via a deferred stack-based state controller to ensure memory safety during transitions.
- **Spatial Hash Grid:** Handles collisions for 1000+ entities efficiently in $O(1)$ lookup time, replacing slow $O(n^2)$ physics checks.
- **Cache-Friendly Memory:** Core structures utilize contiguous `std::vector` arrays to maximize CPU cache hits during update loops.
