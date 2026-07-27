#pragma once
#include "Entities/Weapons/WeaponBase.h"

// Bloody Tear — Evolved Whip (Whip + Hollow Heart)
// Wiki: Deals much higher damage, can deal critical damage, 
// and drains HP from enemies on hit.
class BloodyTear : public WeaponBase {
public:
    BloodyTear(float cooldown = 1.0f, float damage = 50.0f)
        : WeaponBase(cooldown, damage, 0.f) {
        m_level = 8; // Evolved weapons start at max level
        m_amount = 2; // Fires 2 slashes like max-level Whip
        m_areaScale = 1.3f;
        m_isEvolved = true;
        loadVfxTexture();
        m_whipFrame = sf::IntRect(827, 575, 147, 22);
    }

    std::string getName() const override { return "Bloody Tear"; }
    int getMaxLevel() const override { return 8; }

    std::string getUpgradeDescription() const override {
        return "Evolved weapon. Cannot be upgraded further.";
    }

    void levelUp() override {} // No more leveling

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir,
              const std::vector<EnemyBase*>& enemies,
              std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        // Similar to Whip but with much more damage, larger area, and red tint
        float directionX;
        if (shotIndex % 2 == 0)
            directionX = (playerDir.x < 0) ? -1.0f : 1.0f;
        else
            directionX = (playerDir.x < 0) ? 1.0f : -1.0f;

        sf::Vector2f offset(directionX * 70.f, shotIndex * 14.f);

        Projectile p;
        float scaledRange = 100.0f * m_areaScale;
        p.init(startPos + offset, sf::Vector2f(directionX, 0.f), m_damage, 0.f, scaledRange, 0.35f, true);
        
        // Critical hit chance: 20%
        if (std::rand() % 100 < 20) {
            p.init(startPos + offset, sf::Vector2f(directionX, 0.f), m_damage * 2.f, 0.f, scaledRange, 0.35f, true);
        }

        // HP drain: heal player for 8 HP per hit (handled via knockback force as a signal)
        p.setKnockback(150.f);

        if (m_hasVfxTex) {
            // Red-tinted sprite for the evolved version
            p.setSprite(m_vfxTex, m_whipFrame, 1.2f * m_areaScale, true, sf::Color(255, 80, 80));
        } else {
            p.setCustomShape(sf::Vector2f(120.f * m_areaScale, 24.f), sf::Color::Red);
        }
        
        // Enable a blood-red trail
        p.enableTrail(0.02f, 0.25f, sf::Color(200, 30, 30));

        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_whipFrame;
};
