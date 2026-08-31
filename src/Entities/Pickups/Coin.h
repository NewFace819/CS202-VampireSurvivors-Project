#pragma once
#include "Entities/Pickups/Collectible.h"
#include "States/Game/PlayingState.h"
#include "Core/Data/ProfileManager.h"

class Coin : public Collectible {
public:
    Coin() : m_goldValue(0) {}

    void init(const sf::Vector2f& pos, int goldValue) {
        m_position = pos;
        m_goldValue = goldValue;
        m_isActive = true;
        m_isMagnetized = false;
        
        if (!m_coinTex) {
            m_coinTex = new sf::Texture();
            if (m_coinTex->loadFromFile("assets/Graphics/Spritesheets/UI.png")) {
                m_hasCoinTex = true;
            }
        }
        
        if (m_hasCoinTex) {
            m_sprite.setTexture(*m_coinTex);
            // CoinGold icon in UI.png
            m_sprite.setTextureRect(sf::IntRect(1011, 359, 12, 12));
            m_sprite.setOrigin(6.f, 6.f);
            m_sprite.setScale(1.5f, 1.5f);
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
        // No collector known: shop Greed only.
        float greed = ProfileManager::GetInstance().getGreedMultiplier();
        playing->addGoldToRun(static_cast<int>(m_goldValue * greed));
        m_isActive = false; // deactivate
    }

    void onPickupPlayer(PlayingState* playing, Player* collector) override {
        // Shop Greed rank plus the collector's Stone Mask passive.
        float greed = ProfileManager::GetInstance().getGreedMultiplier();
        if (collector) greed += collector->getPassiveGreed();
        playing->addGoldToRun(static_cast<int>(m_goldValue * greed));
        m_isActive = false;
    }

private:
    int m_goldValue;
    
    inline static sf::Texture* m_coinTex = nullptr;
    inline static bool m_hasCoinTex = false;
};
