#include "Core/Data/ProfileManager.h"
#include <fstream>
#include <sstream>
#include <iostream>
#include <algorithm>

ProfileManager::ProfileManager() : m_gold(0) {
    // Initialize the PowerUps list based on Vampire Survivors Wiki
    m_powerUps = {
        { "Might", "Increases damage inflicted by +5% per rank.", 5, 200, 0.05f, "%" },
        { "Max Health", "Augments Max Health by +10% per rank.", 3, 200, 0.10f, "%" },
        { "Recovery", "Recovers 0.1 HP per second per rank.", 5, 200, 0.10f, " HP/s" },
        { "Greed", "Increases amount of Gold earned by +10% per rank.", 5, 200, 0.10f, "%" },
        { "Armor", "Reduces incoming damage by 1 per rank.", 3, 600, 1.0f, " Damage" },
        { "Luck", "Increases chance of item upgrades and drops by +10% per rank.", 3, 600, 0.10f, "%" },
        { "Area", "Increases the size of weapon attacks by +5% per rank.", 2, 300, 0.05f, "%" },
        { "Speed", "Makes weapon projectiles +10% faster per rank.", 2, 300, 0.10f, "%" },
        { "Duration", "Increases the lifetime of projectiles by +15% per rank.", 2, 300, 0.15f, "%" },
        { "MoveSpeed", "Increases character movement speed by +10% per rank.", 2, 300, 0.10f, "%" },
        { "Magnet", "Expands pickup range for gems and coins by +25% per rank.", 5, 300, 0.25f, "%" },
        { "Growth", "Increases experience gained by +3% per rank.", 5, 900, 0.03f, "%" },
        { "Cooldown", "Reduces weapon cooldown intervals by -2.5% per rank.", 2, 900, 0.025f, "%" },
        { "Amount", "Fires +1 extra projectile for all weapons.", 1, 5000, 1.0f, " Projectile" },
        { "Revival", "Enables +1 resurrection at 50% HP upon death.", 1, 10000, 1.0f, " Revival" }
    };

    // Default levels are 0
    for (const auto& pu : m_powerUps) {
        m_upgrades[pu.name] = 0;
    }

    // Try to load save file
    load("save.txt");
}

bool ProfileManager::load(const std::string& filepath) {
    std::ifstream file(filepath);
    if (!file.is_open()) {
        std::cerr << "ProfileManager: No save file found. Starting fresh.\n";
        return false;
    }

    std::string line;
    while (std::getline(file, line)) {
        if (line.empty() || line[0] == '#') continue;
        std::istringstream iss(line);
        std::string key;
        if (!(iss >> key)) continue;

        if (key == "gold") {
            int val;
            if (iss >> val) m_gold = val;
        } else {
            // Find powerup by name (supporting spaces in names like "Max Health")
            std::string name = key;
            std::string word;
            while (iss >> word) {
                name += " " + word;
            }
            // The last token read in name is actually the level if we just split by space
            size_t lastSpace = name.find_last_of(" ");
            if (lastSpace != std::string::npos) {
                std::string levelStr = name.substr(lastSpace + 1);
                std::string actualName = name.substr(0, lastSpace);
                try {
                    int level = std::stoi(levelStr);
                    if (m_upgrades.find(actualName) != m_upgrades.end()) {
                        m_upgrades[actualName] = std::clamp(level, 0, getUpgradeRank(actualName) > 0 ? getUpgradeRank(actualName) : 10);
                    }
                } catch (...) {}
            }
        }
    }
    std::cout << "ProfileManager: Successfully loaded profile with " << m_gold << " gold.\n";
    file.close();
    return true;
}

bool ProfileManager::save(const std::string& filepath) {
    std::ofstream file(filepath);
    if (!file.is_open()) {
        std::cerr << "ProfileManager: Failed to open save file for writing!\n";
        return false;
    }

    file << "# Vampire Survivors Clone Save File\n";
    file << "gold " << m_gold << "\n";
    for (const auto& pair : m_upgrades) {
        file << pair.first << " " << pair.second << "\n";
    }

    std::cout << "ProfileManager: Saved profile with " << m_gold << " gold.\n";
    file.close();
    return true;
}

bool ProfileManager::spendGold(int amount) {
    if (m_gold >= amount) {
        m_gold -= amount;
        return true;
    }
    return false;
}

int ProfileManager::getUpgradeRank(const std::string& name) const {
    auto it = m_upgrades.find(name);
    if (it != m_upgrades.end()) {
        return it->second;
    }
    return 0;
}

int ProfileManager::calculateRankCost(const PowerUpInfo& info, int rank) const {
    if (rank <= 0 || rank > info.maxLevel) return 0;
    // Standard additive price formula: Cost(R) = base * R * (1 + 0.1 * (R - 1))
    return static_cast<int>(info.baseCost * rank * (1.f + 0.1f * (rank - 1)));
}

bool ProfileManager::upgradePowerUp(const std::string& name) {
    auto it = m_upgrades.find(name);
    if (it == m_upgrades.end()) return false;

    // Find PowerUpInfo
    const PowerUpInfo* info = nullptr;
    for (const auto& pu : m_powerUps) {
        if (pu.name == name) {
            info = &pu;
            break;
        }
    }
    if (!info) return false;

    int currentRank = it->second;
    if (currentRank >= info->maxLevel) return false;

    int cost = calculateRankCost(*info, currentRank + 1);
    if (spendGold(cost)) {
        it->second++;
        save("save.txt");
        return true;
    }
    return false;
}

void ProfileManager::refundAll() {
    // Return all spent gold
    for (const auto& pu : m_powerUps) {
        int currentRank = m_upgrades[pu.name];
        for (int r = 1; r <= currentRank; ++r) {
            m_gold += calculateRankCost(pu, r);
        }
        m_upgrades[pu.name] = 0;
    }
    save("save.txt");
}

// Stats Multipliers
float ProfileManager::getMightMultiplier() const {
    return 1.f + getUpgradeRank("Might") * 0.05f;
}

float ProfileManager::getArmorReduction() const {
    return getUpgradeRank("Armor") * 1.f;
}

float ProfileManager::getMaxHealthMultiplier() const {
    return 1.f + getUpgradeRank("Max Health") * 0.10f;
}

float ProfileManager::getRecoveryRate() const {
    return getUpgradeRank("Recovery") * 0.10f;
}

float ProfileManager::getGreedMultiplier() const {
    return 1.f + getUpgradeRank("Greed") * 0.10f;
}

float ProfileManager::getMoveSpeedMultiplier() const {
    return 1.f + getUpgradeRank("MoveSpeed") * 0.10f;
}

float ProfileManager::getMagnetBonus() const {
    return getUpgradeRank("Magnet") * 0.25f;
}

float ProfileManager::getGrowthMultiplier() const {
    return 1.f + getUpgradeRank("Growth") * 0.03f;
}

float ProfileManager::getCooldownMultiplier() const {
    return 1.f - getUpgradeRank("Cooldown") * 0.025f;
}

int ProfileManager::getAmountBonus() const {
    return getUpgradeRank("Amount");
}

int ProfileManager::getRevivalBonus() const {
    return getUpgradeRank("Revival");
}

float ProfileManager::getProjectileSpeedMultiplier() const {
    return 1.f + getUpgradeRank("Speed") * 0.10f;
}

float ProfileManager::getDurationMultiplier() const {
    return 1.f + getUpgradeRank("Duration") * 0.15f;
}

float ProfileManager::getAreaMultiplier() const {
    return 1.f + getUpgradeRank("Area") * 0.05f;
}

float ProfileManager::getLuckMultiplier() const {
    return 1.f + getUpgradeRank("Luck") * 0.10f;
}
