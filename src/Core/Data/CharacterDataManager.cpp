#include "CharacterDataManager.h"
#include <fstream>
#include <iostream>
#include <nlohmann/json.hpp>
#include <algorithm>
#include <cctype>

CharacterDataManager::CharacterDataManager()
    : m_fallbackProfile("UNKNOWN", "Unknown", "Fallback Data", "default_portrait", "default_weapon", 0, std::unordered_map<std::string, float>())
{
}

bool CharacterDataManager::LoadData(const std::string& configFilePath)
{
    std::ifstream file(configFilePath);
    if(!file.is_open())
    {
        std::cerr << "Failed to open Character configuration file: " << configFilePath << "\n";
        return false;
    }

    nlohmann::ordered_json jsonData;
    try
    {
        file >> jsonData;
    }
    catch(const nlohmann::json::parse_error& e)
    {
        std::cerr << "JSON parse error in file " << configFilePath << ": " << e.what() << "\n";
        return false;
    }

    m_characters.clear();
    m_characterOrder.clear();

    for(auto& el : jsonData.items())
    {
        std::string id = el.key();
        
        if(!el.value().is_array() || el.value().empty())
        {
            continue;
        }

        m_characterOrder.push_back(id);

        const auto& charJson = el.value()[0];

        std::string charName = charJson.value("charName", "Unknown");
        std::string surname = charJson.value("surname", "");
        std::string name = charName;
        if(!surname.empty())
        {
            name += " " + surname;
        }

        std::string description = charJson.value("description", "");
        
        std::string spriteName = charJson.value("spriteName", "");
        size_t dotPos = spriteName.find_last_of('.');
        if(dotPos != std::string::npos)
        {
            spriteName = spriteName.substr(0, dotPos);
        }
        std::string portraitTextureId = charJson.value("portraitName", "");
        if (portraitTextureId.empty()) {
            std::string lowerName = charName;
            std::transform(lowerName.begin(), lowerName.end(), lowerName.begin(),
                [](unsigned char c){ return std::tolower(c); });
            portraitTextureId = "p_" + lowerName;
        } else {
            size_t pDotPos = portraitTextureId.find_last_of('.');
            if (pDotPos != std::string::npos) {
                portraitTextureId = portraitTextureId.substr(0, pDotPos);
            }
        }

        std::string startingWeaponId = charJson.value("startingWeapon", "");
        int basePrice = charJson.value("price", 0);

        std::unordered_map<std::string, float> stats;
        std::vector<std::string> statKeys = {
            "maxHp", "armor", "regen", "moveSpeed", "power", "cooldown",
            "area", "speed", "duration", "amount", "luck", "growth",
            "greed", "curse", "magnet", "revivals", "rerolls", "skips", "banish"
        };

        for(const auto& key : statKeys)
        {
            if(charJson.contains(key) && charJson[key].is_number())
            {
                stats[key] = charJson[key].get<float>();
            }
        }

        bool isAlwaysHidden = charJson.value("alwaysHidden", false);
        bool isBought = charJson.value("isBought", false);

        std::string originalSpriteName = charJson.value("spriteName", "");
        int walkingFrames = charJson.value("walkingFrames", 1);

        // textureName is the actual PNG file stem in assets/Graphics/Characters/
        // e.g. "character_pantalonerun". Strip the "character_" prefix for lookup.
        std::string textureName = charJson.value("textureName", "");
        if (textureName.empty()) {
            // Fallback: lowercase id
            textureName = "character_" + id;
            std::transform(textureName.begin(), textureName.end(), textureName.begin(),
                [](unsigned char c){ return std::tolower(c); });
        }
        // Strip leading "character_" prefix so CharacterCardWidget can add it back uniformly
        const std::string prefix = "character_";
        if (textureName.size() > prefix.size() &&
            textureName.substr(0, prefix.size()) == prefix) {
            textureName = textureName.substr(prefix.size());
        }

        CharacterProfile profile(id, name, description, portraitTextureId, startingWeaponId, basePrice, stats, originalSpriteName, walkingFrames, isAlwaysHidden, isBought, textureName);
        m_characters.insert({id, profile});
    }

    return true;
}

const CharacterProfile& CharacterDataManager::GetCharacterById(const std::string& id) const
{
    auto it = m_characters.find(id);
    if(it != m_characters.end())
    {
        return it->second;
    }

    std::cerr << "Character ID not found: " << id << ". Returning fallback profile.\n";
    return m_fallbackProfile;
}

const std::unordered_map<std::string, CharacterProfile>& CharacterDataManager::GetAllCharacters() const
{
    return m_characters;
}

const std::vector<std::string>& CharacterDataManager::GetCharacterOrder() const
{
    return m_characterOrder;
}
