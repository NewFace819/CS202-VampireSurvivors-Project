#pragma once
#include "Entities/Weapons/WeaponBase.h"

// Thousand Edge — Evolved Knife (Knife + Bracer)
// Wiki: Fires a constant stream of knives horizontally in the facing direction without delay.
class ThousandEdge : public WeaponBase {
public:
    ThousandEdge(float cooldown = 0.09f, float damage = 16.0f, float speed = 360.0f)
        : WeaponBase(cooldown, damage, speed) {
        m_level = 8; // Evolved weapons start at max level
        m_amount = 1;
        m_isEvolved = true;
        loadItemsTexture();
        // Knife.asset frame in items.png (1024 height)
        // Unity y=155 -> SFML y = 1024 - 155 - 11 = 858
        m_knifeFrame = sf::IntRect(116, 858, 16, 11);
    }

    std::string getName() const override { return "Thousand Edge"; }
    int getMaxLevel() const override { return 8; }

    std::string getUpgradeDescription() const override {
        return "Evolved weapon. Cannot be upgraded further.";
    }

    void levelUp() override {} // No more leveling

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir,
              const std::vector<EnemyBase*>& enemies,
              std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        sf::Vector2f fireDir = playerDir;
        if (fireDir.x == 0.f && fireDir.y == 0.f) {
            fireDir = sf::Vector2f(1.f, 0.f); // fallback
        }

        Projectile p;
        p.init(startPos, fireDir, m_damage, m_speed, 800.0f, 2.5f, false);
        
        if (m_hasItemsTex) {
            p.setSprite(m_itemsTex, m_knifeFrame, 2.f);
        } else {
            p.setCustomShape(sf::Vector2f(20.f, 5.f), sf::Color::White);
        }

        // Enable a silver/blue trail
        p.enableTrail(0.03f, 0.25f, sf::Color(200, 220, 255));
        
        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_knifeFrame;
};
