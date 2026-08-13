#include "Entities/Obstacle.h"

Obstacle::Obstacle(const sf::Vector2f& pos, const sf::Texture& texture, 
                   const sf::IntRect& textureRect, float scale, 
                   float collisionFootprintRatio, float widthRatio)
    : m_footprintRatio(collisionFootprintRatio), m_widthRatio(widthRatio) {
    setPosition(pos);
    m_sprite.setTexture(texture);
    m_sprite.setTextureRect(textureRect);
    m_sprite.setScale(scale, scale);
    
    // Origin at bottom-center for clean depth sorting and ground positioning
    m_sprite.setOrigin(textureRect.width / 2.0f, static_cast<float>(textureRect.height));
    m_sprite.setPosition(m_position);
    m_isActive = true;
}

void Obstacle::update(float dt) {
    m_sprite.setPosition(m_position);
}

void Obstacle::draw(sf::RenderWindow& window) {
    if (m_isActive && m_isVisible) {
        window.draw(m_sprite);
    }
    
    // Debug draw collision - disabled for release
    /*if (m_isActive && m_footprintRatio > 0.f) {
        sf::FloatRect bounds = getBounds();
        sf::RectangleShape debugRect(sf::Vector2f(bounds.width, bounds.height));
        debugRect.setPosition(bounds.left, bounds.top);
        debugRect.setFillColor(sf::Color(255, 0, 0, 100)); // semi-transparent red
        window.draw(debugRect);
    }*/
}

sf::FloatRect Obstacle::getBounds() const {
    sf::FloatRect spriteBounds = m_sprite.getGlobalBounds();
    float collisionWidth = spriteBounds.width * m_widthRatio;
    float collisionHeight = spriteBounds.height * m_footprintRatio;
    
    // Return centered, bottom-aligned portion of the sprite bounds as the physical collision footprint
    return sf::FloatRect(
        spriteBounds.left + (spriteBounds.width - collisionWidth) / 2.0f,
        spriteBounds.top + spriteBounds.height - collisionHeight,
        collisionWidth,
        collisionHeight
    );
}
