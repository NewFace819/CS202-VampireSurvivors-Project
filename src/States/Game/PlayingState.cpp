#include "PlayingState.h"
#include "States/Game/PauseState.h"
#include "States/Game/LevelUpState.h"
#include "States/Game/TreasureChestState.h"
#include "States/Game/GameOverState.h"
#include "States/Menu/MainMenuState.h"
#include "Core/GameManager.h"
#include "Core/Data/StatsManager.h"
#include "Entities/Weapons/WeaponFactory.h"
#include "Entities/CharacterFactory.h"
#include "Entities/Pickups/ExpGem.h"
#include "Entities/Pickups/Coin.h"
#include "Entities/Pickups/FloorChicken.h"
#include <nlohmann/json.hpp>
#include <fstream>
#include "Core/Physics/Collision.h"
#include "Core/Physics/Physics.h"
#include "Entities/Weapons/EvolutionRegistry.h"
#include "Core/Data/MapLoader.h"
#include <cstdlib>
#include <algorithm>
#include <iostream>
#include <set>

#include "Core/Data/ProfileManager.h"
#include "Core/Data/IconManager.h"

PlayingState::PlayingState(GameManager* manager, CharacterType charType, StageType stageType) 
    : PlayingState(manager, std::vector<CharacterType>{charType}, stageType) {}

PlayingState::PlayingState(GameManager* manager, const std::vector<CharacterType>& charTypes, StageType stageType) 
    : m_manager(manager), m_grid(50.0f), m_enemyPool(10000), m_shooterPool(2000), m_stageType(stageType) { 
    StatsManager::GetInstance().reset();
    IconManager::GetInstance().init();

    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "PlayingState: Could not load font!\n";
    }
    
    if (!m_itemsTex.loadFromFile("assets/Graphics/Spritesheets/items.png")) {
        std::cerr << "PlayingState: Could not load items texture!\n";
    }
    m_enemiesTex.loadFromFile("assets/images/enemies/vs_enemies.png");
    m_enemiesTex.setSmooth(false);
    m_vfxTex.loadFromFile("assets/Graphics/Spritesheets/vfx.png");

    std::string waveJsonPath = "assets/data/mad_forest.json";
    std::string bgPath = "assets/images/maps/forest_tiles.png";

    if (m_stageType == StageType::MadForest) {
        MapData mapData = MapLoader::LoadMap("assets/data/maps/forest_map.json", m_libraryPropsTex);
        if (mapData.success) {
            // Extract the rendered tilemap to our background texture
            m_bgTex.loadFromImage(mapData.backgroundTexture->getTexture().copyToImage());
            m_bgTex.setSmooth(false);
            
            // Steal the obstacles into the base template list
            for (auto& obs : mapData.obstacles) {
                m_baseObstacles.push_back(std::move(obs));
            }
        } else {
            // Fallback
            if (!m_bgTex.loadFromFile(bgPath)) {
                std::cerr << "PlayingState: Could not load background texture: " << bgPath << "\n";
            }
        }
    } else if (m_stageType == StageType::InlaidLibrary) {
        waveJsonPath = "assets/data/inlaid_library.json";
        MapData mapData = MapLoader::LoadMap("assets/data/maps/library_map.json", m_libraryPropsTex);
        if (mapData.success) {
            m_bgTex.loadFromImage(mapData.backgroundTexture->getTexture().copyToImage());
            m_bgTex.setSmooth(false);
            for (auto& obs : mapData.obstacles) {
                m_baseObstacles.push_back(std::move(obs));
            }
        } else {
            bgPath = "assets/images/maps/LibraryTexturePacked.png";
            if (!m_libraryPropsTex.loadFromFile(bgPath)) {
                std::cerr << "PlayingState: Could not load LibraryTexturePacked.png!\n";
            }
            generateLibraryObstacles();
            if (!m_bgTex.loadFromFile(bgPath)) {
                std::cerr << "PlayingState: Could not load background texture: " << bgPath << "\n";
            }
        }
    } else if (m_stageType == StageType::PlantMap) {
        waveJsonPath = "assets/data/plant_map.json";
        MapData mapData = MapLoader::LoadMap("assets/data/maps/plant_map.json", m_plantPropsTex);
        if (mapData.success) {
            m_bgTex.loadFromImage(mapData.backgroundTexture->getTexture().copyToImage());
            m_bgTex.setSmooth(false);
            for (auto& obs : mapData.obstacles) {
                m_baseObstacles.push_back(std::move(obs));
            }
        } else {
            if (!m_bgTex.loadFromFile("assets/images/maps/PlantTexturePacked.png")) {
                std::cerr << "PlayingState: Could not load PlantTexturePacked.png!\n";
            }
        }
    }


    m_bgTex.setRepeated(false);
    m_tileSize = 2048.f;
    
    float scaleX = m_tileSize / static_cast<float>(m_bgTex.getSize().x);
    float scaleY = m_tileSize / static_cast<float>(m_bgTex.getSize().y);

    // Initialize 3x3 grid of tiles: center tile (1,1) sits at world origin
    for (int row = 0; row < 3; ++row) {
        for (int col = 0; col < 3; ++col) {
            m_bgTiles[row][col].setTexture(m_bgTex);
            m_bgTiles[row][col].setScale(scaleX, scaleY);
            m_bgTiles[row][col].setPosition(
                (col - 1) * m_tileSize,
                (row - 1) * m_tileSize
            );
        }
    }

    if (!m_waveManager.loadWavesFromJson(waveJsonPath)) {
        std::cerr << "PlayingState: Failed to load waves: " << waveJsonPath << "\n";
    }

    m_timerText.setFont(m_font);
    m_timerText.setCharacterSize(40);
    m_timerText.setFillColor(sf::Color::White);
    m_timerText.setStyle(sf::Text::Bold);
    m_timerText.setPosition(m_manager->getWindow().getSize().x / 2.0f - 50.0f, 20.0f);

    m_goldText.setFont(m_font);
    m_goldText.setCharacterSize(22);
    m_goldText.setFillColor(sf::Color(228, 199, 109)); // Gold
    m_goldText.setStyle(sf::Text::Bold);
    m_goldText.setPosition(m_manager->getWindow().getSize().x - 220.0f, 25.0f);

    m_runGold = 0;

    size_t count = charTypes.empty() ? 1 : charTypes.size();
    m_players.resize(count);

    // Initialize one passive item pool per player
    m_playerPassiveItems.assign(count, createDefaultPassiveItems());
    for (auto& list : m_playerPassiveItems) {
        for (auto& p : list) {
            p.iconRect = IconManager::GetInstance().getIconRect(p.name);
        }
    }

    // Each player gets their own health pool and revival charges.
    float baseMaxHp = 100.f * ProfileManager::GetInstance().getMaxHealthMultiplier();
    int baseRevivals = ProfileManager::GetInstance().getRevivalBonus();
    for (size_t i = 0; i < count; ++i) {
        m_players[i].initHealth(baseMaxHp, baseRevivals);
    }

    for (size_t i = 0; i < count; ++i) {
        CharacterType cType = charTypes.empty() ? CharacterType::Antonio : charTypes[i];
        Player& p = m_players[i];
        p.setPlayerId(static_cast<int>(i + 1));

        // Initial positions
        float startX = 1280.f / 2.f;
        float startY = 720.f / 2.f;
        if (m_stageType == StageType::InlaidLibrary) {
            startX = 640.f;
            startY = 1024.f;
        }
        if (count > 1) {
            startX += (i == 0 ? -50.f : 50.f);
        }
        p.setPosition(startX, startY);

        std::vector<std::string> startingWeapons;
        CharacterFactory::configurePlayer(p, cType, startingWeapons);
        for (const auto& wName : startingWeapons) {
            addWeaponForPlayer(i, wName);
        }
    }
}

void PlayingState::enter() {
}

void PlayingState::update(float dt) {
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Escape)) {
        m_manager->changeState(std::make_unique<MainMenuState>(m_manager));
        return; 
    }

    // Camera Center (midpoint of active players)
    sf::Vector2f cam(0.f, 0.f);
    int activeCount = 0;
    for (auto& p : m_players) {
        if (p.isActive()) {
            cam += p.getPosition();
            activeCount++;
        }
    }
    if (activeCount > 0) {
        cam /= static_cast<float>(activeCount);
    } else {
        cam = sf::Vector2f(640.f, 360.f);
    }

    // Update infinite background tiles: snap any tile that drifts too far from camera
    {
        for (int row = 0; row < 3; ++row) {
            for (int col = 0; col < 3; ++col) {
                sf::Vector2f tpos = m_bgTiles[row][col].getPosition();
                float dx = cam.x - (tpos.x + m_tileSize * 0.5f);
                float dy = cam.y - (tpos.y + m_tileSize * 0.5f);
                if (dx >  m_tileSize * 1.5f) m_bgTiles[row][col].move( m_tileSize * 3.f, 0.f);
                if (dx < -m_tileSize * 1.5f) m_bgTiles[row][col].move(-m_tileSize * 3.f, 0.f);
                if (dy >  m_tileSize * 1.5f) m_bgTiles[row][col].move(0.f,  m_tileSize * 3.f);
                if (dy < -m_tileSize * 1.5f) m_bgTiles[row][col].move(0.f, -m_tileSize * 3.f);
            }
        }
    }

    if (m_stageType == StageType::MadForest || m_stageType == StageType::PlantMap || m_stageType == StageType::InlaidLibrary) {
        int centerGridX = std::floor(cam.x / m_tileSize);
        int centerGridY = std::floor(cam.y / m_tileSize);

        if (centerGridX != m_lastGridX || centerGridY != m_lastGridY) {
            m_lastGridX = centerGridX;
            m_lastGridY = centerGridY;
            
            m_obstacles.clear();
            for (int x = -1; x <= 1; ++x) {
                for (int y = -1; y <= 1; ++y) {
                    float offsetX = (centerGridX + x) * m_tileSize;
                    float offsetY = (centerGridY + y) * m_tileSize;
                    
                    for (const auto& baseObs : m_baseObstacles) {
                        sf::Vector2f basePos = baseObs->getPosition();
                        auto obs = std::make_unique<Obstacle>(
                            basePos + sf::Vector2f(offsetX, offsetY), 
                            *baseObs->getSprite().getTexture(), 
                            baseObs->getSprite().getTextureRect(), 
                            baseObs->getSprite().getScale().x,
                            baseObs->getFootprintRatio(), 
                            baseObs->getWidthRatio()
                        );
                        obs->setVisible(baseObs->isVisible());
                        m_obstacles.push_back(std::move(obs));
                    }
                }
            }
            rebuildBlockedCells();
        }
    }

    if (!m_cheatApplied && sf::Keyboard::isKeyPressed(sf::Keyboard::LAlt) && sf::Keyboard::isKeyPressed(sf::Keyboard::E)) {
        m_cheatApplied = true;
        // Max out Whip if owned, or add it
        bool hasWhip = false;
        for (auto& w : m_weapons) {
            if (w->getName() == "Whip") {
                while (!w->isMaxLevel()) w->levelUp();
                hasWhip = true;
                break;
            }
        }
        if (!hasWhip) {
            addWeapon("Whip");
            auto& w = m_weapons.back();
            while (!w->isMaxLevel()) w->levelUp();
        }
        // Add Hollow Heart at level 1 if not owned
        addOrUpgradePassive("Hollow Heart");
        std::cout << "CHEAT: Whip maxed + Hollow Heart added! Kill the boss for evolution.\n";
    }

    // Cheat Code: Alt+C = max all weapons + all passives for testing
    if (!m_cheatApplied && sf::Keyboard::isKeyPressed(sf::Keyboard::LAlt) && sf::Keyboard::isKeyPressed(sf::Keyboard::C)) {
        m_cheatApplied = true;
        
        // Add all core weapons if not already present
        std::vector<std::string> allWeapons = {"Whip", "Magic Wand", "Knife", "Fire Wand", "Axe", "Cross", "Garlic", "King Bible", "Santa Water", "Runetracer", "Lightning Ring"};
        for (const auto& wName : allWeapons) {
            bool found = false;
            for (auto& w : m_weapons) if (w->getName() == wName) { found = true; break; }
            if (!found) addWeapon(wName);
        }
        // Max level all owned weapons (including unique starting character weapons)
        for (auto& w : m_weapons) {
            while (!w->isMaxLevel()) w->levelUp();
        }

        // Max all passive items directly without hardcoded string filtering
        for (auto& list : m_playerPassiveItems) {
            for (auto& p : list) {
                p.level = p.maxLevel;
            }
        }
        
        std::cout << "CHEAT: All active weapons and passive items added and maxed!\n";
    }

    // Cheat Code: Alt+T = Spawn Treasure Chest 150px to the right of primary player for testing evolutions
    static bool tPressedLastFrame = false;
    bool tPressed = sf::Keyboard::isKeyPressed(sf::Keyboard::LAlt) && sf::Keyboard::isKeyPressed(sf::Keyboard::T);
    if (tPressed && !tPressedLastFrame) {
        TreasureChest chest;
        chest.init(getPlayer(0).getPosition() + sf::Vector2f(150.f, 0.f));
        m_chests.push_back(chest);
        std::cout << "CHEAT: Spawned a treasure chest 150px to the right of player!\n";
    }
    tPressedLastFrame = tPressed;

    // Cheat Code: Alt+H = spawn a horde around the players, for demo recording.
    // Tap for one batch; hold to keep spawning until the enemy pool runs dry.
    static bool hPressedLastFrame = false;
    static float hordeTimer = 0.f;
    bool hPressed = sf::Keyboard::isKeyPressed(sf::Keyboard::LAlt) && sf::Keyboard::isKeyPressed(sf::Keyboard::H);
    hordeTimer += dt;
    bool hordeFire = hPressed && (!hPressedLastFrame || hordeTimer >= 0.08f);
    if (hordeFire) {
        hordeTimer = 0.f;
        const int hordeSize = 200;

        // Use the current wave's roster so the horde matches the stage.
        std::vector<std::string> types;
        const WaveData* wave = m_waveManager.getCurrentWave(m_survivalTime);
        if (wave && !wave->enemies.empty()) {
            types = wave->enemies;
        } else {
            types.push_back("ZOMBIE");
        }

        int spawned = 0;
        for (int i = 0; i < hordeSize; ++i) {
            EnemyStats stats = EnemyDatabase::getStats(types[std::rand() % types.size()]);

            EnemyBase* enemy = (stats.shootCooldown > 0.f) ? m_shooterPool.acquire()
                                                           : m_enemyPool.acquire();
            if (!enemy) break;  // pool exhausted

            // Ring around the camera, just outside the view, same as normal spawning.
            sf::Vector2u winSize = m_manager->getWindow().getSize();
            float halfW = winSize.x / 2.0f;
            float halfH = winSize.y / 2.0f;
            float spawnRadius = std::sqrt(halfW * halfW + halfH * halfH) + 60.f;
            sf::Vector2f pos;
            if (!findFreeSpawnPos(cam, spawnRadius, pos)) {
                if (enemy->isShooter()) m_shooterPool.release(static_cast<ShooterEnemy*>(enemy));
                else                    m_enemyPool.release(enemy);
                continue;   // ring fully walled here; do not strand the enemy
            }

            // Match the normal spawn path so horde enemies scale like real ones.
            if (stats.hpPerLevel > 0.f) {
                stats.maxHp += stats.hpPerLevel * getHighestPlayerLevel();
            }
            float curse = getRunCurseMultiplier();
            stats.maxHp *= curse;
            stats.speed *= curse;
            stats.hp = stats.maxHp;

            enemy->init(pos, stats, &m_enemiesTex);
            enemy->setTarget(getNearestPlayer(pos));
            m_activeEnemies.push_back(enemy);
            ++spawned;
        }
        std::cout << "CHEAT: Spawned " << spawned << " enemies. Active: "
                  << m_activeEnemies.size() << ", pool left: " << m_enemyPool.availableCount()
                  << (spawned < hordeSize ? "  (POOL EXHAUSTED)" : "") << "\n";
    }
    hPressedLastFrame = hPressed;

    // Cheat Code: Alt+J = spawn ranged (shooter) enemies around the players.
    // The wave data only introduces them from t=60s, which is too late to demo
    // ranged combat in a short recording.
    static bool jPressedLastFrame = false;
    bool jPressed = sf::Keyboard::isKeyPressed(sf::Keyboard::LAlt) && sf::Keyboard::isKeyPressed(sf::Keyboard::J);
    if (jPressed && !jPressedLastFrame) {
        // Any enemy whose data gives it a shoot cooldown is ranged.
        std::vector<std::string> shooterTypes;
        for (const auto& name : EnemyDatabase::getAllNames()) {
            if (EnemyDatabase::getStats(name).shootCooldown > 0.f) {
                shooterTypes.push_back(name);
            }
        }

        int spawned = 0;
        if (shooterTypes.empty()) {
            std::cout << "CHEAT: no ranged enemy types found in the database." << "\n";
        } else {
            const int shooterCount = 12;
            sf::Vector2u winSize = m_manager->getWindow().getSize();
            float halfW = winSize.x / 2.0f;
            float halfH = winSize.y / 2.0f;
            // Closer than the normal ring so they are on screen and firing right away.
            float spawnRadius = std::sqrt(halfW * halfW + halfH * halfH) * 0.55f;

            for (int i = 0; i < shooterCount; ++i) {
                EnemyStats stats = EnemyDatabase::getStats(shooterTypes[std::rand() % shooterTypes.size()]);

                EnemyBase* enemy = m_shooterPool.acquire();
                if (!enemy) break;

                sf::Vector2f pos;
                if (!findFreeSpawnPos(cam, spawnRadius, pos)) {
                    m_shooterPool.release(static_cast<ShooterEnemy*>(enemy));
                    continue;
                }

                if (stats.hpPerLevel > 0.f) {
                    stats.maxHp += stats.hpPerLevel * getHighestPlayerLevel();
                }
                float curse = getRunCurseMultiplier();
                stats.maxHp *= curse;
                stats.speed *= curse;
                stats.hp = stats.maxHp;

                enemy->init(pos, stats, &m_enemiesTex);
                enemy->setTarget(getNearestPlayer(pos));
                m_activeEnemies.push_back(enemy);
                ++spawned;
            }
            std::cout << "CHEAT: Spawned " << spawned << " ranged enemies. Pool left: "
                      << m_shooterPool.availableCount() << "\n";
        }
    }
    jPressedLastFrame = jPressed;

    // Update players & Stage Bounds
    for (size_t pi = 0; pi < m_players.size(); ++pi) {
        Player& p = m_players[pi];
        if (!p.isActive()) continue;

        // Refresh this player's passive item bonuses (Wings, Attractorb, Armor)
        p.setPassiveMoveSpeedMult(1.f + getPassiveStatBonus(pi, "moveSpeed"));
        p.setPassiveMagnetBonus(getPassiveStatBonus(pi, "magnet"));
        p.setPassiveArmor(getPassiveStatBonus(pi, "armor"));
        p.setPassiveGreed(getPassiveStatBonus(pi, "greed"));

        // Hollow Heart: max health scales with the shop bonus and this player's passives.
        p.setMaxHealth(100.f * ProfileManager::GetInstance().getMaxHealthMultiplier()
                             * getPassiveMaxHealthMultiplier(pi));
        // Pummarola stacks with the shop Recovery power-up.
        float regen = ProfileManager::GetInstance().getRecoveryRate() + getPassiveStatBonus(pi, "regen");
        if (regen > 0.f) p.heal(regen * dt);

        p.update(dt);

        if (m_stageType == StageType::InlaidLibrary) {
            sf::Vector2f pos = p.getPosition();
            float minY = 820.f;
            float maxY = 1260.f;
            if (pos.y < minY) {
                p.setPosition(pos.x, minY);
            } else if (pos.y > maxY) {
                p.setPosition(pos.x, maxY);
            }
        }

    }

    // Soft tethering if 2 players active
    if (m_players.size() >= 2 && m_players[0].isActive() && m_players[1].isActive()) {
        float maxDist = 800.f;
        sf::Vector2f delta = m_players[1].getPosition() - m_players[0].getPosition();
        float dist = std::sqrt(delta.x * delta.x + delta.y * delta.y);
        if (dist > maxDist) {
            sf::Vector2f norm = delta / dist;
            sf::Vector2f center = (m_players[0].getPosition() + m_players[1].getPosition()) * 0.5f;
            m_players[0].setPosition(center - norm * (maxDist * 0.5f));
            m_players[1].setPosition(center + norm * (maxDist * 0.5f));
        }
    }

    // Resolve Circle-AABB sliding collisions with furniture and map obstacles for all players
    float playerRadius = 16.f;
    for (auto& p : m_players) {
        if (!p.isActive()) continue;
        sf::Vector2f pPos = p.getPosition();
        for (const auto& obs : m_obstacles) {
            if (obs->isActive() && obs->hasCollision() && Collision::checkCircleAABB(pPos, playerRadius, obs->getBounds())) {
                Collision::resolveCircleAABB(pPos, playerRadius, p.getVelocity(), obs->getBounds());
            }
        }
        p.setPosition(pPos);
    }

    // Update weapons (firing projectiles relative to owner player)
    for (size_t i = 0; i < m_weapons.size(); ++i) {
        size_t ownerIdx = (i < m_weaponOwnerIndices.size()) ? m_weaponOwnerIndices[i] : 0;
        Player& owner = getPlayer(ownerIdx);
        if (!owner.isActive()) continue;   // a downed player's weapons stop firing

        // Owner's in-run passive item bonuses (shop power-ups are applied separately).
        float passiveDmg   = getPassiveDamageMultiplier(ownerIdx);
        float passiveSpeed = getPassiveProjSpeedMultiplier(ownerIdx);
        float passiveArea  = getPassiveAreaMultiplier(ownerIdx);
        float passiveDur   = 1.f + getPassiveStatBonus(ownerIdx, "duration");
        m_weapons[i]->setOwnerCooldownMult(getPassiveCooldownMultiplier(ownerIdx));
        m_weapons[i]->setOwnerAmountBonus(static_cast<int>(getPassiveStatBonus(ownerIdx, "amount")));

        size_t prevProjCount = m_activeProjectiles.size();
        m_weapons[i]->update(dt, owner.getPosition(), owner.getFacingDir(), m_activeEnemies, m_activeProjectiles);
        // Tag freshly spawned projectiles (including this frame's burst shots) with their
        // owner, and apply that player's passive bonuses.
        for (size_t j = prevProjCount; j < m_activeProjectiles.size(); ++j) {
            m_activeProjectiles[j].setOwnerPlayer(ownerIdx);
            m_activeProjectiles[j].applyOwnerModifiers(passiveDmg, passiveSpeed, passiveArea, passiveDur);
        }
    }

    // Update projectiles
    sf::Vector2f viewSize = m_manager->getWindow().getDefaultView().getSize();
    sf::FloatRect cameraBounds(
        cam.x - viewSize.x / 2.0f,
        cam.y - viewSize.y / 2.0f,
        viewSize.x,
        viewSize.y
    );
    
    for (auto& proj : m_activeProjectiles) {
        // Anchor player-following projectiles (aura / orbiting) to their owning player.
        // `cam` is the midpoint of all active players, so using it here dragged every
        // anchored weapon to the centre of the screen in co-op.
        Player& projOwner = getPlayer(proj.getOwnerPlayer());
        proj.update(dt, projOwner.getPosition(), cameraBounds);
    }

    for (auto& proj : m_bossProjectiles) {
        proj.update(dt);
    }

    // Update survival timer
    m_survivalTime += dt;
    
    // Format and update timer text
    int minutes = static_cast<int>(m_survivalTime) / 60;
    int seconds = static_cast<int>(m_survivalTime) % 60;
    char timeBuffer[16];
    std::snprintf(timeBuffer, sizeof(timeBuffer), "%02d:%02d", minutes, seconds);
    m_timerText.setString(timeBuffer);

    // Check for wave transition to spawn bosses
    int newWaveIndex = m_waveManager.getCurrentWaveIndex(m_survivalTime);
    if (newWaveIndex != m_currentWaveIndex) {
        m_currentWaveIndex = newWaveIndex;
        const WaveData* currentWave = m_waveManager.getWave(m_currentWaveIndex);
        
        if (currentWave && !currentWave->boss.empty()) {
            EnemyStats stats = EnemyDatabase::getStats(currentWave->boss);
            EnemyBase* boss = nullptr;
            if (stats.shootCooldown > 0.f) {
                boss = m_shooterPool.acquire();
            } else {
                boss = m_enemyPool.acquire();
            }
            if (boss) {
                float spawnX = cam.x;
                sf::Vector2u winSize = m_manager->getWindow().getSize();
                float spawnY = cam.y - (winSize.y / 2.0f + 200.f); // Spawn safely above screen
                
                int playerLevel = getHighestPlayerLevel();
                if (stats.hpPerLevel > 0.f) {
                    stats.maxHp += stats.hpPerLevel * playerLevel;
                }
                // Bosses are cursed too, or Skull O'Maniac would make them relatively weaker.
                float bossCurse = getRunCurseMultiplier();
                stats.maxHp *= bossCurse;
                stats.speed *= bossCurse;
                stats.hp = stats.maxHp;

                boss->init(sf::Vector2f(spawnX, spawnY), stats, &m_enemiesTex);
                boss->setTarget(getNearestPlayer(sf::Vector2f(spawnX, spawnY)));
                m_activeEnemies.push_back(boss);
                m_bossPtr = boss;
                m_bossIsDead = false;
            }
        }
    }

    // Detect boss death -> spawn treasure chest
    if (m_bossPtr && !m_bossPtr->isActive() && !m_bossIsDead) {
        m_bossIsDead = true;
        TreasureChest chest;
        chest.init(m_bossPtr->getPosition());
        m_chests.push_back(chest);
        std::cout << "Boss defeated! A treasure chest appeared!\n";
    }

    // Update & check chest pickup across all players
    for (auto& chest : m_chests) {
        chest.update(dt);
        bool pickedUp = false;
        size_t collectorIdx = 0;
        for (size_t pi = 0; pi < m_players.size(); ++pi) {
            Player& p = m_players[pi];
            if (p.isActive() && chest.isActive() && chest.getBounds().intersects(p.getBounds())) {
                pickedUp = true;
                collectorIdx = pi;
                break;
            }
        }
        if (pickedUp) {
            chest.deactivate();
            m_manager->pushState(std::make_unique<TreasureChestState>(m_manager, this, collectorIdx));
        }
    }
    m_chests.erase(std::remove_if(m_chests.begin(), m_chests.end(),
        [](const TreasureChest& c) { return !c.isActive(); }), m_chests.end());

    // Wave-based Enemy Spawning Logic
    const WaveData* currentWave = m_waveManager.getCurrentWave(m_survivalTime);
    if (currentWave && !currentWave->enemies.empty()) {
        m_enemySpawnTimer += dt;
        
        int currentCount = m_activeEnemies.size();
        bool shouldSpawn = false;
        int toSpawn = 0;
        
        // Spawn immediately to meet minimum, or spawn periodically
        // Skull O'Maniac raises enemy quantity and spawn rate.
        float curse = getRunCurseMultiplier();
        int cursedMin = static_cast<int>(currentWave->minEnemies * curse);
        float cursedInterval = currentWave->spawnInterval / curse;

        if (currentCount < cursedMin) {
            shouldSpawn = true;
            toSpawn = cursedMin - currentCount;
            if (toSpawn > 20) toSpawn = 20; 
        } else if (m_enemySpawnTimer >= cursedInterval) {
            shouldSpawn = true;
            toSpawn = 1;
            m_enemySpawnTimer = 0.f;
        }

        if (shouldSpawn) {
            for (int i = 0; i < toSpawn; ++i) {
                std::string type = currentWave->enemies[rand() % currentWave->enemies.size()];
                EnemyStats stats = EnemyDatabase::getStats(type);

                EnemyBase* enemy = nullptr;
                if (stats.shootCooldown > 0.f) {
                    enemy = m_shooterPool.acquire();
                } else {
                    enemy = m_enemyPool.acquire();
                }

                if (enemy) {
                    sf::Vector2u winSize = m_manager->getWindow().getSize();
                    float halfW = winSize.x / 2.0f;
                    float halfH = winSize.y / 2.0f;
                    float spawnRadius = std::sqrt(halfW * halfW + halfH * halfH) + 100.f;
                    sf::Vector2f freePos;
                    if (!findFreeSpawnPos(cam, spawnRadius, freePos)) {
                        if (enemy->isShooter()) m_shooterPool.release(static_cast<ShooterEnemy*>(enemy));
                        else                    m_enemyPool.release(enemy);
                        continue;   // ring fully walled here; do not strand the enemy
                    }
                    float spawnX = freePos.x;
                    float spawnY = freePos.y;

                    int playerLevel = getHighestPlayerLevel();
                    if (stats.hpPerLevel > 0.f) {
                        stats.maxHp += stats.hpPerLevel * playerLevel;
                    }
                    // Skull O'Maniac also raises enemy health and speed.
                    stats.maxHp *= curse;
                    stats.speed *= curse;
                    stats.hp = stats.maxHp;

                    enemy->init(sf::Vector2f(spawnX, spawnY), stats, &m_enemiesTex);
                    enemy->setTarget(getNearestPlayer(sf::Vector2f(spawnX, spawnY)));
                    m_activeEnemies.push_back(enemy);
                }
            }
        }
    }

    // 1. Clear grid and insert all active enemies
    m_grid.clear();
    std::vector<Projectile> newProjectiles;
    
    for (auto* enemy : m_activeEnemies) {
        if (enemy->isActive()) {
            m_grid.insertEntity(enemy);
        }
    }

    // Process collisions and update enemies
    for (auto it = m_activeEnemies.begin(); it != m_activeEnemies.end(); ) {
        EnemyBase* enemy = *it;
        if (!enemy->isActive()) {
            // Spawn a random Collectible when an enemy dies.
            // Nothing drops inside a wall: the player cannot reach it, so it would
            // just accumulate in sealed areas as unreachable clutter.
            int roll = isBlocked(enemy->getPosition()) ? 100 : (std::rand() % 100);
            if (roll < 70) {
                if (enemy->getStats().expDrop > 0.0f) {
                    auto gem = std::make_unique<ExpGem>();
                    gem->init(enemy->getPosition(), enemy->getStats().expDrop);
                    m_activeCollectibles.push_back(std::move(gem));
                }
            } else if (roll < 80) {
                auto coin = std::make_unique<Coin>();
                int goldValue = 1;
                coin->init(enemy->getPosition(), goldValue);
                m_activeCollectibles.push_back(std::move(coin));
            } else if (roll < 85) {
                auto chicken = std::make_unique<FloorChicken>();
                chicken->init(enemy->getPosition(), 30.f);
                m_activeCollectibles.push_back(std::move(chicken));
            }

            if (enemy->isShooter()) {
                m_shooterPool.release(static_cast<ShooterEnemy*>(enemy));
            } else {
                m_enemyPool.release(enemy);
            }
            it = m_activeEnemies.erase(it);
            continue;
        } 
        
        Player* targetPlayer = getNearestPlayer(enemy->getPosition());
        if (targetPlayer) enemy->setTarget(targetPlayer);

        // Enemies respect walls. Revert a move that ends inside a solid cell, but
        // only when the enemy started outside one -- otherwise anything that spawned
        // in a wall would be frozen there forever instead of walking out.
        sf::Vector2f preMovePos = enemy->getPosition();
        enemy->update(dt);
        if (isBlocked(enemy->getPosition()) && !isBlocked(preMovePos)) {
            // Try sliding along each axis so enemies follow walls instead of sticking.
            sf::Vector2f post = enemy->getPosition();
            sf::Vector2f slideX(post.x, preMovePos.y);
            sf::Vector2f slideY(preMovePos.x, post.y);
            if (!isBlocked(slideX))      enemy->setPosition(slideX);
            else if (!isBlocked(slideY)) enemy->setPosition(slideY);
            else                         enemy->setPosition(preMovePos);
        }

        if (m_stageType == StageType::InlaidLibrary) {
            sf::Vector2f epos = enemy->getPosition();
            float minEY = 780.f;
            float maxEY = 1300.f;
            if (epos.y < minEY) {
                enemy->setPosition(epos.x, minEY);
            } else if (epos.y > maxEY) {
                enemy->setPosition(epos.x, maxEY);
            }
        }

        
        if (enemy->getStats().enemyClass == EnemyClass::BOSS && targetPlayer) {
            enemy->updateShooting(dt, targetPlayer->getPosition(), m_bossProjectiles, &m_vfxTex);
        }
        
        sf::Vector2f toPlayer = enemy->getPosition() - (targetPlayer ? targetPlayer->getPosition() : cam);
        float distToPlayerSq = toPlayer.x * toPlayer.x + toPlayer.y * toPlayer.y;

        if (enemy->wantsToShoot()) {
            {
                enemy->resetShootFlag();
                if (distToPlayerSq < 1000.f * 1000.f) {
                    sf::Vector2f dir = -toPlayer;
                    float len = std::sqrt(dir.x * dir.x + dir.y * dir.y);
                    if (len > 0.f) {
                        dir /= len;
                        Projectile proj;
                        proj.init(enemy->getPosition(), dir, enemy->getStats().projectileDamage, enemy->getStats().projectileSpeed, 1200.f, 5.f, false);
                        proj.setEnemyProj(true);
                        proj.setFillColor(sf::Color(220, 80, 220));
                        m_activeProjectiles.push_back(proj);
                    }
                }
            }
        }
        
        // --- Enemy-Enemy Soft Collision (Separation) ---
        m_grid.getNeighborsInRadius(enemy->getPosition(), enemy->getRadius() * 2.f, m_neighborScratch);
        for (EnemyBase* other : m_neighborScratch) {
            if (other != enemy && other->isActive()) {
                sf::Vector2f diff = enemy->getPosition() - other->getPosition();
                float distSq = diff.x * diff.x + diff.y * diff.y;
                float combinedRadius = enemy->getRadius() + other->getRadius();
                if (distSq > 0.0001f && distSq < (combinedRadius * combinedRadius)) {
                    float dist = std::sqrt(distSq);
                    float overlap = combinedRadius - dist;
                    sf::Vector2f pushDir = diff / dist;
                    // Crowd separation must not shove enemies through a wall, or a
                    // dense pack would slowly extrude itself into blocked areas.
                    sf::Vector2f pushed = enemy->getPosition() + pushDir * (overlap * 0.5f);
                    if (!isBlocked(pushed) || isBlocked(enemy->getPosition())) {
                        enemy->setPosition(pushed);
                    }
                }
            }
        }
        
        sf::FloatRect enemyBounds = enemy->getBounds();
        
        if (!enemy->isDying()) {
            // Check collision with all active players
            for (auto& p : m_players) {
                if (!p.isActive()) continue;
                if (enemyBounds.intersects(p.getBounds())) {
                    float armorRed = ProfileManager::GetInstance().getArmorReduction() + p.getPassiveArmor();
                    float dmg = std::max(1.f, 10.f - armorRed);
                    p.takeDamage(dmg * dt);
                }

                // Enemy-Player Physical Collision (Separation)
                sf::Vector2f toP = enemy->getPosition() - p.getPosition();
                float distToPSq = toP.x * toP.x + toP.y * toP.y;
                float playerRadius = 15.f;
                float enemyRadius = enemy->getRadius();
                float combinedRadiusPlayer = playerRadius + enemyRadius;
                if (distToPSq > 0.0001f && distToPSq < (combinedRadiusPlayer * combinedRadiusPlayer)) {
                    float dist = std::sqrt(distToPSq);
                    float overlap = combinedRadiusPlayer - dist;
                    sf::Vector2f pushDir = toP / dist;
                    enemy->setPosition(enemy->getPosition() + pushDir * overlap);
                }
            }


        }
        ++it;
    }

    // Projectile -> enemy collision, resolved through the spatial hash grid.
    // This used to be a nested loop inside the enemy pass: every enemy tested against
    // every projectile, so 3000 enemies x 200 projectiles was 600k checks per frame.
    // Now each projectile only tests the enemies in its own neighbourhood.
    for (auto& proj : m_activeProjectiles) {
        if (!proj.canHit() || proj.isEnemyProj()) continue;

        sf::FloatRect projBounds = proj.getBounds();
        // Query radius covers the projectile's own extent, so large auras and area
        // weapons cannot miss enemies sitting at their edges.
        float projReach = std::max(projBounds.width, projBounds.height) * 0.5f;
        m_grid.getNeighborsInRadius(proj.getPosition(), projReach, m_neighborScratch);

        for (EnemyBase* enemy : m_neighborScratch) {
            if (!enemy->isActive() || enemy->isDying()) continue;
            sf::FloatRect enemyBounds = enemy->getBounds();
            if (!projBounds.intersects(enemyBounds)) continue;
                if (proj.hasHitEnemy(enemy)) continue;
                proj.addHitEnemy(enemy);

                bool killed = enemy->takeDamage(proj.getDamage());
                
                if (proj.getSourceWeapon()) {
                    proj.getSourceWeapon()->addDamageDealt(proj.getDamage());
                }

                Physics::ApplyKnockback(enemy, proj.getDirection(), proj.getKnockback(), 1.0f);
                
                if (proj.getKnockback() == 150.f) {
                    getPlayer(proj.getOwnerPlayer()).heal(8.f);
                }
                
                if (proj.isBouncing()) {
                    sf::Vector2f diff = proj.getPosition() - enemy->getPosition();
                    float distSq = diff.x * diff.x + diff.y * diff.y;
                    if (distSq > 0.0001f) {
                        float dist = std::sqrt(distSq);
                        sf::Vector2f normal = diff / dist;
                        
                        sf::Vector2f dir = proj.getDirection();
                        float dot = dir.x * normal.x + dir.y * normal.y;
                        sf::Vector2f reflect = dir - 2.f * dot * normal;
                        
                        float rLen = std::sqrt(reflect.x*reflect.x + reflect.y*reflect.y);
                        if (rLen > 0) reflect /= rLen;
                        
                        float currentSpeed = std::sqrt(proj.m_velocity.x * proj.m_velocity.x + proj.m_velocity.y * proj.m_velocity.y);
                        proj.m_direction = reflect;
                        proj.m_velocity = reflect * currentSpeed;
                        
                        if (proj.m_hasSprite && currentSpeed > 0) {
                            proj.m_initRotation = std::atan2(reflect.y, reflect.x) * 180.f / 3.14159265f;
                            proj.m_animSprite.setRotation(proj.m_initRotation);
                        }
                    }
                }

                if (proj.isExploding()) {
                    float roll = static_cast<float>(std::rand()) / RAND_MAX;
                    if (roll <= proj.getExplosionChance()) {
                        Projectile explosion;
                        float radius = 50.f * ProfileManager::GetInstance().getAreaMultiplier();
                        explosion.init(proj.getPosition(), sf::Vector2f(0.f, 0.f), proj.getDamage() * 2.f, 0.f, 0.f, 0.2f, true);
                        explosion.setCircleShape(radius, sf::Color(255, 100, 100, 150));
                        explosion.setHitInterval(0.5f);
                        explosion.setSourceWeapon(proj.getSourceWeapon());
                        newProjectiles.push_back(explosion);
                    }
                }
                
                if (!proj.isPiercing() && !proj.isBouncing()) {
                    proj.deactivate();
                }
                
                if (killed) {
                    m_kills++;
                }
            }
        }

    // Check enemy projectile collisions with all players
    for (auto& proj : m_activeProjectiles) {
        if (proj.isActive() && proj.isEnemyProj()) {
            for (auto& p : m_players) {
                if (p.isActive() && proj.getBounds().intersects(p.getBounds())) {
                    float armorRed = ProfileManager::GetInstance().getArmorReduction() + p.getPassiveArmor();
                    float dmg = std::max(1.f, proj.getDamage() - armorRed);
                    p.takeDamage(dmg);
                    proj.deactivate();
                    break;
                }
            }
        }
    }

    for (const auto& p : newProjectiles) {
        m_activeProjectiles.push_back(p);
    }
    
    // Pickups collection for all players
    for (auto& item : m_activeCollectibles) {
        Player* nearPlayer = getNearestPlayer(item->getPosition());
        item->update(dt, nearPlayer ? nearPlayer : &m_players[0]);
        for (auto& p : m_players) {
            if (p.isActive() && item->isActive() && item->getBounds().intersects(p.getBounds())) {
                item->onPickupPlayer(this, &p);
                break;
            }
        }
    }

    // Clean up dead collectibles
    m_activeCollectibles.erase(std::remove_if(m_activeCollectibles.begin(), m_activeCollectibles.end(),
        [](const std::unique_ptr<Collectible>& c) { return !c->isActive(); }), m_activeCollectibles.end());


    // Collision check: Boss Projectiles vs Players
    for (auto& proj : m_bossProjectiles) {
        if (proj.isActive()) {
            for (auto& p : m_players) {
                if (p.isActive() && proj.getBounds().intersects(p.getBounds())) {
                    float armorRed = ProfileManager::GetInstance().getArmorReduction() + p.getPassiveArmor();
                    float dmg = std::max(1.f, proj.getDamage() - armorRed);
                    p.takeDamage(dmg);
                    proj.deactivate();
                    break;
                }
            }
        }
    }

    // Clean up dead projectiles
    m_activeProjectiles.erase(std::remove_if(m_activeProjectiles.begin(), m_activeProjectiles.end(),
        [](const Projectile& p) { return !p.isActive(); }), m_activeProjectiles.end());

    m_bossProjectiles.erase(std::remove_if(m_bossProjectiles.begin(), m_bossProjectiles.end(),
        [](const Projectile& p) { return !p.isActive(); }), m_bossProjectiles.end());

    // Update gold HUD text
    m_goldText.setString("GOLD: " + std::to_string(m_runGold));

    // Detect per-player level-up and queue upgrade screen
    for (size_t i = 0; i < m_players.size(); ++i) {
        if (m_players[i].isActive() && m_players[i].checkLevelUp()) {
            m_levelUpQueue.push_back(i);
        }
    }

    if (!m_levelUpQueue.empty()) {
        size_t nextPlayerIdx = m_levelUpQueue.front();
        m_levelUpQueue.erase(m_levelUpQueue.begin());
        m_manager->pushState(std::make_unique<LevelUpState>(m_manager, this, nextPlayerIdx));
    }

    // Check Player Death / Revival -- resolved per player.
    // Each player revives on their own charges; a player out of charges goes down
    // (inactive). The run ends only when every player is down.
    for (size_t pi = 0; pi < m_players.size(); ++pi) {
        Player& p = m_players[pi];
        if (!p.isActive() || !p.isDown()) continue;

        if (p.tryRevive()) {
            // Clear breathing room around the player who was revived.
            const float clearRadiusSq = 450.f * 450.f;
            for (auto* enemy : m_activeEnemies) {
                sf::Vector2f diff = enemy->getPosition() - p.getPosition();
                if (diff.x * diff.x + diff.y * diff.y < clearRadiusSq) {
                    enemy->setActive(false);
                }
            }
            std::cout << "Player " << (pi + 1) << " resurrected! Revivals left: "
                      << p.getRevivalsLeft() << "\n";
        } else {
            p.setActive(false);
            std::cout << "Player " << (pi + 1) << " is down.\n";
        }
    }

    bool allDown = true;
    for (const auto& p : m_players) {
        if (p.isActive()) { allDown = false; break; }
    }

    if (allDown) {
        {
            ProfileManager::GetInstance().save("save.txt");

            RunSummaryData summary;
            summary.mapName = "Mad Forest";
            summary.characterName = "Survivors";
            summary.survivalTime = m_survivalTime;
            summary.goldEarned = m_runGold;
            summary.levelReached = getHighestPlayerLevel();
            summary.enemiesDefeated = m_kills;
            summary.charIconRect = sf::IntRect(0, 0, 16, 16);

            for (const auto& weapon : m_weapons) {
                WeaponSummary ws;
                ws.name = weapon->getName();
                ws.level = weapon->getLevel();
                ws.damage = weapon->getTotalDamageDealt();
                ws.timeActive = summary.survivalTime;
                ws.dps = (summary.survivalTime > 0) ? (ws.damage / summary.survivalTime) : 0;
                ws.frameName = weapon->getName();
                summary.weapons.push_back(ws);
            }

            m_manager->pushState(std::make_unique<GameOverState>(m_manager, summary));
            return;
        }
    }
}

void PlayingState::draw(sf::RenderWindow& window) {
    if (m_stageType == StageType::InlaidLibrary) {
        window.clear(sf::Color::Black);
    } else {
        window.clear(sf::Color(20, 50, 20));
    }

    sf::Vector2f cam(0.f, 0.f);
    int activeCount = 0;
    for (auto& p : m_players) {
        if (p.isActive()) {
            cam += p.getPosition();
            activeCount++;
        }
    }
    if (activeCount > 0) cam /= static_cast<float>(activeCount);
    else cam = sf::Vector2f(640.f, 360.f);

    // Create and apply World View centered on active player midpoint
    sf::View worldView = window.getDefaultView();
    worldView.setCenter(cam);
    window.setView(worldView);

    // Draw infinite-tiling background before everything else
    for (int row = 0; row < 3; ++row)
        for (int col = 0; col < 3; ++col)
            window.draw(m_bgTiles[row][col]);

    // --- 2.5D depth ---
    // An obstacle should occlude something when the obstacle's base sits lower on
    // screen (greater Y) than that thing. This previously compared against cam.y,
    // the camera centre, so walking up or down flipped obstacles between the
    // behind and in-front passes -- which is why gems vanished and reappeared as
    // the player moved. The threshold now comes from the objects themselves.
    m_depthObstacles.clear();
    for (const auto& obs : m_obstacles) {
        if (obs->isActive()) m_depthObstacles.push_back(obs.get());
    }
    std::sort(m_depthObstacles.begin(), m_depthObstacles.end(),
              [](const Obstacle* a, const Obstacle* b) {
                  return a->getPosition().y < b->getPosition().y;
              });

    size_t obsIdx = 0;
    auto drawObstaclesUpTo = [&](float y) {
        while (obsIdx < m_depthObstacles.size() &&
               m_depthObstacles[obsIdx]->getPosition().y <= y) {
            m_depthObstacles[obsIdx]->draw(window);
            ++obsIdx;
        }
    };

    // Players back to front, so each is occluded only by obstacles truly in front
    // of it. With a single camera threshold one co-op player was always wrong.
    m_depthPlayers.clear();
    for (auto& p : m_players) {
        if (p.isActive()) m_depthPlayers.push_back(&p);
    }
    std::sort(m_depthPlayers.begin(), m_depthPlayers.end(),
              [](const Player* a, const Player* b) {
                  return a->getPosition().y < b->getPosition().y;
              });

    // Everything behind the backmost player.
    drawObstaclesUpTo(m_depthPlayers.empty() ? cam.y : m_depthPlayers.front()->getPosition().y);

    // Cull off-screen enemies. Each draw is its own call, so at high enemy counts
    // the ones outside the view were pure cost. Uses the public bounds interface.
    sf::Vector2f vSize = worldView.getSize();
    sf::FloatRect viewRect(cam.x - vSize.x * 0.5f - 64.f,
                           cam.y - vSize.y * 0.5f - 64.f,
                           vSize.x + 128.f, vSize.y + 128.f);
    for (auto* enemy : m_activeEnemies) {
        if (!viewRect.intersects(enemy->getBounds())) continue;
        enemy->draw(window);
    }
    
    for (auto& proj : m_activeProjectiles) {
        proj.draw(window);
    }
    
    for (auto& proj : m_bossProjectiles) {
        proj.draw(window);
    }

    // Draw treasure chests
    for (const auto& chest : m_chests) {
        chest.draw(window);
    }

    // Players, interleaved with the obstacles that fall between them.
    for (Player* p : m_depthPlayers) {
        drawObstaclesUpTo(p->getPosition().y);
        p->draw(window);
    }

    // Whatever is left sits in front of everything on the ground plane.
    while (obsIdx < m_depthObstacles.size()) {
        m_depthObstacles[obsIdx]->draw(window);
        ++obsIdx;
    }

    // Collectibles draw last. Gems and coins are things the player has to find and
    // walk to, so they must never be buried under a table or counter.
    for (auto& item : m_activeCollectibles) {
        item->draw(window);
    }

    // Health Bar Background (under characters) - each player shows their own HP
    float hpBarWidth = 40.f;
    float hpBarHeight = 6.f;

    for (auto& p : m_players) {
        if (!p.isActive()) continue;
        sf::Vector2f playerPos = p.getPosition();
        
        sf::RectangleShape hpBg(sf::Vector2f(hpBarWidth, hpBarHeight));
        hpBg.setPosition(playerPos.x - hpBarWidth / 2.f, playerPos.y + 25.f);
        hpBg.setFillColor(sf::Color(50, 0, 0));
        hpBg.setOutlineThickness(1.f);
        hpBg.setOutlineColor(sf::Color::Black);
        window.draw(hpBg);

        // Health Bar Fill
        float hpPercent = std::max(0.f, p.getHealth() / p.getMaxHealth());
        sf::RectangleShape hpFill(sf::Vector2f(hpBarWidth * hpPercent, hpBarHeight));
        hpFill.setPosition(playerPos.x - hpBarWidth / 2.f, playerPos.y + 25.f);
        hpFill.setFillColor(p.getPlayerId() == 2 ? sf::Color(255, 120, 120) : sf::Color::Red);
        window.draw(hpFill);
    }

    // Reset to Default View for HUD
    window.setView(window.getDefaultView());

    // Draw HUD
    sf::Vector2u windowSize = window.getSize();
    
    // Timer Text (Top Center)
    sf::FloatRect textBounds = m_timerText.getLocalBounds();
    m_timerText.setOrigin(textBounds.left + textBounds.width / 2.0f, textBounds.top + textBounds.height / 2.0f);
    m_timerText.setPosition(windowSize.x / 2.0f, 40.f);
    window.draw(m_timerText);

    // Gold Text (Top Right)
    window.draw(m_goldText);

    // EXP Bar Background (Bottom of screen) - per player
    float expBarWidth = windowSize.x - 40.f;
    size_t numPlayers = m_players.size();
    float barHeight = (numPlayers > 1) ? 7.f : 10.f;

    for (size_t i = 0; i < numPlayers; ++i) {
        float yPos = windowSize.y - static_cast<float>(numPlayers - i) * (barHeight + 4.f) - 4.f;
        sf::RectangleShape expBg(sf::Vector2f(expBarWidth, barHeight));
        expBg.setPosition(20.f, yPos);
        expBg.setFillColor(sf::Color(20, 20, 45));
        expBg.setOutlineThickness(1.f);
        expBg.setOutlineColor(sf::Color::Black);
        window.draw(expBg);

        float expPct = std::min(1.f, std::max(0.f, m_players[i].getExp() / m_players[i].getExpToNextLevel()));
        sf::RectangleShape expFill(sf::Vector2f(expBarWidth * expPct, barHeight));
        expFill.setPosition(20.f, yPos);
        expFill.setFillColor(i == 1 ? sf::Color(220, 100, 255) : sf::Color(0, 180, 255));
        window.draw(expFill);

        // Level indicator text
        sf::Text lvlText;
        lvlText.setFont(m_font);
        lvlText.setString("P" + std::to_string(i + 1) + " LV " + std::to_string(m_players[i].getLevel()));
        lvlText.setCharacterSize(11);
        lvlText.setStyle(sf::Text::Bold);
        lvlText.setFillColor(sf::Color::White);
        lvlText.setPosition(25.f, yPos - 3.f);
        window.draw(lvlText);
    }

    // Draw HUD - Weapons
    float startX = 20.f; 
    float startY = 20.f;
    float padding = 10.f;
    float boxWidth = 38.f;
    float boxHeight = 66.f;
    
    for (size_t i = 0; i < m_weapons.size(); ++i) {
        float x = startX + i * (boxWidth + padding);
        float y = startY; 
        
        sf::RectangleShape bg(sf::Vector2f(boxWidth, boxHeight));
        bg.setPosition(x, y);
        bg.setFillColor(sf::Color(160, 160, 160, 220));
        bg.setOutlineThickness(2.f);
        bg.setOutlineColor(sf::Color(228, 199, 109));
        window.draw(bg);
        
        sf::Sprite iconSprite;
        iconSprite.setTexture(m_itemsTex);
        std::string name = m_weapons[i]->getName();
        sf::IntRect texRect = IconManager::GetInstance().getIconRect(name);
        
        if (name == "Bloody Tear") {
            iconSprite.setColor(sf::Color(255, 100, 100));
        }

        iconSprite.setTextureRect(texRect);
        
        float iconScale = 2.f; 
        iconSprite.setScale(iconScale, iconScale);
        float iconW = texRect.width * iconScale;
        
        iconSprite.setPosition(x + (boxWidth - iconW) / 2.f, y + 2.f);
        window.draw(iconSprite);
        
        int level = m_weapons[i]->getLevel();
        int maxLevel = 8;
        float gridStartX = x + 5.f; 
        float gridStartY = y + 36.f; 
        float cellSize = 8.f;
        float spacing = 2.f;
        
        for (int j = 0; j < maxLevel; ++j) {
            int row = j / 3;
            int col = j % 3;
            sf::RectangleShape cell(sf::Vector2f(cellSize, cellSize));
            cell.setPosition(gridStartX + col * (cellSize + spacing), gridStartY + row * (cellSize + spacing));
            
            if (j < level) {
                cell.setFillColor(sf::Color(255, 230, 80));
            } else {
                cell.setFillColor(sf::Color::Black);
            }
            cell.setOutlineThickness(1.f);
            cell.setOutlineColor(sf::Color(228, 199, 109));
            window.draw(cell);
        }
    }

    // Draw HUD - Passive Items (below weapons)
    // Shows player 1's passives; the weapon row above is likewise a single merged row.
    const std::vector<PassiveItem>& hudPassives = getPassiveItems(0);
    float passiveStartY = startY + boxHeight + 10.f;
    size_t ownedIdx = 0;
    for (size_t i = 0; i < hudPassives.size(); ++i) {
        if (!hudPassives[i].isOwned()) continue;
        float x = startX + ownedIdx * (boxWidth + padding);
        float y = passiveStartY;
        ++ownedIdx;

        sf::RectangleShape bg(sf::Vector2f(boxWidth, boxHeight));
        bg.setPosition(x, y);
        bg.setFillColor(sf::Color(50, 100, 50, 220));
        bg.setOutlineThickness(2.f);
        bg.setOutlineColor(sf::Color(100, 200, 100));
        window.draw(bg);

        sf::Sprite iconSprite;
        iconSprite.setTexture(m_itemsTex);
        iconSprite.setTextureRect(hudPassives[i].iconRect);
        float iconScale = 2.f;
        iconSprite.setScale(iconScale, iconScale);
        float iconW = hudPassives[i].iconRect.width * iconScale;
        iconSprite.setPosition(x + (boxWidth - iconW) / 2.f, y + 2.f);
        window.draw(iconSprite);

        int level   = hudPassives[i].level;
        int maxLevel = hudPassives[i].maxLevel;
        float gridStartX = x + 5.f;
        float gridStartY = y + 36.f;
        float cellSize = 8.f;
        float spacing  = 2.f;

        for (int j = 0; j < maxLevel; ++j) {
            int row = j / 3;
            int col = j % 3;
            sf::RectangleShape cell(sf::Vector2f(cellSize, cellSize));
            cell.setPosition(gridStartX + col * (cellSize + spacing), gridStartY + row * (cellSize + spacing));

            if (j < level) {
                cell.setFillColor(sf::Color(100, 230, 100));
            } else {
                cell.setFillColor(sf::Color::Black);
            }
            cell.setOutlineThickness(1.f);
            cell.setOutlineColor(sf::Color(100, 200, 100));
            window.draw(cell);
        }
    }


}

void PlayingState::exit() {
}

Player* PlayingState::getNearestPlayer(const sf::Vector2f& pos) {
    if (m_players.empty()) return nullptr;
    Player* nearest = nullptr;
    float minDistSq = std::numeric_limits<float>::max();
    for (auto& p : m_players) {
        if (!p.isActive()) continue;
        float dx = p.getPosition().x - pos.x;
        float dy = p.getPosition().y - pos.y;
        float distSq = dx * dx + dy * dy;
        if (distSq < minDistSq) {
            minDistSq = distSq;
            nearest = &p;
        }
    }
    return nearest ? nearest : &m_players[0];
}

void PlayingState::rebuildBlockedCells() {
    m_blockedCells.clear();
    for (const auto& obs : m_obstacles) {
        if (!obs->isActive() || !obs->hasCollision()) continue;
        sf::FloatRect b = obs->getBounds();
        int x0 = static_cast<int>(std::floor(b.left / kBlockedCellSize));
        int x1 = static_cast<int>(std::floor((b.left + b.width) / kBlockedCellSize));
        int y0 = static_cast<int>(std::floor(b.top / kBlockedCellSize));
        int y1 = static_cast<int>(std::floor((b.top + b.height) / kBlockedCellSize));
        for (int gx = x0; gx <= x1; ++gx) {
            for (int gy = y0; gy <= y1; ++gy) {
                m_blockedCells.insert((static_cast<long long>(gx) << 32) ^ static_cast<unsigned int>(gy));
            }
        }
    }
}

bool PlayingState::findFreeSpawnPos(const sf::Vector2f& center, float radius, sf::Vector2f& out) const {
    // Try random angles around the ring, then a full sweep, before giving up.
    // Spawning inside a wall used to leave the enemy stranded there, and with the
    // horde cheat those strays accumulated into solid blocks of stuck enemies.
    for (int attempt = 0; attempt < 12; ++attempt) {
        float angle = (std::rand() % 360) * 3.14159f / 180.f;
        sf::Vector2f p(center.x + std::cos(angle) * radius, center.y + std::sin(angle) * radius);
        if (!isBlocked(p)) { out = p; return true; }
    }
    for (int deg = 0; deg < 360; deg += 5) {
        float angle = deg * 3.14159f / 180.f;
        sf::Vector2f p(center.x + std::cos(angle) * radius, center.y + std::sin(angle) * radius);
        if (!isBlocked(p)) { out = p; return true; }
    }
    return false;
}

bool PlayingState::isBlocked(const sf::Vector2f& worldPos) const {
    int gx = static_cast<int>(std::floor(worldPos.x / kBlockedCellSize));
    int gy = static_cast<int>(std::floor(worldPos.y / kBlockedCellSize));
    return m_blockedCells.count((static_cast<long long>(gx) << 32) ^ static_cast<unsigned int>(gy)) > 0;
}

int PlayingState::getHighestPlayerLevel() const {
    int highest = 1;
    for (const auto& p : m_players) {
        if (p.isActive() && p.getLevel() > highest) highest = p.getLevel();
    }
    return highest;
}

void PlayingState::addWeapon(const std::string& weaponName) {
    addWeaponForPlayer(0, weaponName);
}

void PlayingState::addWeaponForPlayer(size_t playerIdx, const std::string& weaponName) {
    auto newWeapon = WeaponFactory::createWeapon(weaponName);
    if (newWeapon) {
        m_weapons.push_back(std::move(newWeapon));
        m_weaponOwnerIndices.push_back(playerIdx);
    }
}

void PlayingState::removeWeaponForPlayer(size_t playerIdx, const std::string& weaponName) {
    // Erase from both parallel arrays together, back to front so earlier indices stay valid.
    for (size_t i = m_weapons.size(); i-- > 0; ) {
        size_t owner = (i < m_weaponOwnerIndices.size()) ? m_weaponOwnerIndices[i] : 0;
        if (owner != playerIdx || m_weapons[i]->getName() != weaponName) continue;

        // Drop projectiles still pointing at the weapon we are about to destroy.
        for (auto& proj : m_activeProjectiles) {
            if (proj.getSourceWeapon() == m_weapons[i].get()) {
                proj.setSourceWeapon(nullptr);
            }
        }
        m_weapons.erase(m_weapons.begin() + i);
        if (i < m_weaponOwnerIndices.size()) {
            m_weaponOwnerIndices.erase(m_weaponOwnerIndices.begin() + i);
        }
    }
}

void PlayingState::evolveWeaponForPlayer(size_t playerIdx, const std::string& baseName, const std::string& evolvedName) {
    // Remove the base weapon first so a shared name cannot erase the replacement.
    removeWeaponForPlayer(playerIdx, baseName);
    m_bannedWeapons.insert(baseName);
    addWeaponForPlayer(playerIdx, evolvedName);
}

std::set<std::string> PlayingState::getOwnedWeaponNames(size_t playerIdx) const {
    std::set<std::string> names;
    for (size_t i = 0; i < m_weapons.size(); ++i) {
        size_t owner = (i < m_weaponOwnerIndices.size()) ? m_weaponOwnerIndices[i] : 0;
        if (owner == playerIdx) {
            names.insert(m_weapons[i]->getName());
        }
    }
    return names;
}

std::vector<WeaponBase*> PlayingState::getUpgradeableWeapons(size_t playerIdx) {
    std::vector<WeaponBase*> result;
    for (size_t i = 0; i < m_weapons.size(); ++i) {
        size_t owner = (i < m_weaponOwnerIndices.size()) ? m_weaponOwnerIndices[i] : 0;
        if (owner == playerIdx && !m_weapons[i]->isMaxLevel()) {
            result.push_back(m_weapons[i].get());
        }
    }
    return result;
}

std::vector<WeaponBase*> PlayingState::getWeaponsForPlayer(size_t playerIdx) const {
    std::vector<WeaponBase*> result;
    for (size_t i = 0; i < m_weapons.size(); ++i) {
        size_t owner = (i < m_weaponOwnerIndices.size()) ? m_weaponOwnerIndices[i] : 0;
        if (owner == playerIdx) {
            result.push_back(m_weapons[i].get());
        }
    }
    return result;
}

// --- Passive Item Methods ---

std::vector<PassiveItem>& PlayingState::getPassiveItems(size_t playerIdx) {
    if (m_playerPassiveItems.empty()) {
        m_playerPassiveItems.push_back(createDefaultPassiveItems());
    }
    if (playerIdx >= m_playerPassiveItems.size()) {
        return m_playerPassiveItems[0];
    }
    return m_playerPassiveItems[playerIdx];
}

const std::vector<PassiveItem>& PlayingState::getPassiveItems(size_t playerIdx) const {
    if (m_playerPassiveItems.empty()) {
        static std::vector<PassiveItem> dummy = createDefaultPassiveItems();
        return dummy;
    }
    if (playerIdx >= m_playerPassiveItems.size()) {
        return m_playerPassiveItems[0];
    }
    return m_playerPassiveItems[playerIdx];
}

void PlayingState::addOrUpgradePassive(const std::string& name, size_t playerIdx) {
    auto& passives = getPassiveItems(playerIdx);
    for (auto& p : passives) {
        if (p.name == name) {
            if (p.level < p.maxLevel) {
                p.level++;
                // Tiragisu grants an extra revival charge the moment it is picked up.
                if (p.statType == "revival") {
                    getPlayer(playerIdx).addRevival(static_cast<int>(p.bonusPerLevel));
                }
                std::cout << "Player " << (playerIdx + 1) << " Passive " << name << " now level " << p.level << "\n";
            }
            return;
        }
    }
}

std::set<std::string> PlayingState::getOwnedPassiveNames(size_t playerIdx) const {
    std::set<std::string> names;
    const auto& passives = getPassiveItems(playerIdx);
    for (const auto& p : passives) {
        if (p.isOwned()) names.insert(p.name);
    }
    return names;
}

float PlayingState::getPassiveStatBonus(size_t playerIdx, const std::string& statType) const {
    float total = 0.f;
    for (const auto& p : getPassiveItems(playerIdx)) {
        if (p.isOwned() && p.statType == statType) {
            total += p.level * p.bonusPerLevel;
        }
    }
    return total;
}

float PlayingState::getRunCurseMultiplier() const {
    float highest = 0.f;
    for (size_t i = 0; i < m_players.size(); ++i) {
        if (!m_players[i].isActive()) continue;
        highest = std::max(highest, getPassiveStatBonus(i, "curse"));
    }
    return 1.f + highest;
}

float PlayingState::getPassiveDamageMultiplier(size_t playerIdx) const {
    float mult = 1.f;
    for (const auto& p : getPassiveItems(playerIdx)) {
        if (p.isOwned() && p.statType == "damage") {
            mult += p.level * p.bonusPerLevel;
        }
    }
    return mult;
}

float PlayingState::getPassiveCooldownMultiplier(size_t playerIdx) const {
    float mult = 1.f;
    for (const auto& p : getPassiveItems(playerIdx)) {
        if (p.isOwned() && p.statType == "cooldown") {
            mult -= p.level * p.bonusPerLevel;
        }
    }
    return std::max(0.1f, mult);
}

float PlayingState::getPassiveProjSpeedMultiplier(size_t playerIdx) const {
    float mult = 1.f;
    for (const auto& p : getPassiveItems(playerIdx)) {
        if (p.isOwned() && p.statType == "projSpeed") {
            mult += p.level * p.bonusPerLevel;
        }
    }
    return mult;
}

float PlayingState::getPassiveAreaMultiplier(size_t playerIdx) const {
    float mult = 1.f;
    for (const auto& p : getPassiveItems(playerIdx)) {
        if (p.isOwned() && p.statType == "area") {
            mult += p.level * p.bonusPerLevel;
        }
    }
    return mult;
}

float PlayingState::getPassiveMaxHealthMultiplier(size_t playerIdx) const {
    float mult = 1.f;
    for (const auto& p : getPassiveItems(playerIdx)) {
        if (p.isOwned() && p.statType == "maxHealth") {
            mult += p.level * p.bonusPerLevel;
        }
    }
    return mult;
}

// --- Evolution ---

void PlayingState::tryEvolveWeapon(size_t playerIdx) {
    int recipeIdx = findAvailableEvolution(getWeaponsForPlayer(playerIdx), getPassiveItems(playerIdx));
    if (recipeIdx < 0) {
        // No evolution available - give a free level-up instead
        std::cout << "No evolution available. Granting free level-up.\n";
        m_manager->pushState(std::make_unique<LevelUpState>(m_manager, this, playerIdx));
        return;
    }

    const auto& recipe = getEvolutionRecipes()[recipeIdx];
    std::cout << "EVOLUTION! " << recipe.baseWeapon << " -> " << recipe.evolvedWeapon
              << " (player " << (playerIdx + 1) << ")\n";

    evolveWeaponForPlayer(playerIdx, recipe.baseWeapon, recipe.evolvedWeapon);
}

void PlayingState::generateLibraryObstacles() {
    m_obstacles.clear();
    
    // Customize your furniture texture rectangle coordinates from LibraryTexturePacked.png (512x512) here!
    sf::IntRect pianoRect(384, 128, 48, 48);
    sf::IntRect tableRect(320, 128, 32, 32);
    
    // Place furniture regularly along the horizontal library corridor
    for (float x = -3000.f; x <= 3000.f; x += 500.f) {
        if (std::abs(x) < 250.f) continue; // Keep player spawning center area clear of obstacles!
        
        // Upper corridor lane (Y = 780) - Alternating Table and Piano
        if (static_cast<int>(std::abs(x) / 500.f) % 2 == 0) {
            m_obstacles.push_back(std::make_unique<Obstacle>(sf::Vector2f(x, 780.f), m_libraryPropsTex, tableRect, 2.5f, 0.35f));
        } else {
            m_obstacles.push_back(std::make_unique<Obstacle>(sf::Vector2f(x, 780.f), m_libraryPropsTex, pianoRect, 2.5f, 0.4f));
        }
        
        // Lower corridor lane (Y = 1260) - Alternating Piano and Table
        if (static_cast<int>(std::abs(x) / 500.f) % 2 != 0) {
            m_obstacles.push_back(std::make_unique<Obstacle>(sf::Vector2f(x + 250.f, 1260.f), m_libraryPropsTex, tableRect, 2.5f, 0.35f));
        } else {
            m_obstacles.push_back(std::make_unique<Obstacle>(sf::Vector2f(x + 250.f, 1260.f), m_libraryPropsTex, pianoRect, 2.5f, 0.4f));
        }
    }
    std::cout << "Generated " << m_obstacles.size() << " interactive physical furniture obstacle props along Inlaid Library corridor!\n";
}
