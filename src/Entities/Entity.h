#pragma once
#include <SFML/Graphics.hpp>
#include <string>

// Abstract base class for all game objects that have a physical presence
class Entity {
public:
    Entity();
    virtual ~Entity() = default;

    virtual void update(float dt) = 0;
    virtual void draw(sf::RenderWindow& window) = 0;

    // Core properties
    void setPosition(const sf::Vector2f& pos) { m_position = pos; }
    void setPosition(float x, float y) { m_position = sf::Vector2f(x, y); }
    sf::Vector2f getPosition() const { return m_position; }

    void setVelocity(const sf::Vector2f& vel) { m_velocity = vel; }
    sf::Vector2f getVelocity() const { return m_velocity; }

    // Flags
    void setActive(bool active) { m_isActive = active; }
    bool isActive() const { return m_isActive; }

    // Collision
    virtual sf::FloatRect getBounds() const = 0;

protected:
    sf::Vector2f m_position;
    sf::Vector2f m_velocity;
    float m_speed;
    bool m_isActive;
};
