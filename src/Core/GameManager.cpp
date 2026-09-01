#include "Core/GameManager.h"
#include "States/Game/PlayingState.h"
#include "States/Menu/MainMenuState.h"
#include "Entities/Enemy/EnemyDatabase.h"

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>
#endif

namespace {
// Borderless window covering nearly the entire screen.
//
// Not fullscreen and not borderless-at-desktop-size: both hand the window exclusive
// presentation on Windows, which screen recorders cannot capture -- OBS produced a
// blank frame, then later froze on the menu once gameplay began. A window that leaves
// the taskbar visible is never treated as fullscreen and always captures.
//
// The size comes from the desktop work area (screen minus taskbar) less the window
// frame, so the client area is as large as it can be. That matters because the game
// renders the world 1:1 with client pixels: a smaller window shows less of the world,
// not a scaled-down view of the same area.
sf::VideoMode windowedMode() {
    sf::VideoMode desktop = sf::VideoMode::getDesktopMode();
    unsigned int w = desktop.width;
    unsigned int h = desktop.height;

#ifdef _WIN32
    RECT work = {0, 0, 0, 0};
    if (SystemParametersInfoW(SPI_GETWORKAREA, 0, &work, 0)) {
        // Full width, and just short of full height: the window covers almost all of
        // the taskbar, leaving a thin strip of it visible. That sliver is deliberate.
        // A window covering the screen exactly is treated by Windows as fullscreen and
        // given exclusive presentation, which is what froze OBS on the menu frame once
        // gameplay started. Stopping a few pixels short keeps it an ordinary composited
        // window that screen recorders can capture, while looking essentially fullscreen.
        const long kTaskbarSliver = 16;
        const long availW = GetSystemMetrics(SM_CXSCREEN);
        const long availH = GetSystemMetrics(SM_CYSCREEN) - kTaskbarSliver;
        (void)work;

        if (availW > 320) w = static_cast<unsigned int>(availW);
        if (availH > 240) h = static_cast<unsigned int>(availH);
    }
#endif

    return sf::VideoMode(w, h);
}

// Top-left of the work area, so the window sits just under any top-docked taskbar.
sf::Vector2i windowedPosition() {
    return sf::Vector2i(0, 0);
}
} // namespace

GameManager::GameManager()
    : m_window(windowedMode(), "Vampire Survivors Clone", sf::Style::None) {
    m_window.setPosition(windowedPosition());


    // Hide the OS pointer and draw our own, so exactly one cursor is ever visible.
    // See the note in GameManager.h.
    m_window.setMouseCursorVisible(false);

    m_window.setFramerateLimit(60);

    // Build the mouse cursor we draw ourselves -- see the note in GameManager.h.
    // A plain arrow: white fill, dark outline so it stays visible on any background.
    m_cursorShape.setPointCount(7);
    m_cursorShape.setPoint(0, sf::Vector2f( 0.f,  0.f));
    m_cursorShape.setPoint(1, sf::Vector2f( 0.f, 17.f));
    m_cursorShape.setPoint(2, sf::Vector2f( 4.f, 13.f));
    m_cursorShape.setPoint(3, sf::Vector2f( 7.f, 20.f));
    m_cursorShape.setPoint(4, sf::Vector2f(10.f, 19.f));
    m_cursorShape.setPoint(5, sf::Vector2f( 7.f, 12.f));
    m_cursorShape.setPoint(6, sf::Vector2f(12.f, 12.f));
    m_cursorShape.setFillColor(sf::Color::White);
    m_cursorShape.setOutlineColor(sf::Color(20, 20, 20));
    m_cursorShape.setOutlineThickness(1.5f);

    // Load Enemy Database
    EnemyDatabase::loadDatabase("assets/data/enemies.json", "assets/enemies_atlas.json");
    
    // Initially push the Main Menu state
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
            if (!m_states.empty()) {
                m_states.top()->handleEvent(event, m_window);
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

        drawCursor();

        m_window.display();

        processStateChanges();
    }
}

void GameManager::drawCursor() {
    // Screen coordinates: reset to the default view so the cursor is not dragged
    // around by whatever camera the active state left behind.
    sf::View previous = m_window.getView();
    m_window.setView(m_window.getDefaultView());

    sf::Vector2i mouse = sf::Mouse::getPosition(m_window);
    m_cursorShape.setPosition(static_cast<float>(mouse.x), static_cast<float>(mouse.y));
    m_window.draw(m_cursorShape);

    m_window.setView(previous);
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

void GameManager::clearAndChangeState(std::unique_ptr<GameState> state) {
    m_shouldClearAndChange = true;
    m_pendingState = std::move(state);
}

void GameManager::processStateChanges() {
    if (m_shouldClearAndChange) {
        while (!m_states.empty()) {
            m_states.top()->exit();
            m_states.pop();
        }
        m_states.push(std::move(m_pendingState));
        m_states.top()->enter();
        m_shouldClearAndChange = false;
        m_shouldPop = false;
        m_shouldChange = false;
        m_shouldPush = false;
        return; // done processing
    }
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
