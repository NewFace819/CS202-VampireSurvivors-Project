#include "State/PlayingState.h"
#include "State/PauseState.h"
#include "State/LevelUpState.h"
#include "State/TreasureChestState.h"
#include "State/MainMenuState.h"
#include "Engine/GameManager.h"
#include "Engine/StatsManager.h"
#include "Weapons/MagicWand.h"
#include "Weapons/Whip.h"
#include "Weapons/Knife.h"
#include "Weapons/FireWand.h"
#include "Weapons/Axe.h"
#include "Weapons/BloodyTear.h"
#include "Weapons/HolyWand.h"
#include "Weapons/ThousandEdge.h"
#include "Weapons/Hellfire.h"
#include "Weapons/DeathSpiral.h"
#include "Entities/ExpGem.h"
#include "Entities/Coin.h"
#include "Entities/FloorChicken.h"
#include <nlohmann/json.hpp>
#include <fstream>
#include "Physics/Collision.h"
#include "Physics/Physics.h"
#include "Items/EvolutionRegistry.h"
#include <cstdlib>
#include <algorithm>
#include <iostream>

#include "Engine/ProfileManager.h"

PlayingState::PlayingState(GameManager* manager, CharacterType charType, StageType stageType) 
    : m_manager(manager), m_grid(100.0f), m_enemyPool(500), m_shooterPool(150), m_stageType(stageType) { 

    if (!m_font.loadFromFile("assets/ExportedProject/Assets/Font/Courier_HintedSmooth.ttf")) {
        std::cerr << "PlayingState: Could not load font!\n";
    }
    
    if (!m_itemsTex.loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/items.png")) {
        std::cerr << "PlayingState: Could not load items texture!\n";
    }
    m_enemiesTex.loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/enemies.png");
    m_enemiesTex.setSmooth(false);
    m_vfxTex.loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/vfx.png");

    std::string waveJsonPath = "assets/data/mad_forest.json";
    std::string bgPath = "assets/ExportedProject/Assets/App/Art/Sprites/Addressable/backgrounds/bg_forest.png";

    if (m_stageType == StageType::InlaidLibrary) {
        waveJsonPath = "assets/data/inlaid_library.json";
        bgPath = "assets/ExportedProject/Assets/App/Art/Sprites/Addressable/backgrounds/bg_library.png";
        if (!m_libraryPropsTex.loadFromFile("assets/ExportedProject/Assets/Texture2D/LibraryTexturePacked.png")) {
            std::cerr << "PlayingState: Could not load LibraryTexturePacked.png!\n";
        }
        generateLibraryObstacles();
    }

    // Load background tile
    if (!m_bgTex.loadFromFile(bgPath)) {
        std::cerr << "PlayingState: Could not load background texture: " << bgPath << "\n";
    }
    m_bgTex.setRepeated(false);
    m_tileSize = 2048.f; // 1024 texture * 2x scale
    // Initialize 3x3 grid of tiles: center tile (1,1) sits at world origin
    for (int row = 0; row < 3; ++row) {
        for (int col = 0; col < 3; ++col) {
            m_bgTiles[row][col].setTexture(m_bgTex);
            m_bgTiles[row][col].setScale(2.f, 2.f);
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

    m_revivalsLeft = ProfileManager::GetInstance().getRevivalBonus();
    m_runGold = 0;

    // Initialize passive items pool
    m_passiveItems = createDefaultPassiveItems();
    
    m_levelText.setFont(m_font);
    m_levelText.setCharacterSize(8);
    m_levelText.setFillColor(sf::Color::White);
    m_levelText.setStyle(sf::Text::Bold);

    // Load characters_atlas.json
    nlohmann::json charAtlas;
    std::ifstream atlasFile("assets/characters_atlas.json");
    if (atlasFile.is_open()) {
        atlasFile >> charAtlas;
        atlasFile.close();
    } else {
        std::cerr << "PlayingState: Could not open assets/characters_atlas.json\n";
    }

    auto getFrames = [&](const std::string& name) -> std::vector<sf::IntRect> {
        std::vector<sf::IntRect> frames;
        if (charAtlas.contains(name) && charAtlas[name].contains("frames")) {
            for (const auto& f : charAtlas[name]["frames"]) {
                frames.push_back(sf::IntRect(f["x"], f["y"], f["width"], f["height"]));
            }
        }
        return frames;
    };

    switch (charType) {
        case CharacterType::Antonio:
            m_player.setSprite("assets/ExportedProject/Assets/Resources/spritesheets/characters.png", 
                               getFrames("Antonio"));
            m_weapons.push_back(std::make_unique<Whip>());
            break;
        case CharacterType::Imelda:
            m_player.setSprite("assets/ExportedProject/Assets/Resources/spritesheets/characters.png", 
                               getFrames("Imelda"));
            m_weapons.push_back(std::make_unique<MagicWand>());
            break;
        case CharacterType::Gennaro:
            m_player.setSprite("assets/ExportedProject/Assets/Resources/spritesheets/characters.png", 
                               getFrames("Gennaro"));
            m_weapons.push_back(std::make_unique<Knife>());
            break;
        case CharacterType::Arca:
            m_player.setSprite("assets/ExportedProject/Assets/Resources/spritesheets/characters.png", 
                               getFrames("Arca"));
            m_weapons.push_back(std::make_unique<FireWand>());
            break;
        case CharacterType::Lama:
            m_player.setSprite("assets/ExportedProject/Assets/Resources/spritesheets/characters.png", 
                               getFrames("Lama"));
                               //{{0, 0, 32, 32}, {32, 0, 32, 32}, {64, 32, 32, 32}, {64, 64, 32, 32}});
            m_weapons.push_back(std::make_unique<Axe>());
            break;
        case CharacterType::Sigma:
            m_player.setSprite("assets/ExportedProject/Assets/Resources/spritesheets/characters.png", 
                               getFrames("Sigma"));
            m_weapons.push_back(std::make_unique<Whip>());
            m_weapons.push_back(std::make_unique<MagicWand>());
            m_weapons.push_back(std::make_unique<Knife>());
            m_weapons.push_back(std::make_unique<FireWand>());
            m_weapons.push_back(std::make_unique<Axe>());
            break;
    }

    if (m_stageType == StageType::InlaidLibrary) {
        m_player.setPosition(640.f, 1024.f);
    }
}

void PlayingState::enter() {
    StatsManager::GetInstance().reset();
}

void PlayingState::update(float dt) {
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Escape)) {
        m_manager->changeState(std::make_unique<MainMenuState>(m_manager));
        return; 
    }
    // Update infinite background tiles: snap any tile that drifts too far from camera
    {
        sf::Vector2f cam = m_player.getPosition();
        // For each tile, if it's more than 1.5 tile-widths away in any axis, wrap it
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
            m_weapons.push_back(std::make_unique<Whip>());
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
        
        // Add & Max all weapons
        std::vector<std::string> baseWeapons = {"Whip", "Magic Wand", "Knife", "Fire Wand", "Axe"};
        for (const auto& wName : baseWeapons) {
            WeaponBase* found = nullptr;
            for (auto& w : m_weapons) {
                if (w->getName() == wName) {
                    found = w.get();
                    break;
                }
            }
            if (!found) {
                addWeapon(wName);
                found = m_weapons.back().get();
            }
            while (!found->isMaxLevel()) {
                found->levelUp();
            }
        }

        // Max all passives
        std::vector<std::string> passives = {"Hollow Heart", "Empty Tome", "Bracer", "Spinach", "Candelabrador"};
        for (const auto& pName : passives) {
            for (int level = 0; level < 5; ++level) {
                addOrUpgradePassive(pName);
            }
        }
        
        std::cout << "CHEAT: All weapons and passives maxed!\n";
    }

    // Cheat Code: Alt+T = Spawn Treasure Chest 150px to the right of player for testing evolutions
    static bool tPressedLastFrame = false;
    bool tPressed = sf::Keyboard::isKeyPressed(sf::Keyboard::LAlt) && sf::Keyboard::isKeyPressed(sf::Keyboard::T);
    if (tPressed && !tPressedLastFrame) {
        TreasureChest chest;
        chest.init(m_player.getPosition() + sf::Vector2f(150.f, 0.f));
        m_chests.push_back(chest);
        std::cout << "CHEAT: Spawned a treasure chest 150px to the right of player!\n";
    }
    tPressedLastFrame = tPressed;

    m_player.update(dt);

    if (m_stageType == StageType::InlaidLibrary) {
        sf::Vector2f pos = m_player.getPosition();
        // The library floor is in y range [576, 1472] in world space.
        // We clamp the player to stay within the floor with a 64px margin: [640.f, 1408.f]
        float minY = 640.f;
        float maxY = 1408.f;
        if (pos.y < minY) {
            m_player.setPosition(pos.x, minY);
        } else if (pos.y > maxY) {
            m_player.setPosition(pos.x, maxY);
        }

        // Resolve Circle-AABB sliding collisions with furniture obstacles
        sf::Vector2f playerPos = m_player.getPosition();
        float playerRadius = 16.f; // Player physical collision circle
        for (const auto& obs : m_obstacles) {
            if (obs->isActive() && Collision::checkCircleAABB(playerPos, playerRadius, obs->getBounds())) {
                Collision::resolveCircleAABB(playerPos, playerRadius, m_player.getVelocity(), obs->getBounds());
            }
        }
        m_player.setPosition(playerPos);
    }

    // Apply Recovery Upgrade (HP regen)
    float recovery = ProfileManager::GetInstance().getRecoveryRate();
    if (recovery > 0.f) {
        StatsManager::GetInstance().heal(recovery * dt);
    }

    // Update weapons (firing projectiles)
    for (auto& weapon : m_weapons) {
        weapon->update(dt, m_player.getPosition(), m_player.getFacingDir(), m_activeEnemies, m_activeProjectiles);
    }

    // Update projectiles
    for (auto& proj : m_activeProjectiles) {
        proj.update(dt);
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


    char levelBuffer[16];
    std::snprintf(levelBuffer, sizeof(levelBuffer), "LV %d", StatsManager::GetInstance().getLevel());
    m_levelText.setString(levelBuffer);

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
                float spawnX = m_player.getPosition().x;
                float spawnY = m_player.getPosition().y - 1200.f; // Spawn above
                
                int playerLevel = StatsManager::GetInstance().getLevel();
                if (stats.hpPerLevel > 0.f) {
                    stats.maxHp += stats.hpPerLevel * playerLevel;
                    stats.hp = stats.maxHp;
                }
                
                boss->init(sf::Vector2f(spawnX, spawnY), stats, &m_enemiesTex);
                boss->setTarget(&m_player);
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

    // Update & check chest pickup
    for (auto& chest : m_chests) {
        chest.update(dt);
        if (chest.isActive() && chest.getBounds().intersects(m_player.getBounds())) {
            chest.deactivate();
            m_manager->pushState(std::make_unique<TreasureChestState>(m_manager, this));
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
        if (currentCount < currentWave->minEnemies) {
            shouldSpawn = true;
            toSpawn = currentWave->minEnemies - currentCount;
            // Cap at 20 per frame to avoid lag spikes
            if (toSpawn > 20) toSpawn = 20; 
        } else if (m_enemySpawnTimer >= currentWave->spawnInterval) {
            shouldSpawn = true;
            toSpawn = 1; // Or spawn a batch
            m_enemySpawnTimer = 0.f;
        }

        if (shouldSpawn) {
            for (int i = 0; i < toSpawn; ++i) {
                // Randomly select an enemy type from the wave's possible enemies
                std::string type = currentWave->enemies[rand() % currentWave->enemies.size()];
                EnemyStats stats = EnemyDatabase::getStats(type);

                EnemyBase* enemy = nullptr;
                if (stats.shootCooldown > 0.f) {
                    enemy = m_shooterPool.acquire();
                } else {
                    enemy = m_enemyPool.acquire();
                }

                if (enemy) {
                    float angle = static_cast<float>(rand() % 360) * 3.14159f / 180.f;
                    float spawnX = m_player.getPosition().x + std::cos(angle) * 800.f;
                    float spawnY = m_player.getPosition().y + std::sin(angle) * 800.f;

                    int playerLevel = StatsManager::GetInstance().getLevel();
                    if (stats.hpPerLevel > 0.f) {
                        stats.maxHp += stats.hpPerLevel * playerLevel;
                        stats.hp = stats.maxHp;
                    }

                    enemy->init(sf::Vector2f(spawnX, spawnY), stats, &m_enemiesTex);
                    enemy->setTarget(&m_player);
                    m_activeEnemies.push_back(enemy);
                }
            }
        }
    }

    // 1. Clear grid and insert all active enemies
    m_grid.clear();
    for (auto* enemy : m_activeEnemies) {
        if (enemy->isActive()) {
            m_grid.insertEntity(enemy);
        }
    }

    // Process collisions and update enemies
    for (auto it = m_activeEnemies.begin(); it != m_activeEnemies.end(); ) {
        EnemyBase* enemy = *it;
        if (!enemy->isActive()) {
            // Spawn a random Collectible when an enemy dies
            int roll = std::rand() % 100;
            if (roll < 70) {
                // 70% Gem
                if (enemy->getStats().expDrop > 0.0f) {
                    auto gem = std::make_unique<ExpGem>();
                    gem->init(enemy->getPosition(), enemy->getStats().expDrop);
                    m_activeCollectibles.push_back(std::move(gem));
                }
            } else if (roll < 80) {
                // 10% Coin (value between 5 and 15)
                auto coin = std::make_unique<Coin>();
                int goldValue = 5 + (std::rand() % 11);
                coin->init(enemy->getPosition(), goldValue);
                m_activeCollectibles.push_back(std::move(coin));
            } else if (roll < 85) {
                // 5% Floor Chicken
                auto chicken = std::make_unique<FloorChicken>();
                chicken->init(enemy->getPosition(), 30.f); // Heals 30 HP
                m_activeCollectibles.push_back(std::move(chicken));
            }
            // 15% nothing

            if (auto* shooter = dynamic_cast<ShooterEnemy*>(enemy)) {
                m_shooterPool.release(shooter);
            } else {
                m_enemyPool.release(enemy);
            }
            it = m_activeEnemies.erase(it);
            continue;
        } 
        
        enemy->update(dt);

        if (m_stageType == StageType::InlaidLibrary) {
            sf::Vector2f epos = enemy->getPosition();
            // Clamp enemy Y to floor corridor [576, 1472] with a 24px margin: [600.f, 1448.f]
            float minEY = 600.f;
            float maxEY = 1448.f;
            if (epos.y < minEY) {
                enemy->setPosition(epos.x, minEY);
            } else if (epos.y > maxEY) {
                enemy->setPosition(epos.x, maxEY);
            }
        }
        
        if (enemy->getStats().enemyClass == EnemyClass::BOSS) {
            enemy->updateShooting(dt, m_player.getPosition(), m_bossProjectiles, &m_vfxTex);
        }
        
        // Check distance to player. If very close, ignore enemy-enemy collision so they can swarm the player tightly.
        sf::Vector2f toPlayer = enemy->getPosition() - m_player.getPosition();
        float distToPlayerSq = toPlayer.x * toPlayer.x + toPlayer.y * toPlayer.y;

        if (auto* shooter = dynamic_cast<ShooterEnemy*>(enemy)) {
            if (shooter->wantsToShoot()) {
                shooter->resetShootFlag();
                if (distToPlayerSq < 1000.f * 1000.f) {
                    sf::Vector2f dir = -toPlayer;
                    float len = std::sqrt(dir.x * dir.x + dir.y * dir.y);
                    if (len > 0.f) {
                        dir /= len;
                        Projectile proj;
                        proj.init(enemy->getPosition(), dir, enemy->getStats().projectileDamage, enemy->getStats().projectileSpeed, 1200.f, 5.f, false);
                        proj.setEnemyProj(true);
                        proj.setFillColor(sf::Color(220, 80, 220)); // Purple magic bullet
                        m_activeProjectiles.push_back(proj);
                    }
                }
            }
        }
        
        // --- Enemy-Enemy Soft Collision (Separation) ---
        auto neighbors = m_grid.getNeighbors(enemy->getPosition());
        for (EnemyBase* other : neighbors) {
            if (other != enemy && other->isActive()) {
                sf::Vector2f diff = enemy->getPosition() - other->getPosition();
                float distSq = diff.x * diff.x + diff.y * diff.y;
                float combinedRadius = enemy->getRadius() + other->getRadius();
                if (distSq > 0.0001f && distSq < (combinedRadius * combinedRadius)) {
                    float dist = std::sqrt(distSq);
                    float overlap = combinedRadius - dist;
                    // Push them apart
                    sf::Vector2f pushDir = diff / dist;
                    enemy->setPosition(enemy->getPosition() + pushDir * (overlap * 0.5f));
                }
            }
        }
        
        // Simple O(N*M) collision check for now (Grid will be wired later)
        sf::FloatRect enemyBounds = enemy->getBounds();
        
        // Check collision with Player (Damage)
        if (enemyBounds.intersects(m_player.getBounds())) {
            float armorRed = ProfileManager::GetInstance().getArmorReduction();
            float dmg = std::max(1.f, 10.f - armorRed);
            StatsManager::GetInstance().takeDamage(dmg * dt); // 10 damage per second while touching, reduced by armor
        }

        // Enemy-Player Physical Collision (Separation)
        float playerRadius = 15.f;
        float enemyRadius = enemy->getRadius();
        float combinedRadiusPlayer = playerRadius + enemyRadius;
        if (distToPlayerSq > 0.0001f && distToPlayerSq < (combinedRadiusPlayer * combinedRadiusPlayer)) {
            float dist = std::sqrt(distToPlayerSq);
            float overlap = combinedRadiusPlayer - dist;
            sf::Vector2f pushDir = toPlayer / dist; // From player to enemy
            enemy->setPosition(enemy->getPosition() + pushDir * overlap);
        }

        for (auto& proj : m_activeProjectiles) {
            if (proj.isActive() && !proj.isEnemyProj() && proj.getBounds().intersects(enemyBounds)) {
                // Apply Damage & Knockback
                bool killed = enemy->takeDamage(proj.getDamage());
                Physics::ApplyKnockback(enemy, proj.getDirection(), proj.getKnockback(), 1.0f);
                
                // Bloody Tear lifesteal
                if (proj.getKnockback() == 150.f) {
                    StatsManager::GetInstance().heal(8.f);
                }
                
                if (!proj.isPiercing()) {
                    proj.deactivate();
                }
            }
        }
        ++it;
    }

    // Check enemy projectile collisions with player
    for (auto& proj : m_activeProjectiles) {
        if (proj.isActive() && proj.isEnemyProj()) {
            if (proj.getBounds().intersects(m_player.getBounds())) {
                float armorRed = ProfileManager::GetInstance().getArmorReduction();
                float dmg = std::max(1.f, proj.getDamage() - armorRed);
                StatsManager::GetInstance().takeDamage(dmg);
                proj.deactivate();
            }
        }
    }

    // Update collectibles and handle collection
    for (auto& item : m_activeCollectibles) {
        item->update(dt, &m_player);
        if (item->isActive() && item->getBounds().intersects(m_player.getBounds())) {
            item->onPickup(this);
        }
    }

    // Clean up dead collectibles
    m_activeCollectibles.erase(std::remove_if(m_activeCollectibles.begin(), m_activeCollectibles.end(),
        [](const std::unique_ptr<Collectible>& c) { return !c->isActive(); }), m_activeCollectibles.end());


    // Collision check: Boss Projectiles vs Player
    for (auto& proj : m_bossProjectiles) {
        if (proj.isActive() && proj.getBounds().intersects(m_player.getBounds())) {
            float armorRed = ProfileManager::GetInstance().getArmorReduction();
            float dmg = std::max(1.f, proj.getDamage() - armorRed);
            StatsManager::GetInstance().takeDamage(dmg);
            proj.deactivate();
        }
    }

    // Clean up dead projectiles
    m_activeProjectiles.erase(std::remove_if(m_activeProjectiles.begin(), m_activeProjectiles.end(),
        [](const Projectile& p) { return !p.isActive(); }), m_activeProjectiles.end());

    m_bossProjectiles.erase(std::remove_if(m_bossProjectiles.begin(), m_bossProjectiles.end(),
        [](const Projectile& p) { return !p.isActive(); }), m_bossProjectiles.end());

    // Update gold HUD text
    m_goldText.setString("GOLD: " + std::to_string(m_runGold));

    // Detect player level-up and show the upgrade screen
    int currentLevel = StatsManager::GetInstance().getLevel();
    if (currentLevel > m_lastLevel) {
        m_lastLevel = currentLevel;
        m_manager->pushState(std::make_unique<LevelUpState>(m_manager, this));
    }

    // Check Player Death / Revival
    if (StatsManager::GetInstance().getHealth() <= 0.f) {
        if (m_revivalsLeft > 0) {
            m_revivalsLeft--;
            // Heal to 50% max health
            StatsManager::GetInstance().heal(StatsManager::GetInstance().getMaxHealth() * 0.5f);
            
            // Revival blast: deactivate all active enemies in a 450px radius
            for (auto* enemy : m_activeEnemies) {
                sf::Vector2f diff = enemy->getPosition() - m_player.getPosition();
                float distSq = diff.x * diff.x + diff.y * diff.y;
                if (distSq < 450.f * 450.f) {
                    enemy->setActive(false);
                }
            }
            std::cout << "Resurrected! Revivals left: " << m_revivalsLeft << "\n";
        } else {
            // Game Over
            ProfileManager::GetInstance().save("save.txt");
            m_manager->changeState(std::make_unique<MainMenuState>(m_manager));
            return;
        }
    }
}

void PlayingState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color(20, 50, 20));

    // Create and apply World View centered on player
    sf::View worldView = window.getDefaultView();
    worldView.setCenter(m_player.getPosition());
    window.setView(worldView);

    // Draw infinite-tiling background before everything else
    for (int row = 0; row < 3; ++row)
        for (int col = 0; col < 3; ++col)
            window.draw(m_bgTiles[row][col]);

    // Draw obstacles behind player (above in Y world coordinates) for 2.5D depth
    for (const auto& obs : m_obstacles) {
        if (obs->isActive() && obs->getPosition().y <= m_player.getPosition().y + 10.f) {
            obs->draw(window);
        }
    }
    
    for (auto& item : m_activeCollectibles) {
        item->draw(window);
    }

    
    for (auto* enemy : m_activeEnemies) {
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

    m_player.draw(window);

    // Draw obstacles in front of player (below in Y world coordinates) for 2.5D occlusion
    for (const auto& obs : m_obstacles) {
        if (obs->isActive() && obs->getPosition().y > m_player.getPosition().y + 10.f) {
            obs->draw(window);
        }
    }

    // Health Bar Background (under character)
    StatsManager& stats = StatsManager::GetInstance();
    float hpBarWidth = 40.f;
    float hpBarHeight = 6.f;
    sf::Vector2f playerPos = m_player.getPosition();
    
    sf::RectangleShape hpBg(sf::Vector2f(hpBarWidth, hpBarHeight));
    hpBg.setPosition(playerPos.x - hpBarWidth / 2.f, playerPos.y + 25.f);
    hpBg.setFillColor(sf::Color(50, 0, 0));
    hpBg.setOutlineThickness(1.f);
    hpBg.setOutlineColor(sf::Color::Black);
    window.draw(hpBg);

    // Health Bar Fill
    float hpPercent = std::max(0.f, stats.getHealth() / stats.getMaxHealth());
    sf::RectangleShape hpFill(sf::Vector2f(hpBarWidth * hpPercent, hpBarHeight));
    hpFill.setPosition(playerPos.x - hpBarWidth / 2.f, playerPos.y + 25.f);
    hpFill.setFillColor(sf::Color::Red);
    window.draw(hpFill);

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
    


    // EXP Bar Background (Bottom of screen)
    float expBarWidth = windowSize.x - 40.f;
    sf::RectangleShape expBg(sf::Vector2f(expBarWidth, 10.f));
    expBg.setPosition(20.f, windowSize.y - 20.f);
    expBg.setFillColor(sf::Color(0, 0, 50));
    window.draw(expBg);

    // Draw HUD - Weapons
    float startX = 20.f; 
    float startY = 20.f;
    float padding = 10.f;
    float boxWidth = 38.f;
    float boxHeight = 66.f;
    
    for (size_t i = 0; i < m_weapons.size(); ++i) {
        float x = startX + i * (boxWidth + padding);
        float y = startY; 
        
        // Draw weapon box (grey bg, gold border)
        sf::RectangleShape bg(sf::Vector2f(boxWidth, boxHeight));
        bg.setPosition(x, y);
        bg.setFillColor(sf::Color(160, 160, 160, 220)); // Greyish with some transparency
        bg.setOutlineThickness(2.f);
        bg.setOutlineColor(sf::Color(228, 199, 109));
        window.draw(bg);
        
        // Draw icon (at top of box)
        sf::Sprite iconSprite;
        iconSprite.setTexture(m_itemsTex);
        std::string name = m_weapons[i]->getName();
        sf::IntRect texRect;
        if (name == "Whip")            texRect = sf::IntRect(396, 790, 16, 16);
        else if (name == "Magic Wand") texRect = sf::IntRect(472, 793, 16, 16);
        else if (name == "Knife")      texRect = sf::IntRect(116, 858, 16, 11);
        else if (name == "Fire Wand")  texRect = sf::IntRect(434, 788, 16, 16);
        else if (name == "Axe")        texRect = sf::IntRect(485, 660, 16, 16);
        else if (name == "Bloody Tear") {
            texRect = sf::IntRect(396, 790, 16, 16); // Whip icon
            iconSprite.setColor(sf::Color(255, 100, 100)); // Red tinted
        }
        else if (name == "Holy Wand")    texRect = sf::IntRect(491, 793, 16, 16);
        else if (name == "Thousand Edge") texRect = sf::IntRect(2, 801, 16, 16);
        else if (name == "Hellfire")     texRect = sf::IntRect(99, 767, 16, 16);
        else if (name == "Death Spiral")  texRect = sf::IntRect(396, 752, 16, 16);
        else texRect = sf::IntRect(0, 0, 16, 16);

        
        iconSprite.setTextureRect(texRect);
        
        float iconScale = 2.f; 
        iconSprite.setScale(iconScale, iconScale);
        float iconW = texRect.width * iconScale;
        
        iconSprite.setPosition(x + (boxWidth - iconW) / 2.f, y + 2.f);
        window.draw(iconSprite);
        
        // Draw level grid
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
                cell.setFillColor(sf::Color(255, 230, 80)); // Gold/Yellow
            } else {
                cell.setFillColor(sf::Color::Black);
            }
            cell.setOutlineThickness(1.f);
            cell.setOutlineColor(sf::Color(228, 199, 109));
            window.draw(cell);
        }
    }

    // Draw HUD - Passive Items (below weapons)
    float passiveStartY = startY + boxHeight + 10.f;
    size_t ownedIdx = 0;
    for (size_t i = 0; i < m_passiveItems.size(); ++i) {
        if (!m_passiveItems[i].isOwned()) continue;
        float x = startX + ownedIdx * (boxWidth + padding);
        float y = passiveStartY;
        ++ownedIdx;

        // Draw box (greenish bg, green border) — same size as weapon boxes
        sf::RectangleShape bg(sf::Vector2f(boxWidth, boxHeight));
        bg.setPosition(x, y);
        bg.setFillColor(sf::Color(50, 100, 50, 220));
        bg.setOutlineThickness(2.f);
        bg.setOutlineColor(sf::Color(100, 200, 100));
        window.draw(bg);

        // Draw icon (at top of box)
        sf::Sprite iconSprite;
        iconSprite.setTexture(m_itemsTex);
        iconSprite.setTextureRect(m_passiveItems[i].iconRect);
        float iconScale = 2.f;
        iconSprite.setScale(iconScale, iconScale);
        float iconW = m_passiveItems[i].iconRect.width * iconScale;
        iconSprite.setPosition(x + (boxWidth - iconW) / 2.f, y + 2.f);
        window.draw(iconSprite);

        // Draw level grid (same as weapons)
        int level   = m_passiveItems[i].level;
        int maxLevel = m_passiveItems[i].maxLevel;
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
                cell.setFillColor(sf::Color(100, 230, 100)); // Green for passive
            } else {
                cell.setFillColor(sf::Color::Black);
            }
            cell.setOutlineThickness(1.f);
            cell.setOutlineColor(sf::Color(100, 200, 100));
            window.draw(cell);
        }
    }

    // EXP Bar Fill
    float expPercent = std::max(0.f, stats.getExp() / stats.getExpToNextLevel());
    sf::RectangleShape expFill(sf::Vector2f(expBarWidth * expPercent, 10.f));
    expFill.setPosition(20.f, windowSize.y - 20.f);
    expFill.setFillColor(sf::Color::Blue);
    window.draw(expFill);

    sf::FloatRect levelBounds = m_levelText.getLocalBounds();
    m_levelText.setOrigin(levelBounds.left + levelBounds.width / 2.0f, levelBounds.top + levelBounds.height / 2.0f);
    m_levelText.setPosition(windowSize.x / 2.0f, windowSize.y - 15.f);
    window.draw(m_levelText);
}

void PlayingState::exit() {
}

void PlayingState::addWeapon(const std::string& weaponName) {
    if (weaponName == "Whip")      m_weapons.push_back(std::make_unique<Whip>());
    else if (weaponName == "Magic Wand")  m_weapons.push_back(std::make_unique<MagicWand>());
    else if (weaponName == "Knife")     m_weapons.push_back(std::make_unique<Knife>());
    else if (weaponName == "Fire Wand")  m_weapons.push_back(std::make_unique<FireWand>());
    else if (weaponName == "Axe")       m_weapons.push_back(std::make_unique<Axe>());
}

std::set<std::string> PlayingState::getOwnedWeaponNames() const {
    std::set<std::string> names;
    for (const auto& w : m_weapons) {
        names.insert(w->getName());
    }
    return names;
}

std::vector<WeaponBase*> PlayingState::getUpgradeableWeapons() {
    std::vector<WeaponBase*> result;
    for (auto& w : m_weapons) {
        if (!w->isMaxLevel()) {
            result.push_back(w.get());
        }
    }
    return result;
}

// --- Passive Item Methods ---

void PlayingState::addOrUpgradePassive(const std::string& name) {
    for (auto& p : m_passiveItems) {
        if (p.name == name) {
            if (p.level < p.maxLevel) {
                p.level++;
                std::cout << "Passive " << name << " now level " << p.level << "\n";
            }
            return;
        }
    }
}

std::set<std::string> PlayingState::getOwnedPassiveNames() const {
    std::set<std::string> names;
    for (const auto& p : m_passiveItems) {
        if (p.isOwned()) names.insert(p.name);
    }
    return names;
}

float PlayingState::getPassiveDamageMultiplier() const {
    float mult = 1.f;
    for (const auto& p : m_passiveItems) {
        if (p.isOwned() && p.statType == "damage") {
            mult += p.level * p.bonusPerLevel;
        }
    }
    return mult;
}

float PlayingState::getPassiveCooldownMultiplier() const {
    float mult = 1.f;
    for (const auto& p : m_passiveItems) {
        if (p.isOwned() && p.statType == "cooldown") {
            mult -= p.level * p.bonusPerLevel;
        }
    }
    return std::max(0.1f, mult);
}

float PlayingState::getPassiveProjSpeedMultiplier() const {
    float mult = 1.f;
    for (const auto& p : m_passiveItems) {
        if (p.isOwned() && p.statType == "projSpeed") {
            mult += p.level * p.bonusPerLevel;
        }
    }
    return mult;
}

float PlayingState::getPassiveAreaMultiplier() const {
    float mult = 1.f;
    for (const auto& p : m_passiveItems) {
        if (p.isOwned() && p.statType == "area") {
            mult += p.level * p.bonusPerLevel;
        }
    }
    return mult;
}

float PlayingState::getPassiveMaxHealthMultiplier() const {
    float mult = 1.f;
    for (const auto& p : m_passiveItems) {
        if (p.isOwned() && p.statType == "maxHealth") {
            mult += p.level * p.bonusPerLevel;
        }
    }
    return mult;
}

// --- Evolution ---

void PlayingState::tryEvolveWeapon() {
    int recipeIdx = findAvailableEvolution(m_weapons, m_passiveItems);
    if (recipeIdx < 0) {
        // No evolution available — give a free level-up instead
        std::cout << "No evolution available. Granting free level-up.\n";
        m_manager->pushState(std::make_unique<LevelUpState>(m_manager, this));
        return;
    }

    const auto& recipe = getEvolutionRecipes()[recipeIdx];
    std::cout << "EVOLUTION! " << recipe.baseWeapon << " -> " << recipe.evolvedWeapon << "\n";

    // Remove the base weapon and ban it
    m_weapons.erase(std::remove_if(m_weapons.begin(), m_weapons.end(),
        [&](const std::unique_ptr<WeaponBase>& w) { return w->getName() == recipe.baseWeapon; }),
        m_weapons.end());
    m_bannedWeapons.insert(recipe.baseWeapon);

    // Add the evolved weapon
    if (recipe.evolvedWeapon == "Bloody Tear") {
        m_weapons.push_back(std::make_unique<BloodyTear>());
    } else if (recipe.evolvedWeapon == "Holy Wand") {
        m_weapons.push_back(std::make_unique<HolyWand>());
    } else if (recipe.evolvedWeapon == "Thousand Edge") {
        m_weapons.push_back(std::make_unique<ThousandEdge>());
    } else if (recipe.evolvedWeapon == "Hellfire") {
        m_weapons.push_back(std::make_unique<Hellfire>());
    } else if (recipe.evolvedWeapon == "Death Spiral") {
        m_weapons.push_back(std::make_unique<DeathSpiral>());
    }

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
