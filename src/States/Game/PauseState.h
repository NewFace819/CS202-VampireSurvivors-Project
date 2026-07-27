#pragma once
#include "States/Game/GameState.h"

class GameManager;

class PauseState : public GameState {
public:
    PauseState(GameManager* manager);
    ~PauseState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
};
