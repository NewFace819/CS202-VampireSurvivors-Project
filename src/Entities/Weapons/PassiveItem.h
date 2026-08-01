#pragma once
#include <string>
#include <vector>
#include <SFML/Graphics.hpp>

// A passive item the player can pick up during a run.
// These are per-run only (not saved across sessions).
struct PassiveItem {
    std::string name;
    std::string description;
    int level = 0;      // 0 = not owned
    int maxLevel = 5;
    sf::IntRect iconRect; // Position in items.png

    // What stat this item boosts
    std::string statType; // "maxHealth", "cooldown", "projSpeed", "damage", "area"
    float bonusPerLevel = 0.f;

    bool isOwned() const { return level > 0; }
    bool isMaxLevel() const { return level >= maxLevel; }

    std::string getUpgradeDescription() const {
        if (!isOwned()) return description;
        if (isMaxLevel()) return "Max level reached.";
        return description; // Same description for all levels
    }
};

// Returns the default list of passive items available in a run.
// Currently only Hollow Heart is needed for Bloody Tear evolution.
inline std::vector<PassiveItem> createDefaultPassiveItems() {
    return {
        {
            "Hollow Heart",
            "Augments max health by 20%.",
            0, 5,
            sf::IntRect(434, 807, 16, 15), // HeartBlack
            "maxHealth", 0.20f
        },
        {
            "Empty Tome",
            "Reduces weapons cooldown by 8%.",
            0, 5,
            sf::IntRect(206, 686, 16, 16), // Book2
            "cooldown", 0.08f
        },
        {
            "Bracer",
            "Increases projectiles speed by 10%.",
            0, 5,
            sf::IntRect(418, 693, 16, 16), // Gauntlet
            "projSpeed", 0.10f
        },
        {
            "Spinach",
            "Raises inflicted damage by 10%.",
            0, 5,
            sf::IntRect(136, 672, 12, 16), // Leaf
            "damage", 0.10f
        },
        {
            "Candelabrador",
            "Augments the Area of attacks by 10%.",
            0, 5,
            sf::IntRect(467, 598, 15, 16), // Candelabra
            "area", 0.10f
        },
        { "Clover", "Increases Luck by 10%.", 0, 5, sf::IntRect(0, 0, 16, 16), "luck", 0.10f },
        { "Pummarola", "Character recovers 0.2 HP per second.", 0, 5, sf::IntRect(0, 0, 16, 16), "regen", 0.20f },
        { "Spellbinder", "Increases weapon effect duration by 10%.", 0, 5, sf::IntRect(0, 0, 16, 16), "duration", 0.10f },
        { "Attractorb", "Increases item pickup radius by 25%.", 0, 5, sf::IntRect(0, 0, 16, 16), "magnet", 0.25f },
        { "Armor", "Reduces incoming damage by 1 per level.", 0, 5, sf::IntRect(0, 0, 16, 16), "armor", 1.0f },
        { "Duplicator", "Fires +1 extra projectile for all weapons.", 0, 2, sf::IntRect(0, 0, 16, 16), "amount", 1.0f },
        { "Tiragisu", "Revives once with 50% HP.", 0, 2, sf::IntRect(0, 0, 16, 16), "revival", 1.0f },
        { "Stone Mask", "Increases gold coin value by 10%.", 0, 5, sf::IntRect(0, 0, 16, 16), "greed", 0.10f },
        { "Skull O'Maniac", "Increases enemy frequency, HP, and speed by 10%.", 0, 5, sf::IntRect(0, 0, 16, 16), "curse", 0.10f },
        { "Wings", "Increases character move speed by 10%.", 0, 5, sf::IntRect(0, 0, 16, 16), "moveSpeed", 0.10f }
    };
}
