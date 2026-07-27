#pragma once
#include "States/Game/GameState.h"
#include "Core/Data/RunSummaryData.h"
#include <SFML/Graphics.hpp>
#include <memory>
#include "Core/Resources/TextureAtlas.h"
#include "UI/Elements/UIButton.h"

class GameManager;

class GameOverState : public GameState {
public:
    GameOverState(GameManager* manager, const RunSummaryData& runData);
    ~GameOverState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;
    void handleEvent(const sf::Event& event, sf::RenderWindow& window) override;

    bool isTransparent() const override { return true; } // Draw PlayingState underneath

private:
    GameManager* m_manager;
    RunSummaryData m_runData;

    sf::Font m_font;
    TextureAtlas m_uiAtlas;
    sf::Texture m_gameOverTex;
    sf::Sprite m_gameOverSprite;

    std::unique_ptr<UIButton> m_quitBtn;
    
    sf::RectangleShape m_bgOverlay;
    sf::Texture m_bgTexture;
    sf::Sprite m_bgSprite;
    
    float m_fadeTimer = 0.f;
    float m_fadeDuration = 2.f;
};
