#pragma once

#include <string>
#include <vector>
#include "Entities/EnemyDatabase.h"

struct WaveData {
    float startTime;
    int minEnemies;
    float spawnInterval;
    std::vector<std::string> enemies;
    std::string boss;
};

class WaveManager {
public:
    WaveManager();
    ~WaveManager() = default;

    bool loadWavesFromJson(const std::string& filepath);
    
    // Returns the current wave based on game time (in seconds)
    const WaveData* getCurrentWave(float gameTime) const;
    
    // Returns the index of the current wave
    int getCurrentWaveIndex(float gameTime) const;
    
    // Retrieves a specific wave by index
    const WaveData* getWave(int index) const;

private:
    std::string m_mapName;
    std::vector<WaveData> m_waves;
};
