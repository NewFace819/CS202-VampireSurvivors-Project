#include "IconManager.h"
#include <fstream>
#include <iostream>
#include <nlohmann/json.hpp>

using json = nlohmann::json;

void IconManager::init() {
    if (m_initialized) return;

    // 1. Load items_atlas.json
    {
        std::ifstream file("assets/data/items_atlas.json");
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
        std::ifstream file("assets/data/WEAPON_DATA.json");
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
    m_nameToFrame["Money Bag"] = "MoneyPile";
    m_nameToFrame["Floor Chicken"] = "Roast";
    m_nameToFrame["Tiragisu"] = "Tiramisu";
    m_nameToFrame["GUNS"] = "Guns";
    m_nameToFrame["GATTI"] = "Cat";
    m_nameToFrame["SONG"] = "Song";
    m_nameToFrame["TRAPANO"] = "trapano";
    
    // Explicit weapon & evolution icon fallbacks to ensure authentic UI representations
    if (m_nameToFrame.find("Whip") == m_nameToFrame.end()) m_nameToFrame["Whip"] = "Whip";
    if (m_nameToFrame.find("Bloody Tear") == m_nameToFrame.end()) m_nameToFrame["Bloody Tear"] = "Whip2";
    if (m_nameToFrame.find("Magic Wand") == m_nameToFrame.end()) m_nameToFrame["Magic Wand"] = "WandHoly";
    if (m_nameToFrame.find("Holy Wand") == m_nameToFrame.end()) m_nameToFrame["Holy Wand"] = "WandHoly2";
    if (m_nameToFrame.find("Knife") == m_nameToFrame.end()) m_nameToFrame["Knife"] = "Knife";
    if (m_nameToFrame.find("Thousand Edge") == m_nameToFrame.end()) m_nameToFrame["Thousand Edge"] = "Knife2";
    if (m_nameToFrame.find("Fire Wand") == m_nameToFrame.end()) m_nameToFrame["Fire Wand"] = "WandFire";
    if (m_nameToFrame.find("Hellfire") == m_nameToFrame.end()) m_nameToFrame["Hellfire"] = "Hellfire";
    if (m_nameToFrame.find("Axe") == m_nameToFrame.end()) m_nameToFrame["Axe"] = "Axe";
    if (m_nameToFrame.find("Death Spiral") == m_nameToFrame.end()) m_nameToFrame["Death Spiral"] = "Scythe";
    if (m_nameToFrame.find("Cross") == m_nameToFrame.end()) m_nameToFrame["Cross"] = "Cross";
    if (m_nameToFrame.find("Heaven Sword") == m_nameToFrame.end()) m_nameToFrame["Heaven Sword"] = "HeavenSword";
    if (m_nameToFrame.find("Garlic") == m_nameToFrame.end()) m_nameToFrame["Garlic"] = "Garlic";
    if (m_nameToFrame.find("Soul Eater") == m_nameToFrame.end()) m_nameToFrame["Soul Eater"] = "OrbOrange";
    if (m_nameToFrame.find("King Bible") == m_nameToFrame.end()) m_nameToFrame["King Bible"] = "HolyBook";
    if (m_nameToFrame.find("Unholy Vespers") == m_nameToFrame.end()) m_nameToFrame["Unholy Vespers"] = "UnholyBook";
    if (m_nameToFrame.find("Santa Water") == m_nameToFrame.end()) m_nameToFrame["Santa Water"] = "HolyWater";
    if (m_nameToFrame.find("La Borra") == m_nameToFrame.end()) m_nameToFrame["La Borra"] = "Water2";
    if (m_nameToFrame.find("Runetracer") == m_nameToFrame.end()) m_nameToFrame["Runetracer"] = "Diamond2";
    if (m_nameToFrame.find("NO FUTURE") == m_nameToFrame.end()) m_nameToFrame["NO FUTURE"] = "Carnage";
    if (m_nameToFrame.find("Lightning Ring") == m_nameToFrame.end()) m_nameToFrame["Lightning Ring"] = "LighningRing";
    if (m_nameToFrame.find("Thunder Loop") == m_nameToFrame.end()) m_nameToFrame["Thunder Loop"] = "Thunderloop";
    
    // 3. Load vfx_atlas.json
    {
        std::ifstream file("assets/data/vfx_atlas.json");
        if (file.is_open()) {
            try {
                json j;
                file >> j;
                for (auto& el : j.items()) {
                    std::string key = el.key();
                    auto& rect = el.value();
                    
                    if (rect.is_object() && rect.contains("x") && rect.contains("y") && rect.contains("width") && rect.contains("height")) {
                        int x = rect["x"];
                        int y = rect["y"];
                        int w = rect["width"];
                        int h = rect["height"];
                        
                        // Flip Y coordinate because the atlas is bottom-left origin (2048x2048) and SFML is top-left
                        y = 2048 - y - h;
                        
                        m_vfxRects[key] = sf::IntRect(x, y, w, h);
                    }
                }
            } catch (const std::exception& e) {
                std::cerr << "IconManager: Failed to parse vfx_atlas.json: " << e.what() << "\n";
            }
        } else {
            std::cerr << "IconManager: Failed to open assets/Data/vfx_atlas.json\n";
        }
    }

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

sf::IntRect IconManager::getVfxRect(const std::string& vfxName) {
    if (!m_initialized) {
        init();
    }

    auto atlasIt = m_vfxRects.find(vfxName);
    if (atlasIt != m_vfxRects.end()) {
        return atlasIt->second;
    }
    
    std::cerr << "IconManager: Warning: VFX frame '" << vfxName << "' not found in vfx_atlas.json!\n";
    return sf::IntRect(0, 0, 16, 16);
}
