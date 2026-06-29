#pragma once
#include "Weapons/WeaponBase.h"

// The Whip spawns a large horizontal hitbox in front of the player
// It lives for a fraction of a second, doesn't move, and has piercing
class Whip : public WeaponBase {
public:
    Whip(float cooldown = 1.2f, float damage = 15.0f)
        : WeaponBase(cooldown, damage, 0.f) {} // 0 speed since it stays in place

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles) override {
        // Determine offset based on facing direction
        // If player is facing left, offset to the left, else right
        float directionX = (playerDir.x < 0) ? -1.0f : 1.0f;
        
        sf::Vector2f offset(directionX * 60.f, 0.f); // 60 pixels in front

        Projectile p;
        // speed = 0, lifetime = 0.2s, piercing = true
        p.init(startPos + offset, sf::Vector2f(directionX, 0.f), m_damage, 0.f, 80.0f, 0.2f, true);
        
        // Give it a rectangular shape for the whip
        p.setCustomShape(sf::Vector2f(100.f, 20.f), sf::Color::White);
        
        activeProjectiles.push_back(p);
    }
};
