#pragma once
#include <SFML/Graphics.hpp>
#include <cmath>
#include "Player.h"

class ExpGem {
public:
    ExpGem() : m_active(false), m_expValue(0.f) {}

    void loadTexture() {
        if (!m_hasTex) {
            if (!m_tex) {
                m_tex = new sf::Texture();
            }
            if (m_tex->loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/items.png")) {
                m_hasTex = true;
            }
        }
    }


    void init(const sf::Vector2f& pos, float expValue) {
        m_position = pos;
        m_expValue = expValue;
        m_active = true;
        m_isMagnetized = false;
        
        loadTexture();
        if (m_hasTex) {
            m_sprite.setTexture(*m_tex);
            // Frame mapping in items.png (1024 height)
            // GemBlue:  Unity y=666 -> SFML y = 1024 - 666 - 14 = 344
            // GemGreen: Unity y=649 -> SFML y = 1024 - 649 - 14 = 361
            // GemRed:   Unity y=632 -> SFML y = 1024 - 632 - 14 = 378
            sf::IntRect rect;
            if (m_expValue <= 2.f) {
                rect = sf::IntRect(436, 344, 11, 14); // Blue
            } else if (m_expValue <= 9.f) {
                rect = sf::IntRect(436, 361, 11, 14); // Green
            } else {
                rect = sf::IntRect(436, 378, 11, 14); // Red
            }
            m_sprite.setTextureRect(rect);
            m_sprite.setOrigin(5.5f, 7.f);
            m_sprite.setScale(1.5f, 1.5f);
            m_sprite.setPosition(m_position);
        } else {
            m_shape.setRadius(4.f);
            m_shape.setFillColor(sf::Color::Blue);
            m_shape.setOrigin(4.f, 4.f);
            m_shape.setPosition(m_position);
        }
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
                if (m_hasTex) {
                    m_sprite.setPosition(m_position);
                } else {
                    m_shape.setPosition(m_position);
                }
            }
        }
    }

    void draw(sf::RenderWindow& window) {
        if (m_active) {
            if (m_hasTex) {
                window.draw(m_sprite);
            } else {
                window.draw(m_shape);
            }
        }
    }

    bool isActive() const { return m_active; }
    void deactivate() { m_active = false; }
    
    float getExpValue() const { return m_expValue; }
    sf::Vector2f getPosition() const { return m_position; }
    sf::FloatRect getBounds() const { 
        return m_hasTex ? m_sprite.getGlobalBounds() : m_shape.getGlobalBounds(); 
    }

private:
    sf::Vector2f m_position;
    float m_expValue;
    bool m_active;
    bool m_isMagnetized;
    
    sf::CircleShape m_shape;
    sf::Sprite m_sprite;
    
    inline static sf::Texture* m_tex = nullptr;
    inline static bool m_hasTex = false;
};
