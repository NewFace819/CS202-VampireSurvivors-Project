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

    while (m_exp >= m_expToNext) {
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
    // Vampire Survivors formula: 5 + (level - 1) * 10
    m_expToNext = 5.f + (m_level - 1) * 10.f;
}
