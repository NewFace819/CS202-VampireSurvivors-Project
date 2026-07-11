#pragma once
#include "Entities/Collectible.h"
#include "State/PlayingState.h"

class Coin : public Collectible {
public:
    Coin() : m_goldValue(0) {}

    void init(const sf::Vector2f& pos, int goldValue) {
        m_position = pos;
        m_goldValue = goldValue;
        m_isActive = true;
        m_isMagnetized = false;
        
        loadTexture();
        if (m_hasTex) {
            m_sprite.setTexture(*m_tex);
            // Uses a gold-tinted small icon
            m_sprite.setTextureRect(sf::IntRect(378, 790, 16, 16));
            m_sprite.setColor(sf::Color(255, 223, 0)); // Gold/Yellow
            m_sprite.setOrigin(8.f, 8.f);
            m_sprite.setScale(1.3f, 1.3f);
            m_sprite.setPosition(m_position);
            m_hasSprite = true;
        } else {
            m_fallbackShape.setRadius(5.f);
            m_fallbackShape.setFillColor(sf::Color(255, 215, 0)); // Gold
            m_fallbackShape.setOrigin(5.f, 5.f);
            m_fallbackShape.setPosition(m_position);
            m_hasSprite = false;
        }
    }

    void onPickup(PlayingState* playing) override {
        // Grant Gold directly
        playing->addGoldToRun(m_goldValue);
        m_isActive = false; // deactivate
    }

private:
    int m_goldValue;
};
