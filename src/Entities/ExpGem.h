#pragma once
#include <SFML/Graphics.hpp>
#include <cmath>
#include "Player.h"

class ExpGem {
public:
    ExpGem() : m_active(false), m_expValue(0.f) {}

    void init(const sf::Vector2f& pos, float expValue) {
        m_position = pos;
        m_expValue = expValue;
        m_active = true;
        m_isMagnetized = false;
        
        m_shape.setRadius(4.f);
        m_shape.setFillColor(sf::Color::Blue);
        m_shape.setOrigin(4.f, 4.f);
        m_shape.setPosition(m_position);
    }

    void update(float dt, Player* player) {
        if (!m_active || !player) return;

        // Collect radius check
        sf::Vector2f delta = player->getPosition() - m_position;
        float distSq = delta.x * delta.x + delta.y * delta.y;
        
        // Magnet radius (e.g. 100 pixels)
        float magnetRadius = 100.0f;
        if (distSq < magnetRadius * magnetRadius) {
            m_isMagnetized = true;
        }

        if (m_isMagnetized) {
            // Move towards player quickly
            float dist = std::sqrt(distSq);
            if (dist > 0.0001f) {
                sf::Vector2f dir = delta / dist;
                m_position += dir * 400.0f * dt; // Magnetic pull speed
                m_shape.setPosition(m_position);
            }
        }
    }

    void draw(sf::RenderWindow& window) {
        if (m_active) {
            window.draw(m_shape);
        }
    }

    bool isActive() const { return m_active; }
    void deactivate() { m_active = false; }
    
    float getExpValue() const { return m_expValue; }
    sf::Vector2f getPosition() const { return m_position; }
    sf::FloatRect getBounds() const { return m_shape.getGlobalBounds(); }

private:
    sf::Vector2f m_position;
    float m_expValue;
    bool m_active;
    bool m_isMagnetized;
    
    sf::CircleShape m_shape;
};
