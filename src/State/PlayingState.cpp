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

PlayingState::PlayingState(GameManager* manager, CharacterType charType) 
    : m_manager(manager), m_grid(100.0f), m_enemyPool(500) { 

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
