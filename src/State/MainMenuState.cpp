#include "State/MainMenuState.h"
#include "State/PlayingState.h"
#include "Engine/GameManager.h"

MainMenuState::MainMenuState(GameManager* manager) : m_manager(manager) {
    // In a real project, load from a file. We'll leave it empty for the skeleton.
    // m_font.loadFromFile("assets/font.ttf");
    // m_titleText.setFont(m_font);
}

void MainMenuState::enter() {
    // Setup logic when entering Main Menu
}

void MainMenuState::update(float dt) {
    // If Space is pressed, transition to PlayingState
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Space)) {
        m_manager->changeState(std::make_unique<PlayingState>(m_manager));
    }
}

void MainMenuState::draw(sf::RenderWindow& window) {
    // window.draw(m_titleText);
}

void MainMenuState::exit() {
    // Cleanup
}
