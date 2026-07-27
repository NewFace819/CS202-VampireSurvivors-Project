#pragma once
#include <string>
#include <vector>
#include <SFML/Graphics.hpp>

struct WeaponSummary {
    std::string name;
    int level;
    float damage;
    float dps;
    float timeActive;
    std::string frameName;
};

struct PassiveSummary {
    std::string name;
    int level;
    std::string frameName;
};

struct RunSummaryData {
    std::string mapName;
    std::string characterName;
    float survivalTime = 0.f;
    int goldEarned = 0;
    int levelReached = 1;
    int enemiesDefeated = 0;
    std::vector<WeaponSummary> weapons;
    std::vector<PassiveSummary> passives;
    sf::IntRect charIconRect;
};
