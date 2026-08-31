# AI Usage Declaration

**Course:** CS202 — Object-Oriented Programming
**Project:** Vampire Survivors Clone (C++ / SFML)
**Group:** 54
**Members:** Do Gia Huy (25125013), Vo Thanh Hai (25125011)
**Repository:** https://github.com/NewFace819/CS202-VampireSurvivors-Project
**Declaration date:** 31 August 2026

---

> **DRAFT — requires signature before submission.**
> Members must review the statements below, confirm they match their own recollection
> of how they worked, and sign at the end. Items marked *"unverified"* are inferences
> from commit history, not confirmed records — each member should correct the entries
> covering their own commits.

---

## 1. Summary statement

This project was developed with substantial assistance from AI coding tools. AI was used
for implementation, refactoring, debugging, and documentation across most of the
development period. The team designed the project, chose its architecture and scope,
authored or sourced all game assets, and reviewed, tested and accepted every change.

We declare the usage below to the best of our knowledge.

---

## 2. Tools used

| Tool | Period | Used by | Purpose |
|---|---|---|---|
| Antigravity IDE (Gemini) | 29 Jun – 30 Aug 2026 | Do Gia Huy (logs on that machine) | Implementation, refactoring, debugging |
| Claude Code (Claude Opus) | 30 – 31 Aug 2026 | Vo Thanh Hai | Bug fixing, performance work, code review |

> Both members should confirm this attribution. The Antigravity logs are stored under
> `C:\Users\wiih0\`, which indicates Do Gia Huy's machine, but sessions may have
> been run jointly.

---

## 3. Evidence sources

This declaration is derived from three verifiable sources:

1. **Git commit log** — 100 commits, 2 contributors, 9 June to 31 August 2026
   (`git log --all --date=short --pretty="%ad|%h|%an|%s"`)
2. **Antigravity IDE conversation logs** — `C:\Users\wiih0\.gemini\antigravity-ide\brain\`
3. **Claude Code session transcript** — 30–31 August 2026

Where a commit could not be traced to a session log, it is marked **unverified** rather
than asserted either way.

---

## 4. Timeline

```
Jun 9              Project created — no AI
Jun 29             AI session: game bootstrap (menu, state flow, playing loop)
Jul 4              EXP/levelling, level-up choices, projectile effects
Jul 8–11           Synergy/evolution, collectibles, save/load          [unverified]
Jul 12–17          WaveManager, EnemyDatabase, Inlaid Library stage    [unverified]
Jul 25             AI session: asset restructure, character frames
Jul 27             AI session: WeaponFactory, class refactor
Jul 28             .agents/AGENTS.md added — AI agent mode configured
Jul 29 – Aug 13    40+ character implementations                       [unverified]
Aug 27–29          Co-op mode, initial report                          [AI-assisted]
Aug 29–30          Report, PlantMap stage, MapLoader VertexArray       [AI-assisted]
Aug 30–31          Claude Code session — 15 commits                    [AI-assisted]
```

---

## 5. Phase 1 — Antigravity IDE (29 Jun – 30 Aug)

### Confirmed sessions

**Jun 29 — Game bootstrap.** The repository was essentially empty. AI implemented the
main menu, game state flow and initial playing loop from a written plan (`Plan/`),
and debugged a black screen, missing assets and a non-appearing weapon.

**Jul 25 — Asset restructure.** Reorganised character sprite assets and atlas structure;
debugged font loading and save-file path resolution.

**Jul 27 — WeaponFactory and refactor.** Proposed and implemented `WeaponFactory` and
`AllWeapons.h`; refactored class structure to reduce include boilerplate.

**Aug 29–30 — Report and stages.** Wrote the project report (architecture overview, class
diagrams, design-pattern analysis, feature list); added the PlantMap stage; rewrote
`MapLoader` tile rendering using `sf::VertexArray`; created `CharacterFactory`, removing
300+ lines of switch statements from `PlayingState`.

### Commits attributed to AI assistance

| Commit | Date | Change | Basis |
|---|---|---|---|
| `6f30710d` | Jul 28 | Remove puddle fallback, duplicate loop check | Commit message names AI mode |
| `5ad7f225` | Jul 28 | Simplify weapon targeting and projectile logic | unverified |
| `82294864` | Jul 28 | IconManager, HUD icon fix | unverified |
| `a5a484de` | Jul 28 | Cross weapon, WeaponFactory | unverified |
| `1367589d` | Jul 28 | KingBible, SantaWater, Runetracer, bouncing | unverified |
| `4b8e5b3a` | Jul 28 | Shop UI overhaul | unverified |
| `feat(characters)` ×10 | Jul 29 – Aug 13 | 40+ character implementations | unverified |
| `4b078055` | Aug 6 | VFX trails, particles | unverified |
| `f1628b5e` | Aug 1 | Weapon evolution fix, evolved weapon classes | unverified |
| `a193cedd` | Aug 11 | Local 2-player co-op mode | unverified |
| `987f00ed` | Aug 11 | Co-op weapons, EXP, levelling separation | unverified |
| `07c724f3` | Aug 13 | Co-op library map hitbox merge | unverified |
| `ce6d7afc` | Aug 29 | PlantMap stage, HUD fix, report | AI-assisted |
| `ca7301e8` | Aug 30 | MapLoader VertexArray, library_map | AI-assisted |
| `c315bd98` | Aug 30 | CharacterFactory pattern | AI-assisted |

---

## 6. Phase 2 — Claude Code session (30–31 Aug)

A single session covering 15 commits. All were AI-authored, human-directed: the member
reported symptoms, chose which problems to pursue, decided design questions, play-tested
each change and approved every commit.

| Commit | Change |
|---|---|
| `84fe747e` | Anchor aura/orbiting projectiles to their owning player, not the camera |
| `625240aa` | Preserve weapon→player ownership through evolution |
| `ffe05de6` | Scale enemies off real player level; remove dead global level path |
| `02c6d880` | Clear enemies around each player on revival |
| `a8c425d6` | Resolve `CMakeLists.txt` / `CmakeLists.txt` case collision |
| `da9a45de` | Ignore weekly report outputs, run scripts, save files |
| `daef8945` | Make passive items per-player and actually affect stats |
| `30c1ae56` | Wire remaining passive item stat effects |
| `ab94e74d` | Per-player health, death and revivals for co-op |
| `63eae2b2` | Wire Clover, Stone Mask, Skull O'Maniac |
| `49742ea1` | Grid-based projectile collision, draw culling, Release build |
| `a810cc1e` | Correct `assets/Data` casing to match `assets/data` |
| `0c1f883b` | Resolve co-op card sprite by `textureName`, not JSON key |
| `885da875` | Sort 2.5D depth by object Y instead of the camera |
| `ec342846` | Make walls solid for enemies and pickups |

### Design decisions made by the member, not the AI

- Co-op death model: players own their health individually; the run ends only when all
  players are down
- Skull O'Maniac resolves as the highest curse among players, never the sum
- Passive items were to be made functional rather than removed from the feature list
- Enemy pool size raised to 10,000 for demo recording

### Human verification

Every change in this phase was compiled and play-tested by the member before being
committed. Several were rejected or revised after testing — the enemy-wall collision was
committed only after a first attempt was observed failing in-game and corrected.

---

## 7. What was **not** AI-generated

- All game assets — sprites, tilemaps, audio, data JSONs
- Original weapon damage, cooldown and area balance values
- Project scope, architecture and design-pattern selection
- The original `SpatialHashGrid`, `Collision.cpp` and `Physics.h` algorithms
  *(note: `SpatialHashGrid` and `Physics.h` were later modified by AI on 31 Aug —
  see `49742ea1`)*
- The original CMake configuration
  *(note: later modified by AI on 31 Aug — see `49742ea1`)*

---

## 8. Academic integrity statement

We confirm that:

- The declaration above is accurate to the best of our knowledge.
- We understand the code we submitted and can explain any part of it on request.
- AI output was reviewed, tested and accepted by us; we take responsibility for it.
- No part of this submission was copied from another student or group.

---

## 9. Signatures

| Member | Student ID | Tools used | Signature | Date |
|---|---|---|---|---|
| Do Gia Huy | 25125013 | Antigravity IDE (Gemini) | | |
| Vo Thanh Hai | 25125011 | Antigravity IDE (Gemini), Claude Code | | |
