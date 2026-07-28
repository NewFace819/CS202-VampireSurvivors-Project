#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Entities/Enemy/EnemyBase.h"
#include <cmath>
#include <limits>

// Holy Wand — Evolved Magic Wand (Magic Wand + Empty Tome)
// Wiki: Attacks continuously without delay (extremely low cooldown).
class HolyWand : public WeaponBase {
public:
    HolyWand(float cooldown = 0.09f, float damage = 22.0f, float speed = 250.0f)
        : WeaponBase(cooldown, damage, speed) {
        m_level = 8; // Evolved weapons start at max level
        m_amount = 1;
        m_isEvolved = true;
        loadVfxTexture();
        // ProjectileHoly1 frame in vfx.png (2048 height)
        // Unity: x=1098, y=618, w=27, h=14 -> SFML y = 2048 - 618 - 14 = 1416
        m_wandFrame = sf::IntRect(1098, 1416, 27, 14);
    }

    std::string getName() const override { return "Holy Wand"; }
    int getMaxLevel() const override { return 8; }

    std::string getUpgradeDescription() const override {
        return "Evolved weapon. Cannot be upgraded further.";
    }

    void levelUp() override {} // No more leveling

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir,
              const std::vector<EnemyBase*>& enemies,
              std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        EnemyBase* target = getNearestEnemy(startPos, enemies);
        sf::Vector2f fireDir = playerDir; // Default to facing dir if no enemies
        if (target) {
            sf::Vector2f dir = getDirectionTo(startPos, target->getPosition());
            if (dir.x != 0.f || dir.y != 0.f) fireDir = dir;
        }

        Projectile p;
        // Holy Wand projectiles pierce 1 enemy (pierce count = 1)
        p.init(startPos, fireDir, m_damage, m_speed, 800.0f, 5.0f, true);
        
        if (m_hasVfxTex) {
            // Blue/White glowing missile (evolved might be tinted differently, but let's keep it similar for now)
            p.setSprite(m_vfxTex, m_wandFrame, 1.2f, true, sf::Color(150, 200, 255));
        } else {
            p.setCustomShape(sf::Vector2f(12.f, 12.f), sf::Color::Cyan);
        }

        // Enable a bright cyan glowing trail
        p.enableTrail(0.02f, 0.2f, sf::Color(100, 220, 255));

        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_wandFrame;
};
