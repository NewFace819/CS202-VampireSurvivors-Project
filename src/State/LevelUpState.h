#pragma once
#include "State/GameState.h"
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
};

class LevelUpState : public GameState {
public:
    LevelUpState(GameManager* manager, PlayingState* playing);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;
    bool isTransparent() const override { return true; } // Draw PlayingState behind us

private:
    void buildOptions();
    void applyOption(const LevelUpOption& opt);

    GameManager*  m_manager;
    PlayingState* m_playing;

    std::vector<LevelUpOption> m_options; // Up to 3 chosen options

    // UI
    sf::Font  m_font;
    float     m_timeInState = 0.f;

    // One card per option
    struct Card {
        sf::RectangleShape bg;
        sf::RectangleShape iconBg; // The placeholder box for the weapon icon
        sf::Sprite         iconSprite; // The weapon icon
        sf::Text           titleText;
        sf::Text           levelText;
        sf::Text           descText;
        bool               hovered = false;
    };
    std::vector<Card> m_cards;
    
    sf::RectangleShape m_mainPanel;
    sf::Text          m_titleText;
    sf::Text          m_footerText;
    sf::RectangleShape m_overlay;

    sf::Texture       m_itemsTex;
};
