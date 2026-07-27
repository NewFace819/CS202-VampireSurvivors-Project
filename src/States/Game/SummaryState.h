#pragma once
#include "States/Game/GameState.h"
#include "Core/Data/RunSummaryData.h"
#include "Core/Resources/TextureAtlas.h"
#include "UI/Panels/UIPanel.h"
#include "UI/Elements/UIButton.h"
#include <SFML/Graphics.hpp>
#include <memory>

class GameManager;

class SummaryState : public GameState {
public:
    SummaryState(GameManager* manager, const RunSummaryData& runData);
    ~SummaryState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;
    void handleEvent(const sf::Event& event, sf::RenderWindow& window) override;

private:
    GameManager* m_manager;
    RunSummaryData m_runData;

    sf::Texture m_bgTexture;
    sf::Sprite m_bgSprite;

    sf::Font m_font;
    TextureAtlas m_uiAtlas;
    TextureAtlas m_itemsAtlas;
    TextureAtlas m_charAtlas;

    // UI elements
    std::unique_ptr<UIPanel> m_panel;
    std::unique_ptr<UIButton> m_doneBtn;
    
    sf::Text m_titleText;
    sf::Text m_mapInfoText;
    
    std::vector<sf::Text> m_statsTexts;
    std::vector<sf::Text> m_weaponTexts;
    std::vector<sf::Sprite> m_weaponSprites;
    
    sf::Sprite m_charSprite;
    sf::Text m_charNameText;
    std::vector<sf::Sprite> m_passiveSprites;
    std::vector<sf::Text> m_passiveLevelTexts;

    std::string formatTime(float seconds) const;
};
