#pragma once

#include <vector>
#include <string>
#include <SFML/Graphics.hpp>
#include "Entities/Player.h"

enum class CharacterType;

struct CharacterConfig {
    std::string spritePath;
    std::vector<sf::IntRect> frames;
    std::vector<std::string> startingWeapons;
};

class CharacterFactory {
public:
    // Configures a Player instance with its sprite, animations, and returns its starting weapons
    static void configurePlayer(Player& player, CharacterType type, std::vector<std::string>& outStartingWeapons);
};
