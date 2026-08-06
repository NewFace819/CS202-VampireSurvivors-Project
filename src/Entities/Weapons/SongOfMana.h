#pragma once
#include "WeaponBase.h"
#include "Core/Data/IconManager.h"
#include <cmath>

class SongOfMana : public WeaponBase {
public:
    // Base stats: Damage = 15, Cooldown = 2.0s
    SongOfMana(float cooldown = 2.0f, float damage = 10.0f, float speed = 0.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadItemsTexture();
        loadVfxTexture();
        m_amount = 1;
        m_duration = 0.5f;
    }

    std::string getName() const override { return "Song of Mana"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Base Area up by 100%.";
            case 3: return "Effect lasts 0.5 seconds longer. Cooldown increased by 0.8 seconds.";
            case 4: return "Base Area up by 25%. Base Damage up by 10.";
            case 5: return "Effect lasts 0.5 seconds longer. Cooldown increased by 0.8 seconds.";
            case 6: return "Base Area up by 25%. Base Damage up by 10.";
            case 7: return "Effect lasts 0.5 seconds longer. Cooldown increased by 0.8 seconds.";
            case 8: return "Base Area up by 25%. Base Damage up by 10.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_areaScale += 1.0f; break;
            case 3: m_duration += 0.5f; m_cooldown += 0.75f; break;
            case 4: m_areaScale += 0.25f; m_damage += 10.f; break;
            case 5: m_duration += 0.5f; m_cooldown += 0.75f; break;
            case 6: m_areaScale += 0.25f; m_damage += 10.f; break;
            case 7: m_duration += 0.5f; m_cooldown += 0.75f; break;
            case 8: m_areaScale += 0.25f; m_damage += 10.f; break;
        }
        m_level++;
    }

protected:
    float m_duration;

    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        Projectile p;
        float actualDuration = m_duration * ProfileManager::GetInstance().getDurationMultiplier();
        p.init(startPos, sf::Vector2f(0, 0), m_damage, 0.f, 0.f, actualDuration, true); // Piercing, 0 speed
        p.setKnockback(1.0f);
        p.setIsAura(true); // Follows the player
        p.setHitInterval(0.3f); // Tick damage

        float areaMult = ProfileManager::GetInstance().getAreaMultiplier();
        float width = 60.f * m_areaScale * areaMult;
        float height = 3000.f; // Extremely tall column

        p.setCustomShape(sf::Vector2f(width, height), sf::Color(0, 0, 0, 0));
        p.setPulsateVisual(true);
        p.setSourceWeapon(this);
        
        activeProjectiles.push_back(p);

        // Spawn visual wave particles
        const std::vector<std::string> pfxNames = {
            "PfxBlue", "PfxColor1", "PfxColor2", "PfxDarkRed", "PfxGray",
            "PfxGray1", "PfxGray2", "PfxGrayInverted", "PfxGreen", 
            "PfxHoly1", "PfxHoly2", "PfxLightGreen"
        };
        
        int numParticles = 160 + m_level * 20; 
        for (int i = 0; i < numParticles; i++) {
            Projectile pfx;
            pfx.init(startPos, sf::Vector2f(0, 0), 0.f, 0.f, 0.f, actualDuration, true);
            pfx.setIsAura(true);
            pfx.setVisualOnly(true);
            pfx.setFadeOut(true);
            
            float oy = ((std::rand() % 100) / 100.f - 0.5f) * 1200.f; // Start within visible area
            pfx.setAuraOffset(sf::Vector2f(0.f, oy));
            pfx.setAuraBounceSize(sf::Vector2f(width, height)); // Bounce vertically against height, width for sine amp
            
            // Pha ngẫu nhiên từ 0 đến 2PI để tạo thành một khối sóng 3D dày đặc
            float phase = ((std::rand() % 360) / 180.f) * 3.14159f;
            pfx.setAuraSineWave(true, phase);
            
            float vy = (((std::rand() % 100) / 100.f) * 500.f + 150.f); // Move fast vertically
            if (std::rand() % 2 == 0) vy = -vy;
            pfx.setVelocity(sf::Vector2f(0.f, vy));
            
            if (m_hasVfxTex) {
                const std::string& texName = pfxNames[std::rand() % pfxNames.size()];
                sf::IntRect rect = IconManager::GetInstance().getVfxRect(texName);
                if (rect.width > 0) {
                    float pScale = 2.0f; // Made particles smaller
                    pfx.setSprite(m_vfxTex, rect, pScale, false, sf::Color(255, 255, 255, 150)); // Added transparency
                } else {
                    pfx.setCircleShape(2.f, sf::Color(200, 200, 255, 150)); // Added transparency
                }
            } else {
                pfx.setCircleShape(2.f, sf::Color(200, 200, 255, 150)); // Added transparency
            }
            activeProjectiles.push_back(pfx);
        }
    }
};
