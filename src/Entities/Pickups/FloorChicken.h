#pragma once
#include "Entities/Pickups/Collectible.h"
#include "Core/Data/StatsManager.h"
#include "States/Game/PlayingState.h"

class FloorChicken : public Collectible {
public:
    FloorChicken() : m_healValue(0.f) {}

    void init(const sf::Vector2f& pos, float healValue) {
        m_position = pos;
        m_healValue = healValue;
        m_isActive = true;
        m_isMagnetized = false;
        
        loadTexture();
        if (m_hasTex) {
            m_sprite.setTexture(*m_tex);
            // Roast.asset: Unity x=301, y=256, w=16, h=16 -> SFML y=752
            m_sprite.setTextureRect(sf::IntRect(301, 752, 16, 16));
            m_sprite.setColor(sf::Color::White); // No tint needed - sprite has its own color
            m_sprite.setOrigin(8.f, 8.f);
            m_sprite.setScale(1.5f, 1.5f);
            m_sprite.setPosition(m_position);
            m_hasSprite = true;
        } else {
            m_fallbackShape.setRadius(6.f);
            m_fallbackShape.setFillColor(sf::Color::Red);
            m_fallbackShape.setOrigin(6.f, 6.f);
            m_fallbackShape.setPosition(m_position);
            m_hasSprite = false;
        }
    }

    void onPickup(PlayingState* playing) override {
        // Heal the player
        StatsManager::GetInstance().heal(m_healValue);
        m_isActive = false; // deactivate
    }

private:
    float m_healValue;
};
