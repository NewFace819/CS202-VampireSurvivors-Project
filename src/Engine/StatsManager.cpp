#include "StatsManager.h"
#include <cmath>

StatsManager::StatsManager() {
    reset();
}

void StatsManager::reset() {
    m_level = 1;
    m_exp = 0.f;
    m_health = 100.f;
    m_maxHealth = 100.f;
    calculateNextLevelExp();
}

void StatsManager::addExp(float amount) {
    if (amount <= 0) return;
    
    m_exp += amount;
    notify(GameEvent::PlayerGainedExp);

    if (m_exp >= m_expToNext) {
        m_exp -= m_expToNext;
        m_level++;
        calculateNextLevelExp();
        notify(GameEvent::PlayerLevelUp);
    }
}

void StatsManager::takeDamage(float amount) {
    if (amount <= 0) return;
    m_health -= amount;
    if (m_health < 0) m_health = 0;
    notify(GameEvent::PlayerTookDamage);
}

void StatsManager::heal(float amount) {
    if (amount <= 0) return;
    m_health += amount;
    if (m_health > m_maxHealth) m_health = m_maxHealth;
}

void StatsManager::calculateNextLevelExp() {
    // Standard RPG curve
    m_expToNext = 10.f + (m_level * 5.f) * std::pow(1.1f, m_level);
}
