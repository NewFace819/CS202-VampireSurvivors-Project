#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Entities/Enemy/EnemyBase.h"
#include <cmath>
#include <limits>

// A basic weapon that shoots projectiles towards the nearest enemy
class MagicWand : public WeaponBase {
public:
    MagicWand(float cooldown = 1.2f, float damage = 10.0f, float speed = 180.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadVfxTexture();
        // ProjectileHoly1 from vfx.png (2048 height)
        // Unity: x=1098, y=618, w=27, h=14 -> SFML y = 2048 - 618 - 14 = 1416
        m_wandFrame = sf::IntRect(1098, 1416, 27, 14);
    }

    std::string getName() const override { return "Magic Wand"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Fires 1 more projectile.";
            case 3: return "Cooldown reduced by 0.2s.";
            case 4: return "Fires 1 more projectile.";
            case 5: return "Base Damage up by 10.";
            case 6: return "Fires 1 more projectile.";
            case 7: return "Pierce up by 1.";
            case 8: return "Base Damage up by 10.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_amount++; break;
            case 3: m_cooldown = std::max(0.1f, m_cooldown - 0.2f); break;
            case 4: m_amount++; break;
            case 5: m_damage += 10.f; break;
            case 6: m_amount++; break;
            case 7: /* pierce handled per-projectile below */ m_pierce++; break;
            case 8: m_damage += 10.f; break;
        }
        m_level++;
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        sf::Vector2f fireDir = m_currentTargetDir;
        if (shotIndex == 0) {
            EnemyBase* target = getNearestEnemy(startPos, enemies);
            fireDir = playerDir;
            if (target) {
                sf::Vector2f dir = getDirectionTo(startPos, target->getPosition());
                if (dir.x != 0.f || dir.y != 0.f) fireDir = dir;
            }
            m_currentTargetDir = fireDir;
        }

        Projectile p;
        // Use pierce count; default non-piercing but m_pierce extra hits allowed
        p.init(startPos, fireDir, m_damage, m_speed, 50.0f, 5.0f, m_pierce > 0);
        p.setKnockback(1.0f);
        if (m_hasVfxTex) {
            // Blue/White glowing missile
            p.setSprite(m_vfxTex, m_wandFrame, 1.0f, true, sf::Color(100, 200, 255));
        }
        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_wandFrame;
    int m_pierce = 0; // extra pierce levels
    sf::Vector2f m_currentTargetDir;
};
