#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Core/Data/IconManager.h"
#include <cmath>

class Runetracer : public WeaponBase {
public:
    Runetracer(float cooldown = 3.0f, float damage = 10.f)
        : WeaponBase(cooldown, damage, 400.f) {
        m_amount = 1;
        m_duration = 2.25f;
        loadItemsTexture(); // Load items.png for the diamond sprite
    }

    std::string getName() const override { return "Runetracer"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Base Damage up by 5. Base Speed up by 20%.";
            case 3: return "Effect lasts 0.3 seconds longer. Base Damage up by 5.";
            case 4: return "Fires 1 more projectile.";
            case 5: return "Base Damage up by 5. Base Speed up by 20%.";
            case 6: return "Effect lasts 0.3 seconds longer. Base Damage up by 5.";
            case 7: return "Fires 1 more projectile.";
            case 8: return "Effect lasts 0.5 seconds longer.";
            default: return "";
        }
    }

    void levelUp() override {
        m_level++;
        switch (m_level) {
            case 2: m_damage += 5.f; m_speed *= 1.2f; break;
            case 3: m_duration += 0.3f; m_damage += 5.f; break;
            case 4: m_amount += 1; break;
            case 5: m_damage += 5.f; m_speed *= 1.2f; break;
            case 6: m_duration += 0.3f; m_damage += 5.f; break;
            case 7: m_amount += 1; break;
            case 8: m_duration += 0.5f; break;
        }
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        // Fire in a random direction
        float angle = static_cast<float>(rand() % 360) * 3.14159f / 180.f;
        sf::Vector2f dir(std::cos(angle), std::sin(angle));

        Projectile p;
        p.init(startPos, dir, m_damage, m_speed, m_duration, 5.f, true); // m_piercing is true (last param)
        p.setHitInterval(0.5f); // Damage same enemy every 0.5s
        p.setBounceOffScreen(true);
        
        if (m_hasItemsTex) {
            sf::IntRect runeFrame = IconManager::GetInstance().getIconRect("Diamond2");
            p.setSprite(m_itemsTex, runeFrame, 1.0f * m_areaScale, true, sf::Color(255, 255, 255, 255));
        }
        
        // Add a visible trail
        p.enableTrail(0.02f, 0.25f, sf::Color(200, 220, 255, 160));
        
        activeProjectiles.push_back(p);
    }

protected:
    float m_duration;
};

// NO FUTURE — Evolved Runetracer (Runetracer + Armor)
class NoFuture : public Runetracer {
public:
    NoFuture() : Runetracer(1.5f, 30.0f) {
        m_level = 8;
        m_isEvolved = true;
        m_amount = 3;
        m_speed = 600.f;
        m_areaScale = 1.5f;
        m_duration = 5.0f;
    }

    std::string getName() const override { return "NO FUTURE"; }
    int getMaxLevel() const override { return 8; }
    std::string getUpgradeDescription() const override { return "Evolved weapon. Cannot be upgraded further."; }
    void levelUp() override {}
};

