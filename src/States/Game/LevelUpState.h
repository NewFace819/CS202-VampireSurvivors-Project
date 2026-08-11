#pragma once
#include "States/Game/GameState.h"
#include <SFML/Graphics.hpp>
#include <vector>
#include <string>

class GameManager;
class WeaponBase;
class PlayingState;

// One option in the level-up pool:
// - If existingWeapon != nullptr  → upgrade that weapon (call levelUp())
// - If existingWeapon == nullptr  → grant a brand-new weapon (call PlayingState::addWeapon)
// - If isPassive == true          → grant or upgrade a passive item
struct LevelUpOption {
    WeaponBase*  existingWeapon = nullptr;
    std::string  weaponName;       // human-readable name for both paths
    std::string  description;      // e.g. "Fires 1 more projectile."
    int          currentLevel = 0; // 0 if new weapon
    bool         isNew        = false;
    bool         isPassive    = false;
    int          rarity       = 100; // Official VS rarity weight for weighted selection
    std::string  evoPartnerName;
    sf::IntRect  evoPartnerIconRect;
    bool         hasEvo       = false;
};

class LevelUpState : public GameState {
public:
    LevelUpState(GameManager* manager, PlayingState* playing, size_t playerIdx = 0);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;
    bool isTransparent() const override { return true; } // Draw PlayingState behind us

private:
    void buildOptions();
    void buildLeftPanel();
    void buildRightPanel();
    void applyOption(const LevelUpOption& opt);

    // Official VS probabilistic drawing helper
    std::vector<LevelUpOption> sampleItemsWithVSRules(std::vector<LevelUpOption>& pool);

    GameManager*  m_manager;
    PlayingState* m_playing;
    size_t        m_playerIdx = 0;

    std::vector<LevelUpOption> m_options; // Up to 4 chosen options!

    // UI
    sf::Font  m_font;
    float     m_timeInState = 0.f;
    bool      m_isBanishMode = false;

    // Center Panel: One card per option
    struct Card {
        sf::RectangleShape bg;
        sf::RectangleShape iconBg;
        sf::Sprite         iconSprite;
        sf::Text           titleText;
        sf::Text           levelText;
        sf::Text           descText;
        sf::Text           evoLabel;
        sf::Sprite         evoIconSprite;
        bool               hasEvo = false;
        bool               hovered = false;
    };
    std::vector<Card> m_cards;
    
    sf::RectangleShape m_mainPanel;
    sf::RectangleShape m_mainPanelInner; // Double golden frame effect
    sf::Text          m_titleText;
    sf::Text          m_footerText;
    sf::RectangleShape m_overlay;

    // Left Panel: Inventory & Player Stats
    struct InventorySlot {
        sf::RectangleShape box;
        sf::Sprite icon;
        bool filled = false;
    };
    std::vector<InventorySlot> m_weaponSlots;
    std::vector<InventorySlot> m_passiveSlots;
    sf::RectangleShape m_statsPanelBg;
    std::vector<sf::Text> m_statLinesLeft;
    std::vector<sf::Text> m_statLinesRight;

    // Right Panel: Action Buttons (Reroll, Skip, Banish)
    struct ActionButton {
        sf::RectangleShape bg;
        sf::RectangleShape innerBg;
        sf::Text labelText;
        sf::Text countText;
        bool hovered = false;
        bool enabled = false;
        std::string type; // "REROLL", "SKIP", or "BANISH"
    };
    std::vector<ActionButton> m_actionButtons;

    sf::Texture       m_itemsTex;
    sf::Texture       m_uiTex; // UI sprites sheet if needed
};
