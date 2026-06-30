#pragma once
#include <SFML/Graphics.hpp>
#include "State/GameState.h"
#include "Physics/SpatialHashGrid.h"
#include "Entities/Player.h"
#include "Entities/EnemyBase.h"
#include "Engine/ObjectPool.h"
#include "Weapons/WeaponBase.h"
#include "Weapons/Projectile.h"
#include "Entities/ExpGem.h"
#include <memory>
#include <vector>

class GameManager;

class PlayingState : public GameState {
public:
    PlayingState(GameManager* manager);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

private:
    GameManager* m_manager;
    SpatialHashGrid m_grid;
    
    Player m_player;
    ObjectPool<EnemyBase> m_enemyPool;
    std::vector<EnemyBase*> m_activeEnemies;
    
    std::vector<std::unique_ptr<WeaponBase>> m_weapons;
    std::vector<Projectile> m_activeProjectiles;
    std::vector<ExpGem> m_activeGems;

    float m_spawnTimer = 0.f;
    float m_survivalTime = 0.f;
    bool m_bossSpawned = false;

    sf::Font m_font;
    sf::Text m_timerText;
};
