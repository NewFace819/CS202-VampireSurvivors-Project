# Member Contribution

**Course:** CS202 - Object-Oriented Programming
**Project:** Vampire Survivors Clone (C++20 / SFML 2.6)
**Group:** 54
**Members:** Do Gia Huy (25125013), Vo Thanh Hai (25125011)
**Repository:** https://github.com/NewFace819/CS202-VampireSurvivors-Project

> One document of the Group 54 submission set -- see [`00_INDEX.md`](00_INDEX.md).

---

## Member Contribution


See the evaluation form: [https://tinyurl.com/httprojeval](https://tinyurl.com/httprojeval)

> [!IMPORTANT]
> **DRAFT.** The split below is derived from the git history and the weekly reports
> (weeks 06-09). Both members must confirm the percentages before submission -- commit
> counts measure activity, not effort, and neither member should accept a number they
> disagree with.

| Member | Student ID | Git author | Commits | Contribution (%) | Main responsibilities |
|---|---|---|---|---|---|
| Do Gia Huy | 25125013 | `wii` | 46 | **50%** | Rendering and map pipeline, weapon mechanics and VFX, UI framework, data managers |
| Vo Thanh Hai | 25125011 | `NewFace819` | 54 | **50%** | Gameplay systems, character roster, menus and shop, co-op mode, evolution and progression |

**Why 50/50 rather than 54/46.** Commit counts are close but measure different work:
Developer A's commits cluster in July (35) and Developer B's in August (30), reflecting a
handover from engine and UI groundwork to gameplay content, not a difference in effort. A
single commit adding 25 characters is not comparable to a single commit rewriting the tile
renderer. The members should adjust this if their own view differs.

### Division of work

**Do Gia Huy (25125013) -- Developer A**

| Area | Contribution |
|---|---|
| Rendering and maps | Infinite 3x3 tile-wrapping background and grid math; dynamic stage asset layering; `MapLoader` rewritten to render tile meshes via `sf::VertexArray(sf::Triangles)`; Inlaid Library map integration |
| Sprites and animation | Character sprite packing into `characters.png`; `characters_atlas.json` frame loading; `AnimatedSprite` frame system |
| Weapons | Garlic, Cross, King Bible, Santa Water, Runetracer, Lightning Ring; Bone, Cherry Bomb, Eight The Sparrow, Phiera Der Tuphello, Song Of Mana; `WeaponFactory`; evolved weapon projectile transformations |
| VFX | Projectile trail, fade-out and particle system in `Projectile.h`; projectile bouncing and one-shot animations |
| Data and UI framework | `IconManager` atlas parsing; `WaveManager`, `EnemyDatabase`; `UI/Panels`, `UI/Components`, `UI/Elements`; character selection UI, locked-character states |
| Game flow | GameOver and Summary states; enemy swarming and bat animation fixes |

**Vo Thanh Hai (25125011) -- Developer B**

| Area | Contribution |
|---|---|
| Stages and combat | Stage 2 (Inlaid Library) and `StageSelectState`; `ShooterEnemy` subclass and enemy projectiles; interactive library obstacles; 2.5D depth rendering; Circle-AABB sliding collision resolution |
| Character roster | 40+ playable characters with UI, animations and starting weapons across four implementation rounds; atlas frame-key handling for non-standard names |
| Progression | EXP and levelling; synergy and evolution mechanics; `ProfileManager` save/load; PowerUp Shop UI; `Collectible` hierarchy with Coin and FloorChicken |
| Level-up system | Authentic level-up overhaul with wiki-accurate weighted probability draw; reroll, skip and banish charges; treasure chest opening flow |
| Co-op mode | Local 2-player mode with dual controls, dynamic camera and target tracking; separated weapons, EXP and levelling per player |
| Final hardening | Co-op correctness fixes, per-player health and passives, performance work, cross-platform path fixes (weeks 12-13) |

### Shared work

Both members contributed to `PlayingState`, the project's central class (57 and 31 file
touches respectively), and both worked on `Entities/Weapons` (29 and 50). The report,
class diagrams and design-pattern analysis were produced jointly with AI assistance --
see [`AI_Usage_Declaration.md`](AI_Usage_Declaration.md).

---
