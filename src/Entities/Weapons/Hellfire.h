#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Entities/Enemy/EnemyBase.h"
#include <cstdlib>
#include <cmath>

// Hellfire — Evolved Fire Wand (Fire Wand + Spinach)
// Wiki: Fires giant, slow-moving fireballs that pass through enemies (infinite piercing).
class Hellfire : public WeaponBase {
public:
    Hellfire(float cooldown = 2.5f, float damage = 50.0f, float speed = 120.0f)
        : WeaponBase(cooldown, damage, speed) {
        m_level = 8; // Evolved weapons start at max level
        m_amount = 3; // Fires 3 fireballs
        m_burstInterval = 0.02f;
        m_isEvolved = true;
        loadVfxTexture();
        // ProjectileHellfireLarge frame in vfx.png (2048 height)
        // Unity: x: 1128, y: 24, w: 32, h: 27 -> SFML y = 2048 - 24 - 27 = 1997
        m_fireballFrame = sf::IntRect(1128, 1997, 32, 27);
    }

    std::string getName() const override { return "Hellfire"; }
    int getMaxLevel() const override { return 8; }

    std::string getUpgradeDescription() const override {
        return "Evolved weapon. Cannot be upgraded further.";
    }

    void levelUp() override {} // No more leveling

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir,
              const std::vector<EnemyBase*>& enemies,
              std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        sf::Vector2f fireDir = sf::Vector2f(1.f, 0.f); // Default

        // For extra shots, pick other random enemies; for shot 0 pick the nearest
        if (!enemies.empty()) {
            if (shotIndex == 0) {
                // Nearest enemy
                float minDistSq = std::numeric_limits<float>::max();
                EnemyBase* target = nullptr;
                for (auto* enemy : enemies) {
                    if (!enemy->isActive()) continue;
                    sf::Vector2f diff = enemy->getPosition() - startPos;
                    float distSq = diff.x * diff.x + diff.y * diff.y;
                    if (distSq < minDistSq) { minDistSq = distSq; target = enemy; }
                }
                if (target) {
                    sf::Vector2f diff = target->getPosition() - startPos;
                    float len = std::sqrt(diff.x * diff.x + diff.y * diff.y);
                    if (len > 0) fireDir = diff / len;
                }
            } else {
                // Random enemy for extra shots
                int idx = std::rand() % enemies.size();
                EnemyBase* target = enemies[idx];
                sf::Vector2f diff = target->getPosition() - startPos;
                float len = std::sqrt(diff.x * diff.x + diff.y * diff.y);
                if (len > 0) fireDir = diff / len;
            }
        }

        Projectile p;
        // Hellfire has infinite pierce (piercing = true)
        p.init(startPos, fireDir, m_damage, m_speed, 800.0f, 6.0f, true);
        
        if (m_hasVfxTex) {
            // Large Hellfire sprite (scale 2.2f)
            p.setSprite(m_vfxTex, m_fireballFrame, 2.2f);
        } else {
            p.setCustomShape(sf::Vector2f(40.f, 40.f), sf::Color::Red);
        }

        // Enable an intense orange/red glowing trail
        p.enableTrail(0.03f, 0.35f, sf::Color(255, 120, 50));
        
        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_fireballFrame;
};
