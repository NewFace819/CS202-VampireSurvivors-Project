#pragma once
#include "Entities/Entity.h"
#include <SFML/Graphics.hpp>

// Represents a solid interactive obstacle on the map (tables, pianos, pillars)
class Obstacle : public Entity {
public:
    Obstacle(const sf::Vector2f& pos, const sf::Texture& texture, 
             const sf::IntRect& textureRect, float scale = 2.0f, 
             float collisionFootprintRatio = 0.4f, float widthRatio = 1.0f);

    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    sf::FloatRect getBounds() const override;

    const sf::Sprite& getSprite() const { return m_sprite; }
    void setVisible(bool visible) { m_isVisible = visible; }
    bool isVisible() const { return m_isVisible; }
    bool hasCollision() const { return m_footprintRatio > 0.0f; }
    float getFootprintRatio() const { return m_footprintRatio; }
    float getWidthRatio() const { return m_widthRatio; }

private:
    sf::Sprite m_sprite;
    float m_footprintRatio; // Fraction of bottom height used for collision
    float m_widthRatio;     // Fraction of width used for collision (centered)
    bool m_isVisible = true;
};
