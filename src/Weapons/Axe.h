#pragma once
#include "Weapons/WeaponBase.h"
#include <cmath>

// The Axe is thrown upwards and falls down in a parabolic arc, piercing through enemies
class Axe : public WeaponBase {
public:
    Axe(float cooldown = 4.0f, float damage = 20.0f, float speed = 200.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadItemsTexture();
        // Axe.asset frame in items.png (1024 height)
        // Unity y=348 -> SFML y = 1024 - 348 - 16 = 660
        m_axeFrame = sf::IntRect(485, 660, 16, 16);
        m_burstInterval = 0.2f; // wiki: Projectile Interval = 0.2s
    }

    std::string getName() const override { return "Axe"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Base Damage up by 10.";
            case 3: return "Fires 1 more projectile.";
            case 4: return "Base Damage up by 10.";
            case 5: return "Fires 1 more projectile.";
            case 6: return "Base Damage up by 10.";
            case 7: return "Fires 1 more projectile.";
            case 8: return "Base Damage up by 20.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_damage += 10.f; break;
            case 3: m_amount++; break;
            case 4: m_damage += 10.f; break;
            case 5: m_amount++; break;
            case 6: m_damage += 10.f; break;
            case 7: m_amount++; break;
            case 8: m_damage += 20.f; break;
        }
        m_level++;
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        // Extra axes spread slightly horizontally
        float baseX = (playerDir.x < 0) ? -0.2f : 0.2f;
        float spread = (shotIndex - m_amount / 2) * 0.15f; // spread extra axes
        sf::Vector2f fireDir(baseX + spread, -1.0f);
        
        // Normalize
        float length = std::sqrt(fireDir.x * fireDir.x + fireDir.y * fireDir.y);
        if (length > 0) fireDir /= length;

        sf::Vector2f spawnPos = startPos + sf::Vector2f(shotIndex * 20.f, 0.f);

        Projectile p;
        p.init(spawnPos, fireDir, m_damage, m_speed, 800.0f, 3.0f, true);
        p.setKnockback(1.0f);
        p.setGravity(600.f); 
        p.setSpinSpeed(720.f);
        
        if (m_hasItemsTex) {
            p.setSprite(m_itemsTex, m_axeFrame, 2.f);
        } else {
            p.setCustomShape(sf::Vector2f(20.f, 20.f), sf::Color::Cyan);
        }
        
        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_axeFrame;
};
