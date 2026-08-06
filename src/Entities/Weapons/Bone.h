#pragma once
#include "WeaponBase.h"
#include "Core/Data/IconManager.h"
#include <cstdlib>
#include <cmath>

class Bone : public WeaponBase {
public:
    // Base stats for Bone
    Bone(float cooldown = 3.0f, float damage = 5.0f, float speed = 150.0f) // 150.0f is 75% of 200.0f roughly
        : WeaponBase(cooldown, damage, speed) {
        loadItemsTexture();
        m_amount = 1;
        m_burstInterval = 0.1f;
        m_areaScale = 1.2f; // 120% base area
    }

    float m_duration = 2.0f;

    std::string getName() const override { return "Bone"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Base Area up by 20%. Effect lasts 0.2 seconds longer.";
            case 3: return "Fires 1 more projectile. Base Damage up by 20.";
            case 4: return "Base Area up by 20%. Base Speed up by 50%.";
            case 5: return "Fires 1 more projectile. Base Damage up by 20.";
            case 6: return "Effect lasts 0.2 seconds longer.";
            case 7: return "Base Damage up by 20.";
            case 8: return "Effect lasts 0.2 seconds longer. Base Speed increased by 50%.";
            default: return "";
        }
    }

    void levelUp() override {
        WeaponBase::levelUp();
        switch (m_level) {
            case 2: m_areaScale += 0.2f; m_duration += 0.2f; break;
            case 3: m_amount += 1; m_damage += 20.0f; break;
            case 4: m_areaScale += 0.2f; m_speed += 100.0f; break; // Base 200 * 0.50 = 100
            case 5: m_amount += 1; m_damage += 20.0f; break;
            case 6: m_duration += 0.2f; break;
            case 7: m_damage += 20.0f; break;
            case 8: m_duration += 0.2f; m_speed += 100.0f; break;
        }
    }

    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        EnemyBase* target = getRandomEnemy(enemies);
        sf::Vector2f fireDir;

        if (target) {
            fireDir = getDirectionTo(startPos, target->getPosition());
        } else {
            // Random direction if no enemies
            float angle = static_cast<float>(rand() % 360) * 3.14159f / 180.f;
            fireDir = sf::Vector2f(std::cos(angle), std::sin(angle));
        }

        Projectile p;
        p.init(startPos, fireDir, m_damage, m_speed, 1000.f, m_duration, true); // true for piercing
        p.setBouncing(true); // Bounces off enemies and walls
        p.setSourceWeapon(this);
        p.setKnockback(1.5f); // Good knockback

        if (m_hasItemsTex) {
            sf::IntRect iconRect = IconManager::GetInstance().getIconRect("Bone");
            if (iconRect.width == 0) iconRect = sf::IntRect(0, 0, 16, 16);
            float areaMult = ProfileManager::GetInstance().getAreaMultiplier();
            p.setSprite(m_itemsTex, iconRect, 1.5f * m_areaScale * areaMult, true);
        } else {
            p.setCustomShape(sf::Vector2f(10.f, 10.f), sf::Color::White);
        }

        activeProjectiles.push_back(p);
    }
};
