#pragma once
#pragma once

#include <SFML/Graphics.hpp>
#include <string>
#include <unordered_map>
#include <vector>
#include <memory>
#include <nlohmann/json.hpp>

struct AssetTextureData
{
    const sf::Texture* texture;
    sf::IntRect rect;
};

class TextureAtlas {
public:
    TextureAtlas() = default;

    // flipY=true for Unity-exported atlases (bottom-left origin → SFML top-left)
    // flipY=false for atlases already in SFML coordinate system
    bool loadFromFile(const std::string& texturePath, const std::string& jsonPath, bool flipY = true);

    sf::IntRect getRect(const std::string& name) const;
    sf::Texture& getTexture();
    const sf::Texture& getTexture() const;

    // Create sprite centered and scaled
    sf::Sprite CreateSprite(const std::string& assetId) const;

    AssetTextureData GetTextureData(const std::string& assetId) const;

private:
    std::vector<std::unique_ptr<sf::Texture>> m_textures;
    std::unordered_map<std::string, AssetTextureData> m_frames;
    bool m_flipY = true;
};
