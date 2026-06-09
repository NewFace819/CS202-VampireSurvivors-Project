#include "State/PauseState.h"
#include "Engine/GameManager.h"

PauseState::PauseState(GameManager* manager) : m_manager(manager) {
}

void PauseState::enter() {
    // Setup logic when pausing
}

void PauseState::update(float dt) {
    // Logic to resume the game
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Enter)) {
        m_manager->popState();
    }
}

void PauseState::draw(sf::RenderWindow& window) {
    // Overlay pause text/graphics over the playing state
}

void PauseState::exit() {
    // Cleanup
}
