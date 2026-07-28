#pragma once

#include <SFML/Graphics.hpp>
#include <string>
#include <unordered_map>

class IconManager {
public:
    static IconManager& GetInstance() {
        static IconManager instance;
        return instance;
    }

    // Prevents copying
    IconManager(const IconManager&) = delete;
    IconManager& operator=(const IconManager&) = delete;

    // Initializes the manager (loads JSON files)
    void init();

    // Gets the icon rect for a given weapon or passive item name
    // Example: "Magic Wand", "Whip", "Garlic", "Spinach"
    sf::IntRect getIconRect(const std::string& itemName);

    // Gets the rect for a VFX frame in vfx_atlas.json
    sf::IntRect getVfxRect(const std::string& vfxName);

private:
    IconManager() = default;
    ~IconManager() = default;

    // Maps the display name (e.g. "Magic Wand") to its frame name (e.g. "WandHoly.png")
    std::unordered_map<std::string, std::string> m_nameToFrame;

    // Maps the frame name (e.g. "WandHoly" without .png) to its rect
    std::unordered_map<std::string, sf::IntRect> m_atlasRects;
    
    // Maps the VFX frame name to its rect from vfx_atlas.json
    std::unordered_map<std::string, sf::IntRect> m_vfxRects;
    
    bool m_initialized = false;
};
