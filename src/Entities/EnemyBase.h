#pragma once
#include "Entity.h"
#include "EnemyDatabase.h"
#include <cmath>

class EnemyBase : public Entity {
public:
    EnemyBase();
    virtual ~EnemyBase() = default;

    // Resets the enemy state for Object Pooling
    virtual void init(const sf::Vector2f& startPos, const EnemyStats& stats, sf::Texture* texture = nullptr);

    float getRadius() const { return m_shape.getRadius(); }

    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;

    sf::FloatRect getBounds() const override;

    void setTarget(Entity* target) { m_target = target; }
    bool takeDamage(float amount); // returns true if killed
    void applyKnockback(const sf::Vector2f& dir, float weaponKnockback);

    bool isDead() const { return !m_isActive; }

    float getDamage() const { return m_stats.damage; }
    const EnemyStats& getStats() const { return m_stats; }

protected:
    sf::Shader* getDamageShader();

    EnemyStats m_stats;
    Entity* m_target; // Usually the player
    
    // Knockback state
    float m_knockbackTimer = 0.f;
    sf::Vector2f m_knockbackDir;
    float m_knockbackSpeed = 0.f;
    
    // Damage visual feedback
    float m_damageFlashTimer = 0.f;
    
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
