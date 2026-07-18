#include "State/CharacterSelectState.h"
#include "State/StageSelectState.h"
#include "Engine/GameManager.h"
#include <iostream>

struct CharConfig {
    CharacterType type;
    std::string name;
    std::string weapon;
    sf::IntRect iconRect;
};

CharacterSelectState::CharacterSelectState(GameManager* manager) : m_manager(manager) {
    if (!m_font.loadFromFile("assets/ExportedProject/Assets/Font/Courier_HintedSmooth.ttf")) {
        std::cerr << "CharacterSelectState: Could not load font!\n";
    }

    sf::Vector2u windowSize = m_manager->getWindow().getSize();

    m_titleText.setFont(m_font);
    m_titleText.setString("Select Your Character");
    m_titleText.setCharacterSize(40);
    m_titleText.setFillColor(sf::Color::White);
    m_titleText.setStyle(sf::Text::Bold);
    m_titleText.setPosition(windowSize.x / 2.f - m_titleText.getGlobalBounds().width / 2.f, 50.f);

    if (!m_charactersTex.loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/characters.png")) {
        std::cerr << "CharacterSelectState: Could not load characters.png!\n";
    }

    std::vector<CharConfig> configs = {
        { CharacterType::Antonio, "Antonio", "Whip", sf::IntRect(38, 38, 32, 34) },
        { CharacterType::Imelda, "Imelda", "Magic Wand", sf::IntRect(164, 36, 36, 36) },
        { CharacterType::Gennaro, "Gennaro", "Knife", sf::IntRect(256, 0, 34, 34) },
        { CharacterType::Arca, "Arca", "Fire Wand", sf::IntRect(418, 1, 34, 34) },
        { CharacterType::Lama, "Lama", "Axe", sf::IntRect(0, 256, 34, 34) },
        { CharacterType::Sigma, "Queen Sigma", "ALL", sf::IntRect(128, 256, 34, 34) }
    };

    float spacingX = 350.f;
    float spacingY = 280.f;
    float totalW = 3 * spacingX - (spacingX - 300.f); // 3 panels per row, panel width 300
    float totalH = 2 * spacingY - (spacingY - 250.f); // 2 rows, panel height 250
    
    float startX = (windowSize.x - totalW) / 2.f;
    float startY = (windowSize.y - totalH) / 2.f + 40.f; // Slightly offset downwards

    m_panels.resize(configs.size());

    for (size_t i = 0; i < configs.size(); ++i) {
        float x = startX + (i % 3) * spacingX;
        float y = startY + (i / 3) * spacingY;

        CharacterPanel& panel = m_panels[i];
        panel.type = configs[i].type;
        
        panel.panel.setSize(sf::Vector2f(300.f, 250.f));
        panel.panel.setPosition(x, y);
        panel.panel.setFillColor(sf::Color(50, 50, 50));
        panel.panel.setOutlineThickness(5.f);
        panel.panel.setOutlineColor(sf::Color::White);

        panel.sprite.setTexture(m_charactersTex);
        panel.sprite.setTextureRect(configs[i].iconRect);
        panel.sprite.setScale(3.f, 3.f);
        panel.sprite.setPosition(x + 150.f - panel.sprite.getGlobalBounds().width / 2.f, y + 20.f);

        panel.name.setFont(m_font);
        panel.name.setString(configs[i].name);
        panel.name.setCharacterSize(24);
        panel.name.setStyle(sf::Text::Bold);
        panel.name.setPosition(x + 150.f - panel.name.getGlobalBounds().width / 2.f, y + 150.f);

        panel.weapon.setFont(m_font);
        panel.weapon.setString("Weapon: " + configs[i].weapon);
        panel.weapon.setCharacterSize(16);
        panel.weapon.setStyle(sf::Text::Bold);
        panel.weapon.setPosition(x + 150.f - panel.weapon.getGlobalBounds().width / 2.f, y + 190.f);
    }
}

void CharacterSelectState::enter() {
}

void CharacterSelectState::update(float dt) {
    sf::Vector2i mousePos = sf::Mouse::getPosition(m_manager->getWindow());
    sf::Vector2f mousePosF(static_cast<float>(mousePos.x), static_cast<float>(mousePos.y));

    m_timeInState += dt;
    for (auto& panel : m_panels) {
        if (panel.panel.getGlobalBounds().contains(mousePosF)) {
            panel.panel.setFillColor(sf::Color(80, 80, 80));
            if (m_timeInState > 0.2f && sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
                m_manager->changeState(std::make_unique<StageSelectState>(m_manager, panel.type));
            }
        } else {
            panel.panel.setFillColor(sf::Color(50, 50, 50));
        }
    }
}

void CharacterSelectState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color(20, 20, 20));
    window.draw(m_titleText);
    
    for (auto& panel : m_panels) {
        window.draw(panel.panel);
        window.draw(panel.sprite);
        window.draw(panel.name);
        window.draw(panel.weapon);
    }
}

void CharacterSelectState::exit() {
}
