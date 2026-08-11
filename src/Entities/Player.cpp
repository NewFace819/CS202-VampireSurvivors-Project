#include "Player.h"
#include "Core/Data/ProfileManager.h"
#include <iostream>

Player::Player() {
    m_position = sf::Vector2f(1280.f / 2.f, 720.f / 2.f);
    m_speed = 200.f;
    m_facingDir = sf::Vector2f(1.f, 0.f);
    m_isActive = true;

    if (m_badgeFont.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        m_hasFont = true;
    }

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

    if (m_playerId == 2) {
        // Player 2 controls: Arrow keys
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::Up))    dir.y -= 1.f;
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::Down))  dir.y += 1.f;
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::Left))  dir.x -= 1.f;
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::Right)) dir.x += 1.f;
    } else {
        // Player 1 controls: WASD keys
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::W)) dir.y -= 1.f;
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::S)) dir.y += 1.f;
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::A)) dir.x -= 1.f;
        if (sf::Keyboard::isKeyPressed(sf::Keyboard::D)) dir.x += 1.f;
    }

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
    sf::Color ringColor = (m_playerId == 2) ? sf::Color(255, 100, 100, 120) : sf::Color(100, 100, 255, 120);
    sf::CircleShape debugCircle(16.f);
    debugCircle.setOrigin(16.f, 16.f);
    debugCircle.setPosition(m_position);
    debugCircle.setFillColor(ringColor);
    window.draw(debugCircle);

    // Player Indicator Badge (P1 / P2) above player's head
    if (m_hasFont) {
        sf::Text badgeText;
        badgeText.setFont(m_badgeFont);
        badgeText.setString(m_playerId == 2 ? "P2" : "P1");
        badgeText.setCharacterSize(14);
        badgeText.setStyle(sf::Text::Bold);
        badgeText.setFillColor(m_playerId == 2 ? sf::Color(255, 80, 80) : sf::Color(80, 180, 255));
        badgeText.setOutlineColor(sf::Color::Black);
        badgeText.setOutlineThickness(1.5f);
        sf::FloatRect bounds = badgeText.getLocalBounds();
        badgeText.setOrigin(bounds.left + bounds.width / 2.f, bounds.top + bounds.height / 2.f);
        badgeText.setPosition(m_position.x, m_position.y - 28.f);
        window.draw(badgeText);
    }
}

sf::FloatRect Player::getBounds() const {
    if (m_hasSprite)
        return m_animSprite.getGlobalBounds();
    return m_fallbackShape.getGlobalBounds();
}

void Player::addExp(float amount) {
    m_exp += amount * ProfileManager::GetInstance().getGrowthMultiplier();
}

bool Player::checkLevelUp() {
    if (m_exp >= m_expToNext) {
        m_exp -= m_expToNext;
        m_level++;
        m_expToNext = 5.f + (m_level - 1) * 10.f;
        return true;
    }
    return false;
}
