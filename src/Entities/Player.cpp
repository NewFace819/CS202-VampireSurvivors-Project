#include "Player.h"

#include <iostream>

Player::Player() {
    m_position = sf::Vector2f(1280.f / 2.f, 720.f / 2.f);
    m_speed = 200.f;
    m_sprite.setPosition(m_position);
    m_facingDir = sf::Vector2f(1.f, 0.f);
    m_isActive = true;
}

void Player::setSprite(const std::string& texturePath) {
    if (m_texture.loadFromFile(texturePath)) {
        m_sprite.setTexture(m_texture);
        m_sprite.setTextureRect(sf::IntRect(0, 0, 32, 32)); // Slice first frame
        m_sprite.setOrigin(16.f, 16.f); // Half of 32x32
        m_sprite.setScale(2.f, 2.f); // Scale up for gameplay visibility
    } else {
        std::cerr << "Failed to load player sprite: " << texturePath << std::endl;
    }
}

void Player::update(float dt) {
    sf::Vector2f dir(0.f, 0.f);
    
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::W)) dir.y -= 1.f;
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::S)) dir.y += 1.f;
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::A)) dir.x -= 1.f;
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::D)) dir.x += 1.f;

    // Normalize diagonal movement
    if (dir.x != 0.f && dir.y != 0.f) {
        dir.x *= 0.7071f;
        dir.y *= 0.7071f;
    }

    if (dir.x != 0.f || dir.y != 0.f) {
        m_facingDir = dir;
        
        // Flip sprite based on direction
        if (dir.x < 0) m_sprite.setScale(-2.f, 2.f);
        else if (dir.x > 0) m_sprite.setScale(2.f, 2.f);
    }

    m_velocity = dir * m_speed;
    m_position += m_velocity * dt;
    m_sprite.setPosition(m_position);
}

void Player::draw(sf::RenderWindow& window) {
    window.draw(m_sprite);
}

sf::FloatRect Player::getBounds() const {
    return m_sprite.getGlobalBounds();
}
