#include "IconManager.h"
#include <fstream>
#include <iostream>
#include <nlohmann/json.hpp>

using json = nlohmann::json;

void IconManager::init() {
    if (m_initialized) return;

    // 1. Load items_atlas.json
    {
        std::ifstream file("assets/Data/items_atlas.json");
        if (file.is_open()) {
            try {
                json j;
                file >> j;
                for (auto& el : j.items()) {
                    std::string key = el.key(); // e.g. "Garlic", "Whip"
                    auto& rect = el.value();
                    
                    if (rect.is_object() && rect.contains("x") && rect.contains("y") && rect.contains("width") && rect.contains("height")) {
                        int x = rect["x"];
                        int y = rect["y"];
                        int w = rect["width"];
                        int h = rect["height"];
                        
                        // Flip Y coordinate because the atlas is bottom-left origin and SFML is top-left
                        y = 1024 - y - h;
                        
                        m_atlasRects[key] = sf::IntRect(x, y, w, h);
                    }
                }
            } catch (const std::exception& e) {
                std::cerr << "IconManager: Failed to parse items_atlas.json: " << e.what() << "\n";
            }
        } else {
            std::cerr << "IconManager: Failed to open assets/Data/items_atlas.json\n";
        }
    }

    // 2. Load WEAPON_DATA.json to map item names to frame names
    {
        std::ifstream file("assets/Data/WEAPON_DATA.json");
        if (file.is_open()) {
            try {
                json j;
                file >> j;
                // WEAPON_DATA has keys like "CROSS", "WHIP", mapped to an array of level objects
                for (auto& el : j.items()) {
                    auto& levelArray = el.value();
                    if (levelArray.is_array() && levelArray.size() > 0) {
                        auto& level1 = levelArray[0];
                        if (level1.contains("name") && level1["name"].is_string() && 
                            level1.contains("frameName") && level1["frameName"].is_string()) {
                            
                            // Only use frameName from WEAPON_DATA if it's explicitly from the items texture.
                            // If it's from vfx, the icon key is usually just the weapon's name.
                            if (level1.contains("texture") && level1["texture"] == "items") {
                                std::string name = level1["name"];
                                std::string frameName = level1["frameName"];
                                
                                if (frameName.length() >= 4 && frameName.substr(frameName.length() - 4) == ".png") {
                                    frameName = frameName.substr(0, frameName.length() - 4);
                                }
                                
                                m_nameToFrame[name] = frameName;
                            }
                        }
                    }
                }
            } catch (const std::exception& e) {
                std::cerr << "IconManager: Failed to parse WEAPON_DATA.json: " << e.what() << "\n";
            }
        } else {
            std::cerr << "IconManager: Failed to open assets/Data/WEAPON_DATA.json\n";
        }
    }

    // Passive Items - Map them directly if they aren't in WEAPON_DATA
    m_nameToFrame["Money Bag"] = "CoinBag";
    m_nameToFrame["Floor Chicken"] = "Roast";
    
    // Some hardcoded fallbacks just in case
    if (m_nameToFrame.find("Bloody Tear") == m_nameToFrame.end()) m_nameToFrame["Bloody Tear"] = "Whip2";
    if (m_nameToFrame.find("Death Spiral") == m_nameToFrame.end()) m_nameToFrame["Death Spiral"] = "Scythe";
    
    m_initialized = true;
}

sf::IntRect IconManager::getIconRect(const std::string& itemName) {
    if (!m_initialized) {
        init();
    }

    std::string frameName = itemName; // Default to the item name itself

    // Check if we have a mapping from display name to frame name
    auto it = m_nameToFrame.find(itemName);
    if (it != m_nameToFrame.end()) {
        frameName = it->second;
    }

    // Look up the rect in the atlas
    auto atlasIt = m_atlasRects.find(frameName);
    if (atlasIt != m_atlasRects.end()) {
        return atlasIt->second;
    }
    
    std::cerr << "IconManager: Warning: Icon for '" << itemName << "' (frame: '" << frameName << "') not found in items_atlas.json!\n";
    return sf::IntRect(0, 0, 16, 16);
}
