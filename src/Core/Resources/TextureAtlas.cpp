#include "Core/Resources/TextureAtlas.h"
#include <fstream>
#include <iostream>

bool TextureAtlas::loadFromFile(const std::string& texturePath, const std::string& jsonPath, bool flipY) {
    m_flipY = flipY;
    auto newTex = std::make_unique<sf::Texture>();
    if (!newTex->loadFromFile(texturePath)) {
        std::cerr << "TextureAtlas: Failed to load texture: " << texturePath << "\n";
        return false;
    }
    newTex->setSmooth(true);
    sf::Texture* currentTex = newTex.get();
    m_textures.push_back(std::move(newTex));

    std::ifstream file(jsonPath);
    if (!file.is_open()) {
        std::cerr << "TextureAtlas: Failed to load json: " << jsonPath << "\n";
        return false;
    }

    nlohmann::json atlasJson;
    try {
        file >> atlasJson;
    } catch (const std::exception& e) {
        std::cerr << "TextureAtlas: Parse error: " << e.what() << "\n";
        return false;
    }

    unsigned int texHeight = currentTex->getSize().y;

    for (auto it = atlasJson.begin(); it != atlasJson.end(); ++it) {
        const std::string& spriteName = it.key();
        const auto& rectData = it.value();

        if (rectData.contains("x") && rectData.contains("y") && 
            rectData.contains("width") && rectData.contains("height")) {
            
            int x = rectData["x"].get<int>();
            int y_source = rectData["y"].get<int>();
            int width = rectData["width"].get<int>();
            int height = rectData["height"].get<int>();

            int y_final;
            if (m_flipY) {
                y_final = static_cast<int>(texHeight) - y_source - height;
            } else {
                y_final = y_source;
            }
            AssetTextureData data;
            data.texture = currentTex;
            data.rect = sf::IntRect(x, y_final, width, height);
            m_frames[spriteName] = data;
        } else if (rectData.contains("frames") && rectData["frames"].is_array() && rectData["frames"].size() > 0) {
            auto firstFrame = rectData["frames"][0];
            int x = firstFrame["x"].get<int>();
            int y_source = firstFrame["y"].get<int>();
            int width = firstFrame["width"].get<int>();
            int height = firstFrame["height"].get<int>();

            int y_final;
            if (m_flipY) {
                y_final = static_cast<int>(texHeight) - y_source - height;
            } else {
                y_final = y_source;
            }
            AssetTextureData data;
            data.texture = currentTex;
            data.rect = sf::IntRect(x, y_final, width, height);
            m_frames[spriteName] = data;
        }
    }
    return true;
}

sf::IntRect TextureAtlas::getRect(const std::string& name) const {
    auto it = m_frames.find(name);
    if (it != m_frames.end()) {
        return it->second.rect;
    }
    return sf::IntRect();
}

sf::Texture& TextureAtlas::getTexture() {
    return *m_textures[0];
}

const sf::Texture& TextureAtlas::getTexture() const {
    return *m_textures[0];
}

AssetTextureData TextureAtlas::GetTextureData(const std::string& name) const {
    AssetTextureData data = {nullptr, sf::IntRect()};
    auto it = m_frames.find(name);
    if (it != m_frames.end()) {
        data = it->second;
    }
    return data;
}

sf::Sprite TextureAtlas::CreateSprite(const std::string& assetId) const {
    sf::Sprite spr;
    auto it = m_frames.find(assetId);
    if (it != m_frames.end()) {
        spr.setTexture(*(it->second.texture));
        spr.setTextureRect(it->second.rect);
        spr.setOrigin(it->second.rect.width / 2.0f, it->second.rect.height / 2.0f);
    }
    return spr;
}
