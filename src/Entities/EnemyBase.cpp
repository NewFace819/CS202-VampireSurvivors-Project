#include "EnemyBase.h"
#include <cmath>
EnemyBase::EnemyBase()
    : m_hp(0), m_maxHp(0), m_target(nullptr) {
    m_shape.setRadius(20.f);
    m_shape.setFillColor(sf::Color::Red);
    m_shape.setOrigin(20.f, 20.f);
}

void EnemyBase::init(const sf::Vector2f& startPos, float hp, float speed, float radius, sf::Color color) {
    m_position = startPos;
    m_hp = hp;
    m_maxHp = hp;
    m_speed = speed;
    m_isActive = true;
    m_shape.setRadius(radius);
    m_shape.setOrigin(radius, radius);
    m_shape.setFillColor(color);
    m_shape.setPosition(m_position);
}

void EnemyBase::update(float dt) {
    if (!m_isActive || !m_target) return;

    // Move towards target (8-directional or direct vector)
    sf::Vector2f targetPos = m_target->getPosition();
    sf::Vector2f dir = targetPos - m_position;
    
    // Normalize direction
    float length = std::sqrt(dir.x * dir.x + dir.y * dir.y);
    if (length > 0) {
        dir /= length;
    }

    m_velocity = dir * m_speed;
    m_position += m_velocity * dt;
    
    m_shape.setPosition(m_position);
}

void EnemyBase::draw(sf::RenderWindow& window) {
    if (m_isActive) {
        window.draw(m_shape);
    }
}

sf::FloatRect EnemyBase::getBounds() const {
    return m_shape.getGlobalBounds();
}

void EnemyBase::takeDamage(float amount) {
    m_hp -= amount;
    if (m_hp <= 0) {
        m_isActive = false; // Die
    }
}
