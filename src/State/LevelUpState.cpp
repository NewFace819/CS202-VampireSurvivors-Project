#include "LevelUpState.h"
#include "Engine/GameManager.h"

LevelUpState::LevelUpState(GameManager* manager) : m_manager(manager) {
    m_panel.setSize(sf::Vector2f(600.f, 400.f));
    m_panel.setFillColor(sf::Color(50, 50, 150, 200)); // Semi-transparent blue
    m_panel.setOrigin(300.f, 200.f);
    m_panel.setPosition(1280.f / 2.f, 720.f / 2.f);
}

void LevelUpState::enter() {
    // Pause gameplay and show options
}

void LevelUpState::update(float dt) {
    // Normally, the user would click on an upgrade.
    // For now, press Enter to simulate selecting an upgrade and returning to the game.
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Enter)) {
        m_manager->popState();
    }
}

void LevelUpState::draw(sf::RenderWindow& window) {
    // Draw the transparent panel over the PlayingState (which is drawn before this state if implemented as a stack properly, 
    // but right now GameManager only draws the top state. To overlay, GameManager needs a modification or we draw it here).
    
    // For now, just draw the UI panel
    window.draw(m_panel);
}

void LevelUpState::exit() {
}
