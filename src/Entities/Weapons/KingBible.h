#pragma once
#include "WeaponBase.h"
#include "Core/Data/IconManager.h"
#include <cmath>

class KingBible : public WeaponBase {
public:
    // Base stats: Cooldown = 3.0s, Damage = 10.0f, Speed = 1.0f (will be used for orbit speed)
    KingBible(float cooldown = 3.0f, float damage = 10.0f, float speed = 1.5f)
        : WeaponBase(cooldown, damage, speed) {
        
        loadItemsTexture();
        
        m_burstInterval = 0.f; // Spawn all at once
        
        // Duration of the bible
        m_duration = 3.0f;
    }

    std::string getName() const override { return "King Bible"; }
    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Fires 1 more projectile.";
            case 3: return "Base Area up by 25%. Base Speed up by 30%.";
            case 4: return "Effect lasts 0.5 seconds longer. Base Damage up by 10.";
            case 5: return "Fires 1 more projectile.";
            case 6: return "Base Area up by 25%. Base Speed up by 30%.";
            case 7: return "Effect lasts 0.5 seconds longer. Base Damage up by 10.";
            case 8: return "Fires 1 more projectile.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_amount += 1; break;
            case 3: m_areaScale += 0.25f; m_speed += 0.45f; break; // 30% of base 1.5 is 0.45
            case 4: m_duration += 0.5f; m_damage += 10.f; break;
            case 5: m_amount += 1; break;
            case 6: m_areaScale += 0.25f; m_speed += 0.45f; break;
            case 7: m_duration += 0.5f; m_damage += 10.f; break;
            case 8: m_amount += 1; break;
        }
        m_level++;
    }

protected:
    void update(float dt, const sf::Vector2f& playerPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles) override {
        m_timer += dt;
        
        float durationMult = ProfileManager::GetInstance().getDurationMultiplier();
        float actualDuration = m_duration * durationMult;
        float actualCooldown = m_cooldown * ProfileManager::GetInstance().getCooldownMultiplier();
        
        // Cooldown starts when duration ends
        if (m_timer >= actualCooldown + actualDuration) {
            m_timer = 0.f;
            
            int actualAmount = m_amount + ProfileManager::GetInstance().getAmountBonus();
            for (int i = 0; i < actualAmount; ++i) {
                size_t prevSize = activeProjectiles.size();
                fire(playerPos, playerDir, enemies, activeProjectiles, i);
                for (size_t j = prevSize; j < activeProjectiles.size(); ++j) {
                    activeProjectiles[j].setSourceWeapon(this);
                }
            }
        }
    }

    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        int actualAmount = m_amount + ProfileManager::GetInstance().getAmountBonus();
        
        if (shotIndex == 0) {
            m_currentRandomOffset = static_cast<float>(std::rand()) / RAND_MAX * 2.f * 3.14159265f;
        }
        
        float baseAngle = m_currentRandomOffset; // Random offset per burst
        float angleStep = 2.f * 3.14159265f / actualAmount;
        float startAngle = baseAngle + angleStep * shotIndex;
        
        // Base radius 60
        float areaMult = ProfileManager::GetInstance().getAreaMultiplier();
        float radius = 60.f * areaMult;
        
        float durationMult = ProfileManager::GetInstance().getDurationMultiplier();
        float actualDuration = m_duration * durationMult;
        
        // Speed multiplier is applied inside Projectile::init, but we pass it as orbitSpeed
        // Let's pass orbitSpeed as m_speed (default 1.5 rad/s)
        
        Projectile p;
        p.init(startPos, sf::Vector2f(1, 0), m_damage, 0.f, 0.f, actualDuration, true); // Piercing = true
        p.setOrbiting(radius, startAngle, m_speed * ProfileManager::GetInstance().getProjectileSpeedMultiplier());
        p.setKnockback(1.0f);
        
        if (m_hasItemsTex) {
            sf::IntRect iconRect = IconManager::GetInstance().getIconRect("HolyBook");
            if (iconRect.width == 0) {
                iconRect = sf::IntRect(257, 459, 12, 16); // Fallback
            }
            p.setSprite(m_itemsTex, iconRect, 2.0f, false); // applyRotation = false, stay upright
        } else {
            p.setCustomShape(sf::Vector2f(12.f, 16.f), sf::Color(200, 200, 200));
        }
        
        activeProjectiles.push_back(p);
    }
    
private:
    float m_duration;
    float m_currentRandomOffset = 0.f;
};
