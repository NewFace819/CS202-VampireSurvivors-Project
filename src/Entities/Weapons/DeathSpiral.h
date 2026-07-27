#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include <cmath>

// Death Spiral — Evolved Axe (Axe + Candelabrador)
// Wiki: Fires giant, spinning scythes outward in all 8 directions, piercing through all enemies.
class DeathSpiral : public WeaponBase {
public:
    DeathSpiral(float cooldown = 3.5f, float damage = 40.0f, float speed = 180.0f)
        : WeaponBase(cooldown, damage, speed) {
        m_level = 8; // Evolved weapons start at max level
        m_amount = 8; // Fires in all 8 directions
        m_isEvolved = true;
        loadVfxTexture();
        // ProjectileScythe frame in vfx.png (2048 height)
        // Unity: x: 551, y: 172, w: 21, h: 20 -> SFML y = 2048 - 172 - 20 = 1856
        m_scytheFrame = sf::IntRect(551, 1856, 21, 20);
    }

    std::string getName() const override { return "Death Spiral"; }
    int getMaxLevel() const override { return 8; }

    std::string getUpgradeDescription() const override {
        return "Evolved weapon. Cannot be upgraded further.";
    }

    void levelUp() override {} // No more leveling

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir,
              const std::vector<EnemyBase*>& enemies,
              std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        // Firing 8 scythes in all 8 directions.
        // We only fire all 8 on shotIndex 0 to avoid firing 8 * 8 = 64 projectiles!
        // The fire loop in WeaponBase fires `m_amount` times.
        // If we fire 1 direction per shotIndex, we will get all 8 directions sequentially.
        float angle = shotIndex * (2.f * 3.14159265f / 8.f);
        sf::Vector2f fireDir(std::cos(angle), std::sin(angle));

        Projectile p;
        // Infinite pierce (piercing = true)
        p.init(startPos, fireDir, m_damage, m_speed, 800.0f, 4.0f, true);
        p.setSpinSpeed(900.f); // Spin rapidly

        if (m_hasVfxTex) {
            // Large scythe (scale 2.5f)
            p.setSprite(m_vfxTex, m_scytheFrame, 2.5f);
        } else {
            p.setCustomShape(sf::Vector2f(35.f, 35.f), sf::Color::Magenta);
        }

        // Enable a dark purple/pink trail
        p.enableTrail(0.03f, 0.3f, sf::Color(180, 50, 200));

        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_scytheFrame;
};
