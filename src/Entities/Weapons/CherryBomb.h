#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Core/Data/IconManager.h"
#include <cstdlib>
#include <cmath>

class CherryBomb : public WeaponBase {
public:
    // Base stats: Damage = 10, Cooldown = 3.0s, Speed = 300
    CherryBomb(float cooldown = 3.0f, float damage = 10.0f, float speed = 300.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadItemsTexture();
        m_amount = 1;
        m_burstInterval = 0.1f;
        m_explosionChance = 0.4f; 
        m_duration = 2.0f;
    }

    std::string getName() const override { return "Cherry Bomb"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Base Area up by 25%. Base Speed up by 30%.";
            case 3: return "50% chance to explode.";
            case 4: return "Fires 1 more projectile.";
            case 5: return "Base Area up by 25%. Base Damage up by 5.";
            case 6: return "60% chance to explode.";
            case 7: return "Base Area up by 25%. Base Speed up by 30%.";
            case 8: return "Base Area up by 25%. Base Damage up by 5.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_areaScale += 0.25f; m_speed *= 1.3f; break;
            case 3: m_explosionChance = 0.5f; break;
            case 4: m_amount += 1; break;
            case 5: m_damage += 5.f; m_areaScale += 0.25f; break;
            case 6: m_explosionChance = 0.6f; break;
            case 7: m_areaScale += 0.25f; m_speed *= 1.3f; break;
            case 8: m_damage += 5.f; m_areaScale += 0.25f; break;
        }
        m_level++;
    }

protected:
    float m_explosionChance;
    float m_duration;

    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        float angle = static_cast<float>(std::rand()) / RAND_MAX * 2.f * 3.14159265f;
        sf::Vector2f fireDir(std::cos(angle), std::sin(angle));

        Projectile p;
        float actualDuration = m_duration * ProfileManager::GetInstance().getDurationMultiplier();
        p.init(startPos, fireDir, m_damage, m_speed, 800.f, actualDuration, true);
        p.setKnockback(2.f);
        p.setBouncing(true); // Bounce off enemies
        p.setBounceOffScreen(true); // Bounce off screen
        p.setExploding(m_explosionChance > 0.0f, m_explosionChance + (ProfileManager::GetInstance().getLuckMultiplier() - 1.f)); // Luck affects chance
        
        if (m_hasItemsTex) {
            sf::IntRect iconRect = IconManager::GetInstance().getIconRect("Cherry Bomb");
            if (iconRect.width == 0) iconRect = sf::IntRect(0, 0, 16, 16);
            float areaMult = ProfileManager::GetInstance().getAreaMultiplier();
            p.setSprite(m_itemsTex, iconRect, 1.5f * m_areaScale * areaMult, true);
        } else {
            p.setCustomShape(sf::Vector2f(16.f, 16.f), sf::Color::Red);
        }
        
        activeProjectiles.push_back(p);
    }
};
