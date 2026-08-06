#pragma once
#include "Entities/Weapons/WeaponBase.h"

// The Knife fires a fast projectile horizontally in the direction the player is facing
class Knife : public WeaponBase {
public:
    Knife(float cooldown = 1.0f, float damage = 6.5f, float speed = 260.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadItemsTexture();
        // Knife.asset frame in items.png (1024 height)
        // Unity y=155 -> SFML y = 1024 - 155 - 11 = 858
        m_knifeFrame = sf::IntRect(116, 858, 16, 11);
    }

    std::string getName() const override { return "Knife"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Fires 1 more projectile.";
            case 3: return "Fires 1 more projectile. Base Damage up by 5.";
            case 4: return "Fires 1 more projectile.";
            case 5: return "Passes through 1 more enemy.";
            case 6: return "Fires 1 more projectile.";
            case 7: return "Fires 1 more projectile. Base Damage up by 5.";
            case 8: return "Passes through 1 more enemy.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_amount++; break;
            case 3: m_amount++; m_damage += 5.f; break;
            case 4: m_amount++; break;
            case 5: m_pierce++; break;
            case 6: m_amount++; break;
            case 7: m_amount++; m_damage += 5.f; break;
            case 8: m_pierce++; break;
        }
        m_level++;
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        sf::Vector2f fireDir = playerDir;
        if (fireDir.x == 0.f && fireDir.y == 0.f) {
            fireDir = sf::Vector2f(1.f, 0.f); // fallback
        }

        // Spread extra knives in a small fan (each +/- a small angle offset)
        if (shotIndex > 0) {
            float angle = std::atan2(fireDir.y, fireDir.x);
            // Alternate: +0.15rad, -0.15rad, +0.3rad, -0.3rad ...
            int side = (shotIndex % 2 == 1) ? 1 : -1;
            float spread = side * ((shotIndex + 1) / 2) * 0.15f;
            angle += spread;
            fireDir = sf::Vector2f(std::cos(angle), std::sin(angle));
        }

        Projectile p;
        p.init(startPos, fireDir, m_damage, m_speed, 800.0f, 2.0f, m_pierce > 0);
        p.setKnockback(0.5f);
        
        if (m_hasItemsTex) {
            p.setSprite(m_itemsTex, m_knifeFrame, 2.f);
            p.enableTrail(0.01f, 0.2f, sf::Color(200, 200, 200, 150));
        } else {
            p.setCustomShape(sf::Vector2f(20.f, 5.f), sf::Color::White);
        }
        
        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_knifeFrame;
    int m_pierce = 0;
};
