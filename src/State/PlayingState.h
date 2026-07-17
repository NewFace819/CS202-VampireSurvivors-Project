#pragma once
#include <SFML/Graphics.hpp>
#include "State/GameState.h"
#include "Physics/SpatialHashGrid.h"
#include "Entities/Player.h"
#include "Entities/EnemyBase.h"
#include "Entities/ShooterEnemy.h"
#include "Entities/TreasureChest.h"
#include "Engine/ObjectPool.h"
#include "Weapons/WeaponBase.h"
#include "Weapons/Projectile.h"
#include "Entities/Collectible.h"
#include "Items/PassiveItem.h"
#include "Engine/WaveManager.h"
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

enum class StageType {
    MadForest,
    InlaidLibrary
};

class PlayingState : public GameState {
public:
    PlayingState(GameManager* manager, CharacterType charType, StageType stageType);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

    // Add gold to current run and profile persistence
    void addGoldToRun(int amount) {
        m_runGold += amount;
        ProfileManager::GetInstance().addGold(amount);
    }

    // Called by LevelUpState to grant a new weapon by name
    void addWeapon(const std::string& weaponName);


    // Query which weapon type strings are currently owned
    std::set<std::string> getOwnedWeaponNames() const;
    const std::set<std::string>& getBannedWeapons() const { return m_bannedWeapons; }

    // Raw pointers into m_weapons for LevelUpState to call levelUp() on
    std::vector<WeaponBase*> getUpgradeableWeapons();

    // --- Passive Item Interface (for LevelUpState) ---
    std::vector<PassiveItem>& getPassiveItems() { return m_passiveItems; }
    const std::vector<PassiveItem>& getPassiveItems() const { return m_passiveItems; }
    void addOrUpgradePassive(const std::string& name);
    std::set<std::string> getOwnedPassiveNames() const;

    // --- Per-run passive multipliers ---
    float getPassiveDamageMultiplier() const;
    float getPassiveCooldownMultiplier() const;
    float getPassiveProjSpeedMultiplier() const;
    float getPassiveAreaMultiplier() const;
    float getPassiveMaxHealthMultiplier() const;

    // --- Evolution ---
    void tryEvolveWeapon();

private:
    GameManager* m_manager;
    SpatialHashGrid m_grid;
    
    Player m_player;
    ObjectPool<EnemyBase> m_enemyPool;
    ObjectPool<ShooterEnemy> m_shooterPool;
    std::vector<EnemyBase*> m_activeEnemies;
    
    std::vector<std::unique_ptr<WeaponBase>> m_weapons;
    std::vector<Projectile> m_activeProjectiles;
    std::vector<std::unique_ptr<Collectible>> m_activeCollectibles;
    std::vector<PassiveItem> m_passiveItems;
    std::vector<TreasureChest> m_chests;


    float m_enemySpawnTimer = 0.f;
    int   m_lastLevel  = 1; // Track StatsManager level to detect level-ups

    float m_survivalTime = 0.f;
    bool m_bossSpawned = false;
    bool m_bossIsDead = false;
    EnemyBase* m_bossPtr = nullptr; // Track the boss to detect its death

    int m_revivalsLeft = 0;
    int m_runGold = 0;

    // Cheat code state
    bool m_cheatApplied = false;
    std::set<std::string> m_bannedWeapons;

    int m_currentWaveIndex = -1;
    WaveManager m_waveManager;

    sf::Font m_font;
    sf::Text m_timerText;
    sf::Text m_goldText;
    sf::Text m_levelText;
    sf::Texture m_itemsTex;
    sf::Texture m_enemiesTex; // enemies.png

    // Infinite-tiling background (3x3 grid)
    sf::Texture m_bgTex;
    sf::Sprite  m_bgTiles[3][3];  // [row][col]
    float       m_tileSize = 1024.f; // size of one tile in world units
    StageType   m_stageType;
};

