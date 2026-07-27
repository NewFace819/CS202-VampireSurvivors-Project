#pragma once
#include <SFML/Graphics.hpp>
#include <vector>
#include "States/Game/GameState.h"

class GameManager;

struct ShopItemUI {
    std::string name;
    sf::RectangleShape panel;
    sf::Text nameText;
    sf::Text descText;
    sf::Text costText;
    std::vector<sf::RectangleShape> levelBoxes;
};

class ShopState : public GameState {
public:
    ShopState(GameManager* manager);
    ~ShopState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    sf::Font m_font;
    sf::Text m_titleText;
    sf::Text m_goldText;

    // Refund and Back buttons
    sf::RectangleShape m_refundBtn;
    sf::Text m_refundText;
    sf::RectangleShape m_backBtn;
    sf::Text m_backText;

    std::vector<ShopItemUI> m_uiItems;
    float m_timeInState = 0.f;

    void initUI();
    void updateUI();
};
