#include "Entities/ShooterEnemy.h"
#include <cstdlib>

ShooterEnemy::ShooterEnemy() : EnemyBase() {
    m_wantsToShoot = false;
    m_shootTimer = 0.f;
}

void ShooterEnemy::init(const sf::Vector2f& startPos, const EnemyStats& stats, sf::Texture* texture) {
    EnemyBase::init(startPos, stats, texture);
    m_wantsToShoot = false;
    
    if (m_stats.shootCooldown > 0.f) {
        // Stagger the first shot so enemies don't all fire at the exact same millisecond
        m_shootTimer = (static_cast<float>(std::rand()) / RAND_MAX) * m_stats.shootCooldown;
    } else {
        m_shootTimer = 0.f;
    }
}

void ShooterEnemy::update(float dt) {
    // Perform standard base behavior (movement, animation, knockback)
    EnemyBase::update(dt);

    // If alive and shooting is configured, update the shooting clock
    if (m_isActive && !m_isDying && m_stats.shootCooldown > 0.f && m_target) {
        m_shootTimer -= dt;
        if (m_shootTimer <= 0.f) {
            m_wantsToShoot = true;
            m_shootTimer = m_stats.shootCooldown;
        }
    }
}
