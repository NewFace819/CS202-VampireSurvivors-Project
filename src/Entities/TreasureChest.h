#pragma once
#include <SFML/Graphics.hpp>

// A treasure chest dropped by boss enemies.
// When the player walks over it, it triggers a weapon evolution check.
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
            // TreasureIdle_01 in UI.png (x: 448, y: 649, w: 32, h: 22 -> flipped y: 353)
            m_sprite.setTextureRect(sf::IntRect(448, 353, 32, 22));
            m_sprite.setOrigin(16.f, 11.f);
            m_sprite.setPosition(m_position);
            m_sprite.setScale(1.5f, 1.5f);
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

        // Pulse timer for glow effect
        m_pulseTimer = 0.f;
    }

    void update(float dt) {
        if (!m_active) return;
        m_pulseTimer += dt * 3.f;
        
        // Pulsing glow/transparency effect
        float glow = (std::sin(m_pulseTimer) + 1.f) / 2.f; // 0..1
        int alpha = static_cast<int>(180 + glow * 75);
        if (m_hasTex) {
            m_sprite.setColor(sf::Color(255, 255, 255, alpha));
        } else {
            m_shape.setFillColor(sf::Color(228, 199, 109, alpha));
        }
    }

    void draw(sf::RenderWindow& window) const {
        if (!m_active) return;
        if (m_hasTex) {
            window.draw(m_sprite);
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
    inline static sf::Texture* m_chestTex = nullptr;
    inline static bool m_hasTex = false;
};
