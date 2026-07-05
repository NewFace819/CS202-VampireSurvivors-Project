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
#include <string>
#include <set>

class GameManager;

enum class CharacterType {
    Antonio,
    Imelda,
    Gennaro,
    Arca,
    Lama,
    Sigma
};

class PlayingState : public GameState {
public:
    PlayingState(GameManager* manager, CharacterType charType);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

    // Called by LevelUpState to grant a new weapon by name
    void addWeapon(const std::string& weaponName);

    // Query which weapon type strings are currently owned
    std::set<std::string> getOwnedWeaponNames() const;

    // Raw pointers into m_weapons for LevelUpState to call levelUp() on
    std::vector<WeaponBase*> getUpgradeableWeapons();

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
    int   m_lastLevel  = 1; // Track StatsManager level to detect level-ups

    float m_survivalTime = 0.f;
    bool m_bossSpawned = false;

    sf::Font m_font;
    sf::Text m_timerText;
};
