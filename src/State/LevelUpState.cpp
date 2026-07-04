#include "State/LevelUpState.h"
#include "State/PlayingState.h"
#include "Engine/GameManager.h"
#include "Weapons/WeaponBase.h"
#include <iostream>
#include <algorithm>
#include <random>
#include <ctime>

// All weapon names in the game
static const std::vector<std::string> ALL_WEAPON_NAMES = {
    "Whip", "Magic Wand", "Knife", "Fire Wand", "Axe"
};

LevelUpState::LevelUpState(GameManager* manager, PlayingState* playing)
    : m_manager(manager), m_playing(playing) {

    if (!m_font.loadFromFile("C:/Windows/Fonts/arial.ttf")) {
        std::cerr << "LevelUpState: Could not load font!\n";
    }

    // Dark semi-transparent overlay
    m_overlay.setSize(sf::Vector2f(1280.f, 720.f));
    m_overlay.setFillColor(sf::Color(0, 0, 0, 160));

    // "LEVEL UP!" title
    m_titleText.setFont(m_font);
    m_titleText.setString("LEVEL UP!");
    m_titleText.setCharacterSize(52);
    m_titleText.setStyle(sf::Text::Bold);
    m_titleText.setFillColor(sf::Color(255, 220, 50));
    m_titleText.setOutlineColor(sf::Color(120, 60, 0));
    m_titleText.setOutlineThickness(3.f);
    // Centered - will position after text width is known
    m_titleText.setPosition(
        1280.f / 2.f - m_titleText.getGlobalBounds().width / 2.f, 50.f);
}

void LevelUpState::buildOptions() {
    m_options.clear();

    auto owned      = m_playing->getOwnedWeaponNames();
    auto upgradeable = m_playing->getUpgradeableWeapons();

    std::vector<LevelUpOption> pool;

    // 1) Upgradeable owned weapons
    for (auto* w : upgradeable) {
        LevelUpOption opt;
        opt.existingWeapon = w;
        opt.weaponName     = w->getName();
        opt.description    = w->getUpgradeDescription();
        opt.currentLevel   = w->getLevel();
        opt.isNew          = false;
        pool.push_back(opt);
    }

    // 2) New weapons not yet owned
    for (const auto& name : ALL_WEAPON_NAMES) {
        if (owned.find(name) == owned.end()) {
            LevelUpOption opt;
            opt.existingWeapon = nullptr;
            opt.weaponName     = name;
            opt.isNew          = true;
            opt.currentLevel   = 0;
            // Description for brand-new weapons
            if (name == "Whip")        opt.description = "Attacks horizontally,\npasses through enemies.";
            else if (name == "Magic Wand") opt.description = "Fires a magic missile\nat the nearest enemy.";
            else if (name == "Knife")   opt.description = "Throws a fast knife\nin your facing direction.";
            else if (name == "Fire Wand") opt.description = "Hurls a slow fireball\nat a random enemy.";
            else if (name == "Axe")     opt.description = "Throws an axe in an arc,\npierces through enemies.";
            pool.push_back(opt);
        }
    }

    // Shuffle and take up to 3
    std::mt19937 rng(static_cast<unsigned>(std::time(nullptr)));
    std::shuffle(pool.begin(), pool.end(), rng);
    int count = std::min(3, static_cast<int>(pool.size()));
    for (int i = 0; i < count; ++i) {
        m_options.push_back(pool[i]);
    }

    // --- Build card UI ---
    m_cards.clear();
    const float cardW   = 280.f;
    const float cardH   = 320.f;
    const float spacing = 40.f;
    float totalW = count * cardW + (count - 1) * spacing;
    float startX = (1280.f - totalW) / 2.f;
    float cardY  = (720.f - cardH) / 2.f + 20.f;

    // Accent colors per weapon
    auto accentColor = [](const std::string& name) -> sf::Color {
        if (name == "Whip")       return sf::Color(200, 80,  80);
        if (name == "Magic Wand") return sf::Color(60,  140, 230);
        if (name == "Knife")      return sf::Color(180, 180, 60);
        if (name == "Fire Wand")  return sf::Color(230, 100, 30);
        if (name == "Axe")        return sf::Color(90,  170, 90);
        return sf::Color(130, 130, 130);
    };

    for (int i = 0; i < count; ++i) {
        Card card;
        float x = startX + i * (cardW + spacing);

        // Card background
        card.bg.setSize(sf::Vector2f(cardW, cardH));
        card.bg.setPosition(x, cardY);
        card.bg.setFillColor(sf::Color(30, 30, 45));
        card.bg.setOutlineThickness(3.f);
        card.bg.setOutlineColor(accentColor(m_options[i].weaponName));

        // Header bar
        card.header.setSize(sf::Vector2f(cardW, 60.f));
        card.header.setPosition(x, cardY);
        card.header.setFillColor(accentColor(m_options[i].weaponName));

        // Title
        card.titleText.setFont(m_font);
        card.titleText.setString(m_options[i].weaponName);
        card.titleText.setCharacterSize(20);
        card.titleText.setStyle(sf::Text::Bold);
        card.titleText.setFillColor(sf::Color::White);
        card.titleText.setPosition(
            x + cardW / 2.f - card.titleText.getGlobalBounds().width / 2.f,
            cardY + 10.f);

        // Level indicator
        std::string lvlStr = m_options[i].isNew
            ? "NEW WEAPON"
            : "Lv " + std::to_string(m_options[i].currentLevel)
              + " -> " + std::to_string(m_options[i].currentLevel + 1);
        card.levelText.setFont(m_font);
        card.levelText.setString(lvlStr);
        card.levelText.setCharacterSize(14);
        card.levelText.setFillColor(m_options[i].isNew ? sf::Color(80, 255, 120) : sf::Color(220, 220, 220));
        card.levelText.setPosition(
            x + cardW / 2.f - card.levelText.getGlobalBounds().width / 2.f,
            cardY + 36.f);

        // Description
        card.descText.setFont(m_font);
        card.descText.setString(m_options[i].description);
        card.descText.setCharacterSize(16);
        card.descText.setFillColor(sf::Color(210, 210, 210));
        card.descText.setPosition(x + 16.f, cardY + 80.f);

        m_cards.push_back(std::move(card));
    }
}

void LevelUpState::enter() {
    m_timeInState = 0.f;
    buildOptions();
}

void LevelUpState::update(float dt) {
    m_timeInState += dt;
    if (m_timeInState < 0.15f) return; // input delay

    sf::Vector2i mousePos = sf::Mouse::getPosition(m_manager->getWindow());
    sf::Vector2f mp(static_cast<float>(mousePos.x), static_cast<float>(mousePos.y));

    for (int i = 0; i < static_cast<int>(m_cards.size()); ++i) {
        m_cards[i].hovered = m_cards[i].bg.getGlobalBounds().contains(mp);

        // Highlight on hover
        if (m_cards[i].hovered) {
            m_cards[i].bg.setFillColor(sf::Color(50, 50, 75));
            m_cards[i].bg.setOutlineThickness(5.f);

            if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
                applyOption(m_options[i]);
                m_manager->popState();
                return;
            }
        } else {
            m_cards[i].bg.setFillColor(sf::Color(30, 30, 45));
            m_cards[i].bg.setOutlineThickness(3.f);
        }
    }
}

void LevelUpState::draw(sf::RenderWindow& window) {
    // Draw the overlay (PlayingState is still drawn under via stack)
    window.draw(m_overlay);
    window.draw(m_titleText);

    for (auto& card : m_cards) {
        window.draw(card.bg);
        window.draw(card.header);
        window.draw(card.titleText);
        window.draw(card.levelText);
        window.draw(card.descText);
    }
}

void LevelUpState::exit() {
}

void LevelUpState::applyOption(const LevelUpOption& opt) {
    if (opt.existingWeapon) {
        opt.existingWeapon->levelUp();
    } else {
        m_playing->addWeapon(opt.weaponName);
    }
}
