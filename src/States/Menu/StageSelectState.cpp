#include "States/Menu/StageSelectState.h"
#include "Core/GameManager.h"
#include <iostream>

StageSelectState::StageSelectState(GameManager* manager, CharacterType charType)
    : StageSelectState(manager, std::vector<CharacterType>{charType}) {}

StageSelectState::StageSelectState(GameManager* manager, const std::vector<CharacterType>& charTypes)
    : m_manager(manager), m_charTypes(charTypes), m_timeInState(0.f) {

    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
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
            sf::Color(25, 45, 25),
            sf::Color(100, 200, 100)
        },
        {
            StageType::InlaidLibrary,
            "Inlaid Library",
            "A long library corridor with\naggressive undead witches\nfiring magic projectiles.\n\nDifficulty: Hard",
            sf::Color(25, 25, 45),
            sf::Color(100, 100, 220)
        },
        {
            StageType::PlantMap,
            "Green Acres",
            "Overgrown ruins crawling with\nmudmen and undead.\nDense foliage hides danger.\n\nDifficulty: Hard",
            sf::Color(20, 40, 20),
            sf::Color(80, 200, 80)
        }
    };

    float panelW = 300.f;
    float panelH = 300.f;
    float gap = 40.f;
    float totalW = configs.size() * panelW + (configs.size() - 1) * gap;
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
            if (sp.type == StageType::MadForest)
                sp.panel.setFillColor(sf::Color(35, 65, 35));
            else if (sp.type == StageType::InlaidLibrary)
                sp.panel.setFillColor(sf::Color(35, 35, 65));
            else
                sp.panel.setFillColor(sf::Color(30, 60, 30));

            if (m_timeInState > 0.2f && sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
                // Change state to PlayingState with selected character and stage!
                m_manager->changeState(std::make_unique<PlayingState>(m_manager, m_charTypes, sp.type));
                return;
            }
        } else {
            sp.panel.setOutlineThickness(4.f);
            if (sp.type == StageType::MadForest)
                sp.panel.setFillColor(sf::Color(25, 45, 25));
            else if (sp.type == StageType::InlaidLibrary)
                sp.panel.setFillColor(sf::Color(25, 25, 45));
            else
                sp.panel.setFillColor(sf::Color(20, 40, 20));
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
