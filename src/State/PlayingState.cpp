#include "State/PlayingState.h"
#include "State/PauseState.h"
#include "State/LevelUpState.h"
#include "State/MainMenuState.h"
#include "Engine/GameManager.h"
#include "Engine/StatsManager.h"
#include "Weapons/MagicWand.h"
#include "Weapons/Whip.h"
#include "Weapons/Knife.h"
#include "Weapons/FireWand.h"
#include "Weapons/Axe.h"
#include "Physics/Physics.h"
#include <cstdlib>
#include <algorithm>
#include <iostream>

PlayingState::PlayingState(GameManager* manager, CharacterType charType) 
    : m_manager(manager), m_grid(100.0f), m_enemyPool(500) { 

    if (!m_font.loadFromFile("assets/ExportedProject/Assets/Font/Courier_HintedSmooth.ttf")) {
        std::cerr << "PlayingState: Could not load font!\n";
    }
    
    if (!m_itemsTex.loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/items.png")) {
        std::cerr << "PlayingState: Could not load items texture!\n";
    }
    m_enemiesTex.loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/enemies.png");
    m_enemiesTex.setSmooth(false);

    m_timerText.setFont(m_font);
    m_timerText.setCharacterSize(40);
    m_timerText.setFillColor(sf::Color::White);
    m_timerText.setStyle(sf::Text::Bold);
    m_timerText.setPosition(m_manager->getWindow().getSize().x / 2.0f - 50.0f, 20.0f);

    switch (charType) {
        case CharacterType::Antonio:
            m_player.setSprite("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_antonio.png", 
                               {{38,38,32,34}, {74,38,32,34}, {2,74,32,34}});
            m_weapons.push_back(std::make_unique<Whip>());
            break;
        case CharacterType::Imelda:
            m_player.setSprite("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_imelda.png", 
                               {{36,36,36,36}, {72,36,36,36}, {36,108,36,36}, {72,108,36,36}});
            m_weapons.push_back(std::make_unique<MagicWand>());
            break;
        case CharacterType::Gennaro:
            m_player.setSprite("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_gennaro.png", 
                               {{0,0,34,34}, {34,0,34,34}, {70,0,34,34}, {0,34,34,34}});
            m_weapons.push_back(std::make_unique<Knife>());
            break;
        case CharacterType::Arca:
            m_player.setSprite("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_arca.png", 
                               {{34,1,34,34}, {1,38,34,34}, {66,38,34,34}, {0,108,34,34}});
            m_weapons.push_back(std::make_unique<FireWand>());
            break;
        case CharacterType::Lama:
            m_player.setSprite("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_lama.png", 
                               {{0,0,34,34}, {36,0,34,34}, {70,34,34,34}, {68,68,34,34}});
                               //{{0, 0, 32, 32}, {32, 0, 32, 32}, {64, 32, 32, 32}, {64, 64, 32, 32}});
            m_weapons.push_back(std::make_unique<Axe>());
            break;
        case CharacterType::Sigma:
            m_player.setSprite("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_sigma.png", 
                               {{0,0,34,34}, {32,0,34,34}});
            m_weapons.push_back(std::make_unique<Whip>());
            m_weapons.push_back(std::make_unique<MagicWand>());
            m_weapons.push_back(std::make_unique<Knife>());
            m_weapons.push_back(std::make_unique<FireWand>());
            m_weapons.push_back(std::make_unique<Axe>());
            break;
    }
}

void PlayingState::enter() {
}

void PlayingState::update(float dt) {
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Escape)) {
        m_manager->changeState(std::make_unique<MainMenuState>(m_manager));
        return; 
    }

    m_player.update(dt);

    // Update weapons (firing projectiles)
    for (auto& weapon : m_weapons) {
        weapon->update(dt, m_player.getPosition(), m_player.getFacingDir(), m_activeEnemies, m_activeProjectiles);
    }

    // Update projectiles
    for (auto& proj : m_activeProjectiles) {
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

    // Spawn logic (Wave System)
    m_spawnTimer += dt;
    
    // Boss Spawner (At 2:00)
    if (m_survivalTime >= 120.f && !m_bossSpawned) {
        m_bossSpawned = true;
        EnemyBase* boss = m_enemyPool.acquire();
        if (boss) {
            float spawnX = m_player.getPosition().x;
            float spawnY = m_player.getPosition().y - 1200.f; // Spawn above
            boss->init(sf::Vector2f(spawnX, spawnY), 10000.f, 20.f, 100.f, sf::Color(128, 0, 128)); // Huge purple boss
            boss->setTarget(&m_player);
            m_activeEnemies.push_back(boss);
        }
    }

    // Normal Waves
    if (m_survivalTime < 60.f) {
        // Wave 1: 0:00 - 1:00 (Pipestrello 2 - brown bat)
        if (m_spawnTimer >= 0.2f) {
            m_spawnTimer = 0.f;
            for (int i = 0; i < 2; ++i) {
                EnemyBase* enemy = m_enemyPool.acquire();
                if (enemy) {
                    float angle = static_cast<float>(rand() % 360) * 3.14159f / 180.f;
                    float spawnX = m_player.getPosition().x + std::cos(angle) * 800.f;
                    float spawnY = m_player.getPosition().y + std::sin(angle) * 800.f;
                    std::vector<sf::IntRect> moving = {
                        {805, 1030, 25, 24}, {1336, 1052, 21, 24}, 
                        {1011, 917, 19, 24}, {1336, 1052, 21, 24}
                    };
                    std::vector<sf::IntRect> death = {
                        {247, 1169, 27, 26}, {189, 1120, 27, 29}, {477, 904, 31, 33},
                        {1697, 1224, 34, 37}, {1269, 1047, 31, 40}, {496, 738, 33, 41}
                    };
                    enemy->init(sf::Vector2f(spawnX, spawnY), 10.f, 40.f, 8.f, sf::Color::White, &m_enemiesTex, moving, death); 
                    enemy->setTarget(&m_player);
                    m_activeEnemies.push_back(enemy);
                }
            }
        }
    } else {
        // Wave 2: 1:00+ (Pipestrello 4 - blue bat)
        if (m_spawnTimer >= 0.1f) {
            m_spawnTimer = 0.f;
            for (int i = 0; i < 5; ++i) {
                EnemyBase* enemy = m_enemyPool.acquire();
                if (enemy) {
                    float angle = static_cast<float>(rand() % 360) * 3.14159f / 180.f;
                    float spawnX = m_player.getPosition().x + std::cos(angle) * 800.f;
                    float spawnY = m_player.getPosition().y + std::sin(angle) * 800.f;
                    std::vector<sf::IntRect> moving = {
                        {805, 1030, 25, 24}, {1336, 1052, 21, 24}, 
                        {1011, 917, 19, 24}, {1336, 1052, 21, 24}
                    };
                    std::vector<sf::IntRect> death = {
                        {247, 1169, 27, 26}, {189, 1120, 27, 29}, {477, 904, 31, 33},
                        {1697, 1224, 34, 37}, {1269, 1047, 31, 40}, {496, 738, 33, 41}
                    };
                    enemy->init(sf::Vector2f(spawnX, spawnY), 20.f, 70.f, 6.f, sf::Color(100, 100, 255), &m_enemiesTex, moving, death); 
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
            // Spawn an ExpGem when an enemy dies (80% drop rate)
            if (std::rand() % 100 < 80) {
                ExpGem gem;
                gem.init(enemy->getPosition(), 1.f); // 1 EXP per gem for early game
                m_activeGems.push_back(gem);
            }

            m_enemyPool.release(enemy);
            it = m_activeEnemies.erase(it);
            continue;
        } 
        
        enemy->update(dt);
        
        // Check distance to player. If very close, ignore enemy-enemy collision so they can swarm the player tightly.
        sf::Vector2f toPlayer = enemy->getPosition() - m_player.getPosition();
        float distToPlayerSq = toPlayer.x * toPlayer.x + toPlayer.y * toPlayer.y;
        
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
            StatsManager::GetInstance().takeDamage(10.f * dt); // 10 damage per second while touching
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
            if (proj.isActive() && proj.getBounds().intersects(enemyBounds)) {
                // Apply Damage & Knockback
                enemy->takeDamage(proj.getDamage());
                Physics::ApplyKnockback(enemy, proj.getDirection(), proj.getKnockback(), 1.0f);
                
                if (!proj.isPiercing()) {
                    proj.deactivate();
                }
            }
        }
        ++it;
    }

    // Update gems and handle collection
    for (auto& gem : m_activeGems) {
        gem.update(dt, &m_player);
        if (gem.isActive() && gem.getBounds().intersects(m_player.getBounds())) {
            StatsManager::GetInstance().addExp(gem.getExpValue()); 
            gem.deactivate();
        }
    }

    // Clean up dead gems
    m_activeGems.erase(std::remove_if(m_activeGems.begin(), m_activeGems.end(),
        [](const ExpGem& g) { return !g.isActive(); }), m_activeGems.end());

    // Clean up dead projectiles
    m_activeProjectiles.erase(std::remove_if(m_activeProjectiles.begin(), m_activeProjectiles.end(),
        [](const Projectile& p) { return !p.isActive(); }), m_activeProjectiles.end());

    // Detect player level-up and show the upgrade screen
    int currentLevel = StatsManager::GetInstance().getLevel();
    if (currentLevel > m_lastLevel) {
        m_lastLevel = currentLevel;
        m_manager->pushState(std::make_unique<LevelUpState>(m_manager, this));
    }
}

void PlayingState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color(20, 50, 20)); 

    // Create and apply World View centered on player
    sf::View worldView = window.getDefaultView();
    worldView.setCenter(m_player.getPosition());
    window.setView(worldView);
    
    for (auto& gem : m_activeGems) {
        gem.draw(window);
    }
    
    for (auto* enemy : m_activeEnemies) {
        enemy->draw(window);
    }
    
    for (auto& proj : m_activeProjectiles) {
        proj.draw(window);
    }

    m_player.draw(window);

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

    // EXP Bar Fill
    float expPercent = std::max(0.f, stats.getExp() / stats.getExpToNextLevel());
    sf::RectangleShape expFill(sf::Vector2f(expBarWidth * expPercent, 10.f));
    expFill.setPosition(20.f, windowSize.y - 20.f);
    expFill.setFillColor(sf::Color::Blue);
    window.draw(expFill);
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
