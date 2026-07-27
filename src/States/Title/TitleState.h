#pragma once
#include "States/Game/GameState.h"
#include "Core/Resources/TextureAtlas.h"
#include <SFML/Graphics.hpp>
#include <vector>

class GameManager;

class TitleState : public GameState {
public:
    TitleState(GameManager* manager);
    ~TitleState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;

    TextureAtlas m_uiAtlas;
    TextureAtlas m_illAtlas;

    sf::Font m_font;

    // Composite background (sv_main_bg)
    sf::RenderTexture m_compositeTexture;
    sf::Sprite m_compositeSprite;

    // Illustrations that fade in
    struct FadeItem {
        sf::Sprite sprite;
        float delayTimer;
        float fadeTimer;
        float fadeAlpha;   // current 0-255
        float targetAlpha; // max alpha
        bool started;
    };
    std::vector<FadeItem> m_illustrations;

    // "PRESS TO START" blink
    sf::Text m_promptText;
    float m_promptTimer;
    bool m_promptFadingIn;
    float m_promptAlpha;

    bool m_inputLocked;

    void setupBackground();
    void updateFaders(float dt);
};
