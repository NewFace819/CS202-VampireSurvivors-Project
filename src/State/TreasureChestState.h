#pragma once
#include "State/GameState.h"
#include <SFML/Graphics.hpp>
#include <vector>
#include <string>

class GameManager;
class PlayingState;

class TreasureChestState : public GameState {
public:
    TreasureChestState(GameManager* manager, PlayingState* playing);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;
    bool isTransparent() const override { return true; } // Keep PlayingState visible underneath

private:
    void determineReward();
    void spawnCoinShower();

    GameManager*  m_manager;
    PlayingState* m_playing;

    sf::Font      m_font;
    sf::Texture   m_itemsTex;
    sf::Texture   m_uiTex;

    // Background and Cards Panel
    sf::RectangleShape m_overlay;
    sf::RectangleShape m_panel;
    sf::RectangleShape m_panelInner;

    sf::Text           m_titleText;
    sf::Text           m_skipText;

    // Open Chest Graphic
    sf::Sprite         m_chestSprite;

    // V-shaped Light Beams
    sf::ConvexShape    m_lightBeams[3];

    // Reward Details
    sf::Sprite         m_rewardSprite;
    sf::Text           m_rewardNameText;
    sf::Text           m_rewardDescText;

    sf::Sprite         m_goldIconSprite;
    sf::Text           m_goldBonusText;

    // Coin & Sparkle Shower Particles
    struct Particle {
        sf::Sprite sprite;
        sf::Vector2f velocity;
        float rotationSpeed;
        float lifetime;
        float maxLifetime;
    };
    std::vector<Particle> m_particles;

    float        m_timer;
    int          m_goldReward;
    std::string  m_rewardName;
    sf::IntRect  m_rewardIconRect;
    bool         m_isEvolution;
    bool         m_isLevelUp;
};
