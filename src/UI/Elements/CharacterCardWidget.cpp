#include "CharacterCardWidget.h"
#include "../../Core/Data/CharacterProfile.h"
#include "../../Core/Data/WeaponDataManager.h"
#include "Core/Resources/TextureAtlas.h"
#include <SFML/Window/Event.hpp>
#include <SFML/Graphics/RenderWindow.hpp>
#include <SFML/Graphics/RenderTarget.hpp>
#include <nlohmann/json.hpp>
#include <iostream>
#include <fstream>
#include <algorithm>
#include <cctype>
#include <unordered_map>

CharacterCardWidget::CharacterCardWidget(TextureAtlas& atlas, const sf::Font& font, const sf::Font* boldFont, const CharacterProfile& profile, bool isUnlocked, const WeaponDataManager* weaponManager, TextureAtlas* itemsAtlas)
    : m_characterId(profile.GetId())
    , m_state(CardState::Normal)
    , m_isUnlocked(isUnlocked)
    , m_isPressed(false)
{
    m_backgroundNormal.SetTexture(atlas, "frame1_c2");
    m_backgroundNormal.SetMargins(12, 12, 12, 12);
    
    m_backgroundSelected.SetTexture(atlas, "selectionSquare_03");
    m_backgroundSelected.SetMargins(12, 12, 12, 12);
    m_backgroundSelected.SetCornerScale(2.0f);
    m_backgroundSelected.SetSize({190.0f, 190.0f});

    if (boldFont)
    {
        m_nameText.setFont(*boldFont);
    }
    else
    {
        m_nameText.setFont(font);
    }

    std::string fullName = profile.GetName();
    size_t spacePos = fullName.find(' ');
    std::string shortName = (spacePos != std::string::npos) ? fullName.substr(0, spacePos) : fullName;
    m_nameText.setString(shortName);

    m_nameText.setCharacterSize(21);
    m_nameText.setFillColor(sf::Color::White);

    // Get the spriteName from profile (e.g. "Suora_01.png")
    std::string spriteName = profile.GetSpriteName();
    // Strip .png extension to get the frame key for atlas lookup
    std::string frameKey = spriteName;
    if (frameKey.size() > 4 && frameKey.substr(frameKey.size()-4) == ".png")
        frameKey = frameKey.substr(0, frameKey.size()-4);

    // Use textureName from CHARACTER_DATA.json (e.g. "pantalonerun", "minnah")
    // This is already stripped of the "character_" prefix by CharacterDataManager
    std::string resolvedCharId = profile.GetTextureName();
    if (resolvedCharId.empty()) {
        resolvedCharId = profile.GetId();
        std::transform(resolvedCharId.begin(), resolvedCharId.end(), resolvedCharId.begin(),
            [](unsigned char c){ return std::tolower(c); });
    }

    std::string texPath   = "assets/Graphics/Characters/character_" + resolvedCharId + ".png";
    std::string atlasPath = "assets/Data/CharacterAtlas/character_" + resolvedCharId + "_atlas.json";


    bool texLoaded = m_charTexture.loadFromFile(texPath);
    if (texLoaded) {
        // Use the frameKey directly from the spriteName to get the exact rect
        sf::IntRect bestRect(0, 0, 0, 0);
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
                // If the spriteName starts with "new", strip it and try the base key first.
                std::string baseKey = frameKey;
                std::string newKey  = frameKey;
                if (frameKey.size() > 3 &&
                    (frameKey.substr(0, 3) == "new" || frameKey.substr(0, 3) == "New")) {
                    baseKey = frameKey.substr(3); // strip "new"/"New"
                } else {
                    newKey = "new" + frameKey;    // build "new" variant for fallback
                }

                // Get character name for additional fallbacks
                std::string charName = profile.GetName();
                size_t sp = charName.find(' ');
                if (sp != std::string::npos) charName = charName.substr(0, sp);

                // Try in order: base (non-new) -> exact key -> "new" variant -> name_01
                if (!tryFrame(baseKey) && !tryFrame(frameKey) &&
                    !tryFrame(newKey)  && !tryFrame(charName + "_01")) {
                    std::cout << "[CARD DEBUG] No frame found for: " << profile.GetId() << "\n";
                } else {
                    // Apply Y-axis inversion for SFML coordinate system
                    int y_sfml = static_cast<int>(m_charTexture.getSize().y) - bestRect.top - bestRect.height;
                    bestRect.top = y_sfml;
                    found = true;
                }
            } catch(...) {
                std::cerr << "Error parsing JSON: " << atlasPath << "\n";
            }
        }
        
        m_characterSprite.setTexture(m_charTexture);
        if (found) {
            m_characterSprite.setTextureRect(bestRect);
        } else {
            m_characterSprite.setTextureRect(sf::IntRect(0, 0, 32, 32));
        }
    } else {
        std::cerr << "Failed to load image \"" << texPath << "\". Reason: Unable to open file\n";
    }

    sf::FloatRect charBounds = m_characterSprite.getLocalBounds();
    if (charBounds.width > 0 && charBounds.height > 0) {
        m_characterSprite.setScale(92.0f / charBounds.width, 92.0f / charBounds.height);
    }
    
    // Helper: strip .png extension for atlas frame lookup
    auto stripPng = [](const std::string& name) -> std::string {
        if (name.size() > 4 && name.substr(name.size()-4) == ".png")
            return name.substr(0, name.size()-4);
        return name;
    };

    if (weaponManager)
    {
        const WeaponProfile& wp = weaponManager->GetWeaponById(profile.GetStartingWeaponId());
        std::string weaponFrame = wp.GetFrameName();
        std::string frameKey = stripPng(weaponFrame.empty() ? profile.GetStartingWeaponId() : weaponFrame);
        // Prefer items_atlas for weapon sprites (weapons use texture:"items")
        if (itemsAtlas) {
            m_weaponSprite = itemsAtlas->CreateSprite(frameKey);
            // Fallback to UI atlas if not found in items atlas
            if (m_weaponSprite.getLocalBounds().width == 0)
                m_weaponSprite = atlas.CreateSprite(frameKey);
        } else {
            m_weaponSprite = atlas.CreateSprite(frameKey);
        }
    }
    else
    {
        m_weaponSprite = atlas.CreateSprite(profile.GetStartingWeaponId());
    }

    sf::FloatRect weaponBounds = m_weaponSprite.getLocalBounds();
    if(weaponBounds.width > 0 && weaponBounds.height > 0)
    {
        float scale = std::min(42.0f / weaponBounds.width, 42.0f / weaponBounds.height);
        m_weaponSprite.setScale(scale, scale);
    }

    if(!m_isUnlocked)
    {
        m_state = CardState::Locked;
    }

    UpdateVisuals();
}

void CharacterCardWidget::SetState(CardState state)
{
    if(m_state == state)
    {
        return;
    }

    m_state = state;
    UpdateVisuals();
}

void CharacterCardWidget::SetTint(sf::Color color)
{
    m_backgroundSelected.SetColor(color);
}

CardState CharacterCardWidget::GetState() const
{
    return m_state;
}

const std::string& CharacterCardWidget::GetCharacterId() const
{
    return m_characterId;
}

void CharacterCardWidget::SetOnClickCallback(std::function<void(const std::string&)> callback)
{
    m_onClickCallback = std::move(callback);
}

void CharacterCardWidget::UpdateVisuals()
{
    sf::Color tint = m_isPressed ? sf::Color(150, 150, 150) : sf::Color::White;
    
    if (m_state == CardState::Confirmed)
    {
        m_backgroundNormal.SetColor(sf::Color(220, 180, 0)); // Brighter gold background
        m_backgroundSelected.SetColor(sf::Color::White);
    }
    else
    {
        m_backgroundNormal.SetColor(tint);
        m_backgroundSelected.SetColor(tint);
    }

    if (m_state == CardState::Locked) {
        m_characterSprite.setColor(sf::Color(0, 0, 0, 255)); // Pure black silhouette
        m_weaponSprite.setColor(sf::Color(255, 255, 255, 100)); // Slightly faded weapon or transparent
        m_nameText.setFillColor(sf::Color(100, 100, 100)); // Darker name
    } else {
        m_characterSprite.setColor(tint);
        m_weaponSprite.setColor(tint);
        m_nameText.setFillColor(m_isPressed ? sf::Color(200, 200, 200) : sf::Color::White);
    }

}

void CharacterCardWidget::SetPosition(const sf::Vector2f& pos)
{
    UIElement::SetPosition(pos);
    
    m_backgroundNormal.setPosition(pos);
    
    float selOffsetX = (190.0f - m_size.x) / 2.0f;
    float selOffsetY = (190.0f - m_size.y) / 2.0f;
    m_backgroundSelected.setPosition(sf::Vector2f(pos.x - selOffsetX, pos.y - selOffsetY));

    m_nameText.setOrigin(0.0f, 0.0f);
    m_nameText.setPosition(pos.x + 10.0f, pos.y + 10.0f);

    float spacing = 15.0f;
    
    // Character at the center (slightly shifted up to accommodate name/weapon)
    sf::FloatRect charGlobal = m_characterSprite.getGlobalBounds();
    float charX = pos.x + (m_size.x - charGlobal.width) / 2.0f - 25.0f;
    float charY = pos.y + (m_size.y - charGlobal.height) / 2.0f + 25.0f;
    m_characterSprite.setPosition(charX, charY);

    // Weapon at the bottom right corner
    sf::FloatRect weaponGlobal = m_weaponSprite.getGlobalBounds();
    float weaponX = pos.x + m_size.x - weaponGlobal.width + 5.0f;
    float weaponY = pos.y + m_size.y - weaponGlobal.height + 5.0f;
    m_weaponSprite.setPosition(weaponX, weaponY);
}

void CharacterCardWidget::SetSize(const sf::Vector2f& size)
{
    UIElement::SetSize(size);
    m_backgroundNormal.SetSize(size);
    
    m_backgroundSelected.SetSize(sf::Vector2f(190.0f, 190.0f));
    m_backgroundSelected.SetCornerScale(2.0f);
    
    SetPosition(m_position);
}

bool CharacterCardWidget::Contains(const sf::Vector2f& point) const
{
    return point.x >= m_position.x && point.x <= m_position.x + m_size.x &&
           point.y >= m_position.y && point.y <= m_position.y + m_size.y;
}

void CharacterCardWidget::Update(float deltaTime)
{
    m_backgroundNormal.Update();
    m_backgroundSelected.Update();
}

void CharacterCardWidget::HandleEvent(const sf::Event& event, const sf::RenderWindow& window)
{
    if(event.type == sf::Event::MouseButtonPressed && event.mouseButton.button == sf::Mouse::Left)
    {
        sf::Vector2f worldPos = window.mapPixelToCoords(sf::Vector2i(event.mouseButton.x, event.mouseButton.y));
        if(Contains(worldPos))
        {
            m_isPressed = true;
            UpdateVisuals();
        }
    }
    else if(event.type == sf::Event::MouseButtonReleased && event.mouseButton.button == sf::Mouse::Left)
    {
        if(m_isPressed)
        {
            m_isPressed = false;
            UpdateVisuals();
            
            sf::Vector2f worldPos = window.mapPixelToCoords(sf::Vector2i(event.mouseButton.x, event.mouseButton.y));
            if(Contains(worldPos))
            {
                if(m_onClickCallback)
                {
                    m_onClickCallback(m_characterId);
                }
            }
        }
    }
}

void CharacterCardWidget::Draw(sf::RenderTarget& target)
{
    target.draw(m_backgroundNormal);

    if(m_state == CardState::Selected || m_state == CardState::Confirmed)
    {
        target.draw(m_backgroundSelected);
    }

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
