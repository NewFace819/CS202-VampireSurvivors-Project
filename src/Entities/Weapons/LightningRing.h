#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Core/Data/IconManager.h"
#include <cmath>
#include <cstdlib>

class LightningRing : public WeaponBase {
public:
    // Base stats: Damage = 15, Area = 1.0, Cooldown = 4.5s
    LightningRing(float cooldown = 4.5f, float damage = 15.0f, float speed = 0.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadItemsTexture();
        loadVfxTexture();
        m_amount = 2; // Base amount is 2
        m_burstInterval = 0.05f; // Projectile interval is 0.05s
    }

    std::string getName() const override { return "Lightning Ring"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Fires 1 more projectile.";
            case 3: return "Base Damage up by 10. Base Area up by 100%.";
            case 4: return "Fires 1 more projectile.";
            case 5: return "Base Damage up by 20. Base Area up by 100%.";
            case 6: return "Fires 1 more projectile.";
            case 7: return "Base Damage up by 20. Base Area up by 100%.";
            case 8: return "Fires 1 more projectile.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_amount += 1; break;
            case 3: m_damage += 10.f; m_areaScale += 1.0f; break;
            case 4: m_amount += 1; break;
            case 5: m_damage += 20.f; m_areaScale += 1.0f; break;
            case 6: m_amount += 1; break;
            case 7: m_damage += 20.f; m_areaScale += 1.0f; break;
            case 8: m_amount += 1; break;
        }
        m_level++;
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        sf::Vector2f targetPos = startPos;
        
        if (!enemies.empty()) {
            // Pick a random enemy
            int randIndex = std::rand() % enemies.size();
            if (enemies[randIndex] && !enemies[randIndex]->isDying()) {
                targetPos = enemies[randIndex]->getBounds().getPosition();
                targetPos.x += enemies[randIndex]->getBounds().width / 2.f;
                targetPos.y += enemies[randIndex]->getBounds().height / 2.f;
            } else {
                targetPos.x += ((std::rand() % 400) - 200);
                targetPos.y += ((std::rand() % 400) - 200);
            }
        } else {
            // Random position near player
            targetPos.x += ((std::rand() % 800) - 400);
            targetPos.y += ((std::rand() % 600) - 300);
        }

        Projectile p;
        p.init(targetPos, sf::Vector2f(0.f, 1.f), m_damage, 0.f, 0.f, 0.5f, true);
        p.setHitInterval(1.0f); 
        p.setKnockback(1.0f);
        
        float areaMult = ProfileManager::GetInstance().getAreaMultiplier();
        p.setCircleShape(25.f * m_areaScale, sf::Color(255, 255, 0, 100)); 

        if (m_hasVfxTex) {
            std::vector<sf::IntRect> frames;
            frames.push_back(IconManager::GetInstance().getVfxRect("Lightning1"));
            frames.push_back(IconManager::GetInstance().getVfxRect("Lightning2"));
            frames.push_back(IconManager::GetInstance().getVfxRect("Lightning3"));
            
            // Fast forward animation
            p.setAnimatedSprite(m_vfxTex, frames, 30.f, 1.5f * m_areaScale);
            
            // Fire from the top of the screen to the targeted enemy
            auto& anim = p.getAnimatedSprite();
            anim.setAutoCenter(false);
            anim.setOrigin(0.f, frames[0].height / 2.f);
            anim.setRotation(-90.f); // Point upwards
            anim.setScale(800.f / frames[0].width, 1.5f * m_areaScale * areaMult);
            
            // Only damage at the end of lightning (the target position)
            p.setUseShapeForBounds(true);
        }
        
        activeProjectiles.push_back(p);
    }
};
