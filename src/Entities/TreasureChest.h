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
        
        // Visual: golden box
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

        // Pulse timer for glow effect
        m_pulseTimer = 0.f;
    }

    void update(float dt) {
        if (!m_active) return;
        m_pulseTimer += dt * 3.f;
        
        // Pulsing glow effect
        float glow = (std::sin(m_pulseTimer) + 1.f) / 2.f; // 0..1
        int alpha = static_cast<int>(180 + glow * 75);
        m_shape.setFillColor(sf::Color(228, 199, 109, alpha));
    }

    void draw(sf::RenderWindow& window) const {
        if (!m_active) return;
        window.draw(m_shape);
        window.draw(m_lid);
    }

    sf::FloatRect getBounds() const {
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
};
