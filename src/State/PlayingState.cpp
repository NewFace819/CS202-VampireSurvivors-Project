#include "State/PlayingState.h"
#include "State/PauseState.h"
#include "Engine/GameManager.h"
#include "Engine/StatsManager.h"
#include "Weapons/MagicWand.h"
#include "Weapons/Whip.h"
#include "Physics/Physics.h"
#include <cstdlib>

PlayingState::PlayingState(GameManager* manager, CharacterType charType) 
    : m_manager(manager), m_grid(100.0f), m_enemyPool(500) { 
    // Initialize weapons and player sprite based on CharacterType
    if (charType == CharacterType::Antonio) {
        m_weapons.push_back(std::make_unique<Whip>(1.2f, 15.f)); // Antonio starts with Whip
        m_player.setSprite("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_antonio.png");
    } else if (charType == CharacterType::Imelda) {
        m_weapons.push_back(std::make_unique<MagicWand>(0.5f, 25.f, 400.f)); // Imelda starts with Magic Wand
        m_player.setSprite("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_imelda.png");
    }
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

    // Spawn an enemy every 0.5 seconds
    m_spawnTimer += dt;
    if (m_spawnTimer >= 0.2f) {
        m_spawnTimer = 0.f;
        EnemyBase* enemy = m_enemyPool.acquire();
        if (enemy) {
            float angle = static_cast<float>(rand() % 360) * 3.14159f / 180.f;
            float distance = 600.f; // Spawn just outside the view
            float spawnX = m_player.getPosition().x + std::cos(angle) * distance;
            float spawnY = m_player.getPosition().y + std::sin(angle) * distance;
            
            enemy->init(sf::Vector2f(spawnX, spawnY), 10.f, 40.f); // Lowered speed to 40
            enemy->setTarget(&m_player);
            m_activeEnemies.push_back(enemy);
        }
    }

    // Process collisions and update enemies
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

    // EXP Bar Background
    sf::RectangleShape expBg(sf::Vector2f(1240.f, 10.f));
    expBg.setPosition(20.f, 700.f);
    expBg.setFillColor(sf::Color(0, 0, 50));
    window.draw(expBg);

    // EXP Bar Fill
    float expPercent = std::max(0.f, stats.getExp() / stats.getExpToNextLevel());
    sf::RectangleShape expFill(sf::Vector2f(1240.f * expPercent, 10.f));
    expFill.setPosition(20.f, 700.f);
    expFill.setFillColor(sf::Color::Blue);
    window.draw(expFill);
}

void PlayingState::exit() {
}
