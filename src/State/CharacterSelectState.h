#pragma once
#include "State/GameState.h"
#include <SFML/Graphics.hpp>

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

    // Antonio
    sf::Texture m_antonioTex;
    sf::Sprite m_antonioSprite;
    sf::Text m_antonioName;
    sf::Text m_antonioWeapon;
    sf::RectangleShape m_antonioPanel;

    // Imelda
    sf::Texture m_imeldaTex;
    sf::Sprite m_imeldaSprite;
    sf::Text m_imeldaName;
    sf::Text m_imeldaWeapon;
    sf::RectangleShape m_imeldaPanel;
};
