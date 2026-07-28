#pragma once
#include <SFML/Graphics.hpp>
#include <memory>
#include <vector>
#include <string>
#include "States/Game/GameState.h"
#include "Core/Resources/TextureAtlas.h"
#include "Core/Data/PowerUpDataManager.h"
#include "Core/Data/PlayerProgressionManager.h"
#include "UI/Components/NineSliceComponent.h"

class GameManager;
class UIGridLayout;
class UIDetailPanel;
class UIScrollView;
class GoldDisplayWidget;
class UIButton;
struct PowerUpData;

class ShopState : public GameState {
public:
    explicit ShopState(GameManager* manager);
    ~ShopState() override;

    void enter() override;
    void handleEvent(const sf::Event& event, sf::RenderWindow& window) override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    sf::Font m_font;
    sf::Font m_boldFont;
    sf::Text m_titleText;

    TextureAtlas m_atlas;
    PowerUpDataManager m_powerUpData;
    PlayerProgressionManager m_progressionData;

    NineSliceComponent m_mainFrame;
    std::unique_ptr<UIScrollView> m_scrollView;
    UIGridLayout* m_gridLayout = nullptr; // Owned by m_scrollView
    std::unique_ptr<UIDetailPanel> m_detailPanel;
    std::unique_ptr<GoldDisplayWidget> m_goldDisplay;
    std::unique_ptr<UIButton> m_refundButton;
    std::unique_ptr<UIButton> m_backButton;

    sf::RenderTexture m_compositeTexture;
    sf::Sprite m_compositeSprite;
    TextureAtlas m_illustAtlas;
    std::vector<sf::Sprite> m_illustrations;

    float m_timeInState = 0.f;
    bool m_uiInitialized = false;


    void initUI();
    void SetupCompositeBackground();
    void refreshGridData();
    void syncUpgradesWithProfileManager();
    PowerUpData convertToUIData(const std::string& powerUpId);
};

