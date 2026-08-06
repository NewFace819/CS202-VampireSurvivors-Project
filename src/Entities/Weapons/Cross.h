#pragma once
#include "Entities/Weapons/WeaponBase.h"
#include "Entities/Enemy/EnemyBase.h"
#include <cmath>
#include <limits>

// A weapon that aims at the nearest enemy and behaves like a boomerang
class Cross : public WeaponBase {
public:
    Cross(float cooldown = 2.0f, float damage = 5.0f, float speed = 500.0f)
        : WeaponBase(cooldown, damage, speed) {
        loadVfxTexture();
        // ProjectileCross1 from vfx.png (2048 height)
        // Unity: x=1040, y=0, w=16, h=16 -> SFML y = 2048 - 0 - 16 = 2032
        m_crossFrame = sf::IntRect(1040, 2032, 16, 16);
    }

    std::string getName() const override { return "Cross"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Base Damage up by 10.";
            case 3: return "Base Area up by 10%. Base Speed up by 25%.";
            case 4: return "Fires 1 more projectile.";
            case 5: return "Base Damage up by 10.";
            case 6: return "Base Area up by 10%. Base Speed up by 25%.";
            case 7: return "Fires 1 more projectile.";
            case 8: return "Base Damage up by 10.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_damage += 10.f; break;
            case 3: m_areaScale += 0.1f; m_speed += 100.f; break;
            case 4: m_amount++; break;
            case 5: m_damage += 10.f; break;
            case 6: m_areaScale += 0.1f; m_speed += 100.f; break;
            case 7: m_amount++; break;
            case 8: m_damage += 10.f; break;
        }
        m_level++;
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        sf::Vector2f fireDir;
        
        if (shotIndex == 0) {
            EnemyBase* target = getNearestEnemy(startPos, enemies);
            fireDir = playerDir;
            if (target) {
                sf::Vector2f dir = getDirectionTo(startPos, target->getPosition());
                if (dir.x != 0.f || dir.y != 0.f) fireDir = dir;
            }
            m_currentTargetDir = fireDir;
        } else {
            // Slight angle variation for additional projectiles
            float angleOffset = (shotIndex % 2 == 0 ? 1 : -1) * (shotIndex / 2) * 0.2f;
            float currentAngle = std::atan2(m_currentTargetDir.y, m_currentTargetDir.x);
            currentAngle += angleOffset;
            fireDir = sf::Vector2f(std::cos(currentAngle), std::sin(currentAngle));
        }

        Projectile p;
        // The cross is piercing, lives a long time to return across the screen
        p.init(startPos, fireDir, m_damage, m_speed, 0.0f, 6.0f, true);
        p.setKnockback(1.0f);
        
        // Boomerang effect: apply constant negative acceleration
        // This makes it smoothly slow down, stop, and fly backwards
        p.setAcceleration(-fireDir * (m_speed * 1.5f)); 
        p.setMaxSpeed(m_speed * 1.5f);
        
        if (m_hasVfxTex) {
            p.setSprite(m_vfxTex, m_crossFrame, 1.5f * m_areaScale, false, sf::Color::White);
            p.setSpinSpeed(1000.f); // Rotate really fast
        } else {
            p.setCustomShape(sf::Vector2f(16.f, 16.f), sf::Color::Blue);
            p.setSpinSpeed(720.f);
        }
        
        activeProjectiles.push_back(p);
    }

protected:
    sf::IntRect m_crossFrame;

private:
    sf::Vector2f m_currentTargetDir;
};

// Heaven Sword — Evolved Cross (Cross + Clover)
class HeavenSword : public Cross {
public:
    HeavenSword() : Cross(1.5f, 77.0f, 700.0f) {
        m_level = 8;
        m_isEvolved = true;
        m_amount = 3;
        m_areaScale = 1.8f;
        // ProjectileSword from vfx.png: x=550, y=118, w=32, h=15 -> SFML y = 2048 - 118 - 15 = 1915
        m_crossFrame = sf::IntRect(550, 1915, 32, 15);
    }

    std::string getName() const override { return "Heaven Sword"; }
    int getMaxLevel() const override { return 8; }
    std::string getUpgradeDescription() const override { return "Evolved weapon. Cannot be upgraded further."; }
    void levelUp() override {}
};

