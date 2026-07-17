#pragma once

#include <SFML/Graphics.hpp>
#include <string>
#include <unordered_map>
#include <vector>

enum class EnemyClass {
    NORMAL,
    BOSS,
    MAP_EVENT
};

struct EnemyStats {
    EnemyClass enemyClass;
    float hp;
    float maxHp;
    float hpPerLevel;
    float speed;
    float damage;
    float collisionRadius;
    float expDrop;
    sf::Color color;
    
    std::vector<sf::IntRect> movingRects;
    std::vector<sf::IntRect> deathRects;
    bool facesLeftByDefault;
    
    float shootCooldown = 0.f;
    float projectileDamage = 0.f;
    float projectileSpeed = 0.f;
};

class EnemyDatabase {
public:
    // Load enemies.json and enemies_atlas.json
    static void loadDatabase(const std::string& enemiesJsonPath, const std::string& atlasJsonPath);
    
    // Get stats by string ID (e.g., "ZOMBIE")
    static const EnemyStats& getStats(const std::string& id);
    
    // Check if an enemy exists
    static bool exists(const std::string& id);

private:
    static std::unordered_map<std::string, EnemyStats> s_database;
};
