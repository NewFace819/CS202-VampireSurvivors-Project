#pragma once
#include <SFML/Graphics.hpp>
#include <vector>
#include "Projectile.h"

class EnemyBase; // Forward declaration

// Abstract base class for all weapons (Whips, Magic Wands, Fireballs, etc.)
// Weapons act as Spawners for Projectiles based on a cooldown timer.
class WeaponBase {
public:
    WeaponBase(float cooldown, float damage, float speed) 
        : m_cooldown(cooldown), m_timer(0.f), m_damage(damage), m_speed(speed) {}
    
    virtual ~WeaponBase() = default;

    virtual void update(float dt, const sf::Vector2f& playerPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles) {
        m_timer += dt;
        if (m_timer >= m_cooldown) {
            m_timer -= m_cooldown;
            fire(playerPos, playerDir, enemies, activeProjectiles);
        }
    }

    // Leveling up a weapon
    virtual void levelUp() {
        m_level++;
        m_damage += 2.0f; // Example scaling
        // Depending on weapon, might decrease cooldown or add more projectiles
    }

    int getLevel() const { return m_level; }

protected:
    virtual void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles) = 0;

    float m_cooldown;
    float m_timer;
    float m_damage;
    float m_speed;
    int m_level = 1;
};
