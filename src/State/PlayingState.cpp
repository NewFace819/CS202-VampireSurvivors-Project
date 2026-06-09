#include "State/PlayingState.h"
#include "State/PauseState.h"
#include "Engine/GameManager.h"

PlayingState::PlayingState(GameManager* manager) 
    : m_manager(manager), m_grid(100.0f) { // Initialize grid with 100x100 cells
}

void PlayingState::enter() {
    // Initialize gameplay systems
}

void PlayingState::update(float dt) {
    // Logic to pause the game
    if (sf::Keyboard::isKeyPressed(sf::Keyboard::Escape)) {
        m_manager->pushState(std::make_unique<PauseState>(m_manager));
    }
}

void PlayingState::draw(sf::RenderWindow& window) {
    // Draw entities, tilemaps, etc.
}

void PlayingState::exit() {
    // Cleanup gameplay systems
}
