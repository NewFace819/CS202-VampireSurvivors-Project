#pragma once
#include "Entity.h"

class Player : public Entity {
public:
    Player();
    
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    sf::FloatRect getBounds() const override;
    sf::Vector2f getFacingDir() const { return m_facingDir; }

private:
    sf::RectangleShape m_shape;
    sf::Vector2f m_facingDir;
};
