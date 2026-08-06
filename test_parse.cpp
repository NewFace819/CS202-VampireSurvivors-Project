#include <iostream>
#include <fstream>
#include <nlohmann/json.hpp>
#include <SFML/Graphics.hpp>
#include <unordered_map>

using json = nlohmann::json;

int main() {
    std::unordered_map<std::string, sf::IntRect> m_atlasRects;
    std::unordered_map<std::string, std::string> m_nameToFrame;
    
    std::ifstream file1("assets/Data/items_atlas.json");
    if (file1.is_open()) {
        try {
            json j;
            file1 >> j;
            for (auto& el : j.items()) {
                std::string key = el.key();
                auto& rect = el.value();
                int x = rect["x"];
                int y = rect["y"];
                int w = rect["width"];
                int h = rect["height"];
                m_atlasRects[key] = sf::IntRect(x, y, w, h);
            }
            std::cout << "Parsed items_atlas.json, size: " << m_atlasRects.size() << "\n";
            std::cout << "Garlic rect: " << m_atlasRects["Garlic"].left << "\n";
        } catch (const std::exception& e) {
            std::cerr << "Failed to parse items_atlas.json: " << e.what() << "\n";
        }
    }

    std::ifstream file2("assets/Data/WEAPON_DATA.json");
    if (file2.is_open()) {
        try {
            json j;
            file2 >> j;
            for (auto& el : j.items()) {
                auto& levelArray = el.value();
                if (levelArray.is_array() && levelArray.size() > 0) {
                    auto& level1 = levelArray[0];
                    if (level1.contains("name") && level1.contains("frameName")) {
                        std::string name = level1["name"];
                        std::string frameName = level1["frameName"];
                        if (frameName.length() >= 4 && frameName.substr(frameName.length() - 4) == ".png") {
                            frameName = frameName.substr(0, frameName.length() - 4);
                        }
                        m_nameToFrame[name] = frameName;
                    }
                }
            }
            std::cout << "Parsed WEAPON_DATA.json, size: " << m_nameToFrame.size() << "\n";
            std::cout << "Garlic frame: " << m_nameToFrame["Garlic"] << "\n";
        } catch (const std::exception& e) {
            std::cerr << "Failed to parse WEAPON_DATA.json: " << e.what() << "\n";
        }
    }
    
    return 0;
}
