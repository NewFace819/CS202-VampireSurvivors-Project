#include "StatsPanel.h"
#include "../../Core/Data/CharacterProfile.h"
#include <SFML/Graphics/RenderTarget.hpp>
#include <sstream>
#include <iomanip>
#include <iostream>
#include <cmath>
#include "../../Core/Data/PlayerProgressionManager.h"
#include "../../Core/Data/PowerUpDataManager.h"
#include "Core/Resources/TextureAtlas.h"

static sf::Font s_boldFont;
static bool s_boldFontLoaded = false;

StatsPanel::StatsPanel(TextureAtlas& atlas, const sf::Font& font, TextureAtlas* itemsAtlas)
    : UIPanel(atlas, "frame1_c2", 10, 10, 10, 10)
    , m_font(font)
    , m_itemsAtlas(itemsAtlas)
{
    m_statKeys = {
        "maxHp",
        "regen",
        "armor",
        "moveSpeed",
        "power",
        "speed",
        "duration",
        "area",
        "cooldown",
        "amount",
        "revivals",
        "magnet",
        "luck",
        "growth",
        "greed",
        "curse",
        "rerolls",
        "skips",
        "banish"
    };

    if(!s_boldFontLoaded)
    {
        if(s_boldFont.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf"))
        {
            s_boldFontLoaded = true;
        }
        else
        {
            std::cerr << "Failed to load bold font for StatsPanel." << std::endl;
            s_boldFont = m_font; // fallback
            s_boldFontLoaded = true;
        }
    }

    for(const std::string& key : m_statKeys)
    {
        StatRow row;
        row.key = key;

        row.labelText.setFont(s_boldFont);
        row.labelText.setCharacterSize(TEXT_SIZE);
        row.labelText.setString(FormatLabelName(key));
        row.labelText.setFillColor(sf::Color(220, 220, 220));

        row.valueText.setCharacterSize(TEXT_SIZE);
        row.valueText.setString("-");
        row.valueText.setFillColor(sf::Color::White);
        row.valueText.setFont(s_boldFont);

        row.buffText.setCharacterSize(TEXT_SIZE);
        row.buffText.setString("");
        row.buffText.setFillColor(sf::Color(255, 215, 0)); // Gold color
        row.buffText.setFont(s_boldFont);

        m_rows.push_back(row);
    }

    UIPanel::SetCornerScale(1.3f);
}

std::string StatsPanel::GetStatIconFrame(const std::string& key)
{
    // Maps stat key → items_atlas frame name (from POWERUP_DATA.json frameName)
    if (key == "maxHp")    return "HeartBlack";
    if (key == "regen")    return "HeartRuby";
    if (key == "armor")    return "ArmorIron";
    if (key == "moveSpeed")return "Wing";
    if (key == "power")    return "Leaf";
    if (key == "speed")    return "Gauntlet";
    if (key == "duration") return "EmblemEye";
    if (key == "area")     return "Candelabra";
    if (key == "cooldown") return "Book2";
    if (key == "amount")   return "Ring";
    if (key == "revivals") return "Tiramisu";
    if (key == "magnet")   return "OrbGlow";
    if (key == "luck")     return "Clover";
    if (key == "growth")   return "Crown";
    if (key == "greed")    return "Mask";
    if (key == "curse")    return "Curse";
    if (key == "rerolls")  return "Dice";
    if (key == "skips")    return "Skip";
    if (key == "banish")   return "Banish";
    return "";
}


std::string StatsPanel::FormatLabelName(const std::string& key) const
{
    if(key == "maxHp") return "Max Health";
    if(key == "moveSpeed") return "Move Speed";
    if(key == "regen") return "Recovery";
    if(key == "power") return "Might";
    if(key == "speed") return "Speed";
    if(key == "duration") return "Duration";
    if(key == "area") return "Area";
    if(key == "cooldown") return "Cooldown";
    if(key == "amount") return "Amount";
    if(key == "revivals") return "Revival";
    if(key == "magnet") return "Magnet";
    if(key == "luck") return "Luck";
    if(key == "growth") return "Growth";
    if(key == "greed") return "Greed";
    if(key == "curse") return "Curse";
    if(key == "rerolls") return "Reroll";
    if(key == "skips") return "Skip";
    if(key == "banish") return "Banish";
    if(key == "armor") return "Armor";
    return key;
}

void StatsPanel::SetCharacterProfile(const CharacterProfile& profile, const PlayerProgressionManager* progressionManager, const PowerUpDataManager* powerUpManager)
{
    for(StatRow& row : m_rows)
    {
        float value = profile.GetStat(row.key);
        float buff = 0.0f;
        
        if (progressionManager && powerUpManager)
        {
            buff = progressionManager->GetGlobalStatBuff(row.key, *powerUpManager);
        }
        
        FormatStatText(row, value, buff);

        // Set icon sprite
        if (m_itemsAtlas) {
            std::string iconFrame = GetStatIconFrame(row.key);
            if (!iconFrame.empty()) {
                row.iconSprite = m_itemsAtlas->CreateSprite(iconFrame);
                sf::FloatRect ib = row.iconSprite.getLocalBounds();
                if (ib.width > 0 && ib.height > 0) {
                    float s = ICON_SIZE / std::max(ib.width, ib.height);
                    row.iconSprite.setScale(s, s);
                }
            }
        }
    }
    
    // Re-align right bounds since text width changed
    SetPosition(m_position);
}

void StatsPanel::FormatStatText(StatRow& row, float value, float buff) const
{
    if(value == 0.0f)
    {
        row.valueText.setString("-");
        row.valueText.setFillColor(sf::Color(160, 160, 160));
        return;
    }

    row.valueText.setFillColor(sf::Color(255, 215, 0)); // Gold for non-zero

    std::ostringstream oss;
    
    if(row.key == "speed" || row.key == "power" || row.key == "duration" || row.key == "area" || row.key == "cooldown" || row.key == "luck" || row.key == "growth" || row.key == "greed" || row.key == "curse")
    {
        // Many multipliers start at 1.0 (meaning 0% bonus), we subtract 1.0f to get the % difference
        float diff = value - 1.0f;
        if(std::abs(diff) < 0.001f) // Effectively 0
        {
            row.valueText.setString("-");
            return;
        }

        if(diff > 0.0f)
        {
            oss << "+";
        }
        oss << static_cast<int>(diff * 100.0f) << "%";
    }
    else if(row.key == "amount" || row.key == "revivals" || row.key == "rerolls" || row.key == "skips" || row.key == "banish" || row.key == "armor" || row.key == "magnet")
    {
        if(value > 0.0f)
        {
            oss << "+";
        }
        oss << static_cast<int>(value);
    }
    else
    {
        oss << static_cast<int>(value);
    }

    row.valueText.setString(oss.str());

    if (std::abs(buff) > 0.001f)
    {
        std::ostringstream buffOss;
        if(row.key == "speed" || row.key == "power" || row.key == "duration" || row.key == "area" || row.key == "cooldown" || row.key == "luck" || row.key == "growth" || row.key == "greed" || row.key == "curse" || row.key == "defang" || row.key == "recycle")
        {
            if (buff > 0.0f) buffOss << "+";
            buffOss << static_cast<int>(buff * 100.0f) << "%";
        }
        else
        {
            if (buff > 0.0f) buffOss << "+";
            buffOss << static_cast<int>(buff);
        }
        row.buffText.setString(buffOss.str());
    }
    else
    {
        row.buffText.setString("");
    }
}

void StatsPanel::SetPosition(const sf::Vector2f& pos)
{
    UIPanel::SetPosition(pos);
    
    float currentY = pos.y + START_Y_OFFSET;
    // icon occupies PADDING_X .. PADDING_X+ICON_SIZE, then a gap, then label
    float labelX = pos.x + PADDING_X + ICON_SIZE + ICON_LABEL_GAP;
    
    for(StatRow& row : m_rows)
    {
        // Icon: vertically centered in row
        sf::FloatRect ib = row.iconSprite.getLocalBounds();
        float iconH = ib.height * row.iconSprite.getScale().y;
        row.iconSprite.setPosition(pos.x + PADDING_X, START_Y_OFFSET + currentY + (ROW_PADDING - iconH) * 0.5f - 5.0f);

        row.labelText.setPosition(labelX, currentY);
        
        sf::FloatRect valBounds = row.valueText.getLocalBounds();
        sf::FloatRect buffBounds = row.buffText.getLocalBounds();
        
        float buffWidth = row.buffText.getString().isEmpty() ? 0.0f : buffBounds.width;
        float spacing = buffWidth > 0.0f ? 8.0f : 0.0f;
        
        float totalWidth = valBounds.width + spacing + buffWidth;
        float startX = pos.x + m_size.x - PADDING_X - totalWidth;
        
        row.valueText.setPosition(startX, currentY);
        row.buffText.setPosition(startX + valBounds.width + spacing, currentY);
        
        currentY += ROW_PADDING;
        
        if(row.key == "moveSpeed" || row.key == "area" || row.key == "magnet" || row.key == "curse")
        {
            currentY += ROW_PADDING * 0.75f; // Add a small visual gap for groupings
        }
    }
}

void StatsPanel::SetSize(const sf::Vector2f& size)
{
    UIPanel::SetSize(size);
    SetPosition(m_position);
}

void StatsPanel::Update(float deltaTime)
{
    UIPanel::Update(deltaTime);
}

void StatsPanel::HandleEvent(const sf::Event& event, const sf::RenderWindow& window)
{
}

void StatsPanel::Draw(sf::RenderTarget& target)
{
    UIPanel::Draw(target);

    for(const StatRow& row : m_rows)
    {
        // Draw icon if available
        sf::FloatRect ib = row.iconSprite.getLocalBounds();
        if (ib.width > 0)
            target.draw(row.iconSprite);

        target.draw(row.labelText);
        target.draw(row.valueText);
        if (!row.buffText.getString().isEmpty())
        {
            target.draw(row.buffText);
        }
    }
}
