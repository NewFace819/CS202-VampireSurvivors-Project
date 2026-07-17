#include "EnemyDatabase.h"
#include <fstream>
#include <iostream>
#include <nlohmann/json.hpp>

using json = nlohmann::json;

std::unordered_map<std::string, EnemyStats> EnemyDatabase::s_database;

void EnemyDatabase::loadDatabase(const std::string& enemiesJsonPath, const std::string& atlasJsonPath) {
    std::ifstream enemiesFile(enemiesJsonPath);
    if (!enemiesFile.is_open()) {
        std::cerr << "Failed to open enemies database: " << enemiesJsonPath << "\n";
        return;
    }
    
    json enemiesJson;
    enemiesFile >> enemiesJson;
    
    // Load atlas if provided
    json atlasJson;
    if (!atlasJsonPath.empty()) {
        std::ifstream atlasFile(atlasJsonPath);
        if (atlasFile.is_open()) {
            atlasFile >> atlasJson;
        } else {
            std::cerr << "Failed to open atlas database: " << atlasJsonPath << "\n";
        }
    }

    const auto& enemies = enemiesJson["enemies"];
    for (auto it = enemies.begin(); it != enemies.end(); ++it) {
        const std::string& id = it.key();
        const auto& data = it.value();

        EnemyStats stats;
        std::string clsStr = data.value("class", "NORMAL");
        if (clsStr == "BOSS") stats.enemyClass = EnemyClass::BOSS;
        else if (clsStr == "MAP_EVENT") stats.enemyClass = EnemyClass::MAP_EVENT;
        else stats.enemyClass = EnemyClass::NORMAL;

        stats.hp = data.value("hp", 10.f);
        stats.maxHp = stats.hp;
        stats.hpPerLevel = data.value("hpPerLevel", 0.0f);
        stats.speed = data.value("speed", 50.f) * 0.5f; // Scale down speed
        stats.damage = data.value("damage", 5.f);
        stats.collisionRadius = data.value("collisionRadius", 10.f);
        stats.expDrop = data.value("expDrop", 1.f);
        stats.facesLeftByDefault = data.value("facesLeftByDefault", false);
        stats.shootCooldown = data.value("shootCooldown", 0.f);
        stats.projectileDamage = data.value("projectileDamage", 0.f);
        stats.projectileSpeed = data.value("projectileSpeed", 0.f);

        if (data.contains("color")) {
            auto c = data["color"];
            stats.color = sf::Color(c[0], c[1], c[2], c[3]);
        } else {
            stats.color = sf::Color::White;
        }

        auto getAtlasRect = [&atlasJson](const std::string& prefix, int i) -> sf::IntRect {
            std::string key = prefix + std::to_string(i);
            if (atlasJson.contains(key)) {
                auto r = atlasJson[key];
                return sf::IntRect(r["x"], r["y"], r["width"], r["height"]);
            }
            return sf::IntRect();
        };

        if (data.contains("walkRects")) {
            for (auto& r : data["walkRects"]) {
                stats.movingRects.push_back(sf::IntRect(r[0], r[1], r[2], r[3]));
            }
        } else {
            std::string wPrefix = data.value("spriteWalkPrefix", "");
            int wFrames = data.value("walkFrames", 0);
            for (int i = 1; i <= wFrames; ++i) {
                sf::IntRect rect = getAtlasRect(wPrefix, i);
                if (rect.width > 0) stats.movingRects.push_back(rect);
            }
        }

        if (data.contains("deathRects")) {
            for (auto& r : data["deathRects"]) {
                stats.deathRects.push_back(sf::IntRect(r[0], r[1], r[2], r[3]));
            }
        } else {
            std::string dPrefix = data.value("spriteDeathPrefix", "");
            int dFrames = data.value("deathFrames", 0);
            for (int i = 0; i < dFrames; ++i) {
                // Some death frames in our generated JSON are 0-indexed without leading zero!
                // We'll just look it up directly as 'prefix + i'
                std::string key = dPrefix + std::to_string(i);
                if (atlasJson.contains(key)) {
                    auto r = atlasJson[key];
                    stats.deathRects.push_back(sf::IntRect(r["x"], r["y"], r["width"], r["height"]));
                }
            }
        }

        s_database[id] = stats;
    }
}

const EnemyStats& EnemyDatabase::getStats(const std::string& id) {
    auto it = s_database.find(id);
    if (it != s_database.end()) {
        return it->second;
    }
    static EnemyStats defaultStats;
    defaultStats.hp = 10.f;
    defaultStats.maxHp = 10.f;
    defaultStats.hpPerLevel = 0.f;
    defaultStats.speed = 10.f;
    defaultStats.damage = 1.f;
    defaultStats.collisionRadius = 10.f;
    defaultStats.expDrop = 1.f;
    return defaultStats;
}

bool EnemyDatabase::exists(const std::string& id) {
    return s_database.find(id) != s_database.end();
}
