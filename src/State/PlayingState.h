#pragma once
#include "State/GameState.h"
#include "Physics/SpatialHashGrid.h"

class GameManager;

class PlayingState : public GameState {
public:
    PlayingState(GameManager* manager);
    ~PlayingState() override = default;

    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    SpatialHashGrid m_grid;
};
