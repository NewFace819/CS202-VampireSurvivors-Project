#include "States/Game/SummaryState.h"
#include "States/Menu/MainMenuState.h"
#include "Core/GameManager.h"
#include <iostream>
#include <iomanip>
#include <sstream>

SummaryState::SummaryState(GameManager* manager, const RunSummaryData& runData)
    : m_manager(manager), m_runData(runData) {
}

std::string SummaryState::formatTime(float seconds) const {
    int m = static_cast<int>(seconds) / 60;
    int s = static_cast<int>(seconds) % 60;
    std::ostringstream oss;
    oss << std::setw(2) << std::setfill('0') << m << ":"
        << std::setw(2) << std::setfill('0') << s;
    return oss.str();
}

void SummaryState::enter() {
    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "SummaryState: Failed to load font!\n";
    }
    
    if (!m_uiAtlas.loadFromFile("assets/Graphics/Spritesheets/UI.png", "assets/data/ui_atlas.json", true)) {
        std::cerr << "SummaryState: Failed to load UI atlas!\n";
    }
    if (!m_itemsAtlas.loadFromFile("assets/Graphics/Spritesheets/items.png", "assets/data/items_atlas.json", true)) {
        std::cerr << "SummaryState: Failed to load items atlas!\n";
    }
    if (!m_charAtlas.loadFromFile("assets/Graphics/Characters/characters.png", "assets/data/characters_atlas.json", true)) {
        std::cerr << "SummaryState: Failed to load characters atlas!\n";
    }

    sf::Vector2u winSize = m_manager->getWindow().getSize();
    
    if (m_bgTexture.loadFromFile("assets/Graphics/Backgrounds/background.png")) {
        m_bgSprite.setTexture(m_bgTexture);
        sf::Vector2u texSize = m_bgTexture.getSize();
        m_bgSprite.setScale(static_cast<float>(winSize.x) / texSize.x, static_cast<float>(winSize.y) / texSize.y);
    }

    float panelW = winSize.x * 0.8f;
    float panelH = winSize.y * 0.8f;

    // Panel
    m_panel = std::make_unique<UIPanel>(m_uiAtlas, "frame1_c2", 12.f, 12.f, 12.f, 12.f);
    m_panel->SetSize(sf::Vector2f(panelW, panelH));
    m_panel->SetPosition(sf::Vector2f(winSize.x / 2.f - panelW / 2.f, winSize.y / 2.f - panelH / 2.f));

    // Title
    m_titleText.setFont(m_font);
    m_titleText.setString("Results");
    m_titleText.setCharacterSize(48);
    m_titleText.setFillColor(sf::Color::White);
    sf::FloatRect bounds = m_titleText.getLocalBounds();
    m_titleText.setOrigin(bounds.width / 2.f, bounds.height / 2.f);
    m_titleText.setPosition(winSize.x / 2.f, winSize.y / 2.f - panelH / 2.f + 40.f); // Title position

    // Map Info
    m_mapInfoText.setFont(m_font);
    m_mapInfoText.setString(m_runData.mapName + " - Normal - Gold x 1");
    m_mapInfoText.setCharacterSize(24);
    m_mapInfoText.setFillColor(sf::Color(255, 220, 100)); // Yellowish
    m_mapInfoText.setPosition(winSize.x / 2.f - panelW / 2.f + 40.f, m_titleText.getPosition().y + 50.f);

    // Stats
    float startY = m_mapInfoText.getPosition().y + 40.f;
    float leftX = winSize.x / 2.f - panelW / 2.f + 40.f;
    float rightX = winSize.x / 2.f - 40.f; // center divider roughly

    std::vector<std::pair<std::string, std::string>> stats = {
        {"Survived:", formatTime(m_runData.survivalTime)},
        {"Gold earned:", std::to_string(m_runData.goldEarned)},
        {"Level reached:", std::to_string(m_runData.levelReached)},
        {"Enemies defeated:", std::to_string(m_runData.enemiesDefeated)}
    };

    for (int i = 0; i < stats.size(); ++i) {
        sf::Text label, value;
        label.setFont(m_font); value.setFont(m_font);
        label.setCharacterSize(20); value.setCharacterSize(20);
        label.setFillColor(sf::Color::White); value.setFillColor(sf::Color::White);
        label.setString(stats[i].first);
        value.setString(stats[i].second);
        
        label.setPosition(leftX, startY + i * 30.f);
        
        sf::FloatRect vBounds = value.getLocalBounds();
        value.setPosition(rightX - vBounds.width, startY + i * 30.f);

        m_statsTexts.push_back(label);
        m_statsTexts.push_back(value);
    }

    // Weapons table
    float tableY = startY + 4 * 30.f + 30.f;
    
    // Headers
    std::vector<std::string> headers = {"Weapon", "LV", "Damage", "Time", "DPS"};
    float currentX = leftX;
    for (int i = 0; i < headers.size(); ++i) {
        sf::Text hText;
        hText.setFont(m_font);
        hText.setCharacterSize(18);
        hText.setFillColor(sf::Color(255, 220, 100));
        hText.setString(headers[i]);
        hText.setPosition(currentX, tableY);
        m_weaponTexts.push_back(hText);
        currentX += (i == 0) ? 150.f : 80.f;
    }

    // Rows
    for (size_t i = 0; i < m_runData.weapons.size(); ++i) {
        const auto& w = m_runData.weapons[i];
        float rowY = tableY + 30.f + i * 30.f;
        
        sf::Sprite wSprite;
        AssetTextureData assetData = m_itemsAtlas.GetTextureData(w.frameName);
        if (assetData.texture) {
            wSprite.setTexture(*assetData.texture);
            wSprite.setTextureRect(assetData.rect);
            wSprite.setOrigin(assetData.rect.width / 2.f, assetData.rect.height / 2.f);
        }
        wSprite.setPosition(leftX + 10.f, rowY + 12.f);
        wSprite.setScale(1.5f, 1.5f);
        m_weaponSprites.push_back(wSprite);

        sf::Text wName, wLevel, wDmg, wTime, wDps;
        wName.setFont(m_font); wLevel.setFont(m_font); wDmg.setFont(m_font);
        wTime.setFont(m_font); wDps.setFont(m_font);
        
        wName.setCharacterSize(18); wLevel.setCharacterSize(18); wDmg.setCharacterSize(18);
        wTime.setCharacterSize(18); wDps.setCharacterSize(18);

        wName.setString(w.name);
        wLevel.setString(std::to_string(w.level));
        
        std::ostringstream dmgStream, dpsStream;
        dmgStream << std::fixed << std::setprecision(1) << w.damage;
        dpsStream << std::fixed << std::setprecision(1) << w.dps;
        
        wDmg.setString(dmgStream.str());
        wTime.setString(formatTime(w.timeActive));
        wDps.setString(dpsStream.str());

        wName.setPosition(leftX + 30.f, rowY);
        wLevel.setPosition(leftX + 150.f, rowY);
        wDmg.setPosition(leftX + 230.f, rowY);
        wTime.setPosition(leftX + 310.f, rowY);
        wDps.setPosition(leftX + 390.f, rowY);

        m_weaponTexts.push_back(wName);
        m_weaponTexts.push_back(wLevel);
        m_weaponTexts.push_back(wDmg);
        m_weaponTexts.push_back(wTime);
        m_weaponTexts.push_back(wDps);
    }

    // Character Portrait
    std::string charLower = m_runData.characterName;
    std::transform(charLower.begin(), charLower.end(), charLower.begin(), ::tolower);
    std::string charKey = "p_" + charLower;
    
    AssetTextureData charData = m_charAtlas.GetTextureData(charKey);
    if (!charData.texture) {
        charData = m_charAtlas.GetTextureData("p_antonio"); // fallback
    }
    if (charData.texture) {
        m_charSprite.setTexture(*charData.texture);
        m_charSprite.setTextureRect(charData.rect);
        m_charSprite.setOrigin(charData.rect.width / 2.f, charData.rect.height / 2.f);
    }
    m_charSprite.setPosition(winSize.x / 2.f + 40.f, m_titleText.getPosition().y + 50.f);
    m_charSprite.setScale(2.f, 2.f);
    
    m_charNameText.setFont(m_font);
    m_charNameText.setString(m_runData.characterName);
    m_charNameText.setCharacterSize(20);
    m_charNameText.setFillColor(sf::Color(255, 220, 100));
    m_charNameText.setPosition(winSize.x / 2.f + 70.f, m_titleText.getPosition().y + 40.f);

    // Done Button
    m_doneBtn = std::make_unique<UIButton>(m_uiAtlas, "button_c9_normal", 6.f, 6.f, 6.f, 6.f);
    m_doneBtn->SetHoverTexture("button_c9_mouseover");
    m_doneBtn->SetPressTexture("button_c9_pressed");
    m_doneBtn->SetSize(sf::Vector2f(200.f, 60.f));
    m_doneBtn->SetPosition(sf::Vector2f(winSize.x / 2.f - 100.f, winSize.y / 2.f + panelH / 2.f - 70.f));
    m_doneBtn->SetText("DONE", m_font, 32);
    
    m_doneBtn->SetOnClickCallback([this]() {
        m_manager->clearAndChangeState(std::make_unique<MainMenuState>(m_manager));
    });
}

void SummaryState::update(float dt) {
    if (m_panel) m_panel->Update(dt);
    m_doneBtn->Update(dt);
}

void SummaryState::draw(sf::RenderWindow& window) {
    window.setView(window.getDefaultView());
    
    // Background is cleared to black by GameManager
    if (m_bgSprite.getTexture() != nullptr) {
        window.draw(m_bgSprite);
    }

    m_panel->Draw(window);
    
    // Draw center line
    sf::RectangleShape line(sf::Vector2f(2.f, m_panel->GetSize().y * 0.7f));
    line.setFillColor(sf::Color(200, 200, 200, 150));
    line.setPosition(window.getSize().x / 2.f, m_panel->GetPosition().y + 90.0f);
    window.draw(line);

    window.draw(m_titleText);
    window.draw(m_mapInfoText);

    for (const auto& t : m_statsTexts) window.draw(t);
    for (const auto& t : m_weaponTexts) window.draw(t);
    for (const auto& s : m_weaponSprites) window.draw(s);
    
    window.draw(m_charSprite);
    window.draw(m_charNameText);
    for (const auto& s : m_passiveSprites) window.draw(s);
    for (const auto& t : m_passiveLevelTexts) window.draw(t);

    m_doneBtn->Draw(window);
}

void SummaryState::handleEvent(const sf::Event& event, sf::RenderWindow& window) {
    m_doneBtn->HandleEvent(event, window);
}

void SummaryState::exit() {
}
