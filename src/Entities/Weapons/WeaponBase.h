#pragma once
#include <SFML/Graphics.hpp>
#include <vector>
#include <iostream>
#include <string>
#include "Entities/Projectiles/Projectile.h"
#include "Core/Data/ProfileManager.h"

#include "Entities/Enemy/EnemyBase.h"
#include <limits>
#include <cstdlib>
#include <cmath>
// Abstract base class for all weapons (Whips, Magic Wands, Fireballs, etc.)
// Weapons act as Spawners for Projectiles based on a cooldown timer.
class WeaponBase {
public:
    WeaponBase(float cooldown, float damage, float speed) 
        : m_cooldown(cooldown), m_timer(0.f), m_damage(damage), m_speed(speed) {}
    
    virtual ~WeaponBase() = default;

    virtual void update(float dt, const sf::Vector2f& playerPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles) {
        m_timer += dt;
        float actualCooldown = m_cooldown * ProfileManager::GetInstance().getCooldownMultiplier() * m_ownerCooldownMult;
        if (m_timer >= actualCooldown) {
            m_timer = 0.f; // reset timer
            // Fire the first shot immediately
            size_t prevSize = activeProjectiles.size();
            fire(playerPos, playerDir, enemies, activeProjectiles, 0);
            for (size_t i = prevSize; i < activeProjectiles.size(); ++i) {
                activeProjectiles[i].setSourceWeapon(this);
            }
            // Queue remaining shots for sequential burst (0.1s interval)
            int actualAmount = m_amount + ProfileManager::GetInstance().getAmountBonus() + m_ownerAmountBonus;
            m_pendingBurst    = actualAmount - 1;
            m_burstShotsFired = 1;
            m_burstTimer      = 0.f;
            m_burstPlayerPos  = playerPos;
            m_burstPlayerDir  = playerDir;
        }

        // Drain the burst queue at 0.1s intervals (wiki-accurate projectile interval)
        if (m_pendingBurst > 0) {
            m_burstTimer += dt;
            while (m_burstTimer >= m_burstInterval && m_pendingBurst > 0) {
                m_burstTimer -= m_burstInterval;
                size_t prevSize = activeProjectiles.size();
                fire(playerPos, playerDir, enemies, activeProjectiles, m_burstShotsFired);
                for (size_t i = prevSize; i < activeProjectiles.size(); ++i) {
                    activeProjectiles[i].setSourceWeapon(this);
                }
                m_burstShotsFired++;
                m_pendingBurst--;
            }
        }
    }

    // --- Upgrade Interface ---
    virtual std::string getName() const { return "Unknown Weapon"; }

    // Return the description for the NEXT level up (m_level + 1)
    virtual std::string getUpgradeDescription() const { return "Improves the weapon."; }

    virtual void levelUp() { m_level++; }

    int getLevel() const { return m_level; }
    virtual int getMaxLevel() const { return 8; }
    bool isMaxLevel() const { return m_level >= getMaxLevel(); }
    virtual bool isEvolved() const { return m_isEvolved; }

    // Owner's passive-item cooldown bonus, refreshed each frame by PlayingState.
    // Shop power-ups come from ProfileManager; this layers passives on top.
    void setOwnerCooldownMult(float mult) { m_ownerCooldownMult = mult; }
    void setOwnerAmountBonus(int bonus) { m_ownerAmountBonus = bonus; }

    void addDamageDealt(float damage) { m_totalDamageDealt += damage; }
    float getTotalDamageDealt() const { return m_totalDamageDealt; }

protected:
    EnemyBase* getNearestEnemy(const sf::Vector2f& fromPos, const std::vector<EnemyBase*>& enemies) const {
        float minDistSq = std::numeric_limits<float>::max();
        EnemyBase* target = nullptr;
        for (auto* enemy : enemies) {
            if (!enemy->isActive()) continue;
            sf::Vector2f diff = enemy->getPosition() - fromPos;
            float distSq = diff.x * diff.x + diff.y * diff.y;
            if (distSq < minDistSq) {
                minDistSq = distSq;
                target = enemy;
            }
        }
        return target;
    }

    EnemyBase* getRandomEnemy(const std::vector<EnemyBase*>& enemies) const {
        if (enemies.empty()) return nullptr;
        return enemies[std::rand() % enemies.size()];
    }

    sf::Vector2f getDirectionTo(const sf::Vector2f& from, const sf::Vector2f& to) const {
        sf::Vector2f diff = to - from;
        float length = std::sqrt(diff.x * diff.x + diff.y * diff.y);
        if (length > 0.f) {
            return diff / length;
        }
        return sf::Vector2f(0.f, 0.f);
    }

    // `shotIndex` = which shot in the burst (0..m_amount-1), used for spreading or alternating
    virtual void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) = 0;

    // Load the shared items spritesheet (call from subclass constructor)
    bool loadItemsTexture() {
        if (!m_itemsTex.loadFromFile("assets/Graphics/Spritesheets/items.png")) {
            std::cerr << "WeaponBase: failed to load items.png\n";
            return false;
        }
        m_hasItemsTex = true;
        return true;
    }

    // Load the shared vfx spritesheet
    bool loadVfxTexture() {
        if (!m_vfxTex.loadFromFile("assets/Graphics/Spritesheets/vfx.png")) {
            std::cerr << "WeaponBase: failed to load vfx.png\n";
            return false;
        }
        m_hasVfxTex = true;
        return true;
    }

    // Load the shared randomazzo spritesheet
    bool loadRandomazzoTexture() {
        if (!m_randomazzoTex.loadFromFile("assets/Graphics/Characters/character_random.png")) {
            std::cerr << "WeaponBase: failed to load randomazzo.png\n";
            return false;
        }
        m_hasRandomazzoTex = true;
        return true;
    }

    float m_cooldown;
    float m_timer;
    float m_damage;
    float m_speed;
    int   m_level  = 1;
    int   m_amount = 1;       // Number of projectiles fired per burst
    float m_areaScale = 1.0f; // Multiplier for hitbox / visual size
    bool  m_isEvolved = false;

    // Burst firing state (sequential shots at 0.1s intervals)
    int           m_pendingBurst    = 0;
    int           m_burstShotsFired = 0;
    float         m_burstTimer      = 0.f;
    float         m_burstInterval   = 0.1f; // seconds between burst shots (wiki-accurate)
    sf::Vector2f  m_burstPlayerPos;
    sf::Vector2f  m_burstPlayerDir;
    float         m_totalDamageDealt = 0.f;
    float         m_ownerCooldownMult = 1.f;
    int           m_ownerAmountBonus = 0;

    sf::Texture m_itemsTex;
    bool m_hasItemsTex = false;

    sf::Texture m_vfxTex;
    bool m_hasVfxTex = false;

    sf::Texture m_randomazzoTex;
    bool m_hasRandomazzoTex = false;
};
