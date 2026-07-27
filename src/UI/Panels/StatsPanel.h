#pragma once

#include "UIPanel.h"
#include <vector>
#include <string>
#include <SFML/Graphics/Text.hpp>
#include <SFML/Graphics/Sprite.hpp>

// Forward declarations
class TextureAtlas;
class CharacterProfile;
namespace sf { class Font; class RenderTarget; class Event; class RenderWindow; }

class StatsPanel : public UIPanel
{
private:
    struct StatRow
    {
        sf::Text labelText;
        sf::Text valueText;
        sf::Text buffText;
        sf::Sprite iconSprite;
        std::string key;
    };

    std::vector<StatRow> m_rows;
    std::vector<std::string> m_statKeys;
    const sf::Font& m_font;
    TextureAtlas* m_itemsAtlas = nullptr;  // items_atlas for stat icons

    static constexpr float ICON_SIZE   = 22.0f;  // icon display size in pixels
    static constexpr float ICON_LABEL_GAP = 4.0f;

    static constexpr float ROW_PADDING = 27.0f;
    static constexpr unsigned int TEXT_SIZE = 20;
    static constexpr float START_Y_OFFSET = 20.0f;
    static constexpr float PADDING_X = 20.0f;

    void FormatStatText(StatRow& row, float value, float buff) const;
    std::string FormatLabelName(const std::string& key) const;
    static std::string GetStatIconFrame(const std::string& statKey);

public:
    StatsPanel(TextureAtlas& atlas, const sf::Font& font, TextureAtlas* itemsAtlas = nullptr);
    ~StatsPanel() override = default;

    void SetCharacterProfile(const CharacterProfile& profile, const class PlayerProgressionManager* progressionManager = nullptr, const class PowerUpDataManager* powerUpManager = nullptr);

    void Update(float deltaTime) override;
    void HandleEvent(const sf::Event& event, const sf::RenderWindow& window) override;
    void Draw(sf::RenderTarget& target) override;

    void SetPosition(const sf::Vector2f& pos) override;
    void SetSize(const sf::Vector2f& size) override;
};
