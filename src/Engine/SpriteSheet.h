#pragma once
#include <SFML/Graphics.hpp>
#include <vector>

// Helper class to slice a large merged texture into smaller frames
class SpriteSheet {
public:
    // Initializes the spritesheet by defining the grid layout
    // frameWidth/frameHeight are the size of one sprite
    SpriteSheet(sf::Texture& texture, int frameWidth, int frameHeight, int margin = 0, int spacing = 0) 
        : m_texture(&texture), m_frameWidth(frameWidth), m_frameHeight(frameHeight) {
        
        int texWidth = texture.getSize().x;
        int texHeight = texture.getSize().y;

        int cols = (texWidth - margin) / (frameWidth + spacing);
        int rows = (texHeight - margin) / (frameHeight + spacing);

        for (int y = 0; y < rows; ++y) {
            for (int x = 0; x < cols; ++x) {
                sf::IntRect rect(
                    margin + x * (frameWidth + spacing),
                    margin + y * (frameHeight + spacing),
                    frameWidth,
                    frameHeight
                );
                m_frames.push_back(rect);
            }
        }
    }

    // Assigns a specific frame index to a sprite
    void applyFrame(sf::Sprite& sprite, int frameIndex) const {
        if (frameIndex >= 0 && frameIndex < m_frames.size()) {
            sprite.setTexture(*m_texture);
            sprite.setTextureRect(m_frames[frameIndex]);
        }
    }

    // Retrieves a specific frame's IntRect
    sf::IntRect getFrameRect(int frameIndex) const {
        if (frameIndex >= 0 && frameIndex < m_frames.size()) {
            return m_frames[frameIndex];
        }
        return sf::IntRect();
    }

    size_t getFrameCount() const { return m_frames.size(); }

private:
    sf::Texture* m_texture;
    int m_frameWidth;
    int m_frameHeight;
    std::vector<sf::IntRect> m_frames;
};
