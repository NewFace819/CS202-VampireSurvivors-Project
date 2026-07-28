#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Core/Data/IconManager.h"
#include <cmath>

class SantaWater : public WeaponBase {
public:
    SantaWater(float cooldown = 4.5f, float damage = 10.0f, float speed = 0.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadItemsTexture();
        loadVfxTexture();
        m_amount = 1;
        m_burstInterval = 0.3f;
    }

    std::string getName() const override { return "Santa Water"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Fires 1 more projectile. Base Area up by 20%.";
            case 3: return "Effect lasts 0.5 seconds longer. Base Damage up by 10.";
            case 4: return "Fires 1 more projectile. Base Area up by 20%.";
            case 5: return "Effect lasts 0.3 seconds longer. Base Damage up by 10.";
            case 6: return "Fires 1 more projectile. Base Area up by 20%.";
            case 7: return "Effect lasts 0.3 seconds longer. Base Damage up by 5.";
            case 8: return "Base Area up by 20%. Base Damage up by 5.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_amount += 1; m_areaScale += 0.2f; break;
            case 3: m_duration += 0.5f; m_damage += 10.f; break;
            case 4: m_amount += 1; m_areaScale += 0.2f; break;
            case 5: m_duration += 0.3f; m_damage += 10.f; break;
            case 6: m_amount += 1; m_areaScale += 0.2f; break;
            case 7: m_duration += 0.3f; m_damage += 5.f; break;
            case 8: m_areaScale += 0.2f; m_damage += 5.f; break;
        }
        m_level++;
    }

protected:
    float m_duration = 2.0f; // Base duration

    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        Projectile p;

        int actualAmount = m_amount + ProfileManager::GetInstance().getAmountBonus();
        
        sf::Vector2f targetPos = startPos;
        
        if (actualAmount < 4 && shotIndex == 0 && !enemies.empty()) {
            EnemyBase* closest = nullptr;
            float minDist = -1.f;
            for (auto* e : enemies) {
                if (e->isDying()) continue;
                sf::Vector2f diff = e->getPosition() - startPos;
                float distSq = diff.x * diff.x + diff.y * diff.y;
                if (minDist < 0.f || distSq < minDist) {
                    minDist = distSq;
                    closest = e;
                }
            }
            if (closest) {
                targetPos = closest->getPosition();
            }
        } else {
            float angle = (float)shotIndex * (2.f * 3.14159f / (float)actualAmount) + ((float)(std::rand() % 100) * 0.01f);
            float radius = 150.f + (std::rand() % 50);
            targetPos.x += std::cos(angle) * radius;
            targetPos.y += std::sin(angle) * radius;
        }
        
        float spawnHeight = 400.f;
        sf::Vector2f spawnPos = targetPos - sf::Vector2f(0.f, spawnHeight);

        // m_duration here is the lifetime after it spawns.
        // It takes roughly 0.45s to fall. So total lifetime is m_duration + 0.5f.
        p.init(spawnPos, sf::Vector2f(0.f, 1.f), m_damage, 0.f, 0.f, m_duration + 0.5f, true);

        p.setGravity(2000.f); 
        p.setVelocity(sf::Vector2f(0.f, 200.f));
        if (m_hasVfxTex) {
            std::vector<sf::IntRect> puddleFrames;
            for (int i = 5; i <= 14; ++i) {
                puddleFrames.push_back(IconManager::GetInstance().getVfxRect("giantButtonBase_" + std::to_string(i)));
            }
            float dynamicFps = (float)puddleFrames.size() / m_duration;
            p.setLandingAnimated(targetPos.y, &m_vfxTex, puddleFrames, dynamicFps, 0.7f * m_areaScale);
        } else {
            p.setLanding(targetPos.y, nullptr, sf::IntRect(), 1.0f * m_areaScale);
        }
        
        if (m_hasItemsTex) {
            sf::IntRect bottleFrame = IconManager::GetInstance().getIconRect("Santa Water");
            p.setSprite(m_itemsTex, bottleFrame, 1.5f, false, sf::Color(255, 255, 255, 255));
        }
        
        p.setHitInterval(0.5f);
        
        activeProjectiles.push_back(p);
    }
};
