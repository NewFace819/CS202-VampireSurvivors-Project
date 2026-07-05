#pragma once
#include "Entity.h"
#include <cmath>

class EnemyBase : public Entity {
public:
    EnemyBase();
    virtual ~EnemyBase() = default;

    // Resets the enemy state for Object Pooling
    virtual void init(const sf::Vector2f& startPos, float hp, float speed, float radius = 20.f, sf::Color color = sf::Color::White, sf::Texture* texture = nullptr, const std::vector<sf::IntRect>& movingRects = {}, const std::vector<sf::IntRect>& deathRects = {});

    float getRadius() const { return m_shape.getRadius(); }

    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;

    sf::FloatRect getBounds() const override;

    void setTarget(Entity* target) { m_target = target; }
    void takeDamage(float amount);

    bool isDead() const { return !m_isActive; }

protected:
    float m_hp;
    float m_maxHp;
    Entity* m_target; // Usually the player
    
    // For rendering we can just use a simple circle shape for now
    sf::CircleShape m_shape;
    
    // Sprite and animation
    sf::Texture* m_texture;
    std::vector<sf::IntRect> m_movingRects;
    std::vector<sf::IntRect> m_deathRects;
    sf::Sprite m_sprite;
    float m_animTimer;
    int m_currentFrame;
    bool m_isDying;
};
