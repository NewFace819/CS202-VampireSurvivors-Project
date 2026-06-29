#pragma once
#include "Observer.h"

// Manages the player's progression, health, and experience.
class StatsManager : public Subject {
public:
    static StatsManager& GetInstance() {
        static StatsManager instance;
        return instance;
    }

    void reset();

    void addExp(float amount);
    void takeDamage(float amount);
    void heal(float amount);

    int getLevel() const { return m_level; }
    float getExp() const { return m_exp; }
    float getExpToNextLevel() const { return m_expToNext; }
    float getHealth() const { return m_health; }
    float getMaxHealth() const { return m_maxHealth; }

private:
    StatsManager(); // Private constructor for Singleton

    int m_level;
    float m_exp;
    float m_expToNext;
    float m_health;
    float m_maxHealth;
    
    void calculateNextLevelExp();
};
