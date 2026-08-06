#pragma once
#include "WeaponBase.h"
#include "Core/Data/IconManager.h"
#include <cmath>

class EightTheSparrow : public WeaponBase {
public:
    // Base stats: Damage = 5, Cooldown = 1.4s, Speed = 100%, Amount = 1, Pierce = 1
    EightTheSparrow(float cooldown = 1.4f, float damage = 5.0f, float speed = 400.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadVfxTexture();
        m_amount = 1;
        m_burstInterval = 0.2f;
        m_piercing = 1; 
        // Offset timer so it fires alternating with Phiera Der Tuphello
        m_timer = - (cooldown / 2.0f);
    }

    int m_piercing;

    std::string getName() const override { return "Eight The Sparrow"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Fires 1 more projectile.";
            case 3: return "Passes through 2 more enemies.";
            case 4: return "Fires 1 more projectile.";
            case 5: return "Base Damage up by 5.";
            case 6: return "Passes through 2 more enemies.";
            case 7: return "Base Damage up by 5. Base Speed up by 50%.";
            case 8: return "Passes through 2 more enemies.";
            default: return "";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_amount += 1; break;
            case 3: m_piercing += 2; break;
            case 4: m_amount += 1; break;
            case 5: m_damage += 5.f; break;
            case 6: m_piercing += 2; break;
            case 7: m_damage += 5.f; m_speed += 200.f; break; // Base speed is 400. 50% = 200.
            case 8: m_piercing += 2; break;
        }
        WeaponBase::levelUp();
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        // Fire in 4 ordinal directions (diagonals)
        float angles[4] = {
            45.f * 3.14159265f / 180.f,
            135.f * 3.14159265f / 180.f,
            225.f * 3.14159265f / 180.f,
            315.f * 3.14159265f / 180.f
        };

        for (int i = 0; i < 4; i++) {
            sf::Vector2f fireDir(std::cos(angles[i]), std::sin(angles[i]));

            Projectile p;
            p.init(startPos, fireDir, m_damage, m_speed, 1000.f, 3.0f, m_piercing > 1);
            p.setSourceWeapon(this);
            p.setKnockback(1.0f); // Default knockback
            
            if (m_hasVfxTex) {
                // BulletBlue from vfx_atlas: x=1226, y=580, w=21, h=21 -> SFML y = 2048 - 580 - 21 = 1447
                sf::IntRect iconRect(1226, 1447, 21, 21);
                float areaMult = ProfileManager::GetInstance().getAreaMultiplier();
                p.setSprite(m_vfxTex, iconRect, 1.5f * m_areaScale * areaMult, true);
                p.m_animSprite.setRotation(angles[i] * 180.f / 3.14159265f); // Point in direction of travel
            } else {
                p.setCustomShape(sf::Vector2f(12.f, 12.f), sf::Color::Blue);
            }
            activeProjectiles.push_back(p);
        }
    }
};
