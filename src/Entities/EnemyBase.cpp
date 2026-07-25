#include "EnemyBase.h"
#include <cmath>
EnemyBase::EnemyBase()
    : m_target(nullptr) {
    m_shape.setRadius(20.f);
    m_shape.setFillColor(sf::Color::Red);
    m_shape.setOrigin(20.f, 20.f);
}

void EnemyBase::init(const sf::Vector2f& startPos, const EnemyStats& stats, sf::Texture* texture) {
    m_position = startPos;
    m_stats = stats;
    
    m_shape.setRadius(m_stats.collisionRadius);
    m_shape.setOrigin(m_stats.collisionRadius, m_stats.collisionRadius);
    m_shape.setPosition(m_position);
    m_shape.setFillColor(m_stats.color);
    
    m_isActive = true;
    m_isDying = false;
    m_damageFlashTimer = 0.f;
    m_knockbackTimer = 0.f;
    m_knockbackDir = sf::Vector2f(0.f, 0.f);
    m_knockbackSpeed = 0.f;
    m_shootCooldown = 2.0f;
    m_shootTimer = 1.0f + static_cast<float>(std::rand() % 100) / 100.f;

    m_texture = texture;
    m_movingRects = m_stats.movingRects;
    m_deathRects = m_stats.deathRects;
    m_animTimer = 0.f;
    m_currentFrame = 0;
    
    if (m_texture) {
        m_sprite.setTexture(*m_texture, true);
        if (!m_movingRects.empty()) {
            m_sprite.setTextureRect(m_movingRects[0]);
            m_sprite.setOrigin(m_movingRects[0].width / 2.f, m_movingRects[0].height / 2.f);
        } else {
            m_sprite.setOrigin(m_texture->getSize().x / 2.f, m_texture->getSize().y / 2.f);
        }
        m_sprite.setPosition(m_position);
        
        // Use color parameter to tint the sprite, allowing easy palette swaps
        m_sprite.setColor(m_stats.color);
    }
}

void EnemyBase::applyKnockback(const sf::Vector2f& dir, float weaponKnockback) {
    if (weaponKnockback <= 0.0f) return;
    
    // Formula: Distance = Knockback * Knockback_Taken * Movement_Speed
    float knockbackTaken = 1.0f; // Could be modified by items later
    float distance = weaponKnockback * knockbackTaken * m_stats.speed;
    
    // Lasts for 120 milliseconds
    m_knockbackTimer = 0.12f;
    m_knockbackDir = dir;
    m_knockbackSpeed = distance / m_knockbackTimer;
}

void EnemyBase::update(float dt) {
    if (!m_isActive) return;

    // Handle dying animation separately
    if (m_isDying) {
        if (m_texture && !m_deathRects.empty()) {
            m_animTimer += dt;
            if (m_animTimer >= 0.04f) {
                m_animTimer = 0.f;
                m_currentFrame++;
                if (m_currentFrame < m_deathRects.size()) {
                    m_sprite.setTextureRect(m_deathRects[m_currentFrame]);
                    m_sprite.setOrigin(m_deathRects[m_currentFrame].width / 2.f, m_deathRects[m_currentFrame].height / 2.f);
                } else {
                    m_isActive = false; // Finished dying
                }
            }
        } else {
            m_isActive = false;
        }
        return;
    }

    if (!m_target) return;

    sf::Vector2f targetPos = m_target->getPosition();
    sf::Vector2f moveDir = targetPos - m_position;
    
    // Normalize direction
    float length = std::sqrt(moveDir.x * moveDir.x + moveDir.y * moveDir.y);
    if (length > 0) {
        moveDir /= length;
    }

    // Process knockback state
    if (m_knockbackTimer > 0.f) {
        m_knockbackTimer -= dt;
        m_position += m_knockbackDir * m_knockbackSpeed * dt;
    } else {
        // Use enemy's specific speed
        float moveDist = m_stats.speed * dt;
        m_position += moveDir * moveDist;
    }

    m_shape.setPosition(m_position);
    
    if (m_texture) {
        m_sprite.setPosition(m_position);
        
        // Handle flipping logic based on movement direction
        bool faceLeft = (moveDir.x < 0);
        float scaleX = 1.f;
        if (m_stats.facesLeftByDefault) {
            scaleX = faceLeft ? 1.f : -1.f;
        } else {
            scaleX = faceLeft ? -1.f : 1.f;
        }
        m_sprite.setScale(scaleX, 1.f);
        
        // Update animation
        if (!m_movingRects.empty()) {
            m_animTimer += dt;
            if (m_animTimer >= 0.15f) {
                m_animTimer = 0.f;
                m_currentFrame = (m_currentFrame + 1) % m_movingRects.size();
                m_sprite.setTextureRect(m_movingRects[m_currentFrame]);
                m_sprite.setOrigin(m_movingRects[m_currentFrame].width / 2.f, m_movingRects[m_currentFrame].height / 2.f);
            }
        }
    }
    
    if (m_damageFlashTimer > 0.f) {
        m_damageFlashTimer -= dt;
    }
}

void EnemyBase::draw(sf::RenderWindow& window) {
    if (m_isActive) {
        if (m_texture) {
            if (m_damageFlashTimer > 0.f) {
                sf::Shader* shader = getDamageShader();
                if (shader) {
                    shader->setUniform("texture", sf::Shader::CurrentTexture);
                    shader->setUniform("flashAmount", std::min(1.f, m_damageFlashTimer / 0.1f));
                    window.draw(m_sprite, shader);
                } else {
                    // Fallback to additive blend if shader fails
                    m_sprite.setColor(sf::Color(255, 255, 255, 255));
                    window.draw(m_sprite, sf::BlendAdd);
                    m_sprite.setColor(m_stats.color);
                }
            } else {
                window.draw(m_sprite);
            }
        } else {
            window.draw(m_shape);
        }
    }
}

sf::FloatRect EnemyBase::getBounds() const {
    return m_shape.getGlobalBounds();
}

bool EnemyBase::takeDamage(float amount) {
    if (m_isDying || !m_isActive) return false;

    m_stats.hp -= amount;
    m_damageFlashTimer = 0.1f; // Flash white for 0.1s
    if (m_stats.hp <= 0) {
        m_stats.hp = 0;
        m_isDying = true;
        m_animTimer = 0.f;
        m_currentFrame = 0;
        
        // Remove knockback on death so they don't slide while playing death animation
        m_knockbackTimer = 0.f;
        
        if (!m_deathRects.empty()) {
            m_sprite.setTextureRect(m_deathRects[0]);
            m_sprite.setOrigin(m_deathRects[0].width / 2.f, m_deathRects[0].height / 2.f);
        } else {
            m_isActive = false;
        }
        return true;
    }
    return false;
}

sf::Shader* EnemyBase::getDamageShader() {
    static sf::Shader shader;
    static bool loaded = false;
    static bool available = sf::Shader::isAvailable();
    
    if (!available) return nullptr;
    
    if (!loaded) {
        const std::string fragShader = R"(
            uniform sampler2D texture;
            uniform float flashAmount;
            void main() {
                vec4 pixel = texture2D(texture, gl_TexCoord[0].xy);
                gl_FragColor = vec4(mix(pixel.rgb, vec3(1.0, 1.0, 1.0), flashAmount), pixel.a) * gl_Color;
            }
        )";
        shader.loadFromMemory(fragShader, sf::Shader::Fragment);
        loaded = true;
    }
    return &shader;
}

void EnemyBase::updateShooting(float dt, const sf::Vector2f& playerPos, std::vector<Projectile>& bossProjectiles, sf::Texture* vfxTexture) {
    if (!m_isActive || m_isDying || m_stats.enemyClass != EnemyClass::BOSS) return;

    m_shootTimer -= dt;
    if (m_shootTimer <= 0.f) {
        m_shootTimer = m_shootCooldown;

        // Calculate direction towards player
        sf::Vector2f diff = playerPos - m_position;
        float length = std::sqrt(diff.x * diff.x + diff.y * diff.y);
        if (length > 0) {
            sf::Vector2f dir = diff / length;

            Projectile p;
            // Fired directly at player, doing boss contact damage as projectile damage
            p.init(m_position, dir, m_stats.damage, 150.f, 800.f, 5.0f, false);
            
            if (vfxTexture) {
                // Use Magic Wand glowing orb frame but tinted red
                sf::IntRect orbFrame(256, 798, 64, 64);
                p.setSprite(*vfxTexture, orbFrame, 0.4f, true, sf::Color(255, 60, 60));
                p.enableTrail(0.04f, 0.2f, sf::Color(255, 100, 100));
            }
            bossProjectiles.push_back(p);
        }
    }
}
