#pragma once
#include <SFML/Graphics.hpp>
#include <vector>
#include <string>

// Holds a list of IntRects (frames) and cycles through them at a fixed FPS
class AnimatedSprite {
public:
    AnimatedSprite() = default;

    void setTexture(const sf::Texture& tex) {
        m_sprite.setTexture(tex);
    }

    void setFrames(const std::vector<sf::IntRect>& frames, float fps = 8.f) {
        m_frames = frames;
        m_fps = fps;
        m_timer = 0.f;
        m_currentFrame = 0;
        if (!m_frames.empty())
            m_sprite.setTextureRect(m_frames[0]);
    }

    void setAutoCenter(bool autoCenter) { m_autoCenter = autoCenter; }

    void setOrigin(float x, float y) { m_sprite.setOrigin(x, y); }
    void setScale(float x, float y) { m_sprite.setScale(x, y); }
    void setRotation(float angle) { m_sprite.setRotation(angle); }
    void setPosition(const sf::Vector2f& pos) { m_sprite.setPosition(pos); }
    void setColor(const sf::Color& color) { m_sprite.setColor(color); }

    void pause()  { m_paused = true; }
    void resume() { m_paused = false; }

    void update(float dt) {
        if (m_frames.empty() || m_paused) return;
        m_timer += dt;
        if (m_timer >= 1.f / m_fps) {
            m_timer -= 1.f / m_fps; // Keep remainder for smoother animation
            m_currentFrame = (m_currentFrame + 1) % m_frames.size();
            m_sprite.setTextureRect(m_frames[m_currentFrame]);
            if (m_autoCenter) {
                m_sprite.setOrigin(m_frames[m_currentFrame].width / 2.f, m_frames[m_currentFrame].height / 2.f);
            }
        }
    }

    void draw(sf::RenderWindow& window) const {
        window.draw(m_sprite);
    }

    sf::FloatRect getGlobalBounds() const { return m_sprite.getGlobalBounds(); }

private:
    sf::Sprite m_sprite;
    std::vector<sf::IntRect> m_frames;
    float m_fps = 8.f;
    float m_timer = 0.f;
    size_t m_currentFrame = 0;
    bool m_paused = false;
    bool m_autoCenter = false;
};
