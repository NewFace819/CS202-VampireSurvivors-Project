#pragma once
#include <SFML/Graphics.hpp>
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
    sf::Texture m_titleTexture;
    sf::Sprite m_titleSprite;
    sf::Texture m_playTexture;
    sf::Sprite m_playSprite;
    sf::Text m_promptText;
};
