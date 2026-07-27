#include "Player.h"
#include "Core/Data/ProfileManager.h"
#include <iostream>

Player::Player() {
    m_position = sf::Vector2f(1280.f / 2.f, 720.f / 2.f);
    m_speed = 200.f;
    m_facingDir = sf::Vector2f(1.f, 0.f);
    m_isActive = true;

    // Fallback blue rectangle if no sprite loaded
    m_fallbackShape.setSize(sf::Vector2f(20.f, 40.f));
    m_fallbackShape.setFillColor(sf::Color::Blue);
    m_fallbackShape.setOrigin(10.f, 20.f);
    m_fallbackShape.setPosition(m_position);
}

void Player::setSprite(const std::string& texturePath,
                       const std::vector<sf::IntRect>& walkFrames) {
    if (!m_texture.loadFromFile(texturePath)) {
        std::cerr << "Failed to load player sprite: " << texturePath << "\n";
        return;
    }
    m_walkFrames = walkFrames;
    m_animSprite.setTexture(m_texture);
    m_animSprite.setFrames(m_walkFrames, 8.f);
    m_animSprite.pause(); // Start paused (idle pose)
    m_animSprite.setOrigin(16.f, 16.f);
    m_animSprite.setScale(1.3f, 1.3f);
    m_animSprite.setPosition(m_position);
    m_hasSprite = true;
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

    bool wasMoving = m_isMoving;
    m_isMoving = (dir.x != 0.f || dir.y != 0.f);

    if (m_hasSprite) {
        // Switch animation state when movement changes
        if (m_isMoving != wasMoving) {
            if (m_isMoving) {
                m_animSprite.resume(); // Start walking animation
            } else {
                m_animSprite.pause(); // Freeze on current frame as idle pose
            }
        }

        // Flip sprite when moving left/right
        if (dir.x < 0)
            m_animSprite.setScale(-1.3f, 1.3f);
        else if (dir.x > 0)
            m_animSprite.setScale(1.3f, 1.3f);

        if (m_isMoving) m_facingDir = dir;
        m_animSprite.update(dt);
    }

    m_velocity = dir * m_speed * ProfileManager::GetInstance().getMoveSpeedMultiplier();
    m_position += m_velocity * dt;

    if (m_hasSprite)
        m_animSprite.setPosition(m_position);
    else
        m_fallbackShape.setPosition(m_position);
}

void Player::draw(sf::RenderWindow& window) {
    if (!m_isActive) return;
    
    if (m_hasSprite) {
        m_animSprite.draw(window);
    } else {
        window.draw(m_fallbackShape);
    }
    
    // Debug draw collision circle
    sf::CircleShape debugCircle(16.f);
    debugCircle.setOrigin(16.f, 16.f);
    debugCircle.setPosition(m_position);
    debugCircle.setFillColor(sf::Color(0, 0, 255, 100)); // semi-transparent blue
    window.draw(debugCircle);
}

sf::FloatRect Player::getBounds() const {
    if (m_hasSprite)
        return m_animSprite.getGlobalBounds();
    return m_fallbackShape.getGlobalBounds();
}
