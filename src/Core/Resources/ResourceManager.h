#pragma once
#include <SFML/Graphics.hpp>
#include <unordered_map>
#include <string>
#include <memory>

class ResourceManager {
public:
    static ResourceManager& GetInstance() {
        static ResourceManager instance;
        return instance;
    }

    // Loads a texture and stores it. If already loaded, returns the existing one.
    sf::Texture& LoadTexture(const std::string& name, const std::string& filename);

    // Retrieves a previously loaded texture
    sf::Texture& GetTexture(const std::string& name);

private:
    ResourceManager() = default;
    ~ResourceManager() = default;

    // Delete copy/move constructors for singleton
    ResourceManager(const ResourceManager&) = delete;
    ResourceManager& operator=(const ResourceManager&) = delete;

    std::unordered_map<std::string, std::unique_ptr<sf::Texture>> m_textures;
};
