#include "EnemyBase.h"
#include <cmath>
EnemyBase::EnemyBase()
    : m_hp(0), m_maxHp(0), m_target(nullptr) {
    m_shape.setRadius(20.f);
    m_shape.setFillColor(sf::Color::Red);
    m_shape.setOrigin(20.f, 20.f);
}

void EnemyBase::init(const sf::Vector2f& startPos, float hp, float speed, float radius, sf::Color color, sf::Texture* texture, const std::vector<sf::IntRect>& movingRects, const std::vector<sf::IntRect>& deathRects) {
    m_position = startPos;
    m_hp = hp;
    m_maxHp = hp;
    m_speed = speed;
    m_isActive = true;
    
    m_shape.setRadius(radius);
    m_shape.setOrigin(radius, radius);
    m_shape.setPosition(m_position);
    m_shape.setFillColor(color);
    
    m_texture = texture;
    m_movingRects = movingRects;
    m_deathRects = deathRects;
    m_animTimer = 0.f;
    m_currentFrame = 0;
    m_isDying = false;
    
    if (m_texture) {
        m_sprite.setTexture(*m_texture, true);
        if (!m_movingRects.empty()) {
            m_sprite.setTextureRect(m_movingRects[0]);
            m_sprite.setOrigin(m_movingRects[0].width / 2.f, m_movingRects[0].height / 2.f);
        } else {
            m_sprite.setOrigin(m_texture->getSize().x / 2.f, m_texture->getSize().y / 2.f);
        }
        m_sprite.setPosition(m_position);
        
        // Use color parameter to tint the sprite, allowing easy palette swaps
        m_sprite.setColor(color);
    }
}

void EnemyBase::update(float dt) {
    if (!m_isActive) return;

    if (m_isDying) {
        if (m_texture && !m_deathRects.empty()) {
            m_animTimer += dt;
            if (m_animTimer >= 0.1f) {
                m_animTimer = 0.f;
                m_currentFrame++;
                if (m_currentFrame >= m_deathRects.size()) {
                    m_isActive = false; // Finished death animation
                } else {
                    m_sprite.setTextureRect(m_deathRects[m_currentFrame]);
                    m_sprite.setOrigin(m_deathRects[m_currentFrame].width / 2.f, m_deathRects[m_currentFrame].height / 2.f);
                }
            }
        } else {
            m_isActive = false;
        }
        return;
    }

    if (!m_target) return;

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
    
    if (m_texture) {
        m_sprite.setPosition(m_position);
        
        // Flip sprite based on direction
        if (dir.x < 0) {
            m_sprite.setScale(-1.f, 1.f);
        } else if (dir.x > 0) {
            m_sprite.setScale(1.f, 1.f);
        }
        
        // Update animation
        if (!m_movingRects.empty()) {
            m_animTimer += dt;
            if (m_animTimer >= 0.15f) {
                m_animTimer = 0.f;
                m_currentFrame = (m_currentFrame + 1) % m_movingRects.size();
                m_sprite.setTextureRect(m_movingRects[m_currentFrame]);
                m_sprite.setOrigin(m_movingRects[m_currentFrame].width / 2.f, m_movingRects[m_currentFrame].height / 2.f);
            }
        }
    } else {
        m_shape.setPosition(m_position);
    }
}

void EnemyBase::draw(sf::RenderWindow& window) {
    if (m_isActive) {
        if (m_texture) {
            window.draw(m_sprite);
        } else {
            window.draw(m_shape);
        }
    }
}

sf::FloatRect EnemyBase::getBounds() const {
    return m_shape.getGlobalBounds();
}

void EnemyBase::takeDamage(float amount) {
    if (m_isDying) return;

    m_hp -= amount;
    if (m_hp <= 0) {
        m_hp = 0;
        m_isDying = true;
        m_animTimer = 0.f;
        m_currentFrame = 0;
        if (!m_deathRects.empty()) {
            m_sprite.setTextureRect(m_deathRects[0]);
            m_sprite.setOrigin(m_deathRects[0].width / 2.f, m_deathRects[0].height / 2.f);
        } else {
            m_isActive = false;
        }
    }
}
