#pragma once
#include <SFML/Graphics.hpp>
#include <stack>
#include <memory>
#include "States/Game/GameState.h"

class GameManager {
public:
    GameManager();
    void run();

    void pushState(std::unique_ptr<GameState> state);
    void popState();
    void changeState(std::unique_ptr<GameState> state);
    void clearAndChangeState(std::unique_ptr<GameState> state);

    sf::RenderWindow& getWindow() { return m_window; }

private:
    sf::RenderWindow m_window;

    // Cursor drawn by the game rather than the OS. Under sf::Style::Fullscreen the
    // Windows pointer is not composited over the exclusive surface, and neither
    // setMouseCursorVisible(true) nor installing an sf::Cursor brings it back --
    // SFML registers its window class with a null cursor and then still falls
    // through to DefWindowProc, which re-applies it. Drawing our own bypasses all
    // of that and looks the same in every window mode.
    sf::ConvexShape m_cursorShape;
    void drawCursor();
    std::stack<std::unique_ptr<GameState>> m_states;

    // Deferred transition helpers to prevent deleting states during updates
    std::unique_ptr<GameState> m_pendingState;
    bool m_shouldPop = false;
    bool m_shouldChange = false;
    bool m_shouldPush = false;
    bool m_shouldClearAndChange = false;

    void processStateChanges();
};
