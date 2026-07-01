#pragma once
#include <SFML/Graphics.hpp>

class Agent {
public:
    virtual ~Agent() = default;
    
    virtual void update(float dt) = 0;
    virtual void draw(sf::RenderWindow& window) = 0;

    const sf::Vector2f& getPosition() const { return m_position; }
    void setPosition(const sf::Vector2f& position) { m_position = position; }

    const sf::Vector2f& getVelocity() const { return m_velocity; }
    void setVelocity(const sf::Vector2f& velocity) { m_velocity = velocity; }
    
    float getRadius() const { return m_radius; }
    void setRadius(float radius) { m_radius = radius; }

protected:
    sf::Vector2f m_position;
    sf::Vector2f m_velocity;
    float m_radius = 10.0f; // Default radius for collision
};
