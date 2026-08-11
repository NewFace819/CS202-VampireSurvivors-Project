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

private:
    int m_playerId = 1;
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

