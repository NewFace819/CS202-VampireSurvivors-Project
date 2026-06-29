#pragma once
#include "State/GameState.h"
#include <SFML/Graphics.hpp>

class GameManager;

// A pause state that handles the Level Up UI (choosing a weapon/upgrade)
class LevelUpState : public GameState {
public:
    LevelUpState(GameManager* manager);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    sf::RectangleShape m_panel;
};
