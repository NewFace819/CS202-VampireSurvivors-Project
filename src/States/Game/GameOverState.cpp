#include "States/Game/GameOverState.h"
#include "States/Game/SummaryState.h"
#include "Core/GameManager.h"
#include <iostream>

GameOverState::GameOverState(GameManager* manager, const RunSummaryData& runData)
    : m_manager(manager), m_runData(runData) {
}

void GameOverState::enter() {
    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "GameOverState: Failed to load font!\n";
    }
    
    if (!m_uiAtlas.loadFromFile("assets/Graphics/Spritesheets/UI.png", "assets/data/ui_atlas.json", true)) {
        std::cerr << "GameOverState: Failed to load UI atlas!\n";
    }

    if (!m_gameOverTex.loadFromFile("assets/Graphics/UI/gameOver.png")) {
        std::cerr << "GameOverState: Failed to load gameOver.png!\n";
    }
    m_gameOverTex.setSmooth(true);
    m_gameOverSprite.setTexture(m_gameOverTex);

    sf::Vector2u winSize = m_manager->getWindow().getSize();
    
    // Position Game Over sprite
    sf::FloatRect spriteBounds = m_gameOverSprite.getLocalBounds();
    m_gameOverSprite.setOrigin(spriteBounds.width / 2.f, spriteBounds.height / 2.f);
    m_gameOverSprite.setPosition(winSize.x / 2.f, winSize.y * 0.4f);

    m_quitBtn = std::make_unique<UIButton>(m_uiAtlas, "button_c8_normal", 6.f, 6.f, 6.f, 6.f);
    m_quitBtn->SetHoverTexture("button_c8_mouseover");
    m_quitBtn->SetPressTexture("button_c8_pressed");
    m_quitBtn->SetSize(sf::Vector2f(200.f, 60.f));
    m_quitBtn->SetPosition(sf::Vector2f(winSize.x / 2.f - 100.f, winSize.y * 0.6f));
    m_quitBtn->SetText("QUIT", m_font, 32);
    
    m_quitBtn->SetOnClickCallback([this]() {
        m_manager->clearAndChangeState(std::make_unique<SummaryState>(m_manager, m_runData));
    });

    m_bgOverlay.setSize(sf::Vector2f(static_cast<float>(winSize.x), static_cast<float>(winSize.y)));
    m_bgOverlay.setFillColor(sf::Color(150, 0, 0, 0)); // Start transparent red
    
    if (m_bgTexture.loadFromFile("assets/Graphics/Backgrounds/background.png")) {
        m_bgSprite.setTexture(m_bgTexture);
        sf::Vector2u texSize = m_bgTexture.getSize();
        m_bgSprite.setScale(static_cast<float>(winSize.x) / texSize.x, static_cast<float>(winSize.y) / texSize.y);
        m_bgSprite.setColor(sf::Color(255, 255, 255, 0)); // Start transparent
    }
}

void GameOverState::exit() {
}

void GameOverState::update(float dt) {
    if (m_fadeTimer < m_fadeDuration) {
        m_fadeTimer += dt;
        if (m_fadeTimer > m_fadeDuration) m_fadeTimer = m_fadeDuration;
        
        float ratio = m_fadeTimer / m_fadeDuration;
        sf::Uint8 alpha = static_cast<sf::Uint8>(25.f * ratio);
        m_bgOverlay.setFillColor(sf::Color(150, 0, 0, alpha));
        
        sf::Uint8 bgAlpha = static_cast<sf::Uint8>(45.f * ratio);
        m_bgSprite.setColor(sf::Color(255, 255, 255, bgAlpha));
    }
    
    m_quitBtn->Update(dt);
}

void GameOverState::draw(sf::RenderWindow& window) {
    // Reset view to default (UI view)
    window.setView(window.getDefaultView());
    
    window.draw(m_bgOverlay);
    if (m_bgTexture.getSize().x > 0) {
        window.draw(m_bgSprite);
    }
    window.draw(m_gameOverSprite);
    m_quitBtn->Draw(window);
}

void GameOverState::handleEvent(const sf::Event& event, sf::RenderWindow& window) {
    m_quitBtn->HandleEvent(event, window);
}
