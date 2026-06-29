#pragma once
#include "Weapons/WeaponBase.h"

// A basic weapon that shoots projectiles towards the nearest enemy
#include "Entities/EnemyBase.h"

class MagicWand : public WeaponBase {
public:
    MagicWand(float cooldown = 0.5f, float damage = 10.0f, float speed = 300.0f)
        : WeaponBase(cooldown, damage, speed) {}

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles) override {
        // Find nearest active enemy
        float minDistSq = std::numeric_limits<float>::max();
        EnemyBase* target = nullptr;
        
        for (auto* enemy : enemies) {
            if (!enemy->isActive()) continue;
            
            sf::Vector2f diff = enemy->getPosition() - startPos;
            float distSq = diff.x * diff.x + diff.y * diff.y;
            
            if (distSq < minDistSq) {
                minDistSq = distSq;
                target = enemy;
            }
        }
        
        sf::Vector2f fireDir = playerDir; // Default to facing dir if no enemies
        
        if (target) {
            sf::Vector2f diff = target->getPosition() - startPos;
            float length = std::sqrt(diff.x * diff.x + diff.y * diff.y);
            if (length > 0) {
                fireDir = diff / length;
            }
        }

        Projectile p;
        p.init(startPos, fireDir, m_damage, m_speed, 50.0f, 5.0f, false);
        activeProjectiles.push_back(p);
    }
};
