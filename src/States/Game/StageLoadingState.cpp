#include "States/Game/StageLoadingState.h"
#include "States/Game/PlayingState.h"
#include "Core/GameManager.h"
#include <iostream>
#include <iomanip>
#include <sstream>

StageLoadingState::StageLoadingState(GameManager* manager, StageType stageType, CharacterType charType)
    : m_manager(manager), m_stageType(stageType), m_charType(charType), m_elapsed(0.f), m_duration(1.5f), m_isLoaded(false) {
    
    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "StageLoadingState: Could not load font!\n";
    }

    sf::Vector2u win = m_manager->getWindow().getSize();
    float vx = static_cast<float>(win.x);
    float vy = static_cast<float>(win.y);

    m_textTop.setFont(m_font);
    m_textTop.setCharacterSize(38);
    m_textTop.setFillColor(sf::Color::White);
    m_textTop.setString("Loading Stage...");

    m_textMiddle.setFont(m_font);
    m_textMiddle.setCharacterSize(24);
    m_textMiddle.setFillColor(sf::Color::White);
    m_textMiddle.setString("Generating World");

    m_textBottom.setFont(m_font);
    m_textBottom.setCharacterSize(17);
    m_textBottom.setFillColor(sf::Color(150, 150, 150));
    m_textBottom.setString("v1.14.112 (63587693R)");
    
    // Positioning: align right, similar to DLC loading
    float textRightX = vx - 200.0f;

    sf::FloatRect bottomBounds = m_textBottom.getLocalBounds();
    m_textBottom.setOrigin(bottomBounds.left + bottomBounds.width, 0.0f);
    m_textBottom.setPosition(textRightX, vy - 65.0f);

    sf::FloatRect midBounds = m_textMiddle.getLocalBounds();
    m_textMiddle.setOrigin(midBounds.left + midBounds.width, 0.0f);
    m_textMiddle.setPosition(textRightX, vy - 98.0f);

    sf::FloatRect topBounds = m_textTop.getLocalBounds();
    m_textTop.setOrigin(topBounds.left + topBounds.width, 0.0f);
    m_textTop.setPosition(textRightX, vy - 140.0f);
}

void StageLoadingState::enter() {
}

void StageLoadingState::update(float dt) {
    m_elapsed += dt;
    
    if (!m_isLoaded && m_elapsed > m_duration * 0.5f) {
        // Instantiate the massive PlayingState
        m_nextState = std::make_unique<PlayingState>(m_manager, m_charType, m_stageType);
        m_isLoaded = true;
    }

    if (m_isLoaded && m_elapsed >= m_duration) {
        m_manager->changeState(std::move(m_nextState));
    }
}

void StageLoadingState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color::Black);
    window.draw(m_textTop);
    window.draw(m_textMiddle);
    window.draw(m_textBottom);
}

void StageLoadingState::exit() {
}
