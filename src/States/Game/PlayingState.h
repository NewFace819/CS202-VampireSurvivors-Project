#pragma once
#include <SFML/Graphics.hpp>
#include "States/Game/GameState.h"
#include "Core/Physics/SpatialHashGrid.h"
#include "Entities/Player.h"
#include "Entities/Enemy/EnemyBase.h"
#include "Entities/Enemy/ShooterEnemy.h"
#include "Entities/Pickups/TreasureChest.h"
#include "Entities/Obstacle.h"
#include "Core/ObjectPool.h"
#include "Entities/Weapons/WeaponBase.h"
#include "Entities/Projectiles/Projectile.h"
#include "Entities/Pickups/Collectible.h"
#include "Entities/Weapons/PassiveItem.h"
#include "Core/Data/WaveManager.h"
#include <memory>
#include <vector>
#include <string>
#include <set>

class GameManager;

enum class CharacterType {
    Antonio, Imelda, Pasqualina, Gennaro, Arca, Porta, Lama, Poe, Clerici, Dommario, Krochi,
    Christine, Pugnala, Giovanna, Poppea, Concetta, Mortaccio, Cavallo, Ramba,
    OSole, Ambrojoe, Gallo, Divano, ZiAssunta, Exdash, Toasty, Smith, Random,
    Minnah, Leda, Cosmo, Peppino, BigTrouser, MissingN0, Gains, Gyorunton, Sigma, Marrabbio, Avatar, RedDeath, Robbert, ZiAppunta, SheMoon, Santa, Gazebo, ChulaReh, SpaceDude, BatsBatsBats, Rose, Torino, ScorejOni, Gyoruntin, Secretino, SpaceDette
};

enum class StageType {
    MadForest,
    InlaidLibrary
};

class PlayingState : public GameState {
public:
    PlayingState(GameManager* manager, CharacterType charType, StageType stageType);
    PlayingState(GameManager* manager, const std::vector<CharacterType>& charTypes, StageType stageType);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;

    Player& getPlayer(size_t index = 0) { return m_players.empty() ? m_dummyPlayer : m_players[index < m_players.size() ? index : 0]; }
    std::vector<Player>& getPlayers() { return m_players; }
    const std::vector<Player>& getPlayers() const { return m_players; }
    Player* getNearestPlayer(const sf::Vector2f& pos);

    // Add gold to current run and profile persistence
    void addGoldToRun(int amount) {
        m_runGold += amount;
        ProfileManager::GetInstance().addGold(amount);
    }

    // Called by LevelUpState to grant a new weapon by name
    void addWeapon(const std::string& weaponName);
    void addWeaponForPlayer(size_t playerIdx, const std::string& weaponName);


    // Query which weapon type strings are currently owned
    std::set<std::string> getOwnedWeaponNames(size_t playerIdx = 0) const;
    const std::set<std::string>& getBannedWeapons() const { return m_bannedWeapons; }
    void banishItem(const std::string& name) { m_bannedWeapons.insert(name); }

    // Tactical Level-Up charges
    int getRerollCharges() const { return m_rerollCharges; }
    void useRerollCharge() { if (m_rerollCharges > 0) m_rerollCharges--; }
    int getSkipCharges() const { return m_skipCharges; }
    void useSkipCharge() { if (m_skipCharges > 0) m_skipCharges--; }
    int getBanishCharges() const { return m_banishCharges; }
    void useBanishCharge() { if (m_banishCharges > 0) m_banishCharges--; }

    // Raw pointers into m_weapons for LevelUpState to call levelUp() on
    std::vector<WeaponBase*> getUpgradeableWeapons(size_t playerIdx = 0);
    std::vector<WeaponBase*> getWeaponsForPlayer(size_t playerIdx = 0) const;
    const std::vector<std::unique_ptr<WeaponBase>>& getWeapons() const { return m_weapons; }

    // --- Passive Item Interface (for LevelUpState) ---
    std::vector<PassiveItem>& getPassiveItems(size_t playerIdx = 0);
    const std::vector<PassiveItem>& getPassiveItems(size_t playerIdx = 0) const;
    void addOrUpgradePassive(const std::string& name, size_t playerIdx = 0);
    std::set<std::string> getOwnedPassiveNames(size_t playerIdx = 0) const;

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
    
    std::vector<Player> m_players;
    Player m_dummyPlayer;
    std::vector<size_t> m_weaponOwnerIndices; // Maps weapon index -> player index
    std::vector<size_t> m_levelUpQueue;
    ObjectPool<EnemyBase> m_enemyPool;
    ObjectPool<ShooterEnemy> m_shooterPool;
    std::vector<EnemyBase*> m_activeEnemies;
    
    std::vector<std::unique_ptr<WeaponBase>> m_weapons;
    std::vector<Projectile> m_activeProjectiles;
    std::vector<Projectile> m_bossProjectiles;
    std::vector<std::unique_ptr<Collectible>> m_activeCollectibles;
    std::vector<std::vector<PassiveItem>> m_playerPassiveItems;
    std::vector<PassiveItem> m_passiveItems;
    std::vector<TreasureChest> m_chests;
    std::vector<std::unique_ptr<Obstacle>> m_obstacles;
    std::vector<std::unique_ptr<Obstacle>> m_baseObstacles; // Base template for repeating maps
    int m_lastGridX = -999;
    int m_lastGridY = -999;

    // View & Level
    sf::View worldView; 
    sf::Texture m_libraryPropsTex;
    void generateLibraryObstacles();


    float m_enemySpawnTimer = 0.f;
    int   m_lastLevel  = 1; // Track StatsManager level to detect level-ups

    float m_survivalTime = 0.f;
    bool m_bossSpawned = false;
    bool m_bossIsDead = false;
    EnemyBase* m_bossPtr = nullptr; // Track the boss to detect its death

    int m_revivalsLeft = 0;
    int m_runGold = 0;
    int m_kills = 0;
    int m_rerollCharges = 10;
    int m_skipCharges = 10;
    int m_banishCharges = 10;

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
    sf::Texture m_vfxTex; // vfx.png

    // Infinite-tiling background (3x3 grid)
    sf::Texture m_bgTex;
    sf::Sprite  m_bgTiles[3][3];  // [row][col]
    float       m_tileSize = 1024.f; // size of one tile in world units
    StageType   m_stageType;
};

