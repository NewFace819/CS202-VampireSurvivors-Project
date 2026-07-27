#pragma once
#include <SFML/Graphics.hpp>
#include <vector>
#include <string>
#include "States/Game/GameState.h"
#include "UI/UIManager.h"
#include "UI/Elements/UIButton.h"
#include "Core/Resources/TextureAtlas.h"

class GameManager;

class MainMenuState : public GameState {
public:
    MainMenuState(GameManager* manager);
    ~MainMenuState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;
    void handleEvent(const sf::Event& event, sf::RenderWindow& window) override;

private:
    void SetupUI();
    void UpdateCursors(float dt);
    void SetupCompositeBackground();

    GameManager* m_manager;
    sf::Font m_font;
    
    TextureAtlas m_uiAtlas;
    TextureAtlas m_illustAtlas;
    
    sf::RenderTexture m_compositeTexture;
    sf::Sprite m_compositeSprite;
    
    std::vector<sf::Sprite> m_illustrations;
    sf::RectangleShape m_topBarBg;
    
    UIManager m_uiManager;
    std::vector<UIButton*> m_centralCluster;
    
    // Cursor logic
    std::vector<AssetTextureData> m_cursorFrames;
    sf::Sprite m_leftCursor;
    sf::Sprite m_rightCursor;
    
    float m_cursorAnimTimer = 0.0f;
    int m_currentCursorFrame = 0;
    bool m_cursorsVisible = false;
    
    static constexpr float CURSOR_FRAME_DURATION = 0.1f;
    static constexpr float UI_SCALE = 1.08f;
};
