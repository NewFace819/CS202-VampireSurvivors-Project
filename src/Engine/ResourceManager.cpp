#include "ResourceManager.h"
#include <stdexcept>
#include <iostream>

sf::Texture& ResourceManager::LoadTexture(const std::string& name, const std::string& filename) {
    if (m_textures.find(name) != m_textures.end()) {
        return *m_textures[name];
    }

    auto texture = std::make_unique<sf::Texture>();
    if (!texture->loadFromFile(filename)) {
        std::cerr << "Failed to load texture: " << filename << std::endl;
        // SFML already outputs an error to console, but we might want to throw or return a default texture
    }
    
    m_textures[name] = std::move(texture);
    return *m_textures[name];
}

sf::Texture& ResourceManager::GetTexture(const std::string& name) {
    auto it = m_textures.find(name);
    if (it != m_textures.end()) {
        return *(it->second);
    }
    throw std::runtime_error("Texture not found: " + name);
}
