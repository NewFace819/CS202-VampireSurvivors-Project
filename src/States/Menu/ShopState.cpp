#include "States/Menu/ShopState.h"
#include "States/Menu/MainMenuState.h"
#include "Core/GameManager.h"
#include "Core/WindowSettings.h"
#include "Core/Data/ProfileManager.h"
#include "Core/Data/PowerUpData.h"
#include "UI/Components/UIGridLayout.h"
#include "UI/Components/UIDetailPanel.h"
#include "UI/Components/UIScrollView.h"
#include "UI/Components/PowerUpCard.h"
#include "UI/Elements/GoldDisplayWidget.h"
#include "UI/Elements/UIButton.h"
#include <iostream>
#include <algorithm>

ShopState::ShopState(GameManager* manager)
    : m_manager(manager)
{
}

ShopState::~ShopState() = default;

void ShopState::enter() {
    std::cout << "Entering ShopState...\n";
    m_timeInState = 0.f;

    if (!m_uiInitialized) {
        initUI();
        m_uiInitialized = true;
    }
    
    // Refresh player gold & progress from disk/singleton before showing
    m_progressionData.Load("save_data.json");
    refreshGridData();
}

void ShopState::SetupCompositeBackground() {
    if (!m_manager) return;
    
    float width = m_manager->getWindow().getSize().x;
    float height = m_manager->getWindow().getSize().y;
    
    m_compositeTexture.create(static_cast<unsigned int>(width), static_cast<unsigned int>(height));
    m_compositeTexture.clear(sf::Color::Black);

    sf::Texture bgTex;
    if (bgTex.loadFromFile("assets/Graphics/Backgrounds/introBG_0.png")) {
        sf::Sprite bgSprite(bgTex);
        bgSprite.setOrigin(bgTex.getSize().x / 2.0f, bgTex.getSize().y / 2.0f);
        bgSprite.setPosition(width / 2.0f, height / 2.0f);

        float scaleX = width / static_cast<float>(bgTex.getSize().x);
        float scaleY = height / static_cast<float>(bgTex.getSize().y);
        float scale = std::max(scaleX, scaleY);
        bgSprite.setScale(scale, scale);

        m_compositeTexture.draw(bgSprite);
    }

    sf::Texture titleTex;
    if (titleTex.loadFromFile("assets/Graphics/Backgrounds/title.png")) {
        sf::Sprite titleSprite(titleTex);
        titleSprite.setOrigin(titleTex.getSize().x / 2.0f, titleTex.getSize().y / 2.0f);
        titleSprite.setPosition(width / 2.0f, height / 2.0f - 216.f);
        titleSprite.setScale(1.8f, 1.8f);
        m_compositeTexture.draw(titleSprite);
    }

    m_compositeTexture.display();
    m_compositeSprite.setTexture(m_compositeTexture.getTexture());
}

void ShopState::initUI() {
    // Use the game's official standard menu font
    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "[ShopState] Failed to load Courier_HintedSmooth font.\n";
    }
    if (!m_boldFont.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        m_boldFont = m_font;
    }

    // Initialize original composite background
    SetupCompositeBackground();

    // Load atlases for UI elements, item icons, and menu background illustrations
    if (!m_atlas.loadFromFile("assets/Graphics/Spritesheets/UI.png", "assets/Data/ui_atlas.json", true)) {
        std::cerr << "[ShopState] Could not load UI atlas!\n";
    }
    if (!m_atlas.loadFromFile("assets/Graphics/Spritesheets/items.png", "assets/Data/items_atlas.json", true)) {
        std::cerr << "[ShopState] Could not load items atlas!\n";
    }
    if (!m_illustAtlas.loadFromFile("assets/Graphics/Spritesheets/illustrations.png", "assets/Data/illustration_atlas.json", true)) {
        std::cerr << "[ShopState] Could not load illustration atlas!\n";
    }

    // Setup illustration sprites matching MainMenuState
    sf::Vector2f windowSize(m_manager->getWindow().getSize().x, m_manager->getWindow().getSize().y);
    m_illustrations.clear();
    for (int i = 0; i < 3; ++i) {
        sf::Sprite sprite;
        std::string key = "illustrations_" + std::to_string(i);
        AssetTextureData data = m_illustAtlas.GetTextureData(key);
        if (data.texture) {
            sprite.setTexture(*data.texture);
            sprite.setTextureRect(data.rect);
            sprite.setOrigin(data.rect.width / 2.0f, data.rect.height / 2.0f);
        }
        
        sf::Color c = sprite.getColor();
        if (i == 1) c.a = 90;
        else if (i == 2) c.a = 150;
        sprite.setColor(c);
        
        m_illustrations.push_back(sprite);
    }

    float textureGap = windowSize.x / 3.0f;
    if (m_illustrations.size() == 3) {
        m_illustrations[0].setPosition(windowSize.x / 2.0f, windowSize.y / 2.0f + 280.0f);
        m_illustrations[0].setScale(2.5f, 2.5f);
        
        m_illustrations[1].setPosition(windowSize.x / 2.0f - textureGap, windowSize.y / 2.0f + 230.0f);
        m_illustrations[1].setScale(4.9f, 4.9f);
        
        m_illustrations[2].setPosition(windowSize.x / 2.0f + textureGap, windowSize.y / 2.0f);
        m_illustrations[2].setScale(-3.0f, 3.0f);
    }

    // Load data structures
    m_powerUpData.LoadFromJson("assets/Data/POWERUP_DATA.json");
    m_progressionData.Load("save_data.json");

    // Central window frame (Dark purple with gold border, symmetrically centered)
    m_mainFrame.SetTexture(m_atlas, "frame_purple");
    m_mainFrame.SetMargins(15, 15, 15, 15);
    m_mainFrame.SetSize(sf::Vector2f(830.0f, 680.0f));
    m_mainFrame.setPosition(449.0f, 100.0f);
    m_mainFrame.SetCornerScale(2.5f);
    m_mainFrame.Update();

    // Title text centered inside main frame
    m_titleText.setFont(m_boldFont);
    m_titleText.setString("PowerUp Selection");
    m_titleText.setCharacterSize(38);
    m_titleText.setFillColor(sf::Color::White);
    sf::FloatRect textBounds = m_titleText.getLocalBounds();
    m_titleText.setPosition(864.0f - textBounds.width / 2.0f, 120.0f);

    // Gold Display Widget centered at top bar
    m_goldDisplay = std::make_unique<GoldDisplayWidget>(m_atlas, &m_progressionData, m_font);
    m_goldDisplay->SetPosition(sf::Vector2f(720.0f, 18.0f));

    // Back Button placed near top right in alignment with gold display
    m_backButton = std::make_unique<UIButton>(m_atlas, "button_c5_normal", 10, 10, 10, 10);
    m_backButton->SetText("BACK", m_font, 26);
    m_backButton->SetSize(sf::Vector2f(150.0f, 65.0f));
    m_backButton->SetCornerScale(2.0f);
    m_backButton->SetPosition(sf::Vector2f(1144.0f, 18.0f));
    m_backButton->SetOnClickCallback([this]() {
        if (m_manager) {
            m_manager->changeState(std::make_unique<MainMenuState>(m_manager));
        }
    });

    // Refund PowerUps button directly below title
    m_refundButton = std::make_unique<UIButton>(m_atlas, "button_c8_normal", 10, 10, 10, 10);
    m_refundButton->SetText("Refund PowerUps", m_font, 30);
    m_refundButton->SetSize(sf::Vector2f(740.0f, 55.0f));
    m_refundButton->SetCornerScale(2.5f);
    m_refundButton->SetPosition(sf::Vector2f(494.0f, 180.0f));
    m_refundButton->SetOnClickCallback([this]() {
        m_progressionData.RefundAllPowerUps(m_powerUpData);
        syncUpgradesWithProfileManager();
        refreshGridData();
    });

    // Detail Panel as a wide horizontal banner directly beneath the main frame
    m_detailPanel = std::make_unique<UIDetailPanel>(m_atlas, m_font);
    m_detailPanel->SetSize(sf::Vector2f(830.0f, 185.0f));
    m_detailPanel->SetCornerScale(2.5f);
    m_detailPanel->SetPosition(sf::Vector2f(449.0f, 795.0f));
    m_detailPanel->SetOnBuyClicked([this](const std::string& id) {
        if (!id.empty()) {
            int oldLevel = m_progressionData.GetPowerUpLevel(id);
            m_progressionData.BuyPowerUp(id, m_powerUpData);
            if (m_progressionData.GetPowerUpLevel(id) > oldLevel) {
                syncUpgradesWithProfileManager();
                refreshGridData();
            }
        }
    });

    // 4-Column Card Grid wrapped in UIScrollView with equal spacing and right-hand scrollbar
    auto grid = std::make_unique<UIGridLayout>(m_atlas, m_font);
    grid->SetGridProperties(4, 174.0f, 174.0f, 14.0f, 14.0f);
    grid->SetScale(1.0f);
    grid->SetPosition(sf::Vector2f(0.0f, 0.0f));
    grid->SetOnSelectionChangedCallback([this](const PowerUpData& selectedData) {
        if (m_detailPanel) {
            m_detailPanel->UpdateContent(selectedData);
        }
    });
    
    m_gridLayout = grid.get();

    m_scrollView = std::make_unique<UIScrollView>(760.0f, 510.0f, m_atlas);
    m_scrollView->SetPosition(sf::Vector2f(484.0f, 250.0f));
    m_scrollView->SetContent(std::move(grid));
}

PowerUpData ShopState::convertToUIData(const std::string& powerUpId) {
    const PowerUpProfile& profile = m_powerUpData.GetPowerUpById(powerUpId);
    PowerUpData data;
    data.id = profile.GetId();
    data.title = profile.GetName();
    data.description = profile.GetDescription();
    data.textureId = profile.GetFrameName();
    data.currentLevel = m_progressionData.GetPowerUpLevel(data.id);
    data.maxLevel = profile.GetMaxLevel();
    
    if (data.currentLevel < data.maxLevel) {
        data.price = m_progressionData.GetNextPowerUpPrice(data.id, m_powerUpData);
    } else {
        data.price = 0;
    }
    
    data.iconRect = m_atlas.getRect(data.textureId);
    data.emptyBoxRect = m_atlas.getRect("menu_checkbox_24_bg");
    data.filledBoxRect = m_atlas.getRect("menu_checkbox_24_checkmark");
    return data;
}

void ShopState::refreshGridData() {
    if (!m_gridLayout) return;

    std::vector<PowerUpData> dataset;
    const auto& order = m_powerUpData.GetPowerUpOrder();
    for (const auto& id : order) {
        dataset.push_back(convertToUIData(id));
    }
    
    int focusedIdx = m_gridLayout->GetFocusedIndex();
    m_gridLayout->SetDataset(dataset);
    
    if (focusedIdx >= 0 && focusedIdx < static_cast<int>(dataset.size())) {
        m_gridLayout->SelectIndex(focusedIdx);
    } else if (!dataset.empty()) {
        m_gridLayout->SelectIndex(0);
    }
}

void ShopState::syncUpgradesWithProfileManager() {
    ProfileManager& pm = ProfileManager::GetInstance();
    const auto& order = m_powerUpData.GetPowerUpOrder();
    for (const auto& id : order) {
        const PowerUpProfile& prof = m_powerUpData.GetPowerUpById(id);
        int lvl = m_progressionData.GetPowerUpLevel(id);
        pm.setUpgradeRank(prof.GetName(), lvl);
    }
    pm.save("save.txt");
}

void ShopState::handleEvent(const sf::Event& event, sf::RenderWindow& window) {
    if (!m_uiInitialized) return;

    if (m_scrollView) m_scrollView->HandleEvent(event, window);
    if (m_detailPanel) m_detailPanel->HandleEvent(event, window);
    if (m_refundButton) m_refundButton->HandleEvent(event, window);
    if (m_backButton) m_backButton->HandleEvent(event, window);
}

void ShopState::update(float dt) {
    m_timeInState += dt;
    if (!m_uiInitialized) return;

    m_mainFrame.Update();
    if (m_goldDisplay) m_goldDisplay->Update(dt);
    if (m_scrollView) m_scrollView->Update(dt);
    if (m_detailPanel) m_detailPanel->Update(dt);
    if (m_refundButton) m_refundButton->Update(dt);
    if (m_backButton) m_backButton->Update(dt);
}

void ShopState::draw(sf::RenderWindow& window) {
    window.draw(m_compositeSprite);
    for (const auto& sprite : m_illustrations) {
        window.draw(sprite);
    }
    window.draw(m_mainFrame);
    window.draw(m_titleText);
    if (m_goldDisplay) m_goldDisplay->Draw(window);
    if (m_scrollView) m_scrollView->Draw(window);
    if (m_detailPanel) m_detailPanel->Draw(window);
    if (m_refundButton) m_refundButton->Draw(window);
    if (m_backButton) m_backButton->Draw(window);
}

void ShopState::exit() {
    std::cout << "Exiting ShopState...\n";
}
