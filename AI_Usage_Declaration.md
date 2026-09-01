# AI Usage Declaration

**Course:** CS202 — Object-Oriented Programming
**Project:** Vampire Survivors Clone (C++ / SFML)
**Group:** 54
**Members:** Do Gia Huy (25125013), Vo Thanh Hai (25125011)
**Repository:** https://github.com/NewFace819/CS202-VampireSurvivors-Project
**Declaration date:** 1 September 2026

---

> Both members should review the statements below and confirm they match their own
> recollection of how they worked. Items marked *"unverified"* are inferences from the
> commit history, not confirmed records — each member should correct any entry covering
> their own commits.

---

## 1. Summary statement

This project was developed with substantial assistance from AI coding tools. **Both
members used AI for their own parts of the work**, throughout the project, for
implementation, refactoring, debugging and documentation. The team designed the project, chose its architecture and scope,
authored or sourced all game assets, and reviewed, tested and accepted every change.

We declare the usage below to the best of our knowledge.

---

## 2. Tools used

| Tool | Period | Used by | Purpose |
|---|---|---|---|
| Antigravity IDE (Gemini) | 29 Jun – 30 Aug 2026 | **Both members** | Implementation, refactoring, debugging |
| Claude Code (Claude Opus) | 30 Aug – 1 Sep 2026 | Vo Thanh Hai | Bug fixing, performance work, code review |

Both members used Gemini through the Antigravity IDE for their own work throughout the
project. The saved conversation logs under `C:\Users\wiih0\` are Do Gia Huy's;
Vo Thanh Hai's Gemini sessions are not separately archived, and his use is declared here
on his own statement rather than from a log file.

---

## 3. How AI was used

Both members worked with AI the same way, and it is worth describing because it affects
what "AI-assisted" means in the tables below.

The work was **conversational and directed, not generative from a prompt**. A typical
exchange ran:

1. The member describes a problem in their own words — often a symptom rather than a
   diagnosis: *"the gems disappear when I move up"*, *"why don't I see the shooter
   enemies"*, *"the recording is just a white screen"*.
2. The AI investigates the actual source, reports what it found, and proposes an
   approach — sometimes several, with trade-offs.
3. The member decides: picks an option, redirects, or rejects the premise. Design
   questions were always resolved by the member, not the AI.
4. The AI implements and compiles.
5. The member builds, plays the game, and reports back what is still wrong.

Steps 2 to 5 frequently repeated. Several changes took multiple rounds before they were
accepted — enemy-wall collision was fixed twice, the first attempt having been observed
failing in-game, and the recording window mode went through five configurations before a
capture worked. Work that failed testing was not committed.

The members therefore understand the submitted code, chose its design, and are
responsible for it. AI shortened the writing, not the deciding.

---

## 4. Evidence sources

This declaration is derived from three verifiable sources:

1. **Git commit log** — 100 commits, 2 contributors, 9 June to 1 September 2026
   (`git log --all --date=short --pretty="%ad|%h|%an|%s"`)
2. **Antigravity IDE conversation logs** — `C:\Users\wiih0\.gemini\antigravity-ide\brain\`
   (individual sessions are cited below by their conversation ID, e.g. `2e07d3fa`)
3. **Claude Code session transcript** — 30 August to 1 September 2026

Where a commit could not be traced to a session log, it is marked **unverified** rather
than asserted either way.

---

## 5. Timeline

```
Jun 9              Project created — no AI
Jun 29             AI session: game bootstrap (menu, state flow, playing loop)
Jul 4              EXP/levelling, level-up choices, projectile effects
Jul 8–11            Synergy/evolution, collectibles, save/load  (Hai)   [confirmed]
Jul 12–17          WaveManager, EnemyDatabase, Inlaid Library stage    [unverified]
Jul 25             AI session: asset restructure, character frames
Jul 27             AI session: WeaponFactory, class refactor
Jul 28             .agents/AGENTS.md added — AI agent mode configured
Jul 29 – Aug 6     40+ character implementations   (Hai)               [confirmed]
Aug 11             Local co-op mode                (Hai)               [confirmed]
Aug 13             Co-op library map merge         (Huy)               [unverified]
Aug 29–30          Report, PlantMap, MapLoader     (Huy)               [AI-assisted]
Aug 30 – Sep 1     Claude Code session, 15 commits  (Hai)               [AI-assisted]
```

---

## 6. Phase 1 — Antigravity IDE (29 Jun – 30 Aug)

### Confirmed sessions

**Jun 29 — Game bootstrap.** *(Antigravity session `2e07d3fa`)* The repository was
essentially empty. AI implemented the main menu, game state flow and initial playing
loop from a structured plan file (`agent.md`, `Plan/`), and debugged a black screen,
missing assets, a broken main menu and a weapon that failed to appear. It also helped
write an initial draft of the project report.

**Jul 25 — Asset restructure.** *(Antigravity session `d7b1bc22`)* Integrated and
reorganised character sprite assets; renamed asset folders and restructured the character
atlas; debugged font loading and save-file path resolution.

**Jul 27 — WeaponFactory and refactor.** *(Antigravity session `25c6781c`)* Suggested
and created `WeaponFactory` and the `AllWeapons.h` aggregation header; refactored the
class structure to reduce include boilerplate; verified the factory pattern was applied
correctly.

**Aug 29–30 — Report and stages.** *(Antigravity session `143e8bc6`)* Read all
source files and wrote the project report: architecture overview, 6 class diagrams, 8
design patterns and the 40-feature list. Added the PlantMap stage (`PlantMap` enum,
loading block, wave config JSON, third stage-select panel). Found and removed a duplicate
level-indicator block in `PlayingState::draw()`. Rewrote `MapLoader` tile rendering using
`sf::VertexArray` and integrated `library_map`. Created `CharacterFactory`, removing 300+
lines of switch statements from `PlayingState`. Added the report's TODO checklist and the
member, video and declaration stub sections.

### Commits attributed to AI assistance

| Commit | Date | Author | Change | Basis |
|---|---|---|---|---|
| `6f30710d` | Jul 28 | Huy | Remove puddle fallback, duplicate loop check | Commit message names AI mode |
| `5ad7f225` | Jul 28 | Huy | Simplify weapon targeting and projectile logic | unverified |
| `82294864` | Jul 28 | Huy | IconManager, HUD icon fix | unverified |
| `a5a484de` | Jul 28 | Huy | Cross weapon, WeaponFactory | unverified |
| `1367589d` | Jul 28 | Huy | KingBible, SantaWater, Runetracer, bouncing | unverified |
| `4b8e5b3a` | Jul 28 | Hai | Shop UI overhaul | **confirmed by member** (Gemini) |
| `feat(characters)` ×10 | Jul 29 – Aug 6 | Hai | 40+ character implementations | **confirmed by member** (Gemini) |
| `4b078055` | Aug 6 | Huy | VFX trails, particles | unverified |
| `f1628b5e` | Aug 1 | Hai | Weapon evolution fix, evolved weapon classes | **confirmed by member** (Gemini) |
| `a193cedd` | Aug 11 | Hai | Local 2-player co-op mode | **confirmed by member** (Gemini) |
| `987f00ed` | Aug 11 | Hai | Co-op weapons, EXP, levelling separation | **confirmed by member** (Gemini) |
| `07c724f3` | Aug 13 | Huy | Co-op library map hitbox merge | unverified |
| `ce6d7afc` | Aug 29 | Huy | PlantMap stage, HUD fix, report | AI-assisted |
| `ca7301e8` | Aug 30 | Huy | MapLoader VertexArray, library_map | AI-assisted |
| `c315bd98` | Aug 30 | Huy | CharacterFactory pattern | AI-assisted |

**Reading the Basis column.** *Confirmed by member* means the author has stated they used
Gemini on that work. *AI-assisted* means it is corroborated by a saved Antigravity session
log. *Unverified* means neither: the commit predates the logs we still hold, or could not
be tied to a specific session. Unverified is not a claim that no AI was involved — it
records that we cannot evidence it either way, and we preferred saying so to guessing.

---

## 7. Phase 2 — Claude Code session (30 Aug – 1 Sep)

A single session covering 15 commits, run by Vo Thanh Hai. All were AI-authored and
human-directed, following the pattern described in section 3: the member reported
symptoms, chose which problems to pursue, decided the design questions, play-tested each
change and approved every commit.

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

## 8. What was **not** AI-generated

- All game assets — sprites, tilemaps, audio, data JSONs
- Original weapon damage, cooldown and area balance values
- Project scope, architecture and design-pattern selection
- The original `SpatialHashGrid`, `Collision.cpp` and `Physics.h` algorithms
  *(note: `SpatialHashGrid` and `Physics.h` were later modified by AI on 31 Aug —
  see `49742ea1`)*
- The original CMake configuration
  *(note: later modified by AI on 31 Aug — see `49742ea1`)*

---
