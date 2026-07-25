#include "Entities/Obstacle.h"

Obstacle::Obstacle(const sf::Vector2f& pos, const sf::Texture& texture, 
                   const sf::IntRect& textureRect, float scale, 
                   float collisionFootprintRatio)
    : m_footprintRatio(collisionFootprintRatio) {
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
    if (m_isActive) {
        window.draw(m_sprite);
    }
}

sf::FloatRect Obstacle::getBounds() const {
    sf::FloatRect spriteBounds = m_sprite.getGlobalBounds();
    float collisionHeight = spriteBounds.height * m_footprintRatio;
    
    // Return bottom portion of the sprite bounds as the physical collision footprint
    return sf::FloatRect(
        spriteBounds.left,
        spriteBounds.top + spriteBounds.height - collisionHeight,
        spriteBounds.width,
        collisionHeight
    );
}
