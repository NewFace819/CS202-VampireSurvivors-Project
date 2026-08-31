#include "DetailPanel.h"
#include "../../Core/Data/CharacterProfile.h"
#include "../../Core/Data/WeaponDataManager.h"
#include "Core/Resources/TextureAtlas.h"
#include "../Core/TextUtility.h"
#include <SFML/Graphics/RenderTarget.hpp>
#include <SFML/Window/Event.hpp>
#include <SFML/Graphics/RenderWindow.hpp>
#include <nlohmann/json.hpp>
#include <fstream>
#include <algorithm>
#include <cctype>
#include <cmath>

DetailPanel::DetailPanel(TextureAtlas& atlas, const sf::Font& font, const sf::Font* boldFont, TextureAtlas* itemsAtlas)
    : UIPanel(atlas, "frame1_c2", 12, 12, 12, 12)
    , m_atlas(atlas)
    , m_itemsAtlas(itemsAtlas)
    , m_hasProfile(false)
{
    UIPanel::SetCornerScale(2.0f);

    const sf::Font& textFont = boldFont ? *boldFont : font;

    m_nameText.setFont(textFont);
    m_nameText.setCharacterSize(24);
    m_nameText.setFillColor(sf::Color::White);

    m_descriptionText.setFont(textFont);
    m_descriptionText.setCharacterSize(20);
    m_descriptionText.setFillColor(sf::Color(200, 200, 240));

    // Create weapon background using NineSliceComponent
    m_weaponBgSprite.SetTexture(m_atlas, "frameB10");
    m_weaponBgSprite.SetMargins(12.0f, 12.0f, 12.0f, 12.0f);
    m_weaponBgSprite.SetCornerScale(2.5f);
    m_weaponBgSprite.SetSize(sf::Vector2f(80.0f, 80.0f));
}

void DetailPanel::SetCharacterProfile(const CharacterProfile& profile, const WeaponDataManager* weaponManager, bool isUnlocked)
{
    m_hasProfile = true;

    m_nameText.setString(profile.GetName());
    m_rawDescription = profile.GetDescription();
    m_descriptionText.setString(m_rawDescription);

    // ── Rebuild character sprite using the exact same logic as CharacterCardWidget ──
    std::string spriteName = profile.GetSpriteName();
    std::string frameKey   = spriteName;
    if (frameKey.size() > 4 && frameKey.substr(frameKey.size()-4) == ".png")
        frameKey = frameKey.substr(0, frameKey.size()-4);

    std::string texId = profile.GetTextureName();
    if (texId.empty()) {
        texId = profile.GetId();
        std::transform(texId.begin(), texId.end(), texId.begin(),
            [](unsigned char c){ return std::tolower(c); });
    }
    std::string texPath   = "assets/Graphics/Characters/character_" + texId + ".png";
    std::string atlasPath = "assets/data/CharacterAtlas/character_" + texId + "_atlas.json";

    m_characterSprite = sf::Sprite(); // reset
    if (m_charTexture.loadFromFile(texPath)) {
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
                        bestRect.width  = it->value("width",  32);
                        bestRect.height = it->value("height", 32);
                        return true;
                    }
                    return false;
                };

                // Same priority as CharacterCardWidget: prefer non-"new" skin
                std::string baseKey = frameKey;
                std::string newKey  = frameKey;
                if (frameKey.size() > 3 &&
                    (frameKey.substr(0,3) == "new" || frameKey.substr(0,3) == "New")) {
                    baseKey = frameKey.substr(3);
                } else {
                    newKey = "new" + frameKey;
                }

                std::string charName = profile.GetName();
                size_t sp = charName.find(' ');
                if (sp != std::string::npos) charName = charName.substr(0, sp);

                if (tryFrame(baseKey) || tryFrame(frameKey) ||
                    tryFrame(newKey)  || tryFrame(charName + "_01")) {
                    // Apply Y-axis inversion (same as CharacterCardWidget)
                    int y_sfml = static_cast<int>(m_charTexture.getSize().y)
                                 - bestRect.top - bestRect.height;
                    bestRect.top = y_sfml;
                    found = true;
                }
            } catch (...) {}
        }

        m_characterSprite.setTexture(m_charTexture);
        m_characterSprite.setTextureRect(found ? bestRect
                                               : sf::IntRect(0, 0, 32, 32));

        // Scale to 92×92 (same as CharacterCardWidget)
        sf::FloatRect b = m_characterSprite.getLocalBounds();
        if (b.width > 0 && b.height > 0) {
            m_characterSprite.setScale(92.0f / b.width, 92.0f / b.height);
        }
    } else {
        // Fallback: portrait from UI atlas
        m_characterSprite = m_atlas.CreateSprite(profile.GetPortraitTextureId());
        sf::FloatRect cb = m_characterSprite.getLocalBounds();
        if (cb.width > 0 && cb.height > 0)
            m_characterSprite.setScale(92.0f / cb.width, 92.0f / cb.height);
    }


    // Helper: strip .png extension for atlas frame lookup
    auto stripPng = [](const std::string& name) -> std::string {
        if (name.size() > 4 && name.substr(name.size()-4) == ".png")
            return name.substr(0, name.size()-4);
        return name;
    };

    // Update weapon sprite
    if (weaponManager)
    {
        const WeaponProfile& wp = weaponManager->GetWeaponById(profile.GetStartingWeaponId());
        std::string weaponFrame = wp.GetFrameName();
        std::string frameKey = stripPng(weaponFrame.empty() ? profile.GetStartingWeaponId() : weaponFrame);

        if (m_itemsAtlas) {
            m_weaponSprite = m_itemsAtlas->CreateSprite(frameKey);
            if (m_weaponSprite.getLocalBounds().width == 0)
                m_weaponSprite = m_atlas.CreateSprite(frameKey);
        } else {
            m_weaponSprite = m_atlas.CreateSprite(frameKey);
        }
    }
    else
    {
        m_weaponSprite = m_atlas.CreateSprite(profile.GetStartingWeaponId());
    }

    sf::FloatRect weaponBounds = m_weaponSprite.getLocalBounds();
    if(weaponBounds.width > 0 && weaponBounds.height > 0)
    {
        float scale = std::min(56.0f / weaponBounds.width, 56.0f / weaponBounds.height);
        m_weaponSprite.setScale(scale, scale);
    }

    if (!isUnlocked) {
        m_characterSprite.setColor(sf::Color(0, 0, 0, 255));
        // m_weaponSprite.setColor(sf::Color(0, 0, 0, 255));
        m_nameText.setFillColor(sf::Color(100, 100, 100));
    } else {
        m_characterSprite.setColor(sf::Color::White);
        m_weaponSprite.setColor(sf::Color::White);
        m_nameText.setFillColor(sf::Color::White);
    }

    // Re-layout immediately in case lengths changed
    SetPosition(m_position);
}


void DetailPanel::SetPosition(const sf::Vector2f& pos)
{
    UIPanel::SetPosition(pos);

    m_nameText.setPosition(pos.x + TEXT_PADDING_X, pos.y + TEXT_PADDING_Y);

    float currentY = pos.y + TEXT_PADDING_Y + 20.0f + SPACE_BETWEEN_ELEMENTS;

    // Character sprite on the left
    m_characterSprite.setPosition(pos.x + TEXT_PADDING_X, currentY);

    float characterRightX = pos.x + TEXT_PADDING_X + 92.0f; // character sprite size is 92

    // Weapon background right of character
    float weaponBgX = characterRightX + SPACE_BETWEEN_ELEMENTS;
    m_weaponBgSprite.setPosition(weaponBgX, currentY + 10.0f);

    // Weapon sprite centered on background
    sf::FloatRect weaponGlobal = m_weaponSprite.getGlobalBounds();
    float weaponX = weaponBgX + (80.0f - weaponGlobal.width) / 2.0f + 28.0f; 
    float weaponY = currentY + 10.0f + (80.0f - weaponGlobal.height) / 2.0f + 28.0f;
    m_weaponSprite.setPosition(weaponX, weaponY);

    // Description text right of panel (or right of weapon bg)
    float descX = weaponBgX + 80.0f + SPACE_BETWEEN_ELEMENTS;
    m_descriptionText.setPosition(descX, currentY);

    // Wrap text based on remaining width
    float maxWidth = m_size.x - (descX - pos.x) - TEXT_PADDING_X;
    if(maxWidth > 50.0f)
    {
        m_descriptionText.setString(m_rawDescription); // Reset to raw before wrapping
        UI::TextUtility::WrapText(m_descriptionText, maxWidth);
    }
}

void DetailPanel::SetSize(const sf::Vector2f& size)
{
    UIPanel::SetSize(size);
    SetPosition(m_position);
}

void DetailPanel::Update(float deltaTime)
{
    UIPanel::Update(deltaTime);
    m_weaponBgSprite.Update();
}

void DetailPanel::HandleEvent(const sf::Event& event, const sf::RenderWindow& window)
{
    UIPanel::HandleEvent(event, window);
}

void DetailPanel::Draw(sf::RenderTarget& target)
{
    UIPanel::Draw(target);

    if(m_hasProfile)
    {
        target.draw(m_nameText);
        target.draw(m_characterSprite);
        target.draw(m_weaponBgSprite);
        target.draw(m_weaponSprite);
        target.draw(m_descriptionText);
    }
}

void DetailPanel::SetTint(sf::Color color)
{
    UIPanel::SetColor(color);
}
