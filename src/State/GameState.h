#pragma once
#include <SFML/Graphics.hpp>

class GameState {
public:
    virtual ~GameState() = default;
    virtual void enter() = 0;
    virtual void update(float dt) = 0;
    virtual void draw(sf::RenderWindow& window) = 0;
    virtual void exit() = 0;
    // Return true to draw the state below this one first (overlay states)
    virtual bool isTransparent() const { return false; }
};
