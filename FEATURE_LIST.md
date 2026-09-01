# Feature List

**Course:** CS202 - Object-Oriented Programming
**Project:** Vampire Survivors Clone (C++20 / SFML 2.6)
**Group:** 54
**Members:** Do Gia Huy (25125013), Vo Thanh Hai (25125011)
**Repository:** https://github.com/NewFace819/CS202-VampireSurvivors-Project

> One document of the Group 54 submission set -- see [`00_INDEX.md`](00_INDEX.md).

---

## Feature List (40 features × 0.25 pts = 10 pts)


| # | Feature | Implementation Location |
|---|---|---|
| 1 | Main Menu with animated background, start / shop / quit | `MainMenuState` |
| 2 | Character Selection — 40+ characters with portrait, stats, starting weapon | `CharacterSelectState`, `CharacterSelectionView` |
| 3 | Stage Selection — 3 playable stages: Mad Forest, Inlaid Library, and Green Acres (Plant Map) with stage-specific wave configurations | `StageSelectState`, `StageWaveDataManager` |
| 4 | Shop / Meta-progression — 14 permanent power-up ranks bought with gold | `ShopState`, `ProfileManager` |
| 5 | Persistent Save System — gold and power-up ranks saved to `save.txt` | `ProfileManager::save/load` |
| 6 | Infinite tiling world — 3×3 background tile grid repositioning around player | `PlayingState` background loop |
| 7 | Player movement — 8-directional with animated sprite, facing direction tracked | `Player::update` |
| 8 | EXP & Leveling — exp gems from enemies, magnet radius, scaling exp-to-next | `ExpGem`, `Player::addExp` |
| 9 | 16 unique weapons — Whip, Magic Wand, Fire Wand, Axe, Cross, King Bible, Knife, Santa Water, Runetracer, Lightning Ring, Garlic, Song of Mana, Eight the Sparrow, Phiera Der Tuphello, Bone, Cherry Bomb | `Entities/Weapons/` |
| 10 | Weapon evolution system — 11 evolutions triggered at max level + required passive item | `EvolutionRegistry`, `TreasureChestState::determineReward`, `PlayingState::evolveWeaponForPlayer` |
| 11 | 15 passive items, each with a working stat effect — Hollow Heart, Empty Tome, Bracer, Spinach, Candelabrador, Clover, Pummarola, Spellbinder, Attractorb, Armor, Duplicator, Tiragisu, Stone Mask, Skull O'Maniac, Wings | `PassiveItem`, `PlayingState::getPassiveStatBonus` |
| 12 | Level-up UI — pick from 4 random weapon / passive upgrade cards | `LevelUpState` |
| 13 | Burst-fire system — wiki-accurate 0.1 s intervals between burst shots | `WeaponBase::update` burst queue |
| 14 | Wave / spawner system — timed enemy waves loaded from data files | `StageWaveDataManager`, `WaveManager` |
| 15 | Boss enemy — spawns at configured time; tracked for death detection & victory | `PlayingState m_bossPtr` |
| 16 | Shooter enemies — `ShooterEnemy` fires projectiles at the player | `ShooterEnemy` |
| 17 | Enemy Object Pool — 1 000-object pre-allocated pool for enemies | `ObjectPool<EnemyBase>`, `ObjectPool<ShooterEnemy>` |
| 18 | Projectile system — velocity, lifetime, pierce, knockback, trail VFX, sprite animation | `Projectile.h` |
| 19 | Collision detection — AABB via SpatialHashGrid for enemy↔projectile, enemy↔enemy separation and player↔enemy; blocked-cell lookup keeps enemies and pickups out of walls | `Collision.cpp`, `SpatialHashGrid`, `PlayingState::isBlocked` |
| 20 | Data-Driven Map & Obstacle System — `MapLoader` parses multi-layer tilemaps via `sf::VertexArray(sf::Triangles)` with exact polygon mesh vertices, UV coordinates, and physical collision bounds for Mad Forest, Inlaid Library, and Plant Map | `MapLoader`, `Obstacle`, `PlayingState` |
| 21 | Collectible items — Exp Gems, Coins, Floor Chicken, Treasure Chests | `Entities/Pickups/` |
| 22 | Treasure Chest state — dedicated overlay for opening chests and choosing rewards | `TreasureChestState` |
| 23 | Pause state — push-on-stack pause overlay | `PauseState` |
| 24 | HUD — survival timer, gold counter, level indicator, weapon icons | `PlayingState::draw` |
| 25 | Game Over state — death screen with run statistics | `GameOverState` |
| 26 | Summary / End-of-run screen — kills, time, damage per weapon, gold earned | `SummaryState`, `RunSummaryData` |
| 27 | Multi-player support — per-player weapons, passive items, EXP, levelling, health, death and revivals | `m_players`, `m_weaponOwnerIndices`, `m_playerPassiveItems`, `Player` |
| 28 | Banish / Skip / Reroll charges — 10 each per run, consumed in level-up UI | `PlayingState` charge members |
| 29 | Icon Manager — unified icon look-up for all weapons and passives from atlas | `IconManager` |
| 30 | VFX trail system — fading particle trail on projectiles | `Projectile::enableTrail` |
| 31 | Animated sprites — frame-based animation for player and enemies | `AnimatedSprite` |
| 32 | Texture Atlas / Sprite Sheet system — sub-rect sprites from shared atlases | `ResourceManager/TextureAtlas` |
| 33 | Cheat code system — hidden keyboard combos for special in-game effects | `PlayingState m_cheatApplied` |
| 34 | Observer pattern events — decoupled notifications for level-up, damage, exp, death | `Observer.h`, `Subject` |
| 35 | Character unlock / progression — tracks which characters player has unlocked | `PlayerProgressionManager` |
| 36 | Power-up refund — shop allows resetting all upgrades for a full gold refund | `ProfileManager::refundAll` |
| 37 | Stage loading screen — transition state before entering gameplay | `StageLoadingState` |
| 38 | Intro / Title screen states | `States/Intro/`, `States/Title/` |
| 39 | Modular UI system — panels, elements, components, views separated from game logic | `UI/` subsystems |
| 40 | Data-driven design — character profiles, weapon profiles, wave data loaded from files | `Data/` managers |

---
