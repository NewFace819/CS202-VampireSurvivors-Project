# How to extract and build

**Project:** Vampire Survivors Clone (C++20 / SFML 2.6)
**Group:** 54 — Do Gia Huy (25125013), Vo Thanh Hai (25125011)
**Archive:** `Group54_source.zip` (11.3 MB, single file — no splitting or joining needed)

---

## 1. Extract

**Windows** — right-click `Group54_source.zip` → **Extract All…** → choose a folder.

Or in PowerShell:

```powershell
Expand-Archive -Path Group54_source.zip -DestinationPath C:\VampireSurvivors
```

> **Extract to a short path** such as `C:\VampireSurvivors`, not a deeply nested
> `Downloads` folder. MinGW's linker fails on very long paths and on paths containing
> `--`.

After extracting you should see:

```
CMakeLists.txt
src/
assets/
.gitignore
```

---

## 2. Requirements

| Tool | Version | Notes |
|---|---|---|
| CMake | 3.16 or newer | tested on 4.3 |
| C++ compiler | C++20 | tested with MinGW-w64 GCC 15 (UCRT64) |
| Internet connection | — | **required on the first build only** |

SFML 2.6.1 and nlohmann/json 3.11.2 are **not** included in the archive. CMake downloads
them automatically on the first configure via `FetchContent`, so the first build needs
an internet connection. Later builds work offline.

---

## 3. Build

From the extracted folder:

```bash
cmake -S . -B build
cmake --build build -j 8
```

With MinGW specifically:

```bash
cmake -S . -B build -G "MinGW Makefiles"
cmake --build build -j 8
```

The first build takes roughly **5–10 minutes** because SFML is compiled from source.
Later builds take seconds.

The build defaults to **Release**. For a debug build:

```bash
cmake -S . -B build -DCMAKE_BUILD_TYPE=Debug
```

---

## 4. Run

```bash
cd build
./VampireSurvivorsClone.exe
```

The assets are copied next to the executable automatically as part of the build, so the
game must be run **from inside `build/`** — running it from elsewhere leaves it unable to
find `assets/`.

---

## 5. Controls

| Input | Action |
|---|---|
| `W` `A` `S` `D` | Move (player 1) |
| Arrow keys | Move (player 2, co-op) |
| Mouse | Menus, level-up cards, shop |
| `Esc` | Pause |

Weapons fire automatically; the player only moves.

### Test / demo shortcuts

These exist for testing and for recording the demo video. They are not part of normal
gameplay.

| Keys | Effect |
|---|---|
| `Alt` + `C` | Grant every weapon and passive item at max level |
| `Alt` + `E` | Grant Whip + Hollow Heart (sets up a weapon evolution) |
| `Alt` + `T` | Spawn a treasure chest next to the player |
| `Alt` + `H` | Spawn a wave of enemies (hold to keep spawning) |
| `Alt` + `J` | Spawn ranged enemies next to the player |

---

## 6. If something goes wrong

**`CMake Error ... Compatibility with CMake < 3.5 has been removed`**
The vendored SFML and json declare old minimums. `CMakeLists.txt` already sets
`CMAKE_POLICY_VERSION_MINIMUM` to handle this, so make sure you are configuring the
project's own `CMakeLists.txt` and not a subdirectory.

**`Invalid switch - <folder>` while linking**
Caused by a path containing `--` or by an over-long path. Extract to a short, simple path
such as `C:\VampireSurvivors`.

**FetchContent fails to download**
The first build needs internet access to fetch SFML and nlohmann/json. Check the
connection or any proxy, then re-run `cmake -S . -B build`.

**Game starts but textures or text are missing**
Run it from inside `build/`, where the copied `assets/` folder lives.

---

## 7. What is in the archive

| Path | Contents |
|---|---|
| `src/` | All C++ source, 182 files across `Core`, `Entities`, `States`, `UI` |
| `assets/` | Sprites, tilemaps, fonts and the JSON game data |
| `CMakeLists.txt` | Build configuration, including dependency fetching |

Excluded deliberately: the `build/` output directory, the `.git` history, and unused
asset files — nine unreferenced fonts (including a 22 MB proprietary Microsoft font that
should not be redistributed) and three unreferenced source images. Everything the game
loads at run time is present; this was verified by checking all 128 asset paths in the
source against the archive contents.

**Verified before submission:** the archive was extracted to a clean folder, configured,
built from scratch, and the resulting executable was run successfully.
