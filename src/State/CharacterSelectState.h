#pragma once
#include "State/GameState.h"
#include <SFML/Graphics.hpp>

#include "State/PlayingState.h"

class GameManager;

class CharacterSelectState : public GameState {
public:
    CharacterSelectState(GameManager* manager);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    
    sf::Font m_font;
    sf::Text m_titleText;

    struct CharacterPanel {
        CharacterType type;
        sf::RectangleShape panel;
        sf::Texture tex;
        sf::Sprite sprite;
        sf::Text name;
        sf::Text weapon;
    };

    std::vector<CharacterPanel> m_panels;
    float m_timeInState = 0.f;
};
