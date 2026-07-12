#pragma once
#include "Weapons/WeaponBase.h"

// The Whip spawns a large horizontal hitbox in front of the player
// It lives for a fraction of a second, doesn't move, and has piercing
class Whip : public WeaponBase {
public:
    Whip(float cooldown = 1.35f, float damage = 10.0f)
        : WeaponBase(cooldown, damage, 0.f) {
        loadVfxTexture();
        // slash.asset frame in vfx.png (2048 height)
        // Unity y=1451 -> SFML y = 2048 - 1451 - 22 = 575
        m_whipFrame = sf::IntRect(827, 575, 147, 22); 
    }

    std::string getName() const override { return "Whip"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Fires 1 more projectile.";
            case 3: return "Base Damage up by 5.";
            case 4: return "Base Area up by 10%.\nBase Damage up by 5.";
            case 5: return "Base Damage up by 5.";
            case 6: return "Base Area up by 10%.\nBase Damage up by 5.";
            case 7: return "Base Damage up by 5.";
            case 8: return "Base Damage up by 5.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_amount++; break;
            case 3: m_damage += 5.f; break;
            case 4: m_areaScale += 0.1f; m_damage += 5.f; break;
            case 5: m_damage += 5.f; break;
            case 6: m_areaScale += 0.1f; m_damage += 5.f; break;
            case 7: m_damage += 5.f; break;
            case 8: m_damage += 5.f; break;
        }
        m_level++;
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        // Alternate direction for each extra projectile: odd shots go away from player
        float directionX;
        if (shotIndex % 2 == 0)
            directionX = (playerDir.x < 0) ? -1.0f : 1.0f;
        else
            directionX = (playerDir.x < 0) ? 1.0f : -1.0f;

        // Offset slightly per extra shot so they don't perfectly overlap
        sf::Vector2f offset(directionX * 60.f, shotIndex * 12.f);

        Projectile p;
        float scaledRange = 80.0f * m_areaScale;
        p.init(startPos + offset, sf::Vector2f(directionX, 0.f), m_damage, 0.f, scaledRange, 0.3f, true);
        p.setKnockback(1.0f);
        
        if (m_hasVfxTex) {
            p.setSprite(m_vfxTex, m_whipFrame, 1.f * m_areaScale); // 147x22px already wide enough
        } else {
            p.setCustomShape(sf::Vector2f(100.f * m_areaScale, 20.f), sf::Color::White);
        }
        
        activeProjectiles.push_back(p);
    }

private:
    sf::IntRect m_whipFrame;
};
