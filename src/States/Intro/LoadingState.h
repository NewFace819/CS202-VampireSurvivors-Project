#pragma once
#include "States/Game/GameState.h"
#include "Core/Resources/TextureAtlas.h"
#include <memory>
#include <SFML/Graphics.hpp>
#include <string>
#include <functional>

class GameManager;

class LoadingState : public GameState {
public:
    using StateFactory = std::function<std::unique_ptr<GameState>()>;

    LoadingState(GameManager* manager, StateFactory factory, const std::string& texturePath, float minDuration = 1.0f);
    
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    StateFactory m_factory;
    std::unique_ptr<GameState> m_nextState;
    float m_duration;
    float m_elapsed;
    bool m_isLoaded;
    
    sf::Texture m_bgTexture;
    sf::Sprite m_bgSprite;
    
    // DLC Loading Screen specifics
    TextureAtlas m_itemsAtlas;
    std::vector<sf::IntRect> m_treasureFrames;
    sf::Sprite m_treasureSprite;
    float m_animTimer;
    int m_frameIndex;
    
    sf::Font m_font;
    sf::Text m_textTop;
    sf::Text m_textMiddle;
    sf::Text m_textBottom;
    
    int m_phase;
    float m_percent;
    std::vector<std::string> m_dlcNames;
    int m_currentDlcIndex;
    
    float m_stepTimer;
    float m_finalWaitTimer;
};
