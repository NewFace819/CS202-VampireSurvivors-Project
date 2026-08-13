#include "Core/Data/MapLoader.h"
#include <fstream>
#include <iostream>
#include <nlohmann/json.hpp>

using json = nlohmann::json;

MapData MapLoader::LoadMap(const std::string& filepath, sf::Texture& outAtlasTexture) {
    MapData result;
    result.success = false;

    std::ifstream file(filepath);
    if (!file.is_open()) {
        std::cerr << "MapLoader: Could not open " << filepath << "\n";
        return result;
    }

    json j;
    try {
        file >> j;
    } catch (const json::parse_error& e) {
        std::cerr << "MapLoader: Parse error in " << filepath << ": " << e.what() << "\n";
        return result;
    }

    std::string atlasPath = j.value("atlas", "");
    if (atlasPath.empty() || !outAtlasTexture.loadFromFile(atlasPath)) {
        std::cerr << "MapLoader: Could not load atlas texture: " << atlasPath << "\n";
        return result;
    }
    
    // We want crisp pixels if the game is pixel art
    outAtlasTexture.setSmooth(false);

    int mapWidth = j.value("mapWidth", 64);
    int mapHeight = j.value("mapHeight", 64);
    int tileWidth = j.value("tileWidth", 32);
    int tileHeight = j.value("tileHeight", 32);

    result.backgroundTexture = std::make_shared<sf::RenderTexture>();
    if (!result.backgroundTexture->create(mapWidth * tileWidth, mapHeight * tileHeight)) {
        std::cerr << "MapLoader: Could not create RenderTexture of size " 
                  << mapWidth * tileWidth << "x" << mapHeight * tileHeight << "\n";
        return result;
    }

    result.backgroundTexture->clear(sf::Color::Transparent);

    if (j.contains("layers") && j["layers"].is_array()) {
        for (const auto& layer : j["layers"]) {
            std::string name = layer.value("name", "");
            bool visible = layer.value("visible", true);
            if (!visible) continue;

            bool isBackground = (name == "Floor" || name == "FloorOverlay" || name == "Decals" || name == "Shadows");

            if (layer.contains("tiles") && layer["tiles"].is_array()) {
                for (const auto& tile : layer["tiles"]) {
                    int tx = tile.value("x", 0);
                    int ty = tile.value("y", 0);

                    if (tile.contains("spriteRect")) {
                        auto rectObj = tile["spriteRect"];
                        sf::IntRect sRect(
                            rectObj.value("x", 0),
                            rectObj.value("y", 0),
                            rectObj.value("width", 32),
                            rectObj.value("height", 32)
                        );

                        if (isBackground) {
                            sf::Sprite s(outAtlasTexture, sRect);
                            s.setPosition(static_cast<float>(tx * tileWidth), static_cast<float>(ty * tileHeight));
                            result.backgroundTexture->draw(s);
                        } else {
                            // Foreground obstacle (visual Y-sorted)
                            // In tile map, origin is top-left usually, but Obstacle centers X and bottom Y.
                            // To place Obstacle correctly, we set its position to bottom-center of its rect.
                            
                            float collisionRatio = 0.0f;
                            float widthRatio = 1.0f;
                            
                            bool noCollision = tile.value("noCollision", false);
                            
                            if (name == "Obstacle" || name == "Walls" || name == "PlayerWall") {
                                if (!noCollision) {
                                    collisionRatio = 0.8f; // Make bottom 80% solid
                                }
                                widthRatio = 0.4f;     // Trees are usually thinner than a full tile
                            }

                            // Calculate world coordinates
                            float posX = static_cast<float>(tx * tileWidth) + sRect.width / 2.0f;
                            float posY = static_cast<float>(ty * tileHeight) + sRect.height;

                            auto obs = std::make_unique<Obstacle>(
                                sf::Vector2f(posX, posY), outAtlasTexture, sRect, 1.0f, collisionRatio, widthRatio
                            );
                            result.obstacles.push_back(std::move(obs));
                        }
                    }
                }
            }
        }
    }

    result.backgroundTexture->display();

    result.success = true;
    return result;
}
