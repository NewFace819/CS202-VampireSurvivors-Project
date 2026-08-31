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

    // --- Per-player health ---
    // Each player owns their health. A player at 0 HP with no revivals left is
    // set inactive ("down"); the run ends only when every player is down.
    void initHealth(float maxHealth, int revivals);
    void takeDamage(float amount);
    void heal(float amount);
    void setMaxHealth(float maxHealth);      // rescales current HP proportionally
    float getHealth() const { return m_health; }
    float getMaxHealth() const { return m_maxHealth; }
    bool isDown() const { return m_health <= 0.f; }
    int  getRevivalsLeft() const { return m_revivalsLeft; }
    void addRevival(int n) { m_revivalsLeft += n; }
    bool tryRevive();                        // consumes a revival, restores 50% HP

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
    float m_health = 100.f;
    float m_maxHealth = 100.f;
    int   m_revivalsLeft = 0;
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

