# Member Contribution

**Course:** CS202 - Object-Oriented Programming
**Project:** Vampire Survivors Clone (C++20 / SFML 2.6)
**Group:** 54
**Members:** Do Gia Huy (25125013), Vo Thanh Hai (25125011)
**Repository:** https://github.com/NewFace819/CS202-VampireSurvivors-Project

> One document of the Group 54 submission set -- see [`00_INDEX.md`](00_INDEX.md).

---

## 1. Summary

| Member | Student ID | Git author | Commits | Contribution | Main areas |
|---|---|---|---|---|---|
| Do Gia Huy | 25125013 | `wii` | 46 | **50%** | Rendering and map pipeline, weapon mechanics and VFX, UI framework, data managers |
| Vo Thanh Hai | 25125011 | `NewFace819` | 54 | **50%** | Gameplay systems, character roster, menus and shop, co-op mode, progression |

**Total:** 100 commits, 9 June to 1 September 2026 (13 weeks).

**On the 50/50 split.** The commit counts are close but measure different kinds of
work, so we did not derive the percentage from them. Developer A's commits cluster in
July (35) and Developer B's in August (30), which reflects a handover from engine and
UI groundwork to gameplay content rather than a difference in effort. A single commit
adding 25 characters is not comparable to a single commit rewriting the tile renderer.
Line counts were considered and rejected outright: one 533,000-line map JSON dominates
them entirely and makes the measure meaningless.

---

## 2. Task division by week

Weeks run Monday to Sunday. Week 1 begins 8 June 2026.
Weeks with no entry had no commits (exam periods and breaks).

### Week 1 (8 - 14 Jun) - Project setup
| Member | Tasks |
|---|---|
| Do Gia Huy | Initial CMake build configuration; imported the base asset set |
| Vo Thanh Hai | Repository creation, `.gitignore` / `.gitattributes`, initial project skeleton |

### Week 4 (29 Jun - 5 Jul) - Core game loop
| Member | Tasks |
|---|---|
| Do Gia Huy | First playable build: Knife and Whip weapons, enemy targeting, player stats, collision damage, game state flow; EXP and levelling system; level-up weapon choice; projectile visual effects; character animation frames |
| Vo Thanh Hai | Wave mode and collision logic; CMake fixes; merge resolution across the asset restructure |

### Week 5 (6 - 12 Jul) - Systems and data
| Member | Tasks |
|---|---|
| Do Gia Huy | `WaveManager` and `EnemyDatabase` with external game-data files; enemy sprite atlas; enemy swarming behaviour and bat animation fixes; LevelUp and CharacterSelect UI design; CMake asset-junction optimisation |
| Vo Thanh Hai | Shop first draft with `ProfileManager` and account saving; weapon synergy mechanic; evolved synergy weapons; `Collectible` superclass with Coin and Floor Chicken; level-up soft-lock fixes |

### Week 6 (13 - 19 Jul) - Second stage and atlases
| Member | Tasks |
|---|---|
| Do Gia Huy | Infinite-tiling Mad Forest background (3x3 wrapping grid); packed character sprites into a single atlas; dynamic frame loading from `characters_atlas.json` |
| Vo Thanh Hai | Stage 2 (Inlaid Library) and `StageSelectState`; `ShooterEnemy` subclass and enemy projectiles; boss treasure chest; Python validators for enemy and UI sprite configuration |

### Week 7 (20 - 26 Jul) - Depth rendering and UI polish
| Member | Tasks |
|---|---|
| Vo Thanh Hai | Interactive library obstacles; 2.5D depth rendering; Circle-AABB sliding collision resolution; authentic Level Up and Treasure Chest presentation |

### Week 8 (27 Jul - 2 Aug) - Weapons, factory, character UI
| Member | Tasks |
|---|---|
| Do Gia Huy | Project layout restructure and core-system refactor; `WeaponFactory`; Cross, Garlic, King Bible, Santa Water, Runetracer, Lightning Ring; projectile bouncing and one-shot animations; `IconManager` atlas parsing; GameOver and Summary states; character-card, detail-panel and roster UI including locked and purchasable states |
| Vo Thanh Hai | PowerUp Shop UI overhaul with synchronised progression data; character selection UI with scaled pricing; 12 playable characters with UI and animations across four rounds; evolved weapon classes and evolution persistence fix |

### Week 9 (3 - 9 Aug) - Roster completion and VFX
| Member | Tasks |
|---|---|
| Do Gia Huy | Projectile VFX system: trails, fade-out and particle emission, applied across the base weapons |
| Vo Thanh Hai | Remaining 25+ playable characters and their starting weapons, completing the full roster; `WeaponFactory` and `IconManager` updates to cover them |

### Week 10 (10 - 16 Aug) - Local co-op
| Member | Tasks |
|---|---|
| Do Gia Huy | Merged the library map hitboxes and stage boundaries with the new co-op system |
| Vo Thanh Hai | Local 2-player co-op: dual controls, dynamic camera, per-player target tracking; separated weapons, EXP and levelling per player |

### Week 12 (24 - 30 Aug) - Third stage, report, co-op correctness
| Member | Tasks |
|---|---|
| Do Gia Huy | Third stage (Green Acres / Plant Map); `MapLoader` rewritten to render tile meshes via `sf::VertexArray`, integrating `library_map`; `CharacterFactory` pattern removing 300+ lines of switch statements from `PlayingState`; first draft of the project report and AI declaration |
| Vo Thanh Hai | Co-op correctness pass: projectile ownership, weapon ownership through evolution, enemy scaling, per-player revival; `CMakeLists.txt` case-collision fix; repository hygiene |

### Week 13 (31 Aug - 1 Sep) - Hardening, performance, submission
| Member | Tasks |
|---|---|
| Vo Thanh Hai | Per-player health, death and revivals; all 15 passive items given working stat effects; performance work (grid-based projectile collision, draw culling, Release build configuration); cross-platform path fixes; 2.5D depth sort correction; solid walls for enemies and pickups; submission documents, demo script and recording |

---

## 3. Responsibilities by subsystem

**Do Gia Huy (25125013)**

| Area | Contribution |
|---|---|
| Rendering and maps | Infinite tile-wrapping background; `MapLoader` vertex-array tile meshes; stage asset layering; Inlaid Library and Plant Map integration |
| Sprites and animation | Character atlas packing; `characters_atlas.json` frame loading; `AnimatedSprite` |
| Weapons | Cross, Garlic, King Bible, Santa Water, Runetracer, Lightning Ring, Bone, Cherry Bomb, Eight The Sparrow, Phiera Der Tuphello, Song Of Mana; `WeaponFactory`; evolved projectile transformations |
| VFX | Trails, fade-out and particles in `Projectile.h`; projectile bouncing |
| Data and UI framework | `IconManager`, `WaveManager`, `EnemyDatabase`; `UI/Panels`, `UI/Components`, `UI/Elements`; character selection UI |
| Game flow | GameOver and Summary states; enemy swarming |
| Architecture | `CharacterFactory` pattern; project layout restructure |

**Vo Thanh Hai (25125011)**

| Area | Contribution |
|---|---|
| Stages and combat | Inlaid Library and `StageSelectState`; `ShooterEnemy` and enemy projectiles; library obstacles; 2.5D depth rendering; Circle-AABB sliding collision |
| Character roster | 40+ playable characters with UI, animations and starting weapons |
| Progression | EXP and levelling; synergy and evolution; `ProfileManager` save/load; PowerUp Shop; `Collectible` hierarchy |
| Level-up system | Wiki-accurate weighted draw; reroll, skip and banish charges; treasure chest flow |
| Co-op mode | Dual controls, dynamic camera, target tracking; per-player weapons, EXP, levelling, passives, health, death and revivals |
| Performance | Grid-based projectile collision, draw culling, object-pool sizing, Release build |
| Hardening | Cross-platform path fixes, solid wall collision, passive item stat effects |

---

## 4. Shared work

Both members contributed to `PlayingState`, the project's central class (57 and 31 file
touches respectively), and both worked in `Entities/Weapons` (50 and 29). The report,
class diagrams and design-pattern analysis were produced jointly with AI assistance --
see [`AI_Usage_Declaration.md`](AI_Usage_Declaration.md).

---

## 5. Evidence

Every claim above is traceable to the repository:

```bash
git log --all --date=short --pretty="%ad|%an|%s"        # full history
git shortlog -sne --all                                  # commits per author
git log --author="wii" --name-only --pretty=format:      # files touched
```

Weekly reports for weeks 6 to 9 (`Group54_06` to `Group54_09`) record the same division
in the team's own words at the time.
