#include "Player.h"

Player::Player() {
    m_position = sf::Vector2f(1280.f / 2.f, 720.f / 2.f);
    m_speed = 200.f;
    m_shape.setSize(sf::Vector2f(20.f, 40.f));
    m_shape.setFillColor(sf::Color::Blue);
    m_shape.setOrigin(10.f, 20.f);
    m_shape.setPosition(m_position);
    m_facingDir = sf::Vector2f(1.f, 0.f);
    m_isActive = true;
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
    }

    m_velocity = dir * m_speed;
    m_position += m_velocity * dt;
    m_shape.setPosition(m_position);
}

void Player::draw(sf::RenderWindow& window) {
    window.draw(m_shape);
}

sf::FloatRect Player::getBounds() const {
    return m_shape.getGlobalBounds();
}
