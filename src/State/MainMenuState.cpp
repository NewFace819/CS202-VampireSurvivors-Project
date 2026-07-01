#include "State/MainMenuState.h"
#include "State/CharacterSelectState.h"
#include "Engine/GameManager.h"
#include <iostream>

MainMenuState::MainMenuState(GameManager* manager) : m_manager(manager) {
    if (!m_titleTexture.loadFromFile("assets/ExportedProject/Assets/Texture2D/title.png")) {
        std::cerr << "Could not load title image!\n";
    }
    m_titleSprite.setTexture(m_titleTexture);
    
    // Center it on a 1280x720 window
    m_titleSprite.setOrigin(m_titleTexture.getSize().x / 2.0f, m_titleTexture.getSize().y / 2.0f);
    m_titleSprite.setPosition(1280.0f / 2.0f, 720.0f / 2.0f - 100.f);

    if (!m_playTexture.loadFromFile("assets/ExportedProject/Assets/Texture2D/Play_Now.png")) {
        std::cerr << "Could not load play button image!\n";
    }
    m_playSprite.setTexture(m_playTexture);
    m_playSprite.setOrigin(m_playTexture.getSize().x / 2.0f, m_playTexture.getSize().y / 2.0f);
    m_playSprite.setPosition(1280.0f / 2.0f, 720.0f / 2.0f + 100.f);

}

void MainMenuState::enter() {
}

void MainMenuState::update(float dt) {
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Space)) {
        m_manager->changeState(std::make_unique<CharacterSelectState>(m_manager));
    }

    if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
        sf::Vector2i mousePos = sf::Mouse::getPosition(m_manager->getWindow());
        if (m_playSprite.getGlobalBounds().contains(static_cast<float>(mousePos.x), static_cast<float>(mousePos.y))) {
            m_manager->changeState(std::make_unique<CharacterSelectState>(m_manager));
        }
    }
}

void MainMenuState::draw(sf::RenderWindow& window) {
    // Draw a grey background so we know the state is rendering
    window.clear(sf::Color(30, 30, 30));
    window.draw(m_titleSprite);
    window.draw(m_playSprite);
}

void MainMenuState::exit() {
}
