#include "State/ShopState.h"
#include "State/MainMenuState.h"
#include "Engine/GameManager.h"
#include "Engine/ProfileManager.h"
#include <iostream>
#include <iomanip>

ShopState::ShopState(GameManager* manager) : m_manager(manager) {
    if (!m_font.loadFromFile("assets/ExportedProject/Assets/Font/Courier_HintedSmooth.ttf")) {
        std::cerr << "ShopState: Could not load font!\n";
    }
    
    initUI();
}

void ShopState::initUI() {
    sf::Vector2u wSize = m_manager->getWindow().getSize();
    float windowW = static_cast<float>(wSize.x);
    float windowH = static_cast<float>(wSize.y);

    // Title Text
    m_titleText.setFont(m_font);
    m_titleText.setString("META-UPGRADE SHOP");
    m_titleText.setCharacterSize(44);
    m_titleText.setFillColor(sf::Color(228, 199, 109)); // Gold
    m_titleText.setStyle(sf::Text::Bold);
    m_titleText.setPosition(windowW / 2.f - m_titleText.getGlobalBounds().width / 2.f, 25.f);

    // Gold Text
    m_goldText.setFont(m_font);
    m_goldText.setCharacterSize(22);
    m_goldText.setFillColor(sf::Color::White);
    m_goldText.setStyle(sf::Text::Bold);
    m_goldText.setPosition(50.f, 85.f);

    // Buttons at the bottom
    float btnY = windowH - 85.f;
    float btnW = 280.f;
    float btnH = 50.f;

    // Refund Button
    m_refundBtn.setSize(sf::Vector2f(btnW, btnH));
    m_refundBtn.setFillColor(sf::Color(120, 30, 30));
    m_refundBtn.setOutlineThickness(3.f);
    m_refundBtn.setOutlineColor(sf::Color(228, 199, 109));
    m_refundBtn.setPosition(windowW / 2.f - btnW - 30.f, btnY);

    m_refundText.setFont(m_font);
    m_refundText.setString("REFUND ALL");
    m_refundText.setCharacterSize(20);
    m_refundText.setFillColor(sf::Color::White);
    m_refundText.setStyle(sf::Text::Bold);
    sf::FloatRect rBounds = m_refundText.getLocalBounds();
    m_refundText.setOrigin(rBounds.left + rBounds.width / 2.f, rBounds.top + rBounds.height / 2.f);
    m_refundText.setPosition(m_refundBtn.getPosition().x + btnW / 2.f, m_refundBtn.getPosition().y + btnH / 2.f);

    // Back Button
    m_backBtn.setSize(sf::Vector2f(btnW, btnH));
    m_backBtn.setFillColor(sf::Color(40, 40, 40));
    m_backBtn.setOutlineThickness(3.f);
    m_backBtn.setOutlineColor(sf::Color(228, 199, 109));
    m_backBtn.setPosition(windowW / 2.f + 30.f, btnY);

    m_backText.setFont(m_font);
    m_backText.setString("BACK TO MENU");
    m_backText.setCharacterSize(20);
    m_backText.setFillColor(sf::Color::White);
    m_backText.setStyle(sf::Text::Bold);
    sf::FloatRect bBounds = m_backText.getLocalBounds();
    m_backText.setOrigin(bBounds.left + bBounds.width / 2.f, bBounds.top + bBounds.height / 2.f);
    m_backText.setPosition(m_backBtn.getPosition().x + btnW / 2.f, m_backBtn.getPosition().y + btnH / 2.f);

    // Position the 15 Power-ups in a 3 column x 5 row grid
    const auto& powerUps = ProfileManager::GetInstance().getPowerUpsList();
    
    float startX = 50.f;
    float startY = 135.f;
    float spacingX = 400.f;
    float spacingY = 95.f;
    float panelW = 380.f;
    float panelH = 85.f;

    // Adjust grid spacing based on window width
    if (windowW > 1300.f) {
        startX = (windowW - (3 * panelW + 2 * (spacingX - panelW))) / 2.f;
    }

    m_uiItems.clear();
    for (size_t i = 0; i < powerUps.size(); ++i) {
        int col = i / 5;
        int row = i % 5;
        float x = startX + col * spacingX;
        float y = startY + row * spacingY;

        ShopItemUI ui;
        ui.name = powerUps[i].name;

        // Background Panel
        ui.panel.setSize(sf::Vector2f(panelW, panelH));
        ui.panel.setPosition(x, y);
        ui.panel.setFillColor(sf::Color(30, 30, 30));
        ui.panel.setOutlineThickness(2.f);
        ui.panel.setOutlineColor(sf::Color(80, 80, 80));

        // Name Text
        ui.nameText.setFont(m_font);
        ui.nameText.setString(ui.name);
        ui.nameText.setCharacterSize(18);
        ui.nameText.setFillColor(sf::Color::White);
        ui.nameText.setStyle(sf::Text::Bold);
        ui.nameText.setPosition(x + 15.f, y + 10.f);

        // Description Text
        ui.descText.setFont(m_font);
        ui.descText.setString(powerUps[i].description);
        ui.descText.setCharacterSize(11);
        ui.descText.setFillColor(sf::Color(170, 170, 170));
        ui.descText.setPosition(x + 15.f, y + 58.f);

        // Cost Text
        ui.costText.setFont(m_font);
        ui.costText.setCharacterSize(15);
        ui.costText.setFillColor(sf::Color(228, 199, 109));
        ui.costText.setStyle(sf::Text::Bold);
        ui.costText.setPosition(x + panelW - 110.f, y + 12.f);

        // Level Indicators
        float indicatorStartX = x + 15.f;
        float indicatorStartY = y + 36.f;
        float boxW = 14.f;
        float boxH = 10.f;
        float boxSpacing = 4.f;

        for (int j = 0; j < powerUps[i].maxLevel; ++j) {
            sf::RectangleShape box(sf::Vector2f(boxW, boxH));
            box.setPosition(indicatorStartX + j * (boxW + boxSpacing), indicatorStartY);
            box.setOutlineThickness(1.f);
            box.setOutlineColor(sf::Color(200, 200, 200));
            box.setFillColor(sf::Color::Black);
            ui.levelBoxes.push_back(box);
        }

        m_uiItems.push_back(std::move(ui));
    }

    updateUI();
}

void ShopState::updateUI() {
    ProfileManager& pm = ProfileManager::GetInstance();
    
    // Update Gold Label
    m_goldText.setString("GOLD COINS: " + std::to_string(pm.getGold()));

    const auto& powerUps = pm.getPowerUpsList();
    for (size_t i = 0; i < m_uiItems.size(); ++i) {
        auto& ui = m_uiItems[i];
        const auto& pu = powerUps[i];
        int currentRank = pm.getUpgradeRank(ui.name);

        // Update Level Boxes color
        for (int j = 0; j < pu.maxLevel; ++j) {
            auto& box = ui.levelBoxes[j];
            if (j < currentRank) {
                box.setFillColor(sf::Color(228, 199, 109)); // Gold
                box.setOutlineColor(sf::Color(228, 199, 109));
            } else {
                box.setFillColor(sf::Color::Black);
                box.setOutlineColor(sf::Color(100, 100, 100));
            }
        }

        // Update Cost Label
        if (currentRank >= pu.maxLevel) {
            ui.costText.setString("   MAX");
            ui.costText.setFillColor(sf::Color(100, 220, 100));
        } else {
            int cost = pm.calculateRankCost(pu, currentRank + 1);
            ui.costText.setString("Cost: " + std::to_string(cost));
            
            if (pm.getGold() >= cost) {
                ui.costText.setFillColor(sf::Color(228, 199, 109)); // Gold
            } else {
                ui.costText.setFillColor(sf::Color(180, 50, 50)); // Red (can't afford)
            }
        }
    }
}

void ShopState::enter() {
    m_timeInState = 0.f;
    updateUI();
}

void ShopState::update(float dt) {
    m_timeInState += dt;
    sf::Vector2i mousePos = sf::Mouse::getPosition(m_manager->getWindow());
    sf::Vector2f mousePosF(static_cast<float>(mousePos.x), static_cast<float>(mousePos.y));

    // Handle Hover State for Buttons
    if (m_refundBtn.getGlobalBounds().contains(mousePosF)) {
        m_refundBtn.setFillColor(sf::Color(160, 40, 40));
    } else {
        m_refundBtn.setFillColor(sf::Color(120, 30, 30));
    }

    if (m_backBtn.getGlobalBounds().contains(mousePosF)) {
        m_backBtn.setFillColor(sf::Color(70, 70, 70));
    } else {
        m_backBtn.setFillColor(sf::Color(40, 40, 40));
    }

    // Handle Hover State for Upgrades
    for (auto& ui : m_uiItems) {
        if (ui.panel.getGlobalBounds().contains(mousePosF)) {
            ui.panel.setFillColor(sf::Color(55, 55, 55));
            ui.panel.setOutlineColor(sf::Color(228, 199, 109));
        } else {
            ui.panel.setFillColor(sf::Color(30, 30, 30));
            ui.panel.setOutlineColor(sf::Color(80, 80, 80));
        }
    }

    // Handle Click Events
    if (m_timeInState > 0.2f && sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
        m_timeInState = 0.f; // Debounce clicks

        // Refund Click
        if (m_refundBtn.getGlobalBounds().contains(mousePosF)) {
            ProfileManager::GetInstance().refundAll();
            updateUI();
            std::cout << "Refunded all power-ups!\n";
        }
        // Back Click
        else if (m_backBtn.getGlobalBounds().contains(mousePosF)) {
            m_manager->changeState(std::make_unique<MainMenuState>(m_manager));
        }
        // Upgrade click
        else {
            for (auto& ui : m_uiItems) {
                if (ui.panel.getGlobalBounds().contains(mousePosF)) {
                    if (ProfileManager::GetInstance().upgradePowerUp(ui.name)) {
                        std::cout << "Upgraded " << ui.name << " successfully!\n";
                        updateUI();
                    }
                    break;
                }
            }
        }
    }
}

void ShopState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color(20, 20, 20));

    window.draw(m_titleText);
    window.draw(m_goldText);

    // Draw Panels and Texts
    for (auto& ui : m_uiItems) {
        window.draw(ui.panel);
        window.draw(ui.nameText);
        window.draw(ui.descText);
        window.draw(ui.costText);
        
        // Draw the level indicator boxes for this item
        for (const auto& box : ui.levelBoxes) {
            window.draw(box);
        }
    }

    // Draw Buttons
    window.draw(m_refundBtn);
    window.draw(m_refundText);
    window.draw(m_backBtn);
    window.draw(m_backText);
}

void ShopState::exit() {
}
