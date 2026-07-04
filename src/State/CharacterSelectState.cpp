#include "State/CharacterSelectState.h"
#include "State/PlayingState.h"
#include "Engine/GameManager.h"
#include <iostream>

CharacterSelectState::CharacterSelectState(GameManager* manager) : m_manager(manager) {
    if (!m_font.loadFromFile("C:/Windows/Fonts/arial.ttf")) {
        std::cerr << "Could not load Arial font!\n";
    }

    m_titleText.setFont(m_font);
    m_titleText.setString("Select Your Character");
    m_titleText.setCharacterSize(40);
    m_titleText.setFillColor(sf::Color::White);
    m_titleText.setPosition(1280.f / 2.f - m_titleText.getGlobalBounds().width / 2.f, 100.f);

    // Setup Antonio Panel
    m_antonioPanel.setSize(sf::Vector2f(300.f, 400.f));
    m_antonioPanel.setPosition(250.f, 200.f);
    m_antonioPanel.setFillColor(sf::Color(50, 50, 50));
    m_antonioPanel.setOutlineThickness(5.f);
    m_antonioPanel.setOutlineColor(sf::Color::White);

    if (m_antonioTex.loadFromFile("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_antonio.png")) {
        m_antonioSprite.setTexture(m_antonioTex);
        m_antonioSprite.setTextureRect(sf::IntRect(0, 0, 32, 32)); // Use first frame
        m_antonioSprite.setScale(4.f, 4.f); // Scale up more since it's only 32x32 now
        m_antonioSprite.setPosition(400.f - m_antonioSprite.getGlobalBounds().width / 2.f, 250.f);
    }

    m_antonioName.setFont(m_font);
    m_antonioName.setString("Antonio");
    m_antonioName.setCharacterSize(30);
    m_antonioName.setPosition(400.f - m_antonioName.getGlobalBounds().width / 2.f, 450.f);

    m_antonioWeapon.setFont(m_font);
    m_antonioWeapon.setString("Weapon: Whip");
    m_antonioWeapon.setCharacterSize(20);
    m_antonioWeapon.setPosition(400.f - m_antonioWeapon.getGlobalBounds().width / 2.f, 500.f);

    // Setup Imelda Panel
    m_imeldaPanel.setSize(sf::Vector2f(300.f, 400.f));
    m_imeldaPanel.setPosition(730.f, 200.f);
    m_imeldaPanel.setFillColor(sf::Color(50, 50, 50));
    m_imeldaPanel.setOutlineThickness(5.f);
    m_imeldaPanel.setOutlineColor(sf::Color::White);

    if (m_imeldaTex.loadFromFile("assets/ExportedProject/Assets/App/Art/Sprites/Addressable/characters/character_imelda.png")) {
        m_imeldaSprite.setTexture(m_imeldaTex);
        m_imeldaSprite.setTextureRect(sf::IntRect(0, 0, 32, 32)); // Use first frame
        m_imeldaSprite.setScale(4.f, 4.f); // Scale up more since it's only 32x32 now
        m_imeldaSprite.setPosition(880.f - m_imeldaSprite.getGlobalBounds().width / 2.f, 250.f);
    }

    m_imeldaName.setFont(m_font);
    m_imeldaName.setString("Imelda");
    m_imeldaName.setCharacterSize(30);
    m_imeldaName.setPosition(880.f - m_imeldaName.getGlobalBounds().width / 2.f, 450.f);

    m_imeldaWeapon.setFont(m_font);
    m_imeldaWeapon.setString("Weapon: Magic Wand");
    m_imeldaWeapon.setCharacterSize(20);
    m_imeldaWeapon.setPosition(880.f - m_imeldaWeapon.getGlobalBounds().width / 2.f, 500.f);
}

void CharacterSelectState::enter() {
}

void CharacterSelectState::update(float dt) {
    sf::Vector2i mousePos = sf::Mouse::getPosition(m_manager->getWindow());
    sf::Vector2f mousePosF(static_cast<float>(mousePos.x), static_cast<float>(mousePos.y));

    // Hover effects
    if (m_antonioPanel.getGlobalBounds().contains(mousePosF)) {
        m_antonioPanel.setFillColor(sf::Color(80, 80, 80));
        if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
            m_manager->changeState(std::make_unique<PlayingState>(m_manager, CharacterType::Antonio));
        }
    } else {
        m_antonioPanel.setFillColor(sf::Color(50, 50, 50));
    }

    if (m_imeldaPanel.getGlobalBounds().contains(mousePosF)) {
        m_imeldaPanel.setFillColor(sf::Color(80, 80, 80));
        if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
            m_manager->changeState(std::make_unique<PlayingState>(m_manager, CharacterType::Imelda));
        }
    } else {
        m_imeldaPanel.setFillColor(sf::Color(50, 50, 50));
    }
}

void CharacterSelectState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color(20, 20, 20));
    window.draw(m_titleText);
    
    window.draw(m_antonioPanel);
    window.draw(m_antonioSprite);
    window.draw(m_antonioName);
    window.draw(m_antonioWeapon);

    window.draw(m_imeldaPanel);
    window.draw(m_imeldaSprite);
    window.draw(m_imeldaName);
    window.draw(m_imeldaWeapon);
}

void CharacterSelectState::exit() {
}
