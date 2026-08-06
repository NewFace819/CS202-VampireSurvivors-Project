#pragma once
#include "Entities/Weapons/WeaponBase.h"

// Garlic: An aura weapon that damages enemies near the player
class Garlic : public WeaponBase {
public:
    // Base stats from wiki: Damage = 5, Area = 100%, Cooldown = 1.3s
    Garlic(float cooldown = 1.3f, float damage = 5.0f, float speed = 0.0f)
        : WeaponBase(cooldown, damage, speed) {
        m_timer = cooldown; // Fire immediately upon acquiring
    }

    std::string getName() const override { return "Garlic"; }

    std::string getUpgradeDescription() const override {
        switch (m_level + 1) {
            case 2: return "Base Area up by 40%. Base Damage up by 2.";
            case 3: return "Cooldown reduced by 0.1 seconds. Base Damage up by 1.";
            case 4: return "Base Area up by 20%. Base Damage up by 1.";
            case 5: return "Cooldown reduced by 0.1 seconds. Base Damage up by 2.";
            case 6: return "Base Area up by 20%. Base Damage up by 1.";
            case 7: return "Cooldown reduced by 0.1 seconds. Base Damage up by 1.";
            case 8: return "Base Area up by 20%. Base Damage up by 2.";
            default: return "Max level reached.";
        }
    }

    void levelUp() override {
        switch (m_level + 1) {
            case 2: m_areaScale += 0.4f; m_damage += 2.f; break;
            case 3: m_cooldown -= 0.1f; m_damage += 1.f; break;
            case 4: m_areaScale += 0.2f; m_damage += 1.f; break;
            case 5: m_cooldown -= 0.1f; m_damage += 2.f; break;
            case 6: m_areaScale += 0.2f; m_damage += 1.f; break;
            case 7: m_cooldown -= 0.1f; m_damage += 1.f; break;
            case 8: m_areaScale += 0.2f; m_damage += 2.f; break;
        }
        m_level++;
    }

protected:
    void fire(const sf::Vector2f& startPos, const sf::Vector2f& playerDir, const std::vector<EnemyBase*>& enemies, std::vector<Projectile>& activeProjectiles, int shotIndex = 0) override {
        Projectile p;
        // Garlic aura has a base radius. Usually around 40-50 pixels in Vampire Survivors.
        // It lives exactly for m_cooldown seconds, so when it dies a new one spawns and can hit enemies again
        p.init(startPos, sf::Vector2f(0.f, 0.f), m_damage, 0.f, 0.f, m_cooldown, true);
        p.setKnockback(10.0f); // Small knockback value as per wiki
        
        // Aura tracking the player
        p.setIsAura(true);
        p.setGarlicAura(true);

        // Make it a transparent circle with an outline
        float radius = 50.f; // Base radius
        if (m_isEvolved) {
            p.setCircleShape(radius, sf::Color(150, 0, 150, 120));
            p.setOutline(2.f, sf::Color(200, 50, 200, 220));
        } else {
            p.setCircleShape(radius, sf::Color(255, 255, 200, 100)); // Will internally multiply by areaScale
            p.setOutline(2.f, sf::Color(255, 255, 200, 200));
        }

        activeProjectiles.push_back(p);
    }
};

// Soul Eater — Evolved Garlic (Garlic + Pummarola)
class SoulEater : public Garlic {
public:
    SoulEater() : Garlic(1.0f, 20.0f, 0.0f) {
        m_level = 8;
        m_isEvolved = true;
        m_areaScale = 1.5f;
    }

    std::string getName() const override { return "Soul Eater"; }
    int getMaxLevel() const override { return 8; }
    std::string getUpgradeDescription() const override { return "Evolved weapon. Cannot be upgraded further."; }
    void levelUp() override {}
};

