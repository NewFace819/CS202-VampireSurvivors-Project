#include "UIPlayerCoopCard.h"
#include "../../Core/Data/CharacterProfile.h"
#include "../../Core/Data/WeaponDataManager.h"
#include "Core/Resources/TextureAtlas.h"
#include <SFML/Graphics/RenderTarget.hpp>
#include <fstream>
#include <nlohmann/json.hpp>
#include <iostream>

UIPlayerCoopCard::UIPlayerCoopCard(TextureAtlas& atlas, const sf::Font& font, const sf::Font* boldFont, const std::string& playerName)
    : m_playerName(playerName)
    , m_currentProfile(nullptr)
    , m_isSelected(false)
{
    m_backgroundNormal.SetTexture(atlas, "frame1_c2");
    m_backgroundNormal.SetMargins(12, 12, 12, 12);

    if (boldFont)
    {
        m_nameText.setFont(*boldFont);
        m_playerText.setFont(*boldFont);
    }
    else
    {
        m_nameText.setFont(font);
        m_playerText.setFont(font);
    }

    m_nameText.setString("");
    m_nameText.setCharacterSize(21);
    m_nameText.setFillColor(sf::Color::White);
    
    m_playerText.setString(playerName);
    m_playerText.setCharacterSize(24);
    m_playerText.setFillColor(sf::Color::White);
    
    UpdateVisuals();
}

void UIPlayerCoopCard::SetCharacterProfile(const CharacterProfile* profile, const WeaponDataManager* weaponManager, TextureAtlas& atlas)
{
    m_currentProfile = profile;
    
    if (profile)
    {
        std::string fullName = profile->GetName();
        size_t spacePos = fullName.find(' ');
        std::string shortName = (spacePos != std::string::npos) ? fullName.substr(0, spacePos) : fullName;
        m_nameText.setString(shortName);

        // Load character sprite manually like CharacterCardWidget
        std::string spriteName = profile->GetSpriteName();
        std::string frameKey = spriteName;
        if (frameKey.size() > 4 && frameKey.substr(frameKey.size()-4) == ".png")
            frameKey = frameKey.substr(0, frameKey.size()-4);

        // Use textureName from CHARACTER_DATA.json, already stripped of the
        // "character_" prefix by CharacterDataManager. The JSON key (GetId()) is
        // often a different word from the sprite file -- CROCI/krochi,
        // CIRO/arca, NEO/marrabbio and 28 others -- so using the id here loaded a
        // file that does not exist, leaving the previous character's sprite on
        // screen. CharacterCardWidget already resolves it this way.
        std::string resolvedCharId = profile->GetTextureName();
        if (resolvedCharId.empty()) {
            resolvedCharId = profile->GetId();
            std::transform(resolvedCharId.begin(), resolvedCharId.end(), resolvedCharId.begin(),
                [](unsigned char c){ return std::tolower(c); });
        }

        std::string texPath   = "assets/Graphics/Characters/character_" + resolvedCharId + ".png";
        std::string atlasPath = "assets/data/CharacterAtlas/character_" + resolvedCharId + "_atlas.json";

        bool texLoaded = m_charTexture.loadFromFile(texPath);
        if (texLoaded) {
            sf::IntRect bestRect(0, 0, 32, 32);
            bool found = false;
            std::ifstream atlasFile(atlasPath);
            if (atlasFile.is_open()) {
                try {
                    nlohmann::json atlasJson;
                    atlasFile >> atlasJson;
                    auto tryFrame = [&](const std::string& key) -> bool {
                        auto it = atlasJson.find(key);
                        if (it != atlasJson.end()) {
                            bestRect.left   = it->value("x", 0);
                            bestRect.top    = it->value("y", 0);
                            bestRect.width  = it->value("width", 32);
                            bestRect.height = it->value("height", 32);
                            return true;
                        }
                        return false;
                    };
                    // Priority: prefer the NON-"new" skin (default/original look).
                    std::string baseKey = frameKey;
                    std::string newKey  = frameKey;
                    if (frameKey.size() > 3 &&
                        (frameKey.substr(0, 3) == "new" || frameKey.substr(0, 3) == "New")) {
                        baseKey = frameKey.substr(3); // strip "new"/"New"
                    } else {
                        newKey = "new" + frameKey;
                    }

                    std::string charName = profile->GetName();
                    size_t sp = charName.find(' ');
                    if (sp != std::string::npos) charName = charName.substr(0, sp);

                    // Try in order: base (non-new) -> exact -> "new" variant -> name_01
                    if (!tryFrame(baseKey) && !tryFrame(frameKey) &&
                        !tryFrame(newKey)  && !tryFrame(charName + "_01")) {
                        // no frame found — leave bestRect as default 32x32
                    } else {
                        int y_sfml = static_cast<int>(m_charTexture.getSize().y) - bestRect.top - bestRect.height;
                        bestRect.top = y_sfml;
                        found = true;
                    }
                } catch(...) {}
            }
            m_characterSprite.setTexture(m_charTexture);
            m_characterSprite.setTextureRect(bestRect);
        }

        sf::FloatRect charBounds = m_characterSprite.getLocalBounds();
        if(charBounds.width > 0 && charBounds.height > 0)
        {
            m_characterSprite.setScale(92.0f / charBounds.width, 92.0f / charBounds.height);
        }
        
        if (weaponManager)
        {
            const WeaponProfile& wp = weaponManager->GetWeaponById(profile->GetStartingWeaponId());
            std::string weaponFrame = wp.GetFrameName();
            m_weaponSprite = atlas.CreateSprite(weaponFrame.empty() ? profile->GetStartingWeaponId() : weaponFrame);
        }
        else
        {
            m_weaponSprite = atlas.CreateSprite(profile->GetStartingWeaponId());
        }

        sf::FloatRect weaponBounds = m_weaponSprite.getLocalBounds();
        if(weaponBounds.width > 0 && weaponBounds.height > 0)
        {
            m_weaponSprite.setScale(42.0f / weaponBounds.width, 42.0f / weaponBounds.height);
        }
    }
    else
    {
        m_nameText.setString("");
    }
    
    SetPosition(m_position);
    UpdateVisuals();
}

void UIPlayerCoopCard::SetSelected(bool selected)
{
    m_isSelected = selected;
    UpdateVisuals();
}

void UIPlayerCoopCard::UpdateVisuals()
{
    if (m_currentProfile == nullptr)
    {
        m_backgroundNormal.SetColor(sf::Color(100, 100, 100));
        m_playerText.setFillColor(sf::Color(150, 150, 150));
    }
    else
    {
        m_backgroundNormal.SetColor(sf::Color::White);
        m_playerText.setFillColor(sf::Color::White);
    }
}

void UIPlayerCoopCard::SetPosition(const sf::Vector2f& pos)
{
    UIElement::SetPosition(pos);
    
    m_backgroundNormal.setPosition(pos);

    m_nameText.setOrigin(0.0f, 0.0f);
    m_nameText.setPosition(pos.x + 10.0f, pos.y + 10.0f);

    if (m_currentProfile)
    {
        float spacing = 15.0f;
        float charW = m_characterSprite.getGlobalBounds().width;
        float weapW = m_weaponSprite.getGlobalBounds().width;
        float totalW = charW + spacing + weapW;
        
        float startX = pos.x + (m_size.x - totalW) / 2.0f;
        float centerY = pos.y + m_size.y / 2.0f; // Center without offset

        m_characterSprite.setPosition(startX, centerY - m_characterSprite.getGlobalBounds().height / 2.0f);
        m_weaponSprite.setPosition(startX + charW + spacing, centerY - m_weaponSprite.getGlobalBounds().height / 2.0f + 15.0f);
    }
    
    sf::FloatRect playerBounds = m_playerText.getLocalBounds();
    m_playerText.setPosition(pos.x + (m_size.x - playerBounds.width) / 2.0f, pos.y + m_size.y - playerBounds.height - 20.0f);
}

void UIPlayerCoopCard::SetSize(const sf::Vector2f& size)
{
    UIElement::SetSize(size);
    m_backgroundNormal.SetSize(size);
    
    SetPosition(m_position);
}

void UIPlayerCoopCard::Update(float deltaTime)
{
    m_backgroundNormal.Update();
}

void UIPlayerCoopCard::HandleEvent(const sf::Event& event, const sf::RenderWindow& window)
{
}

void UIPlayerCoopCard::Draw(sf::RenderTarget& target)
{
    target.draw(m_backgroundNormal);

    if (m_currentProfile)
    {
        target.draw(m_nameText);
        target.draw(m_characterSprite);
        
        // Draw Weapon Shadow
        sf::Vector2f origPos = m_weaponSprite.getPosition();
        sf::Color origColor = m_weaponSprite.getColor();
        
        m_weaponSprite.setColor(sf::Color(0, 0, 0, 180));
        m_weaponSprite.setPosition(origPos.x + 4.0f, origPos.y + 4.0f);
        target.draw(m_weaponSprite);
        
        // Draw Actual Weapon
        m_weaponSprite.setColor(origColor);
        m_weaponSprite.setPosition(origPos);
        target.draw(m_weaponSprite);
    }
    
    target.draw(m_playerText);
}
