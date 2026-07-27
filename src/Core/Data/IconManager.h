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

private:
    IconManager() = default;
    ~IconManager() = default;

    // Maps the display name (e.g. "Magic Wand") to its frame name (e.g. "WandHoly.png")
    std::unordered_map<std::string, std::string> m_nameToFrame;

    // Maps the frame name (e.g. "WandHoly" without .png) to its rect
    std::unordered_map<std::string, sf::IntRect> m_atlasRects;
    
    bool m_initialized = false;
};
