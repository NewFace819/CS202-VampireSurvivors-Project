#pragma once

#include "States/Game/GameState.h"
#include "States/Game/PlayingState.h"
#include <SFML/Graphics.hpp>

class GameManager;

class StageLoadingState : public GameState {
public:
    StageLoadingState(GameManager* manager, StageType stageType, CharacterType charType);
    ~StageLoadingState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    StageType m_stageType;
    CharacterType m_charType;
    
    sf::Font m_font;
    sf::Text m_textTop;
    sf::Text m_textMiddle;
    sf::Text m_textBottom;

    float m_elapsed;
    float m_duration;
    bool m_isLoaded;
    
    std::unique_ptr<GameState> m_nextState;
};
