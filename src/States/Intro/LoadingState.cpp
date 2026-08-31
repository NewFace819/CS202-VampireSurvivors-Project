#include "States/Intro/LoadingState.h"
#include "Core/GameManager.h"
#include <iostream>
#include <iomanip>
#include <sstream>

LoadingState::LoadingState(GameManager* manager, StateFactory factory, const std::string& texturePath, float minDuration)
    : m_manager(manager), m_factory(std::move(factory)), m_duration(minDuration), m_elapsed(0.f), m_isLoaded(false)
    , m_animTimer(0.f), m_frameIndex(0), m_phase(0), m_percent(0.f), m_currentDlcIndex(0), m_stepTimer(0.f), m_finalWaitTimer(0.f) {
    
    // We optionally load a background texture
    if (!texturePath.empty()) {
        if (!m_bgTexture.loadFromFile(texturePath)) {
            std::cerr << "LoadingState: Could not load texture: " << texturePath << "\n";
        } else {
            m_bgSprite.setTexture(m_bgTexture);
            m_bgTexture.setSmooth(true);
            sf::Vector2u windowSize = m_manager->getWindow().getSize();
            sf::Vector2u textureSize = m_bgTexture.getSize();
            
            // Scale to fit screen
            m_bgSprite.setScale(
                static_cast<float>(windowSize.x) / textureSize.x,
                static_cast<float>(windowSize.y) / textureSize.y
            );
        }
    }

    m_dlcNames = {
        "Legacy of the Moonspell", 
        "Emergency Meeting", 
        "Operation Gun", 
        "Ode to Castlevania", 
        "Tides of the Foscari", 
        "Emerald Diorama", 
        "Ante Chamber"
    };

    // Load fonts and items atlas for the fake DLC loading screen
    m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf");
    m_itemsAtlas.loadFromFile("assets/Graphics/Spritesheets/items.png", "assets/data/items_atlas.json");

    for (int i = 1; i <= 4; ++i) {
        sf::IntRect rect = m_itemsAtlas.getRect("TreasureIdle_0" + std::to_string(i));
        if (rect.width > 0) m_treasureFrames.push_back(rect);
    }
    
    sf::Vector2u win = m_manager->getWindow().getSize();
    float vx = static_cast<float>(win.x);
    float vy = static_cast<float>(win.y);

    if (!m_treasureFrames.empty()) {
        m_treasureSprite.setTexture(m_itemsAtlas.getTexture());
        m_treasureSprite.setTextureRect(m_treasureFrames[0]);
        // Don't set origin to center, so it matches the reference positioning logic easily
        // Or keep origin and adjust.
        m_treasureSprite.setPosition(vx - 175.0f, vy - 130.0f);
        m_treasureSprite.setScale(4.3f, 3.2f);
    }

    m_textTop.setFont(m_font);
    m_textTop.setCharacterSize(38);
    m_textTop.setFillColor(sf::Color::White);
    m_textTop.setString("Loading DLC");

    m_textMiddle.setFont(m_font);
    m_textMiddle.setCharacterSize(24);
    m_textMiddle.setFillColor(sf::Color::White);
    m_textMiddle.setString("Legacy of the Moonspell (0%)");

    m_textBottom.setFont(m_font);
    m_textBottom.setCharacterSize(17);
    m_textBottom.setFillColor(sf::Color(150, 150, 150));
    m_textBottom.setString("v1.14.112 (63587693R)");
    
    // Positioning: align right
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

void LoadingState::enter() {
}

void LoadingState::update(float dt) {
    m_elapsed += dt;
    m_animTimer += dt;
    
    // Animate treasure chest
    if (m_animTimer >= 0.4f && !m_treasureFrames.empty()) {
        m_animTimer = 0.f;
        m_frameIndex = (m_frameIndex + 1) % m_treasureFrames.size();
        m_treasureSprite.setTextureRect(m_treasureFrames[m_frameIndex]);
    }

    sf::Vector2u win = m_manager->getWindow().getSize();
    float textRightX = win.x - 200.0f;
    
    if (m_phase == 0) {
        m_stepTimer += dt;
        if (m_stepTimer >= 0.15f) {
            m_stepTimer = 0.0f;
            m_percent += 10 + (rand() % 70); // random jump
            
            if (m_percent >= 100) {
                m_percent = 100;
                m_currentDlcIndex++;
                if (m_currentDlcIndex >= static_cast<int>(m_dlcNames.size())) {
                    m_phase = 1;
                } else {
                    m_percent = 0;
                }
            }
        }
        
        if (m_phase == 0 && m_currentDlcIndex < static_cast<int>(m_dlcNames.size())) {
            std::stringstream ss;
            ss << m_dlcNames[m_currentDlcIndex] << " (" << m_percent << "%)";
            m_textMiddle.setString(ss.str());
            
            sf::FloatRect bounds = m_textMiddle.getLocalBounds();
            m_textMiddle.setOrigin(bounds.left + bounds.width, 0.0f);
            m_textMiddle.setPosition(textRightX, win.y - 98.0f);
        }
    } else if (m_phase == 1) {
        // Phase 1: Hide middle text, move top text
        m_textMiddle.setString("");
        
        m_textTop.setString("Loading");
        sf::FloatRect topBounds = m_textTop.getLocalBounds();
        m_textTop.setOrigin(topBounds.left + topBounds.width, 0.0f);
        m_textTop.setPosition(textRightX, win.y - 110.0f);
        
        m_finalWaitTimer += dt;
        if (m_finalWaitTimer >= 0.3f && !m_isLoaded) {
            // Pre-load the state
            m_nextState = m_factory();
            m_isLoaded = true;
        }
        
        if (m_isLoaded && m_finalWaitTimer >= 0.8f) {
            m_manager->changeState(std::move(m_nextState));
        }
    }
}

void LoadingState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color::Black);
    
    if (m_bgTexture.getSize().x > 0) {
        window.draw(m_bgSprite);
    }
    
    window.draw(m_textTop);
    window.draw(m_textMiddle);
    window.draw(m_textBottom);
    window.draw(m_treasureSprite);
}

void LoadingState::exit() {
}
