#include "States/Game/TreasureChestState.h"
#include "States/Game/PlayingState.h"
#include "Core/GameManager.h"
#include "Entities/Weapons/WeaponBase.h"
#include "Entities/Weapons/PassiveItem.h"
#include "Core/Data/StatsManager.h"
#include "Core/Data/ProfileManager.h"
#include "Entities/Weapons/EvolutionRegistry.h"
#include "Core/Data/IconManager.h"
#include <iostream>
#include <cmath>
#include <algorithm>
#include <random>

// Helper to get item coordinates
static sf::IntRect getItemIconRect(const std::string& name, PlayingState* playing) {
    if (playing) {
        for (const auto& p : playing->getPassiveItems()) {
            if (p.name == name) {
                return p.iconRect;
            }
        }
    }
    return IconManager::GetInstance().getIconRect(name);
}

TreasureChestState::TreasureChestState(GameManager* manager, PlayingState* playing)
    : m_manager(manager), m_playing(playing), m_timer(0.f), m_goldReward(0),
      m_isEvolution(false), m_isLevelUp(false) {

    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "TreasureChestState: Could not load font!\n";
    }
    if (!m_itemsTex.loadFromFile("assets/Graphics/Spritesheets/items.png")) {
        std::cerr << "TreasureChestState: Could not load items texture!\n";
    }
    if (!m_uiTex.loadFromFile("assets/Graphics/Spritesheets/UI.png")) {
        std::cerr << "TreasureChestState: Could not load UI texture!\n";
    }

    sf::Vector2u windowSize = m_manager->getWindow().getSize();
    float winW = static_cast<float>(windowSize.x);
    float winH = static_cast<float>(windowSize.y);

    m_overlay.setSize(sf::Vector2f(winW, winH));
    m_overlay.setFillColor(sf::Color(0, 0, 0, 180));

    // Card Panel Setup (500x660 centered)
    float panelW = 500.f;
    float panelH = 660.f;
    float panelX = (winW - panelW) / 2.f;
    float panelY = (winH - panelH) / 2.f;

    m_panel.setSize(sf::Vector2f(panelW, panelH));
    m_panel.setPosition(panelX, panelY);
    m_panel.setFillColor(sf::Color(74, 76, 130)); // Slate blue/purple
    m_panel.setOutlineThickness(5.f);
    m_panel.setOutlineColor(sf::Color(228, 199, 109)); // Gold border

    m_panelInner.setSize(sf::Vector2f(panelW - 14.f, panelH - 14.f));
    m_panelInner.setPosition(panelX + 7.f, panelY + 7.f);
    m_panelInner.setFillColor(sf::Color::Transparent);
    m_panelInner.setOutlineThickness(1.5f);
    m_panelInner.setOutlineColor(sf::Color(228, 199, 109, 140));

    // Texts
    m_titleText.setFont(m_font);
    m_titleText.setString("TREASURE CHEST");
    m_titleText.setCharacterSize(30);
    m_titleText.setFillColor(sf::Color(255, 230, 80));
    m_titleText.setStyle(sf::Text::Bold);
    m_titleText.setPosition(panelX + (panelW - m_titleText.getGlobalBounds().width) / 2.f, panelY + 25.f);

    m_skipText.setFont(m_font);
    m_skipText.setString("Press SPACE or Left-Click to Claim");
    m_skipText.setCharacterSize(17);
    m_skipText.setFillColor(sf::Color(210, 210, 180));
    m_skipText.setPosition(panelX + (panelW - m_skipText.getGlobalBounds().width) / 2.f, panelY + panelH - 35.f);

    // Open Chest Sprite: TreasureOpen_04 (x: 465, y: 902, w: 36, h: 24 -> SFML y: 1024 - 902 - 24 = 98)
    m_chestSprite.setTexture(m_uiTex);
    m_chestSprite.setTextureRect(sf::IntRect(465, 98, 36, 24));
    m_chestSprite.setOrigin(18.f, 12.f);
    m_chestSprite.setScale(3.8f, 3.8f);
    m_chestSprite.setPosition(panelX + panelW / 2.f, panelY + panelH - 120.f);

    // Default Item Icon Sprite
    m_rewardSprite.setTexture(m_itemsTex);
    m_rewardSprite.setScale(4.f, 4.f);
    m_rewardSprite.setPosition(panelX + (panelW - 64.f) / 2.f, panelY + 130.f);

    // Set up Reward labels
    m_rewardNameText.setFont(m_font);
    m_rewardNameText.setCharacterSize(24);
    m_rewardNameText.setFillColor(sf::Color(255, 255, 255));
    m_rewardNameText.setStyle(sf::Text::Bold);

    m_rewardDescText.setFont(m_font);
    m_rewardDescText.setCharacterSize(16);
    m_rewardDescText.setFillColor(sf::Color(220, 220, 220));

    m_goldBonusText.setFont(m_font);
    m_goldBonusText.setCharacterSize(22);
    m_goldBonusText.setFillColor(sf::Color(255, 235, 70));
    m_goldBonusText.setStyle(sf::Text::Bold);

    m_goldIconSprite.setTexture(m_itemsTex);
    m_goldIconSprite.setTextureRect(getItemIconRect("Money Bag", nullptr));
    m_goldIconSprite.setScale(2.5f, 2.5f);

    determineReward();
}

void TreasureChestState::determineReward() {
    auto& weapons = m_playing->getWeapons();
    auto& passives = m_playing->getPassiveItems();
    auto& banned = m_playing->getBannedWeapons();

    // 1. Try evolution
    int recipeIdx = findAvailableEvolution(weapons, passives);
    if (recipeIdx >= 0) {
        const auto& recipe = getEvolutionRecipes()[recipeIdx];
        m_isEvolution = true;
        m_isLevelUp = false;
        m_rewardName = recipe.evolvedWeapon;

        // Remove base weapon first to prevent erasure of replacement weapon if names coincide
        m_playing->banishItem(recipe.baseWeapon);
        auto& mutableWeapons = const_cast<std::vector<std::unique_ptr<WeaponBase>>&>(m_playing->getWeapons());
        mutableWeapons.erase(
            std::remove_if(mutableWeapons.begin(), mutableWeapons.end(),
                [&](const std::unique_ptr<WeaponBase>& w) { return w->getName() == recipe.baseWeapon; }),
            mutableWeapons.end()
        );

        // Add new evolved weapon after base weapon removal
        m_playing->addWeapon(recipe.evolvedWeapon);

        m_rewardIconRect = getItemIconRect(m_rewardName, m_playing);
        m_rewardDescText.setString("EVOLUTION ACQUIRED!");
        m_goldReward = 200 + (std::rand() % 200); // 200 - 400 gold
        return;
    }

    // 2. Fallback: random inventory upgrade
    std::vector<WeaponBase*> upgWeapons = m_playing->getUpgradeableWeapons();
    std::vector<PassiveItem*> upgPassives;
    for (auto& p : passives) {
        if (p.isOwned() && !p.isMaxLevel() && banned.find(p.name) == banned.end()) {
            upgPassives.push_back(&p);
        }
    }

    int totalOptions = upgWeapons.size() + upgPassives.size();
    if (totalOptions > 0) {
        m_isLevelUp = true;
        m_isEvolution = false;

        int idx = std::rand() % totalOptions;
        if (idx < static_cast<int>(upgWeapons.size())) {
            WeaponBase* w = upgWeapons[idx];
            w->levelUp();
            m_rewardName = w->getName();
            m_rewardDescText.setString("WEAPON LEVEL UP!");
        } else {
            PassiveItem* p = upgPassives[idx - upgWeapons.size()];
            p->level++;
            m_rewardName = p->name;
            m_rewardDescText.setString("PASSIVE ITEM UPGRADE!");
        }

        m_rewardIconRect = getItemIconRect(m_rewardName, m_playing);
        m_goldReward = 80 + (std::rand() % 80); // 80 - 160 gold
        return;
    }

    // 3. Ultra Fallback: fully maxed out -> Sack of coins!
    m_isEvolution = false;
    m_isLevelUp = false;
    m_rewardName = "Money Bag";
    m_rewardIconRect = getItemIconRect("Money Bag", nullptr);
    m_rewardDescText.setString("ALL WEAPONS MAXED - EXTRA COINS!");
    m_goldReward = 250 + (std::rand() % 250); // 250 - 500 gold
}

void TreasureChestState::spawnCoinShower() {
    sf::Vector2u windowSize = m_manager->getWindow().getSize();
    float chestX = m_panel.getPosition().x + m_panel.getSize().x / 2.f;
    float chestY = m_panel.getPosition().y + m_panel.getSize().y - 120.f;

    for (int i = 0; i < 40; ++i) {
        Particle p;
        p.sprite.setTexture(m_itemsTex);
        // Randomly pick coin icon or sparkle/gem icon rect
        if (std::rand() % 2 == 0) {
            p.sprite.setTextureRect(sf::IntRect(97, 786, 16, 16)); // Coin
        } else {
            p.sprite.setTextureRect(sf::IntRect(301, 752, 16, 16)); // gem/sparkle
        }
        p.sprite.setOrigin(8.f, 8.f);
        p.sprite.setScale(1.5f, 1.5f);
        p.sprite.setPosition(chestX + (std::rand() % 20 - 10), chestY - 10.f);

        // Exploding upwards velocity
        float angle = static_cast<float>(std::rand() % 120 + 210) * 3.14159f / 180.f; // -30 to -150 deg (upwards arc)
        float speed = 250.f + static_cast<float>(std::rand() % 250);
        p.velocity = sf::Vector2f(std::cos(angle) * speed, std::sin(angle) * speed);
        p.rotationSpeed = static_cast<float>(std::rand() % 360 - 180);
        p.lifetime = p.maxLifetime = 1.0f + static_cast<float>(std::rand() % 100) / 100.f;

        m_particles.push_back(std::move(p));
    }
}

void TreasureChestState::enter() {
    m_timer = 0.f;
    m_particles.clear();

    determineReward();

    // Scale up gold payout by greed stat multiplier
    m_goldReward = static_cast<int>(m_goldReward * ProfileManager::GetInstance().getGreedMultiplier());

    // Display setup
    m_rewardNameText.setString(m_rewardName);
    
    // Set icon sprite texture and rect
    m_rewardSprite.setTexture(m_itemsTex);
    m_rewardSprite.setTextureRect(m_rewardIconRect);
    m_rewardSprite.setOrigin(m_rewardIconRect.width / 2.f, m_rewardIconRect.height / 2.f);
    m_rewardSprite.setScale(3.5f, 3.5f);

    float panelX = m_panel.getPosition().x;
    float panelY = m_panel.getPosition().y;
    float panelW = m_panel.getSize().x;
    float panelH = m_panel.getSize().y;

    m_rewardSprite.setPosition(panelX + panelW / 2.f, panelY + 230.f);
    m_rewardNameText.setPosition(panelX + (panelW - m_rewardNameText.getGlobalBounds().width) / 2.f, panelY + 310.f);
    m_rewardDescText.setPosition(panelX + (panelW - m_rewardDescText.getGlobalBounds().width) / 2.f, panelY + 355.f);

    m_goldBonusText.setString("+" + std::to_string(m_goldReward) + " Gold");
    
    float goldTotalW = m_goldIconSprite.getGlobalBounds().width + 10.f + m_goldBonusText.getGlobalBounds().width;
    float goldStartX = panelX + (panelW - goldTotalW) / 2.f;
    m_goldIconSprite.setPosition(goldStartX, panelY + panelH - 180.f);
    m_goldBonusText.setPosition(goldStartX + m_goldIconSprite.getGlobalBounds().width + 10.f, panelY + panelH - 180.f);

    spawnCoinShower();
}

void TreasureChestState::update(float dt) {
    m_timer += dt;

    float panelX = m_panel.getPosition().x;
    float panelY = m_panel.getPosition().y;
    float panelW = m_panel.getSize().x;
    float panelH = m_panel.getSize().y;

    float chestX = panelX + panelW / 2.f;
    float chestY = panelY + panelH - 120.f;

    // 1) Animate 3 V-shaped light beams (pulsing and expanding)
    float baseSize = 80.f + std::sin(m_timer * 5.f) * 20.f;
    int alpha = static_cast<int>(120.f + std::sin(m_timer * 4.f) * 40.f);
    sf::Color beamColor(210, 50, 210, alpha); // Magenta beam

    // Center beam (straight up)
    m_lightBeams[0].setPointCount(4);
    m_lightBeams[0].setPoint(0, sf::Vector2f(chestX - 25.f, chestY - 15.f));
    m_lightBeams[0].setPoint(1, sf::Vector2f(chestX + 25.f, chestY - 15.f));
    m_lightBeams[0].setPoint(2, sf::Vector2f(chestX + baseSize, panelY + 120.f));
    m_lightBeams[0].setPoint(3, sf::Vector2f(chestX - baseSize, panelY + 120.f));
    m_lightBeams[0].setFillColor(beamColor);

    // Left diagonal beam
    m_lightBeams[1].setPointCount(4);
    m_lightBeams[1].setPoint(0, sf::Vector2f(chestX - 25.f, chestY - 15.f));
    m_lightBeams[1].setPoint(1, sf::Vector2f(chestX + 25.f, chestY - 15.f));
    m_lightBeams[1].setPoint(2, sf::Vector2f(panelX + 20.f, panelY + 150.f));
    m_lightBeams[1].setPoint(3, sf::Vector2f(panelX + 20.f - baseSize * 0.7f, panelY + 150.f));
    m_lightBeams[1].setFillColor(sf::Color(110, 60, 230, alpha)); // Purple beam

    // Right diagonal beam
    m_lightBeams[2].setPointCount(4);
    m_lightBeams[2].setPoint(0, sf::Vector2f(chestX - 25.f, chestY - 15.f));
    m_lightBeams[2].setPoint(1, sf::Vector2f(chestX + 25.f, chestY - 15.f));
    m_lightBeams[2].setPoint(2, sf::Vector2f(panelX + panelW - 20.f + baseSize * 0.7f, panelY + 150.f));
    m_lightBeams[2].setPoint(3, sf::Vector2f(panelX + panelW - 20.f, panelY + 150.f));
    m_lightBeams[2].setFillColor(sf::Color(110, 60, 230, alpha));

    // 2) Animate reward icon floating and rotating
    float floatOffset = std::sin(m_timer * 3.f) * 12.f;
    m_rewardSprite.setPosition(panelX + panelW / 2.f, panelY + 220.f + floatOffset);
    m_rewardSprite.setRotation(std::sin(m_timer * 1.5f) * 6.f);

    // 3) Periodic spawning of new coin particles from open chest lid
    static float spawnCooldown = 0.f;
    spawnCooldown += dt;
    if (spawnCooldown >= 0.05f) {
        spawnCooldown = 0.f;
        Particle p;
        p.sprite.setTexture(m_itemsTex);
        p.sprite.setTextureRect(sf::IntRect(97, 786, 16, 16));
        p.sprite.setOrigin(8.f, 8.f);
        p.sprite.setScale(1.2f, 1.2f);
        p.sprite.setPosition(chestX + (std::rand() % 16 - 8), chestY - 10.f);

        float angle = static_cast<float>(std::rand() % 60 + 240) * 3.14159f / 180.f; // Straight up arc
        float speed = 180.f + static_cast<float>(std::rand() % 150);
        p.velocity = sf::Vector2f(std::cos(angle) * speed, std::sin(angle) * speed);
        p.rotationSpeed = static_cast<float>(std::rand() % 240 - 120);
        p.lifetime = p.maxLifetime = 0.8f + static_cast<float>(std::rand() % 60) / 100.f;

        m_particles.push_back(std::move(p));
    }

    // 4) Update particles physics (velocity, rotation, gravity)
    for (auto& p : m_particles) {
        p.lifetime -= dt;
        p.velocity.y += 450.f * dt; // Gravity pull downwards
        p.sprite.move(p.velocity * dt);
        p.sprite.rotate(p.rotationSpeed * dt);

        // Alpha fade-out
        int a = static_cast<int>((p.lifetime / p.maxLifetime) * 255.f);
        p.sprite.setColor(sf::Color(255, 255, 255, std::max(0, std::min(255, a))));
    }

    m_particles.erase(std::remove_if(m_particles.begin(), m_particles.end(),
        [](const Particle& p) { return p.lifetime <= 0.f; }), m_particles.end());

    // 5) Action / Skip handler
    if (m_timer > 0.2f) { // Debounce click
        if (sf::Mouse::isButtonPressed(sf::Mouse::Left) || sf::Keyboard::isKeyPressed(sf::Keyboard::Space)) {
            m_playing->addGoldToRun(m_goldReward);
            m_manager->popState();
        }
    }
}

void TreasureChestState::draw(sf::RenderWindow& window) {
    window.draw(m_overlay);

    // Main background card
    window.draw(m_panel);
    window.draw(m_panelInner);

    // Beams of light radiating from chest
    for (int i = 0; i < 3; ++i) {
        window.draw(m_lightBeams[i]);
    }

    // Chest, coins, titles
    window.draw(m_chestSprite);
    
    // Draw explosion particles
    for (const auto& p : m_particles) {
        window.draw(p.sprite);
    }

    // Reward display elements
    window.draw(m_rewardSprite);
    window.draw(m_rewardNameText);
    window.draw(m_rewardDescText);
    window.draw(m_goldIconSprite);
    window.draw(m_goldBonusText);
    window.draw(m_titleText);
    window.draw(m_skipText);
}

void TreasureChestState::exit() {
}
