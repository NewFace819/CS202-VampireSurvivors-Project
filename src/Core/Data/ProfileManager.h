#pragma once
#include <string>
#include <map>
#include <vector>

struct PowerUpInfo {
    std::string name;
    std::string description;
    int maxLevel;
    int baseCost;
    float bonusPerLevel;
    std::string effectSuffix;
};

class ProfileManager {
public:
    static ProfileManager& GetInstance() {
        static ProfileManager instance;
        return instance;
    }

    // Load and save functions using C++ streams
    bool load(const std::string& filepath);
    bool save(const std::string& filepath);

    // Gold management
    int getGold() const { return m_gold; }
    void addGold(int amount) { m_gold += amount; }
    bool spendGold(int amount);

    // PowerUp ranks management
    int getUpgradeRank(const std::string& name) const;
    void setUpgradeRank(const std::string& name, int rank) { m_upgrades[name] = rank; }
    bool upgradePowerUp(const std::string& name);
    void refundAll();

    // Specific multiplier/bonus getters for gameplay stats
    float getMightMultiplier() const;
    float getArmorReduction() const;
    float getMaxHealthMultiplier() const;
    float getRecoveryRate() const;
    float getGreedMultiplier() const;
    float getMoveSpeedMultiplier() const;
    float getMagnetBonus() const;
    float getGrowthMultiplier() const;
    float getCooldownMultiplier() const;
    int getAmountBonus() const;
    int getRevivalBonus() const;
    float getProjectileSpeedMultiplier() const;
    float getDurationMultiplier() const;
    float getAreaMultiplier() const;
    float getLuckMultiplier() const;

    // Get list of all available PowerUps for UI
    const std::vector<PowerUpInfo>& getPowerUpsList() const { return m_powerUps; }

    // Cost formula for a specific rank (1-indexed) of a PowerUp
    int calculateRankCost(const PowerUpInfo& info, int rank) const;

private:
    ProfileManager();
    ~ProfileManager() = default;
    ProfileManager(const ProfileManager&) = delete;
    ProfileManager& operator=(const ProfileManager&) = delete;

    int m_gold;
    std::map<std::string, int> m_upgrades; // name -> current level
    std::vector<PowerUpInfo> m_powerUps;
};
