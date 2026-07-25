#pragma once
#include <SFML/Graphics.hpp>
#include <cmath>

// A treasure chest dropped by boss enemies.
// When the player walks over it, it triggers the TreasureChestState card opening screen.
class TreasureChest {
public:
    TreasureChest() : m_active(false) {}

    void init(const sf::Vector2f& position) {
        m_position = position;
        m_active = true;
        
        if (!m_chestTex) {
            m_chestTex = new sf::Texture();
            if (m_chestTex->loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/UI.png")) {
                m_hasTex = true;
            }
        }

        if (m_hasTex) {
            m_sprite.setTexture(*m_chestTex);
            // TreasureIdle_03 in UI.png (x: 995, y: 517, w: 28, h: 27 -> SFML y: 1024 - 517 - 27 = 480)
            m_sprite.setTextureRect(sf::IntRect(995, 480, 28, 27));
            m_sprite.setOrigin(14.f, 13.5f);
            m_sprite.setPosition(m_position);
            m_sprite.setScale(1.7f, 1.7f);

            // Bouncing Indicator Arrow (arrow_01: x: 297, y: 588, w: 16, h: 15 -> SFML y: 1024 - 588 - 15 = 421)
            m_arrowSprite.setTexture(*m_chestTex);
            m_arrowSprite.setTextureRect(sf::IntRect(297, 421, 16, 15));
            m_arrowSprite.setOrigin(8.f, 7.5f);
            m_arrowSprite.setScale(2.0f, 2.0f);
        } else {
            // Fallback Visual: golden box
            m_shape.setSize(sf::Vector2f(32.f, 28.f));
            m_shape.setOrigin(16.f, 14.f);
            m_shape.setPosition(m_position);
            m_shape.setFillColor(sf::Color(228, 199, 109)); // Gold
            m_shape.setOutlineThickness(2.f);
            m_shape.setOutlineColor(sf::Color(180, 140, 40));

            // Lid decoration
            m_lid.setSize(sf::Vector2f(36.f, 10.f));
            m_lid.setOrigin(18.f, 10.f);
            m_lid.setPosition(m_position.x, m_position.y - 10.f);
            m_lid.setFillColor(sf::Color(200, 170, 80));
            m_lid.setOutlineThickness(2.f);
            m_lid.setOutlineColor(sf::Color(180, 140, 40));
        }

        m_pulseTimer = 0.f;
    }

    void update(float dt) {
        if (!m_active) return;
        m_pulseTimer += dt * 4.f;
        
        // Pulsing glow/transparency effect for chest
        float glow = (std::sin(m_pulseTimer) + 1.f) / 2.f; // 0..1
        int alpha = static_cast<int>(190 + glow * 65);
        if (m_hasTex) {
            m_sprite.setColor(sf::Color(255, 255, 255, alpha));
            
            // Bobbing arrow indicator right above the chest
            float bobOffset = std::sin(m_pulseTimer * 1.5f) * 6.f;
            m_arrowSprite.setPosition(m_position.x, m_position.y - 34.f + bobOffset);
            // Flash arrow color slightly to alert the player
            float arrowGlow = (std::cos(m_pulseTimer * 1.5f) + 1.f) / 2.f;
            m_arrowSprite.setColor(sf::Color(255, 230 + static_cast<int>(arrowGlow * 25), 100 + static_cast<int>(arrowGlow * 100)));
        } else {
            m_shape.setFillColor(sf::Color(228, 199, 109, alpha));
        }
    }

    void draw(sf::RenderWindow& window) const {
        if (!m_active) return;
        if (m_hasTex) {
            window.draw(m_sprite);
            window.draw(m_arrowSprite);
        } else {
            window.draw(m_shape);
            window.draw(m_lid);
        }
    }

    sf::FloatRect getBounds() const {
        if (m_hasTex) {
            return m_sprite.getGlobalBounds();
        }
        return m_shape.getGlobalBounds();
    }

    bool isActive() const { return m_active; }
    void deactivate() { m_active = false; }
    sf::Vector2f getPosition() const { return m_position; }

private:
    sf::Vector2f m_position;
    bool m_active;
    sf::RectangleShape m_shape;
    sf::RectangleShape m_lid;
    float m_pulseTimer;

    sf::Sprite m_sprite;
    sf::Sprite m_arrowSprite;
    inline static sf::Texture* m_chestTex = nullptr;
    inline static bool m_hasTex = false;
};
