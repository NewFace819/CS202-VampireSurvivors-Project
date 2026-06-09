#pragma once
#include "State/GameState.h"

class GameManager;

class MainMenuState : public GameState {
public:
    MainMenuState(GameManager* manager);
    ~MainMenuState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    sf::Font m_font;
    sf::Text m_titleText;
    sf::Text m_promptText;
};
