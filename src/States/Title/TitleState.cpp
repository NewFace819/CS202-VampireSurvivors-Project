#include "States/Title/TitleState.h"
#include "States/Menu/MainMenuState.h"
#include "Core/GameManager.h"
#include <iostream>

// Virtual resolution constants (from reference: Core::VIRTUAL_WIDTH/HEIGHT)
// Use actual window size
TitleState::TitleState(GameManager* manager)
    : m_manager(manager)
    , m_promptTimer(0.f)
    , m_promptFadingIn(true)
    , m_promptAlpha(0.f)
    , m_inputLocked(true)
{
    m_uiAtlas.loadFromFile("assets/Graphics/Spritesheets/UI.png", "assets/data/ui_atlas.json");
    m_illAtlas.loadFromFile("assets/Graphics/Spritesheets/illustrations.png", "assets/data/illustration_atlas.json");

    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "TitleState: Could not load font!\n";
    }

    float vx = 1728.f;
    float vy = 1080.f;

    setupBackground();

    // Setup illustrations - same positions as reference
    const float textureGap = vx / 3.0f;
    struct IllConfig { std::string key; float px, py, sx, sy; float targetAlpha; float delay; };
    std::vector<IllConfig> illConfigs = {
        { "illustrations_0", vx / 2.f,               vy / 2.f + 280.f,  2.5f,  2.5f,  255.f, 0.0f  },
        { "illustrations_1", vx / 2.f - textureGap,  vy / 2.f + 230.f,  4.9f,  4.9f,   90.f, 0.1f  },
        { "illustrations_2", vx / 2.f + textureGap,  vy / 2.f,         -3.0f,  3.0f,  150.f, 0.2f  }
    };

    for (const auto& cfg : illConfigs) {
        FadeItem item;
        sf::IntRect rect = m_illAtlas.getRect(cfg.key);
        if (rect.width > 0) {
            item.sprite.setTexture(m_illAtlas.getTexture());
            item.sprite.setTextureRect(rect);
            item.sprite.setOrigin(rect.width / 2.f, rect.height / 2.f);
        }
        item.sprite.setPosition(cfg.px, cfg.py);
        item.sprite.setScale(cfg.sx, cfg.sy);
        item.sprite.setColor(sf::Color(255, 255, 255, 0)); // start transparent
        item.delayTimer = cfg.delay;
        item.fadeTimer  = 0.f;
        item.fadeAlpha  = 0.f;
        item.targetAlpha = cfg.targetAlpha;
        item.started    = false;
        m_illustrations.push_back(item);
    }

    // "PRESS TO START" text
    m_promptText.setFont(m_font);
    m_promptText.setString("PRESS TO START");
    m_promptText.setCharacterSize(49);
    m_promptText.setFillColor(sf::Color(255, 255, 255, 0));
    sf::FloatRect bounds = m_promptText.getLocalBounds();
    m_promptText.setOrigin(bounds.left + bounds.width / 2.f, bounds.top + bounds.height / 2.f);
    m_promptText.setPosition(vx / 2.f, vy - 240.f);
}

void TitleState::setupBackground() {
    float vx = 1728.f;
    float vy = 1080.f;

    m_compositeTexture.create(1728, 1080);
    m_compositeTexture.clear(sf::Color::Black);
    m_compositeTexture.display();
    m_compositeSprite.setTexture(m_compositeTexture.getTexture());
}

void TitleState::enter() {}

void TitleState::update(float dt) {
    updateFaders(dt);

    // After all illustrations started, unlock input and blink prompt
    bool allStarted = !m_illustrations.empty();
    for (const auto& item : m_illustrations) {
        if (!item.started) { allStarted = false; break; }
    }

    if (allStarted) {
        m_inputLocked = false;

        // Blink "PRESS TO START" — fade in/out at speed 1.0s each cycle
        float speed = 1.0f;
        if (m_promptFadingIn) {
            m_promptAlpha = std::min(255.f, m_promptAlpha + dt * (255.f / speed));
            if (m_promptAlpha >= 255.f) { m_promptAlpha = 255.f; m_promptFadingIn = false; }
        } else {
            m_promptAlpha = std::max(0.f, m_promptAlpha - dt * (255.f / speed));
            if (m_promptAlpha <= 0.f) { m_promptAlpha = 0.f; m_promptFadingIn = true; }
        }
        sf::Color c = m_promptText.getFillColor();
        c.a = static_cast<sf::Uint8>(m_promptAlpha);
        m_promptText.setFillColor(c);

        // Detect any mouse click or key press → go to MainMenu
        if (!m_inputLocked) {
            bool clicked = sf::Mouse::isButtonPressed(sf::Mouse::Left)
                        || sf::Mouse::isButtonPressed(sf::Mouse::Right);
            bool anyKey = false;
            // Check common keys
            for (int k = 0; k < sf::Keyboard::KeyCount; ++k) {
                if (sf::Keyboard::isKeyPressed(static_cast<sf::Keyboard::Key>(k))) {
                    anyKey = true; break;
                }
            }
            if (clicked || anyKey) {
                m_inputLocked = true; // prevent double-trigger
                m_manager->changeState(std::make_unique<MainMenuState>(m_manager));
                return;
            }
        }
    }
}

void TitleState::updateFaders(float dt) {
    for (auto& item : m_illustrations) {
        if (!item.started) {
            item.delayTimer -= dt;
            if (item.delayTimer <= 0.f) {
                item.started = true;
            }
        } else {
            // Fade in over 2 seconds
            item.fadeTimer += dt;
            float ratio = std::min(1.f, item.fadeTimer / 2.0f);
            item.fadeAlpha = ratio * item.targetAlpha;
            sf::Color c = item.sprite.getColor();
            c.a = static_cast<sf::Uint8>(item.fadeAlpha);
            item.sprite.setColor(c);
        }
    }
}

void TitleState::draw(sf::RenderWindow& window) {
    window.setView(window.getDefaultView());
    window.clear(sf::Color::Black);
    window.draw(m_compositeSprite);

    for (const auto& item : m_illustrations) {
        if (item.started) {
            window.draw(item.sprite);
        }
    }
    static float m_elapsed = 0.f;
    m_elapsed += 1.f/60.f; // Approximation for draw call update



    if (!m_inputLocked) {
        window.draw(m_promptText);
        if (m_elapsed > 1.f) {
            m_manager->changeState(std::make_unique<MainMenuState>(m_manager));
        }
    }
}

void TitleState::exit() {}
