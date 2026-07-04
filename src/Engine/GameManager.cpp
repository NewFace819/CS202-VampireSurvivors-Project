#include "Engine/GameManager.h"
#include "State/MainMenuState.h"

GameManager::GameManager() 
    : m_window(sf::VideoMode(1280, 720), "Vampire Survivors Clone") {
    m_window.setFramerateLimit(60);
    // Initially push the main menu state
    pushState(std::make_unique<MainMenuState>(this));
}

void GameManager::run() {
    sf::Clock clock;

    while (m_window.isOpen()) {
        float dt = clock.restart().asSeconds();

        sf::Event event;
        while (m_window.pollEvent(event)) {
            if (event.type == sf::Event::Closed) {
                m_window.close();
            }
        }

        if (!m_states.empty()) {
            m_states.top()->update(dt);
        }

        m_window.clear(sf::Color::Black);
        
        if (!m_states.empty()) {
            // If the top state is transparent (overlay), draw the one below first
            if (m_states.top()->isTransparent() && m_states.size() >= 2) {
                // Temporarily get second-from-top: use a copy of the stack adapter
                // We can't iterate std::stack directly, so we draw top-1 by peeking via swap trick
                // Simpler: store as vector-based approach via a temporary draw queue
                std::vector<GameState*> drawQueue;
                // Collect states that need drawing (bottom-up, just top 2)
                auto& top = m_states.top();
                drawQueue.push_back(top.get()); // will draw second
                // Access second state: pop/peek/push (safe since we're not in update)
                auto topState = std::move(const_cast<std::unique_ptr<GameState>&>(m_states.top()));
                m_states.pop();
                if (!m_states.empty()) {
                    m_states.top()->draw(m_window); // draw PlayingState first
                }
                m_states.push(std::move(topState));
                m_states.top()->draw(m_window); // draw overlay on top
            } else {
                m_states.top()->draw(m_window);
            }
        }

        m_window.display();

        processStateChanges();
    }
}

void GameManager::pushState(std::unique_ptr<GameState> state) {
    m_shouldPush = true;
    m_pendingState = std::move(state);
}

void GameManager::popState() {
    m_shouldPop = true;
}

void GameManager::changeState(std::unique_ptr<GameState> state) {
    m_shouldChange = true;
    m_pendingState = std::move(state);
}

void GameManager::processStateChanges() {
    if (m_shouldPop && !m_states.empty()) {
        m_states.top()->exit();
        m_states.pop();
        if (!m_states.empty()) {
            m_states.top()->enter();
        }
        m_shouldPop = false;
    }

    if (m_shouldChange) {
        if (!m_states.empty()) {
            m_states.top()->exit();
            m_states.pop();
        }
        m_states.push(std::move(m_pendingState));
        m_states.top()->enter();
        m_shouldChange = false;
    }

    if (m_shouldPush) {
        m_states.push(std::move(m_pendingState));
        m_states.top()->enter();
        m_shouldPush = false;
    }
}
