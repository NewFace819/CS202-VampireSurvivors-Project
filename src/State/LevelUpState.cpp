#include "State/LevelUpState.h"
#include "State/PlayingState.h"
#include "Engine/GameManager.h"
#include "Weapons/WeaponBase.h"
#include "Items/PassiveItem.h"
#include "Engine/StatsManager.h"

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

    if (!m_font.loadFromFile("assets/ExportedProject/Assets/Font/Courier_HintedSmooth.ttf")) {
        std::cerr << "LevelUpState: Could not load font!\n";
    }
    
    if (!m_itemsTex.loadFromFile("assets/ExportedProject/Assets/Resources/spritesheets/items.png")) {
        std::cerr << "LevelUpState: Could not load items texture!\n";
    }

    sf::Vector2u windowSize = m_manager->getWindow().getSize();

    // Dark semi-transparent overlay
    m_overlay.setSize(sf::Vector2f(static_cast<float>(windowSize.x), static_cast<float>(windowSize.y)));
    m_overlay.setFillColor(sf::Color(0, 0, 0, 160));

    // Main Panel Background (size and pos set in buildOptions)
    m_mainPanel.setFillColor(sf::Color(76, 81, 130)); // Purplish blue
    m_mainPanel.setOutlineThickness(4.f);
    m_mainPanel.setOutlineColor(sf::Color(228, 199, 109)); // Gold

    // "Level Up!" title
    m_titleText.setFont(m_font);
    m_titleText.setString("Level Up!");
    m_titleText.setCharacterSize(52);
    m_titleText.setFillColor(sf::Color::White);
    m_titleText.setStyle(sf::Text::Bold);
    
    // Footer text
    m_footerText.setFont(m_font);
    m_footerText.setString("Increase your Luck\nfor a chance to get 4\nchoices.");
    m_footerText.setCharacterSize(26);
    m_footerText.setFillColor(sf::Color::White);
    m_footerText.setStyle(sf::Text::Bold);
    // Center text alignment visually by setting origin? SFML doesn't have native text align center.
    // The spaces/newlines will just be left aligned. We can format the string carefully.
    m_footerText.setString("      Increase your Luck\n    for a chance to get 4\n             choices.");
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

    // 2) New weapons not yet owned (excluding evolved/banned ones)
    const auto& banned = m_playing->getBannedWeapons();
    for (const auto& name : ALL_WEAPON_NAMES) {
        if (owned.find(name) == owned.end() && banned.find(name) == banned.end()) {
            LevelUpOption opt;
            opt.existingWeapon = nullptr;
            opt.weaponName     = name;
            opt.isNew          = true;
            opt.isPassive      = false;
            opt.currentLevel   = 0;
            // Description for brand-new weapons
            if (name == "Whip")        opt.description = "Attacks horizontally, passes through enemies.";
            else if (name == "Magic Wand") opt.description = "Fires a magic missile at the nearest enemy.";
            else if (name == "Knife")   opt.description = "Throws a fast knife in your facing direction.";
            else if (name == "Fire Wand") opt.description = "Hurls a slow fireball at a random enemy.";
            else if (name == "Axe")     opt.description = "Throws an axe in an arc, pierces through enemies.";
            pool.push_back(opt);
        }
    }

    // 3) Passive items (new or upgradeable)
    auto& passives = m_playing->getPassiveItems();
    for (auto& p : passives) {
        if (!p.isMaxLevel()) {
            LevelUpOption opt;
            opt.existingWeapon = nullptr;
            opt.weaponName     = p.name;
            opt.description    = p.getUpgradeDescription();
            opt.currentLevel   = p.level;
            opt.isNew          = !p.isOwned();
            opt.isPassive      = true;
            pool.push_back(opt);
        }
    }

    // If the pool is empty (all weapons/passives fully maxed), offer fallbacks
    if (pool.empty()) {
        LevelUpOption optGold;
        optGold.existingWeapon = nullptr;
        optGold.weaponName     = "Money Bag";
        optGold.description    = "Grants 100 Gold coins immediately.";
        optGold.isNew          = false;
        optGold.isPassive      = false;
        optGold.currentLevel   = 0;
        pool.push_back(optGold);

        LevelUpOption optChicken;
        optChicken.existingWeapon = nullptr;
        optChicken.weaponName     = "Floor Chicken";
        optChicken.description    = "Heals 30 Health Points.";
        optChicken.isNew          = false;
        optChicken.isPassive      = false;
        optChicken.currentLevel   = 0;
        pool.push_back(optChicken);
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
    sf::Vector2u windowSize = m_manager->getWindow().getSize();

    const float panelW  = 650.f;
    const float cardW   = 610.f;
    const float cardH   = 140.f;
    const float spacing = 15.f;
    
    float totalCardH = count * cardH + (count - 1) * spacing;
    float panelH = 150.f + totalCardH + 200.f; // 150 top, 200 bottom

    float panelX = (windowSize.x - panelW) / 2.f;
    float panelY = (windowSize.y - panelH) / 2.f;
    m_mainPanel.setSize(sf::Vector2f(panelW, panelH));
    m_mainPanel.setPosition(panelX, panelY);

    m_titleText.setPosition(panelX + (panelW - m_titleText.getGlobalBounds().width) / 2.f, panelY + 30.f);

    float startY = panelY + 130.f;
    float cardX  = panelX + (panelW - cardW) / 2.f;

    for (int i = 0; i < count; ++i) {
        Card card;
        float y = startY + i * (cardH + spacing);

        // Card background
        card.bg.setSize(sf::Vector2f(cardW, cardH));
        card.bg.setPosition(cardX, y);
        if (m_options[i].weaponName == "Money Bag") {
            card.bg.setFillColor(sf::Color(180, 140, 40)); // Gold color
        } else if (m_options[i].weaponName == "Floor Chicken") {
            card.bg.setFillColor(sf::Color(150, 70, 70)); // Deep red/pink
        } else if (m_options[i].isPassive) {
            card.bg.setFillColor(sf::Color(80, 120, 80)); // Green for passives
        } else {
            card.bg.setFillColor(sf::Color(136, 136, 136));
        }
        card.bg.setOutlineThickness(3.f);
        card.bg.setOutlineColor(sf::Color(228, 199, 109));

        // Icon Box placeholder
        float iconSize = 64.f;
        card.iconBg.setSize(sf::Vector2f(iconSize, iconSize));
        card.iconBg.setPosition(cardX + 20.f, y + 20.f);
        card.iconBg.setFillColor(sf::Color::Black);
        card.iconBg.setOutlineThickness(2.f);
        card.iconBg.setOutlineColor(sf::Color(228, 199, 109));

        // Weapon Icon Sprite
        card.iconSprite.setTexture(m_itemsTex);
        sf::IntRect texRect;
        if (m_options[i].weaponName == "Money Bag") {
            texRect = sf::IntRect(378, 790, 16, 16); // Spinach icon
            card.iconSprite.setColor(sf::Color(255, 230, 80)); // Tint yellow
        } else if (m_options[i].weaponName == "Floor Chicken") {
            texRect = sf::IntRect(360, 790, 16, 16); // Heart icon
            card.iconSprite.setColor(sf::Color(255, 120, 120)); // Tint red
        } else if (m_options[i].isPassive) {
            // Use passive item icon from the items list
            auto& passives = m_playing->getPassiveItems();
            for (const auto& p : passives) {
                if (p.name == m_options[i].weaponName) {
                    texRect = p.iconRect;
                    break;
                }
            }
        } else if (m_options[i].weaponName == "Whip")            texRect = sf::IntRect(396, 790, 16, 16);
        else if (m_options[i].weaponName == "Magic Wand") texRect = sf::IntRect(472, 793, 16, 16);
        else if (m_options[i].weaponName == "Knife")      texRect = sf::IntRect(116, 858, 16, 11);
        else if (m_options[i].weaponName == "Fire Wand")  texRect = sf::IntRect(434, 788, 16, 16);
        else if (m_options[i].weaponName == "Axe")        texRect = sf::IntRect(485, 660, 16, 16);
        else texRect = sf::IntRect(0, 0, 16, 16); // Default fallback
        card.iconSprite.setTextureRect(texRect);
        
        // Scale to fit the 64x64 box
        float scaleX = iconSize / texRect.width;
        float scaleY = iconSize / texRect.height;
        float scale = std::min(scaleX, scaleY); // Maintain aspect ratio
        card.iconSprite.setScale(scale, scale);
        
        // Center inside the box
        float iconW = texRect.width * scale;
        float iconH = texRect.height * scale;
        card.iconSprite.setPosition(
            cardX + 20.f + (iconSize - iconW) / 2.f, 
            y + 20.f + (iconSize - iconH) / 2.f
        );

        // Title
        card.titleText.setFont(m_font);
        card.titleText.setString(m_options[i].weaponName);
        card.titleText.setCharacterSize(24);
        card.titleText.setFillColor(sf::Color::White);
        card.titleText.setStyle(sf::Text::Bold);
        card.titleText.setPosition(cardX + 110.f, y + 20.f);

        // Level indicator
        std::string lvlStr;
        if (m_options[i].weaponName == "Money Bag" || m_options[i].weaponName == "Floor Chicken") {
            lvlStr = "Bonus";
        } else {
            lvlStr = m_options[i].isNew ? "New!" : "Lv " + std::to_string(m_options[i].currentLevel + 1);
        }
        card.levelText.setFont(m_font);
        card.levelText.setString(lvlStr);
        card.levelText.setCharacterSize(22);
        card.levelText.setFillColor(sf::Color(255, 230, 80));
        card.levelText.setStyle(sf::Text::Bold);
        card.levelText.setPosition(cardX + cardW - card.levelText.getGlobalBounds().width - 20.f, y + 20.f);

        // Description
        card.descText.setFont(m_font);
        card.descText.setString(m_options[i].description);
        card.descText.setCharacterSize(20);
        card.descText.setFillColor(sf::Color(240, 240, 240));
        card.descText.setStyle(sf::Text::Bold);
        card.descText.setPosition(cardX + 110.f, y + 55.f);

        m_cards.push_back(std::move(card));
    }
    
    m_footerText.setPosition(panelX + (panelW - m_footerText.getGlobalBounds().width) / 2.f, startY + totalCardH + 50.f);
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
            if (m_options[i].weaponName == "Money Bag") {
                m_cards[i].bg.setFillColor(sf::Color(220, 170, 60));
            } else if (m_options[i].weaponName == "Floor Chicken") {
                m_cards[i].bg.setFillColor(sf::Color(190, 100, 100));
            } else if (m_options[i].isPassive) {
                m_cards[i].bg.setFillColor(sf::Color(110, 160, 110));
            } else {
                m_cards[i].bg.setFillColor(sf::Color(170, 170, 170));
            }
            m_cards[i].bg.setOutlineThickness(5.f);

            if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
                applyOption(m_options[i]);
                m_manager->popState();
                return;
            }
        } else {
            if (m_options[i].weaponName == "Money Bag") {
                m_cards[i].bg.setFillColor(sf::Color(180, 140, 40));
            } else if (m_options[i].weaponName == "Floor Chicken") {
                m_cards[i].bg.setFillColor(sf::Color(150, 70, 70));
            } else if (m_options[i].isPassive) {
                m_cards[i].bg.setFillColor(sf::Color(80, 120, 80));
            } else {
                m_cards[i].bg.setFillColor(sf::Color(136, 136, 136));
            }
            m_cards[i].bg.setOutlineThickness(3.f);
        }
    }
}

void LevelUpState::draw(sf::RenderWindow& window) {
    // Draw the overlay (PlayingState is still drawn under via stack)
    window.draw(m_overlay);
    window.draw(m_mainPanel);
    window.draw(m_titleText);
    window.draw(m_footerText);

    for (auto& card : m_cards) {
        window.draw(card.bg);
        window.draw(card.iconBg);
        window.draw(card.iconSprite);
        window.draw(card.titleText);
        window.draw(card.levelText);
        window.draw(card.descText);
    }
}

void LevelUpState::exit() {
}

void LevelUpState::applyOption(const LevelUpOption& opt) {
    if (opt.weaponName == "Money Bag") {
        m_playing->addGoldToRun(100);
    } else if (opt.weaponName == "Floor Chicken") {
        StatsManager::GetInstance().heal(30.f);
    } else if (opt.isPassive) {
        m_playing->addOrUpgradePassive(opt.weaponName);
    } else if (opt.existingWeapon) {
        opt.existingWeapon->levelUp();
    } else {
        m_playing->addWeapon(opt.weaponName);
    }
}

