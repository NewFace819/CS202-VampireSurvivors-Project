#include "States/Game/LevelUpState.h"
#include "States/Game/PlayingState.h"
#include "Core/GameManager.h"
#include "Entities/Weapons/WeaponBase.h"
#include "Entities/Weapons/PassiveItem.h"
#include "Core/Data/StatsManager.h"
#include "Core/Data/ProfileManager.h"
#include "Entities/Weapons/EvolutionRegistry.h"

#include <iostream>
#include <algorithm>
#include <random>
#include <ctime>
#include <sstream>
#include <iomanip>
#include <cmath>
#include <numeric>

// All weapon names in the game
static const std::vector<std::string> ALL_WEAPON_NAMES = {
    "Whip", "Magic Wand", "Knife", "Fire Wand", "Axe"
};

// Helper function to get icon texture coordinates for any item
static sf::IntRect getItemIconRect(const std::string& name, PlayingState* playing) {
    if (name == "Money Bag")     return sf::IntRect(97, 786, 16, 16);
    if (name == "Floor Chicken") return sf::IntRect(301, 752, 16, 16);
    if (name == "Whip")          return sf::IntRect(396, 790, 16, 16);
    if (name == "Magic Wand")    return sf::IntRect(472, 793, 16, 16);
    if (name == "Knife")         return sf::IntRect(116, 858, 16, 11);
    if (name == "Fire Wand")     return sf::IntRect(434, 788, 16, 16);
    if (name == "Axe")           return sf::IntRect(485, 660, 16, 16);

    if (playing) {
        for (const auto& p : playing->getPassiveItems()) {
            if (p.name == name) {
                return p.iconRect;
            }
        }
    }
    return sf::IntRect(0, 0, 16, 16); // Default fallback
}

LevelUpState::LevelUpState(GameManager* manager, PlayingState* playing)
    : m_manager(manager), m_playing(playing) {

    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "LevelUpState: Could not load font!\n";
    }
    if (!m_itemsTex.loadFromFile("assets/Graphics/Spritesheets/items.png")) {
        std::cerr << "LevelUpState: Could not load items texture!\n";
    }

    sf::Vector2u windowSize = m_manager->getWindow().getSize();
    m_overlay.setSize(sf::Vector2f(static_cast<float>(windowSize.x), static_cast<float>(windowSize.y)));
    m_overlay.setFillColor(sf::Color(0, 0, 0, 170));

    m_titleText.setFont(m_font);
    m_titleText.setString("Level Up!");
    m_titleText.setCharacterSize(44);
    m_titleText.setFillColor(sf::Color::White);
    m_titleText.setStyle(sf::Text::Bold);
    
    m_footerText.setFont(m_font);
    m_footerText.setCharacterSize(18);
    m_footerText.setFillColor(sf::Color(220, 220, 180));
    m_footerText.setStyle(sf::Text::Bold);
}

std::vector<LevelUpOption> LevelUpState::sampleItemsWithVSRules(std::vector<LevelUpOption>& pool) {
    std::vector<LevelUpOption> result;
    if (pool.empty()) return result;

    // 1. Calculate how many choices to offer (3 or 4) based on character Luck
    float totalLuck = std::max(0.1f, ProfileManager::GetInstance().getLuckMultiplier());
    float chanceFourth = 1.0f - (1.0f / totalLuck);
    float rollFourth = static_cast<float>(std::rand()) / RAND_MAX;
    
    int targetChoices = (rollFourth < chanceFourth) ? 4 : 3;
    targetChoices = std::min(targetChoices, static_cast<int>(pool.size()));

    // 2. Separate pool into owned (upgradeable) items and brand-new unowned items
    std::vector<int> availableIndices(pool.size());
    std::iota(availableIndices.begin(), availableIndices.end(), 0);

    auto getWeightedRandomIndex = [&](const std::vector<int>& candidateIndices) -> int {
        int totalWeight = 0;
        for (int idx : candidateIndices) {
            totalWeight += pool[idx].rarity;
        }
        if (totalWeight <= 0) return candidateIndices.empty() ? -1 : candidateIndices[0];
        int randWeight = std::rand() % totalWeight;
        int accum = 0;
        for (int idx : candidateIndices) {
            accum += pool[idx].rarity;
            if (randWeight < accum) return idx;
        }
        return candidateIndices.back();
    };

    // Wiki rule: Attempt specifically to offer items already owned by player (2 checks)
    int playerLevel = StatsManager::GetInstance().getLevel();
    float xVal = (playerLevel % 2 == 0) ? 2.0f : 1.0f;
    float ownedChance = 1.0f + 0.3f * xVal - (1.0f / totalLuck);

    for (int check = 0; check < 2 && static_cast<int>(result.size()) < targetChoices; ++check) {
        float rollOwned = static_cast<float>(std::rand()) / RAND_MAX;
        if (rollOwned <= ownedChance) {
            // Find owned items currently in availableIndices
            std::vector<int> ownedCandidates;
            for (int idx : availableIndices) {
                if (!pool[idx].isNew) {
                    ownedCandidates.push_back(idx);
                }
            }
            if (!ownedCandidates.empty()) {
                int chosenIdx = getWeightedRandomIndex(ownedCandidates);
                result.push_back(pool[chosenIdx]);
                availableIndices.erase(std::remove(availableIndices.begin(), availableIndices.end(), chosenIdx), availableIndices.end());
            }
        }
    }

    // 3. Fill remaining slots up to targetChoices from all remaining eligible items via weighted sampling without repetition
    while (static_cast<int>(result.size()) < targetChoices && !availableIndices.empty()) {
        int chosenIdx = getWeightedRandomIndex(availableIndices);
        result.push_back(pool[chosenIdx]);
        availableIndices.erase(std::remove(availableIndices.begin(), availableIndices.end(), chosenIdx), availableIndices.end());
    }

    return result;
}

void LevelUpState::buildOptions() {
    m_options.clear();
    m_isBanishMode = false;
    m_titleText.setString("Level Up!");
    m_titleText.setFillColor(sf::Color::White);

    auto owned       = m_playing->getOwnedWeaponNames();
    auto upgradeable = m_playing->getUpgradeableWeapons();
    const auto& banned = m_playing->getBannedWeapons();

    std::vector<LevelUpOption> pool;

    // 1) Upgradeable owned weapons
    for (auto* w : upgradeable) {
        if (banned.find(w->getName()) != banned.end()) continue;
        LevelUpOption opt;
        opt.existingWeapon = w;
        opt.weaponName     = w->getName();
        opt.description    = w->getUpgradeDescription();
        opt.currentLevel   = w->getLevel();
        opt.isNew          = false;
        opt.isPassive      = false;
        opt.rarity         = 100;
        pool.push_back(opt);
    }

    // 2) New weapons not yet owned (excluding banned ones)
    for (const auto& name : ALL_WEAPON_NAMES) {
        if (owned.find(name) == owned.end() && banned.find(name) == banned.end()) {
            LevelUpOption opt;
            opt.existingWeapon = nullptr;
            opt.weaponName     = name;
            opt.isNew          = true;
            opt.isPassive      = false;
            opt.currentLevel   = 0;
            opt.rarity         = 80; // Slightly rarer to find specific new weapons
            if (name == "Whip")            opt.description = "Attacks horizontally, passes through enemies.";
            else if (name == "Magic Wand") opt.description = "Fires a magic missile at the nearest enemy.";
            else if (name == "Knife")      opt.description = "Throws a fast knife in your facing direction.";
            else if (name == "Fire Wand")  opt.description = "Hurls a slow fireball at a random enemy.";
            else if (name == "Axe")        opt.description = "Throws an axe in an arc, pierces through enemies.";
            pool.push_back(opt);
        }
    }

    // 3) Passive items
    auto& passives = m_playing->getPassiveItems();
    for (auto& p : passives) {
        if (!p.isMaxLevel() && banned.find(p.name) == banned.end()) {
            LevelUpOption opt;
            opt.existingWeapon = nullptr;
            opt.weaponName     = p.name;
            opt.description    = p.getUpgradeDescription();
            opt.currentLevel   = p.level;
            opt.isNew          = !p.isOwned();
            opt.isPassive      = true;
            opt.rarity         = p.isOwned() ? 100 : 70;
            pool.push_back(opt);
        }
    }

    // Evolution partner hint resolution
    const auto& recipes = getEvolutionRecipes();
    for (auto& opt : pool) {
        if (!opt.isPassive) {
            for (const auto& r : recipes) {
                if (r.baseWeapon == opt.weaponName) {
                    opt.hasEvo = true;
                    opt.evoPartnerName = r.requiredPassive;
                    opt.evoPartnerIconRect = getItemIconRect(r.requiredPassive, m_playing);
                    break;
                }
            }
        } else {
            for (const auto& r : recipes) {
                if (r.requiredPassive == opt.weaponName) {
                    opt.hasEvo = true;
                    opt.evoPartnerName = r.baseWeapon;
                    opt.evoPartnerIconRect = getItemIconRect(r.baseWeapon, m_playing);
                    break;
                }
            }
        }
    }

    // If pool is empty, offer fallback bonus items
    if (pool.empty()) {
        LevelUpOption optGold;
        optGold.weaponName = "Money Bag";
        optGold.description = "Grants 100 Gold coins immediately.";
        optGold.rarity = 100;
        pool.push_back(optGold);

        LevelUpOption optChicken;
        optChicken.weaponName = "Floor Chicken";
        optChicken.description = "Heals 30 Health Points.";
        optChicken.rarity = 100;
        pool.push_back(optChicken);
    }

    // Sample items using authentic VS mathematical formulas!
    m_options = sampleItemsWithVSRules(pool);
    int count = static_cast<int>(m_options.size());

    // --- Build Center Card UI ---
    m_cards.clear();
    sf::Vector2u windowSize = m_manager->getWindow().getSize();

    const float panelW  = 610.f;
    const float cardW   = 570.f;
    const float cardH   = 120.f;
    const float spacing = 12.f;
    
    float totalCardH = count * cardH + (count - 1) * spacing;
    float panelH = 120.f + totalCardH + 40.f;
    float panelX = (windowSize.x - panelW) / 2.f;
    float panelY = (windowSize.y - panelH) / 2.f;

    m_mainPanel.setSize(sf::Vector2f(panelW, panelH));
    m_mainPanel.setPosition(panelX, panelY);
    m_mainPanel.setFillColor(sf::Color(74, 76, 130)); // Authentic slate blue/purple
    m_mainPanel.setOutlineThickness(4.f);
    m_mainPanel.setOutlineColor(sf::Color(228, 199, 109)); // Gold border

    m_mainPanelInner.setSize(sf::Vector2f(panelW - 12.f, panelH - 12.f));
    m_mainPanelInner.setPosition(panelX + 6.f, panelY + 6.f);
    m_mainPanelInner.setFillColor(sf::Color::Transparent);
    m_mainPanelInner.setOutlineThickness(1.f);
    m_mainPanelInner.setOutlineColor(sf::Color(228, 199, 109, 150));

    m_titleText.setPosition(panelX + (panelW - m_titleText.getGlobalBounds().width) / 2.f, panelY + 20.f);

    float startY = panelY + 95.f;
    float cardX  = panelX + (panelW - cardW) / 2.f;

    for (int i = 0; i < count; ++i) {
        Card card;
        float y = startY + i * (cardH + spacing);

        card.bg.setSize(sf::Vector2f(cardW, cardH));
        card.bg.setPosition(cardX, y);
        if (m_options[i].weaponName == "Money Bag")      card.bg.setFillColor(sf::Color(160, 130, 40));
        else if (m_options[i].weaponName == "Floor Chicken") card.bg.setFillColor(sf::Color(150, 70, 70));
        else                                             card.bg.setFillColor(sf::Color(130, 130, 135)); // Stone gray
        card.bg.setOutlineThickness(2.f);
        card.bg.setOutlineColor(sf::Color(228, 199, 109));

        // Left Icon box
        float iconBoxSize = 60.f;
        card.iconBg.setSize(sf::Vector2f(iconBoxSize, iconBoxSize));
        card.iconBg.setPosition(cardX + 15.f, y + 15.f);
        card.iconBg.setFillColor(sf::Color::Black);
        card.iconBg.setOutlineThickness(2.f);
        card.iconBg.setOutlineColor(sf::Color(228, 199, 109));

        card.iconSprite.setTexture(m_itemsTex);
        sf::IntRect texRect = getItemIconRect(m_options[i].weaponName, m_playing);
        card.iconSprite.setTextureRect(texRect);
        
        float scale = std::min(iconBoxSize / texRect.width, iconBoxSize / texRect.height) * 0.85f;
        card.iconSprite.setScale(scale, scale);
        float iconW = texRect.width * scale;
        float iconH = texRect.height * scale;
        card.iconSprite.setPosition(cardX + 15.f + (iconBoxSize - iconW) / 2.f, y + 15.f + (iconBoxSize - iconH) / 2.f);

        // Title
        card.titleText.setFont(m_font);
        card.titleText.setString(m_options[i].weaponName);
        card.titleText.setCharacterSize(22);
        card.titleText.setFillColor(sf::Color::White);
        card.titleText.setStyle(sf::Text::Bold);
        card.titleText.setPosition(cardX + 90.f, y + 15.f);

        // Level / Status indicator
        std::string lvlStr;
        if (m_options[i].weaponName == "Money Bag" || m_options[i].weaponName == "Floor Chicken") {
            lvlStr = "Bonus";
        } else {
            lvlStr = m_options[i].isNew ? "New!" : "Lv " + std::to_string(m_options[i].currentLevel + 1);
        }
        card.levelText.setFont(m_font);
        card.levelText.setString(lvlStr);
        card.levelText.setCharacterSize(20);
        card.levelText.setFillColor(sf::Color(255, 235, 70)); // Bright yellow
        card.levelText.setStyle(sf::Text::Bold);
        card.levelText.setPosition(cardX + cardW - card.levelText.getGlobalBounds().width - 20.f, y + 15.f);

        // Evolution partner badge
        card.hasEvo = m_options[i].hasEvo;
        if (card.hasEvo) {
            card.evoLabel.setFont(m_font);
            card.evoLabel.setString("evo:");
            card.evoLabel.setCharacterSize(16);
            card.evoLabel.setFillColor(sf::Color(200, 200, 200));
            card.evoLabel.setPosition(cardX + cardW - 85.f, y + 42.f);

            card.evoIconSprite.setTexture(m_itemsTex);
            card.evoIconSprite.setTextureRect(m_options[i].evoPartnerIconRect);
            float evoScale = 20.f / std::max(1, m_options[i].evoPartnerIconRect.height);
            card.evoIconSprite.setScale(evoScale, evoScale);
            card.evoIconSprite.setPosition(cardX + cardW - 40.f, y + 38.f);
        }

        // Description
        card.descText.setFont(m_font);
        card.descText.setString(m_options[i].description);
        card.descText.setCharacterSize(17);
        card.descText.setFillColor(sf::Color(245, 245, 245));
        card.descText.setPosition(cardX + 90.f, y + 70.f);

        m_cards.push_back(std::move(card));
    }

    buildLeftPanel();
    buildRightPanel();
}

void LevelUpState::buildLeftPanel() {
    sf::Vector2u windowSize = m_manager->getWindow().getSize();
    float leftX = 25.f;
    float topY = (windowSize.y - m_mainPanel.getSize().y) / 2.f;
    if (topY < 20.f) topY = 20.f;

    // 1) Inventory Box (2 rows x 6 columns)
    m_weaponSlots.clear();
    m_passiveSlots.clear();

    const float slotSize = 36.f;
    const float slotSpace = 6.f;
    const int cols = 6;
    const float invW = cols * slotSize + (cols - 1) * slotSpace + 20.f;
    
    auto& activeWeapons = m_playing->getWeapons();
    auto& activePassives = m_playing->getPassiveItems();

    // Weapon row
    for (int i = 0; i < cols; ++i) {
        InventorySlot slot;
        slot.box.setSize(sf::Vector2f(slotSize, slotSize));
        slot.box.setPosition(leftX + 10.f + i * (slotSize + slotSpace), topY);
        slot.box.setFillColor(sf::Color(45, 40, 45, 240));
        slot.box.setOutlineThickness(2.f);
        slot.box.setOutlineColor(sf::Color(150, 130, 80));

        if (i < static_cast<int>(activeWeapons.size())) {
            slot.filled = true;
            slot.icon.setTexture(m_itemsTex);
            sf::IntRect rect = getItemIconRect(activeWeapons[i]->getName(), m_playing);
            slot.icon.setTextureRect(rect);
            float s = (slotSize * 0.8f) / std::max(1, rect.height);
            slot.icon.setScale(s, s);
            slot.icon.setPosition(slot.box.getPosition().x + (slotSize - rect.width * s) / 2.f,
                                  slot.box.getPosition().y + (slotSize - rect.height * s) / 2.f);
        }
        m_weaponSlots.push_back(std::move(slot));
    }

    // Passive row
    std::vector<PassiveItem> ownedPassives;
    for (const auto& p : activePassives) {
        if (p.isOwned()) ownedPassives.push_back(p);
    }
    float passivesY = topY + slotSize + slotSpace;
    for (int i = 0; i < cols; ++i) {
        InventorySlot slot;
        slot.box.setSize(sf::Vector2f(slotSize, slotSize));
        slot.box.setPosition(leftX + 10.f + i * (slotSize + slotSpace), passivesY);
        slot.box.setFillColor(sf::Color(45, 40, 45, 240));
        slot.box.setOutlineThickness(2.f);
        slot.box.setOutlineColor(sf::Color(150, 130, 80));

        if (i < static_cast<int>(ownedPassives.size())) {
            slot.filled = true;
            slot.icon.setTexture(m_itemsTex);
            sf::IntRect rect = ownedPassives[i].iconRect;
            slot.icon.setTextureRect(rect);
            float s = (slotSize * 0.8f) / std::max(1, rect.height);
            slot.icon.setScale(s, s);
            slot.icon.setPosition(slot.box.getPosition().x + (slotSize - rect.width * s) / 2.f,
                                  slot.box.getPosition().y + (slotSize - rect.height * s) / 2.f);
        }
        m_passiveSlots.push_back(std::move(slot));
    }

    // 2) Player Stats Chart
    float statsY = passivesY + slotSize + 15.f;
    float statsH = m_mainPanel.getPosition().y + m_mainPanel.getSize().y - statsY;
    if (statsH < 400.f) statsH = 400.f;

    m_statsPanelBg.setSize(sf::Vector2f(invW, statsH));
    m_statsPanelBg.setPosition(leftX, statsY);
    m_statsPanelBg.setFillColor(sf::Color(55, 55, 60, 240));
    m_statsPanelBg.setOutlineThickness(2.f);
    m_statsPanelBg.setOutlineColor(sf::Color(210, 170, 90));

    m_statLinesLeft.clear();
    m_statLinesRight.clear();

    struct StatRow { std::string label; std::string val; bool bonus; };
    ProfileManager& prof = ProfileManager::GetInstance();
    StatsManager& stats = StatsManager::GetInstance();

    auto fmtPct = [](float mul) -> std::string {
        int pct = static_cast<int>(std::round((mul - 1.0f) * 100.f));
        if (pct >= 0) return "+" + std::to_string(pct) + "%";
        return std::to_string(pct) + "%";
    };

    std::vector<StatRow> rows = {
        {"Max Health", std::to_string(static_cast<int>(stats.getMaxHealth())), prof.getMaxHealthMultiplier() > 1.f},
        {"Recovery",   "3.50", true},
        {"Armor",      "+" + std::to_string(static_cast<int>(prof.getArmorReduction())), prof.getArmorReduction() > 0},
        {"Move Speed", fmtPct(prof.getMoveSpeedMultiplier()), prof.getMoveSpeedMultiplier() > 1.f},
        {"Might",      fmtPct(prof.getMightMultiplier()), prof.getMightMultiplier() > 1.f},
        {"Speed",      fmtPct(prof.getProjectileSpeedMultiplier()), prof.getProjectileSpeedMultiplier() > 1.f},
        {"Duration",   fmtPct(prof.getDurationMultiplier()), prof.getDurationMultiplier() > 1.f},
        {"Area",       fmtPct(prof.getAreaMultiplier()), prof.getAreaMultiplier() > 1.f},
        {"Cooldown",   "-" + std::to_string(static_cast<int>(std::round((1.0f - prof.getCooldownMultiplier()) * 100.f))) + "%", prof.getCooldownMultiplier() < 1.f},
        {"Amount",     "+" + std::to_string(prof.getAmountBonus()), prof.getAmountBonus() > 0},
        {"Revival",    "+" + std::to_string(prof.getRevivalBonus()), prof.getRevivalBonus() > 0},
        {"Magnet",     "+" + std::to_string(static_cast<int>(prof.getMagnetBonus())), prof.getMagnetBonus() > 0},
        {"Luck",       fmtPct(prof.getLuckMultiplier()), prof.getLuckMultiplier() > 1.f},
        {"Growth",     fmtPct(prof.getGrowthMultiplier()), prof.getGrowthMultiplier() > 1.f},
        {"Greed",      fmtPct(prof.getGreedMultiplier()), prof.getGreedMultiplier() > 1.f},
        {"Curse",      "+0%", false},
        {"---",        "---", false},
        {"Reroll",     "+" + std::to_string(m_playing->getRerollCharges()), m_playing->getRerollCharges() > 0},
        {"Skip",       "+" + std::to_string(m_playing->getSkipCharges()), m_playing->getSkipCharges() > 0},
        {"Banish",     "+" + std::to_string(m_playing->getBanishCharges()), m_playing->getBanishCharges() > 0}
    };

    float lineY = statsY + 10.f;
    float lineStep = (statsH - 20.f) / static_cast<float>(rows.size());

    for (const auto& r : rows) {
        if (r.label == "---") {
            lineY += lineStep * 0.5f;
            continue;
        }
        sf::Text tLeft(r.label, m_font, 15);
        tLeft.setPosition(leftX + 12.f, lineY);
        tLeft.setFillColor(sf::Color(230, 230, 230));
        m_statLinesLeft.push_back(tLeft);

        sf::Text tRight(r.val, m_font, 15);
        tRight.setPosition(leftX + invW - tRight.getGlobalBounds().width - 12.f, lineY);
        tRight.setFillColor(r.bonus ? sf::Color(100, 245, 120) : sf::Color(230, 230, 230));
        m_statLinesRight.push_back(tRight);

        lineY += lineStep;
    }
}

void LevelUpState::buildRightPanel() {
    m_actionButtons.clear();
    sf::Vector2u windowSize = m_manager->getWindow().getSize();

    float centerRight = m_mainPanel.getPosition().x + m_mainPanel.getSize().y;
    float rightX = m_mainPanel.getPosition().x + m_mainPanel.getSize().x + 25.f;
    float btnW = 210.f;
    float btnH = 68.f;
    float spacing = 22.f;

    float totalH = 3 * btnH + 2 * spacing;
    float startY = m_mainPanel.getPosition().y + 40.f;

    struct BtnDef { std::string type; std::string title; int count; sf::Color col; };
    std::vector<BtnDef> defs = {
        {"REROLL", "REROLL", m_playing->getRerollCharges(), sf::Color(20, 55, 190)},
        {"SKIP",   "SKIP",   m_playing->getSkipCharges(),   sf::Color(200, 40, 40)},
        {"BANISH", "BANISH", m_playing->getBanishCharges(), sf::Color(200, 40, 40)}
    };

    for (int i = 0; i < 3; ++i) {
        ActionButton btn;
        btn.type = defs[i].type;
        btn.enabled = (defs[i].count > 0);

        float y = startY + i * (btnH + spacing);
        btn.bg.setSize(sf::Vector2f(btnW, btnH));
        btn.bg.setPosition(rightX, y);
        btn.bg.setFillColor(btn.enabled ? defs[i].col : sf::Color(90, 90, 95));
        btn.bg.setOutlineThickness(3.f);
        btn.bg.setOutlineColor(sf::Color(228, 199, 109));

        btn.innerBg.setSize(sf::Vector2f(btnW - 6.f, btnH - 6.f));
        btn.innerBg.setPosition(rightX + 3.f, y + 3.f);
        btn.innerBg.setFillColor(sf::Color::Transparent);
        btn.innerBg.setOutlineThickness(1.f);
        btn.innerBg.setOutlineColor(sf::Color(255, 235, 140, 180));

        btn.labelText.setFont(m_font);
        btn.labelText.setString(defs[i].title);
        btn.labelText.setCharacterSize(26);
        btn.labelText.setFillColor(btn.enabled ? sf::Color::White : sf::Color(170, 170, 170));
        btn.labelText.setStyle(sf::Text::Bold);
        btn.labelText.setPosition(rightX + (btnW - btn.labelText.getGlobalBounds().width) / 2.f, y + 8.f);

        btn.countText.setFont(m_font);
        btn.countText.setString(std::to_string(defs[i].count) + " left");
        btn.countText.setCharacterSize(18);
        btn.countText.setFillColor(btn.enabled ? sf::Color(255, 235, 100) : sf::Color(160, 160, 160));
        btn.countText.setPosition(rightX + (btnW - btn.countText.getGlobalBounds().width) / 2.f, y + 38.f);

        m_actionButtons.push_back(std::move(btn));
    }
}

void LevelUpState::enter() {
    m_timeInState = 0.f;
    buildOptions();
}

void LevelUpState::update(float dt) {
    m_timeInState += dt;
    if (m_timeInState < 0.15f) return; // Input delay to prevent accidental selection

    sf::Vector2i mousePos = sf::Mouse::getPosition(m_manager->getWindow());
    sf::Vector2f mp(static_cast<float>(mousePos.x), static_cast<float>(mousePos.y));

    // Update center option cards
    for (int i = 0; i < static_cast<int>(m_cards.size()); ++i) {
        m_cards[i].hovered = m_cards[i].bg.getGlobalBounds().contains(mp);

        if (m_cards[i].hovered) {
            if (m_isBanishMode) {
                m_cards[i].bg.setFillColor(sf::Color(180, 60, 60)); // Crimson glow in banish mode
            } else if (m_options[i].weaponName == "Money Bag") {
                m_cards[i].bg.setFillColor(sf::Color(200, 160, 50));
            } else if (m_options[i].weaponName == "Floor Chicken") {
                m_cards[i].bg.setFillColor(sf::Color(180, 90, 90));
            } else {
                m_cards[i].bg.setFillColor(sf::Color(160, 160, 165));
            }
            m_cards[i].bg.setOutlineThickness(4.f);
            m_cards[i].bg.setOutlineColor(sf::Color(255, 235, 60)); // Glowing gold

            if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
                if (m_isBanishMode) {
                    // Banish this item permanently from the run!
                    m_playing->banishItem(m_options[i].weaponName);
                    m_playing->useBanishCharge();
                    buildOptions(); // Re-draw choices without the banished item!
                    return;
                } else {
                    applyOption(m_options[i]);
                    m_manager->popState();
                    return;
                }
            }
        } else {
            if (m_isBanishMode) {
                m_cards[i].bg.setFillColor(sf::Color(120, 50, 50));
            } else if (m_options[i].weaponName == "Money Bag") {
                m_cards[i].bg.setFillColor(sf::Color(160, 130, 40));
            } else if (m_options[i].weaponName == "Floor Chicken") {
                m_cards[i].bg.setFillColor(sf::Color(150, 70, 70));
            } else {
                m_cards[i].bg.setFillColor(sf::Color(130, 130, 135));
            }
            m_cards[i].bg.setOutlineThickness(2.f);
            m_cards[i].bg.setOutlineColor(sf::Color(228, 199, 109));
        }
    }

    // Update tactical action buttons
    for (auto& btn : m_actionButtons) {
        if (!btn.enabled) continue;
        btn.hovered = btn.bg.getGlobalBounds().contains(mp);
        if (btn.hovered) {
            btn.bg.setOutlineThickness(5.f);
            btn.bg.setOutlineColor(sf::Color(255, 240, 90));
            if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
                m_timeInState = 0.f; // Reset debounce timer
                if (btn.type == "REROLL") {
                    m_playing->useRerollCharge();
                    buildOptions();
                    return;
                } else if (btn.type == "SKIP") {
                    m_playing->useSkipCharge();
                    // Skip awards 20% experience bonus or 100 gold
                    m_playing->addGoldToRun(100);
                    m_manager->popState();
                    return;
                } else if (btn.type == "BANISH") {
                    m_isBanishMode = !m_isBanishMode;
                    if (m_isBanishMode) {
                        m_titleText.setString("Select Item to BANISH!");
                        m_titleText.setFillColor(sf::Color(255, 100, 100));
                    } else {
                        m_titleText.setString("Level Up!");
                        m_titleText.setFillColor(sf::Color::White);
                    }
                    return;
                }
            }
        } else {
            btn.bg.setOutlineThickness(3.f);
            btn.bg.setOutlineColor(sf::Color(228, 199, 109));
        }
    }
}

void LevelUpState::draw(sf::RenderWindow& window) {
    // Draw background dim overlay
    window.draw(m_overlay);

    // 1. Draw Center Main Modal
    window.draw(m_mainPanel);
    window.draw(m_mainPanelInner);
    window.draw(m_titleText);
    window.draw(m_footerText);

    for (auto& card : m_cards) {
        window.draw(card.bg);
        window.draw(card.iconBg);
        window.draw(card.iconSprite);
        window.draw(card.titleText);
        window.draw(card.levelText);
        window.draw(card.descText);
        if (card.hasEvo) {
            window.draw(card.evoLabel);
            window.draw(card.evoIconSprite);
        }
    }

    // 2. Draw Left Panel (Inventory + Player Stats)
    for (const auto& slot : m_weaponSlots) {
        window.draw(slot.box);
        if (slot.filled) window.draw(slot.icon);
    }
    for (const auto& slot : m_passiveSlots) {
        window.draw(slot.box);
        if (slot.filled) window.draw(slot.icon);
    }
    window.draw(m_statsPanelBg);
    for (size_t i = 0; i < m_statLinesLeft.size(); ++i) {
        window.draw(m_statLinesLeft[i]);
        window.draw(m_statLinesRight[i]);
    }

    // 3. Draw Right Panel (Tactical Action Buttons)
    for (const auto& btn : m_actionButtons) {
        window.draw(btn.bg);
        window.draw(btn.innerBg);
        window.draw(btn.labelText);
        window.draw(btn.countText);
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
