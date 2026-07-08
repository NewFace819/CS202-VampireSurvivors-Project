#include "State/MainMenuState.h"
#include "State/CharacterSelectState.h"
#include "State/ShopState.h"
#include "Engine/GameManager.h"
#include <iostream>

MainMenuState::MainMenuState(GameManager* manager) : m_manager(manager) {
    if (!m_titleTexture.loadFromFile("assets/ExportedProject/Assets/Texture2D/title.png")) {
        std::cerr << "Could not load title image!\n";
    }
    m_titleSprite.setTexture(m_titleTexture);
    
    sf::Vector2u windowSize = m_manager->getWindow().getSize();
    
    // Center it on the screen
    m_titleSprite.setOrigin(m_titleTexture.getSize().x / 2.0f, m_titleTexture.getSize().y / 2.0f);
    m_titleSprite.setPosition(windowSize.x / 2.0f, windowSize.y / 2.0f - 100.f);

    if (!m_playTexture.loadFromFile("assets/ExportedProject/Assets/Texture2D/Play_Now.png")) {
        std::cerr << "Could not load play button image!\n";
    }
    m_playSprite.setTexture(m_playTexture);
    m_playSprite.setOrigin(m_playTexture.getSize().x / 2.0f, m_playTexture.getSize().y / 2.0f);
    m_playSprite.setPosition(windowSize.x / 2.0f, windowSize.y / 2.0f + 100.f);

    // Load font for shop button
    if (!m_font.loadFromFile("assets/ExportedProject/Assets/Font/Courier_HintedSmooth.ttf")) {
        std::cerr << "MainMenuState: Could not load font!\n";
    }

    // Initialize shop button
    float shopBtnW = 280.f;
    float shopBtnH = 50.f;
    m_shopBtnRect.setSize(sf::Vector2f(shopBtnW, shopBtnH));
    m_shopBtnRect.setFillColor(sf::Color(40, 40, 40));
    m_shopBtnRect.setOutlineThickness(3.f);
    m_shopBtnRect.setOutlineColor(sf::Color(228, 199, 109)); // Gold outline
    m_shopBtnRect.setOrigin(shopBtnW / 2.f, shopBtnH / 2.f);
    m_shopBtnRect.setPosition(windowSize.x / 2.0f, windowSize.y / 2.0f + 200.f);

    m_shopBtnText.setFont(m_font);
    m_shopBtnText.setString("POWER-UPS SHOP");
    m_shopBtnText.setCharacterSize(18);
    m_shopBtnText.setFillColor(sf::Color::White);
    m_shopBtnText.setStyle(sf::Text::Bold);
    sf::FloatRect textBounds = m_shopBtnText.getLocalBounds();
    m_shopBtnText.setOrigin(textBounds.left + textBounds.width / 2.f, textBounds.top + textBounds.height / 2.f);
    m_shopBtnText.setPosition(m_shopBtnRect.getPosition());
}

void MainMenuState::enter() {
}

void MainMenuState::update(float dt) {
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Space)) {
        m_manager->changeState(std::make_unique<CharacterSelectState>(m_manager));
        return;
    }
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::P) || sf::Keyboard::isKeyPressed(sf::Keyboard::S)) {
        m_manager->changeState(std::make_unique<ShopState>(m_manager));
        return;
    }

    sf::Vector2i mousePos = sf::Mouse::getPosition(m_manager->getWindow());
    sf::Vector2f mousePosF(static_cast<float>(mousePos.x), static_cast<float>(mousePos.y));

    // Handle Hover state for Shop Button
    if (m_shopBtnRect.getGlobalBounds().contains(mousePosF)) {
        m_shopBtnRect.setFillColor(sf::Color(70, 70, 70));
    } else {
        m_shopBtnRect.setFillColor(sf::Color(40, 40, 40));
    }

    if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
        if (m_playSprite.getGlobalBounds().contains(mousePosF)) {
            m_manager->changeState(std::make_unique<CharacterSelectState>(m_manager));
        } else if (m_shopBtnRect.getGlobalBounds().contains(mousePosF)) {
            m_manager->changeState(std::make_unique<ShopState>(m_manager));
        }
    }
}

void MainMenuState::draw(sf::RenderWindow& window) {
    // Draw a grey background so we know the state is rendering
    window.clear(sf::Color(30, 30, 30));
    window.draw(m_titleSprite);
    window.draw(m_playSprite);

    window.draw(m_shopBtnRect);
    window.draw(m_shopBtnText);
}

void MainMenuState::exit() {
}
