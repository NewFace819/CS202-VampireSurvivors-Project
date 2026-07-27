#pragma once

#include "UIPanel.h"
#include "../Components/NineSliceComponent.h"
#include <SFML/Graphics/Text.hpp>
#include <SFML/Graphics/Sprite.hpp>
#include <SFML/Graphics/Texture.hpp>
#include <string>

// Forward declarations
class TextureAtlas;
class CharacterProfile;
class WeaponDataManager;
namespace sf { class Font; class RenderTarget; class Event; class RenderWindow; }

class DetailPanel : public UIPanel
{
private:
    TextureAtlas& m_atlas;
    TextureAtlas* m_itemsAtlas = nullptr;
    
    sf::Text     m_nameText;
    sf::Text     m_descriptionText;
    sf::Sprite   m_weaponSprite;
    sf::Sprite   m_characterSprite;
    sf::Texture  m_charTexture;       // owns the character PNG texture
    NineSliceComponent m_weaponBgSprite;
    
    std::string m_rawDescription;
    bool m_hasProfile;

    static constexpr float TEXT_PADDING_X = 20.0f;
    static constexpr float TEXT_PADDING_Y = 10.0f;
    static constexpr float SPACE_BETWEEN_ELEMENTS = 15.0f;
    static constexpr float WEAPON_OFFSET_Y = 50.0f;

public:
    DetailPanel(TextureAtlas& atlas, const sf::Font& font, const sf::Font* boldFont = nullptr, TextureAtlas* itemsAtlas = nullptr);
    ~DetailPanel() override = default;

    void SetCharacterProfile(const CharacterProfile& profile, const WeaponDataManager* weaponManager = nullptr, bool isUnlocked = true);

    void Update(float deltaTime) override;
    void HandleEvent(const sf::Event& event, const sf::RenderWindow& window) override;
    void Draw(sf::RenderTarget& target) override;

    void SetPosition(const sf::Vector2f& pos) override;
    void SetSize(const sf::Vector2f& size) override;
    void SetTint(sf::Color color);
};
