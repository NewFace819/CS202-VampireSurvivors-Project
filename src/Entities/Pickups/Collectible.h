#pragma once
#include "Entities/Entity.h"
#include "Entities/Player.h"
#include "Core/Data/ProfileManager.h"
#include <SFML/Graphics.hpp>
#include <iostream>
#include <cmath>

class PlayingState; // Forward declaration

class Collectible : public Entity {
public:
    Collectible() : m_isMagnetized(false), m_hasSprite(false) {
        m_isActive = true;
        m_speed = 400.f; // Magnetic pull speed
    }
    virtual ~Collectible() = default;

    void loadTexture() {
        if (!m_hasTex) {
            if (!m_tex) {
                m_tex = new sf::Texture();
            }
            if (m_tex->loadFromFile("assets/Graphics/Spritesheets/items.png")) {
                m_hasTex = true;
            } else {
                std::cerr << "Collectible: Failed to load items.png texture!\n";
            }
        }
    }

    void update(float dt) override {
        if (!m_isActive) return;
        updatePosition();
    }

    virtual void update(float dt, Player* player) {
        if (!m_isActive || !player) return;

        sf::Vector2f delta = player->getPosition() - m_position;
        float distSq = delta.x * delta.x + delta.y * delta.y;
        
        // Magnet radius (e.g. 100 pixels, boosted by Magnet powerup/upgrades)
        float magnetRadius = 100.0f * (1.f + ProfileManager::GetInstance().getMagnetBonus());
        if (distSq < magnetRadius * magnetRadius) {
            m_isMagnetized = true;
        }

        if (m_isMagnetized) {
            float dist = std::sqrt(distSq);
            if (dist > 0.0001f) {
                sf::Vector2f dir = delta / dist;
                m_position += dir * m_speed * dt;
                updatePosition();
            }
        }
    }

    void draw(sf::RenderWindow& window) override {
        if (!m_isActive) return;
        if (m_hasSprite && m_hasTex) {
            window.draw(m_sprite);
        } else {
            window.draw(m_fallbackShape);
        }
    }

    sf::FloatRect getBounds() const override {
        if (m_hasSprite && m_hasTex) {
            return m_sprite.getGlobalBounds();
        }
        return m_fallbackShape.getGlobalBounds();
    }

    virtual void onPickup(PlayingState* playing) = 0;

protected:
    void updatePosition() {
        if (m_hasSprite) {
            m_sprite.setPosition(m_position);
        } else {
            m_fallbackShape.setPosition(m_position);
        }
    }

    bool m_isMagnetized;
    bool m_hasSprite;
    sf::Sprite m_sprite;
    sf::CircleShape m_fallbackShape;

    inline static sf::Texture* m_tex = nullptr;
    inline static bool m_hasTex = false;
};
