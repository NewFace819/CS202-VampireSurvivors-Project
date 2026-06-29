#pragma once
#include <SFML/Graphics.hpp>
#include <stack>
#include <memory>
#include "State/GameState.h"

class GameManager {
public:
    GameManager();
    void run();

    void pushState(std::unique_ptr<GameState> state);
    void popState();
    void changeState(std::unique_ptr<GameState> state);

    sf::RenderWindow& getWindow() { return m_window; }

private:
    sf::RenderWindow m_window;
    std::stack<std::unique_ptr<GameState>> m_states;

    // Deferred transition helpers to prevent deleting states during updates
    std::unique_ptr<GameState> m_pendingState;
    bool m_shouldPop = false;
    bool m_shouldChange = false;
    bool m_shouldPush = false;

    void processStateChanges();
};
