#pragma once
#include <SFML/Graphics.hpp>
#include <string>
#include <vector>
#include <memory>
#include "Entities/Obstacle.h"

struct MapData {
    std::shared_ptr<sf::RenderTexture> backgroundTexture;
    std::vector<std::unique_ptr<Obstacle>> obstacles;
    bool success = false;
};

class MapLoader {
public:
    // Parses a map JSON file, renders background layers into a 2048x2048 texture,
    // and extracts foreground/obstacle layers into Obstacle entities.
    static MapData LoadMap(const std::string& filepath, sf::Texture& outAtlasTexture);
};
