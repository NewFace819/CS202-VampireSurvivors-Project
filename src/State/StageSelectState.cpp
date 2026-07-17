#include "State/StageSelectState.h"
#include "Engine/GameManager.h"
#include <iostream>

StageSelectState::StageSelectState(GameManager* manager, CharacterType charType)
    : m_manager(manager), m_charType(charType), m_timeInState(0.f) {

    if (!m_font.loadFromFile("assets/ExportedProject/Assets/Font/Courier_HintedSmooth.ttf")) {
        std::cerr << "StageSelectState: Could not load font!\n";
    }

    sf::Vector2u windowSize = m_manager->getWindow().getSize();

    // Title text
    m_titleText.setFont(m_font);
    m_titleText.setString("Select Stage");
    m_titleText.setCharacterSize(40);
    m_titleText.setFillColor(sf::Color::White);
    m_titleText.setStyle(sf::Text::Bold);
    
    // Center title
    sf::FloatRect titleBounds = m_titleText.getLocalBounds();
    m_titleText.setOrigin(titleBounds.left + titleBounds.width / 2.f, titleBounds.top + titleBounds.height / 2.f);
    m_titleText.setPosition(windowSize.x / 2.f, 80.f);

    // Stage Panels definitions
    struct StageConfig {
        StageType type;
        std::string name;
        std::string description;
        sf::Color normalColor;
        sf::Color outlineColor;
    };

    std::vector<StageConfig> configs = {
        {
            StageType::MadForest,
            "Mad Forest",
            "A dark forest teeming with bats,\nzombies, and skeletons.\n\nDifficulty: Normal",
            sf::Color(25, 45, 25), // Dark Forest Green
            sf::Color(100, 200, 100) // Vibrant Green border
        },
        {
            StageType::InlaidLibrary,
            "Inlaid Library",
            "A long library corridor with\naggressive undead witches\nfiring magic projectiles.\n\nDifficulty: Hard",
            sf::Color(25, 25, 45), // Dark Indigo Library
            sf::Color(100, 100, 220) // Vibrant Blue border
        }
    };

    float panelW = 400.f;
    float panelH = 300.f;
    float gap = 60.f;
    float totalW = 2 * panelW + gap;
    float startX = (windowSize.x - totalW) / 2.f;
    float startY = (windowSize.y - panelH) / 2.f + 50.f;

    for (size_t i = 0; i < configs.size(); ++i) {
        StagePanel sp;
        sp.type = configs[i].type;

        // Background box
        sp.panel.setSize(sf::Vector2f(panelW, panelH));
        sp.panel.setPosition(startX + i * (panelW + gap), startY);
        sp.panel.setFillColor(configs[i].normalColor);
        sp.panel.setOutlineThickness(4.f);
        sp.panel.setOutlineColor(configs[i].outlineColor);

        // Stage Name
        sp.name.setFont(m_font);
        sp.name.setString(configs[i].name);
        sp.name.setCharacterSize(28);
        sp.name.setFillColor(sf::Color::White);
        sp.name.setStyle(sf::Text::Bold);
        
        sf::FloatRect nameBounds = sp.name.getLocalBounds();
        sp.name.setOrigin(nameBounds.left + nameBounds.width / 2.f, 0.f);
        sp.name.setPosition(sp.panel.getPosition().x + panelW / 2.f, sp.panel.getPosition().y + 25.f);

        // Stage Description
        sp.description.setFont(m_font);
        sp.description.setString(configs[i].description);
        sp.description.setCharacterSize(16);
        sp.description.setFillColor(sf::Color(200, 200, 200));
        
        sf::FloatRect descBounds = sp.description.getLocalBounds();
        sp.description.setOrigin(descBounds.left + descBounds.width / 2.f, 0.f);
        sp.description.setPosition(sp.panel.getPosition().x + panelW / 2.f, sp.panel.getPosition().y + 90.f);

        m_panels.push_back(std::move(sp));
    }
}

void StageSelectState::enter() {
}

void StageSelectState::update(float dt) {
    m_timeInState += dt;

    sf::Vector2i mousePos = sf::Mouse::getPosition(m_manager->getWindow());
    sf::Vector2f mousePosF(static_cast<float>(mousePos.x), static_cast<float>(mousePos.y));

    for (auto& sp : m_panels) {
        sf::Color baseColor = sp.panel.getFillColor();
        
        if (sp.panel.getGlobalBounds().contains(mousePosF)) {
            // Brighten background on hover
            sp.panel.setOutlineThickness(6.f);
            if (sp.type == StageType::MadForest) {
                sp.panel.setFillColor(sf::Color(35, 65, 35));
            } else {
                sp.panel.setFillColor(sf::Color(35, 35, 65));
            }

            if (m_timeInState > 0.2f && sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
                // Change state to PlayingState with selected character and stage!
                m_manager->changeState(std::make_unique<PlayingState>(m_manager, m_charType, sp.type));
                return;
            }
        } else {
            sp.panel.setOutlineThickness(4.f);
            if (sp.type == StageType::MadForest) {
                sp.panel.setFillColor(sf::Color(25, 45, 25));
            } else {
                sp.panel.setFillColor(sf::Color(25, 25, 45));
            }
        }
    }
}

void StageSelectState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color(15, 15, 20)); // Slick dark backdrop
    
    window.draw(m_titleText);

    for (auto& sp : m_panels) {
        window.draw(sp.panel);
        window.draw(sp.name);
        window.draw(sp.description);
    }
}

void StageSelectState::exit() {
}
