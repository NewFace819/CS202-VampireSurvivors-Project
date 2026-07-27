#pragma once
#include "Entities/Pickups/Collectible.h"
#include "Core/Data/StatsManager.h"
#include "States/Game/PlayingState.h"

class ExpGem : public Collectible {
public:
    ExpGem() : m_expValue(0.f) {}

    void init(const sf::Vector2f& pos, float expValue) {
        m_position = pos;
        m_expValue = expValue;
        m_isActive = true;
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
            m_hasSprite = true;
        } else {
            m_fallbackShape.setRadius(4.f);
            m_fallbackShape.setFillColor(sf::Color::Blue);
            m_fallbackShape.setOrigin(4.f, 4.f);
            m_fallbackShape.setPosition(m_position);
            m_hasSprite = false;
        }
    }

    void onPickup(PlayingState* playing) override {
        // Grant EXP
        StatsManager::GetInstance().addExp(m_expValue);
        m_isActive = false; // deactivate
    }

    float getExpValue() const { return m_expValue; }

private:
    float m_expValue;
};
