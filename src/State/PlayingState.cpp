#include "State/PlayingState.h"
#include "State/PauseState.h"
#include "Engine/GameManager.h"
#include "Engine/StatsManager.h"
#include "Weapons/MagicWand.h"
#include "Weapons/Whip.h"
#include "Physics/Physics.h"
#include <cstdlib>
#include <algorithm>
#include <cmath>
#include <cstdio>

PlayingState::PlayingState(GameManager* manager) 
    : m_manager(manager), m_grid(100.0f), m_enemyPool(5000) { 
    // Initialize weapons
    m_weapons.push_back(std::make_unique<MagicWand>(0.5f, 25.f, 400.f)); // Acts like Knife
    m_weapons.push_back(std::make_unique<Whip>(1.2f, 15.f)); // Melee Whip

    if (!m_font.loadFromFile("C:\\Windows\\Fonts\\arial.ttf")) {
        // Fallback handled gracefully by SFML (just won't render text)
    }
    m_timerText.setFont(m_font);
    m_timerText.setCharacterSize(40);
    m_timerText.setFillColor(sf::Color::White);
}

void PlayingState::enter() {
}

void PlayingState::update(float dt) {
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Escape)) {
        m_manager->pushState(std::make_unique<PauseState>(m_manager));
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
        // Wave 1: 0:00 - 1:00 (Small orange enemies)
        if (m_spawnTimer >= 0.2f) {
            m_spawnTimer = 0.f;
            for (int i = 0; i < 2; ++i) {
                EnemyBase* enemy = m_enemyPool.acquire();
                if (enemy) {
                    float angle = static_cast<float>(rand() % 360) * 3.14159f / 180.f;
                    float spawnX = m_player.getPosition().x + std::cos(angle) * 800.f;
                    float spawnY = m_player.getPosition().y + std::sin(angle) * 800.f;
                    enemy->init(sf::Vector2f(spawnX, spawnY), 10.f, 40.f, 15.f, sf::Color(255, 165, 0)); 
                    enemy->setTarget(&m_player);
                    m_activeEnemies.push_back(enemy);
                }
            }
        }
    } else {
        // Wave 2: 1:00+ (Fast red enemies swarm)
        if (m_spawnTimer >= 0.1f) {
            m_spawnTimer = 0.f;
            for (int i = 0; i < 5; ++i) {
                EnemyBase* enemy = m_enemyPool.acquire();
                if (enemy) {
                    float angle = static_cast<float>(rand() % 360) * 3.14159f / 180.f;
                    float spawnX = m_player.getPosition().x + std::cos(angle) * 800.f;
                    float spawnY = m_player.getPosition().y + std::sin(angle) * 800.f;
                    enemy->init(sf::Vector2f(spawnX, spawnY), 20.f, 70.f, 20.f, sf::Color::Red); 
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

    // 2. Process collisions and update enemies
    for (auto it = m_activeEnemies.begin(); it != m_activeEnemies.end(); ) {
        EnemyBase* enemy = *it;
        if (!enemy->isActive()) {
            // Spawn an ExpGem when an enemy dies
            ExpGem gem;
            gem.init(enemy->getPosition(), 10.f); // 10 EXP per gem
            m_activeGems.push_back(gem);

            m_enemyPool.release(enemy);
            it = m_activeEnemies.erase(it);
            continue;
        } 
        
        enemy->update(dt);
        
        // Check distance to player. If very close, ignore enemy-enemy collision so they can swarm the player tightly.
        sf::Vector2f toPlayer = enemy->getPosition() - m_player.getPosition();
        float distToPlayerSq = toPlayer.x * toPlayer.x + toPlayer.y * toPlayer.y;
        
        if (distToPlayerSq > 2500.f) { // 50 * 50 = 2500 (Ignore collision if within 50 pixels of player)
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
        }
        
        // Simple O(N*M) collision check for now (Grid will be wired later)
        sf::FloatRect enemyBounds = enemy->getBounds();
        
        // Check collision with Player
        if (enemyBounds.intersects(m_player.getBounds())) {
            StatsManager::GetInstance().takeDamage(10.f * dt); // 10 damage per second while touching
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

    // Reset to Default View for HUD
    window.setView(window.getDefaultView());

    // Draw HUD
    StatsManager& stats = StatsManager::GetInstance();
    sf::Vector2u windowSize = window.getSize();
    
    // Timer Text (Top Center)
    sf::FloatRect textBounds = m_timerText.getLocalBounds();
    m_timerText.setOrigin(textBounds.left + textBounds.width / 2.0f, textBounds.top + textBounds.height / 2.0f);
    m_timerText.setPosition(windowSize.x / 2.0f, 40.f);
    window.draw(m_timerText);
    
    // Health Bar Background
    sf::RectangleShape hpBg(sf::Vector2f(200.f, 20.f));
    hpBg.setPosition(20.f, 20.f);
    hpBg.setFillColor(sf::Color(50, 0, 0));
    window.draw(hpBg);

    // Health Bar Fill
    float hpPercent = std::max(0.f, stats.getHealth() / stats.getMaxHealth());
    sf::RectangleShape hpFill(sf::Vector2f(200.f * hpPercent, 20.f));
    hpFill.setPosition(20.f, 20.f);
    hpFill.setFillColor(sf::Color::Red);
    window.draw(hpFill);

    // EXP Bar Background (Bottom of screen)
    float expBarWidth = windowSize.x - 40.f;
    sf::RectangleShape expBg(sf::Vector2f(expBarWidth, 10.f));
    expBg.setPosition(20.f, windowSize.y - 20.f);
    expBg.setFillColor(sf::Color(0, 0, 50));
    window.draw(expBg);

    // EXP Bar Fill
    float expPercent = std::max(0.f, stats.getExp() / stats.getExpToNextLevel());
    sf::RectangleShape expFill(sf::Vector2f(expBarWidth * expPercent, 10.f));
    expFill.setPosition(20.f, windowSize.y - 20.f);
    expFill.setFillColor(sf::Color::Blue);
    window.draw(expFill);
}

void PlayingState::exit() {
}
