#pragma once
#include "Entity.h"
#include "Core/Animation/AnimatedSprite.h"
#include <string>
#include <vector>
#include <SFML/Graphics.hpp>

class Player : public Entity {
public:
    Player();
    
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    sf::FloatRect getBounds() const override;
    sf::Vector2f getFacingDir() const { return m_facingDir; }
    void setSprite(const std::string& texturePath,
                   const std::vector<sf::IntRect>& walkFrames);

    void setPlayerId(int id) { m_playerId = id; }
    int getPlayerId() const { return m_playerId; }

    // Per-run passive item bonuses, refreshed each frame by PlayingState.
    // Shop power-ups stay in ProfileManager; these layer on top.
    void setPassiveMoveSpeedMult(float m) { m_passiveMoveSpeedMult = m; }
    void setPassiveMagnetBonus(float b)   { m_passiveMagnetBonus = b; }
    void setPassiveArmor(float a)         { m_passiveArmor = a; }
    float getPassiveMagnetBonus() const   { return m_passiveMagnetBonus; }
    float getPassiveArmor() const         { return m_passiveArmor; }

    int getLevel() const { return m_level; }
    float getExp() const { return m_exp; }
    float getExpToNextLevel() const { return m_expToNext; }
    void addExp(float amount);
    bool checkLevelUp();

private:
    int m_playerId = 1;
    float m_passiveMoveSpeedMult = 1.f;
    float m_passiveMagnetBonus = 0.f;
    float m_passiveArmor = 0.f;
    int m_level = 1;
    float m_exp = 0.f;
    float m_expToNext = 5.f;
    sf::Texture m_texture;
    AnimatedSprite m_animSprite;
    sf::Vector2f m_facingDir;
    bool m_hasSprite = false;
    bool m_isMoving = false;
    std::vector<sf::IntRect> m_walkFrames;

    // Fallback rectangle for when no sprite is set
    sf::RectangleShape m_fallbackShape;
    sf::Font m_badgeFont;
    bool m_hasFont = false;
};

