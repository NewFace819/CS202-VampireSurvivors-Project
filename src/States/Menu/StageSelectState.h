#pragma once
#include "States/Game/GameState.h"
#include "States/Game/PlayingState.h"
#include <SFML/Graphics.hpp>
#include <vector>

class GameManager;

class StageSelectState : public GameState {
public:
    StageSelectState(GameManager* manager, CharacterType charType);
    StageSelectState(GameManager* manager, const std::vector<CharacterType>& charTypes);
    ~StageSelectState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    std::vector<CharacterType> m_charTypes;
    
    sf::Font m_font;
    sf::Text m_titleText;

    struct StagePanel {
        StageType type;
        sf::RectangleShape panel;
        sf::Text name;
        sf::Text description;
    };

    std::vector<StagePanel> m_panels;
    float m_timeInState = 0.f;
};
