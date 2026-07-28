#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Entities/Enemy/EnemyBase.h"
#include <cstdlib>
#include <cmath>

// The Fire Wand fires a slow-moving, high-damage fireball at a random enemy
class FireWand : public WeaponBase {
public:
    FireWand(float cooldown = 3.0f, float damage = 20.0f, float speed = 100.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadVfxTexture();
        // ProjectileFireball frame in vfx.png (2048 height)
        // Unity y=0 -> SFML y = 2048 - 0 - 27 = 2021
        m_fireballFrame = sf::IntRect(247, 2021, 32, 27);
        m_amount = 3;           // wiki: Amount = 3 at level 1
        m_burstInterval = 0.02f; // wiki: Projectile Interval = 0.02s
    }

    std::string getName() const override { return "Fire Wand"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Base Damage up by 10.";
            case 3: return "Base Damage up by 10.\nBase Speed up by 20%.";
            case 4: return "Base Damage up by 10.";
            case 5: return "Base Damage up by 10.\nBase Speed up by 20%.";
            case 6: return "Base Damage up by 10.";
            case 7: return "Base Damage up by 10.\nBase Speed up by 20%.";
            case 8: return "Base Damage up by 10.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_damage += 10.f; break;
            case 3: m_damage += 10.f; m_speed *= 1.2f; break;
            case 4: m_damage += 10.f; break;
            case 5: m_damage += 10.f; m_speed *= 1.2f; break;
            case 6: m_damage += 10.f; break;
            case 7: m_damage += 10.f; m_speed *= 1.2f; break;
            case 8: m_damage += 10.f; break;
        }
        m_level++;
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        sf::Vector2f fireDir = sf::Vector2f(1.f, 0.f); // Default

        // For extra shots, pick other random enemies; for shot 0 pick the nearest
        if (!enemies.empty()) {
            EnemyBase* target = nullptr;
            if (shotIndex == 0) {
                target = getNearestEnemy(startPos, enemies);
            } else {
                target = getRandomEnemy(enemies);
            }
            if (target) {
                sf::Vector2f dir = getDirectionTo(startPos, target->getPosition());
                if (dir.x != 0.f || dir.y != 0.f) fireDir = dir;
            }
        }

        Projectile p;
        p.init(startPos, fireDir, m_damage, m_speed, 800.0f, 5.0f, false);
        p.setKnockback(1.0f);
        
        if (m_hasVfxTex) {
            p.setSprite(m_vfxTex, m_fireballFrame, 1.0f);
        } else {
            p.setCustomShape(sf::Vector2f(20.f, 20.f), sf::Color::Red);
        }
        
        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_fireballFrame;
};
