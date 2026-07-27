#include "Core/Data/WaveManager.h"
#include <fstream>
#include <iostream>
#include <nlohmann/json.hpp>

using json = nlohmann::json;

WaveManager::WaveManager() {}

bool WaveManager::loadWavesFromJson(const std::string& filepath) {
    std::ifstream file(filepath);
    if (!file.is_open()) {
        std::cerr << "Failed to open wave file: " << filepath << std::endl;
        return false;
    }

    try {
        json j;
        file >> j;

        if (j.contains("name")) {
            m_mapName = j["name"];
        }

        if (j.contains("waves") && j["waves"].is_array()) {
            for (const auto& waveJson : j["waves"]) {
                WaveData wave;
                wave.startTime = waveJson["startTime"].get<float>();
                wave.minEnemies = waveJson.value("enemyMinimum", waveJson.value("maxEnemies", 10));
                wave.spawnInterval = waveJson.value("spawnInterval", 1.0f);

                if (waveJson.contains("enemies") && waveJson["enemies"].is_array()) {
                    for (const auto& enemyStr : waveJson["enemies"]) {
                        wave.enemies.push_back(enemyStr.get<std::string>());
                    }
                }
                if (waveJson.contains("boss") && waveJson["boss"].is_string()) {
                    wave.boss = waveJson["boss"].get<std::string>();
                }
                m_waves.push_back(wave);
            }
        }
    } catch (const json::exception& e) {
        std::cerr << "JSON parsing error in " << filepath << ": " << e.what() << std::endl;
        return false;
    }

    return true;
}

const WaveData* WaveManager::getCurrentWave(float gameTime) const {
    if (m_waves.empty()) return nullptr;

    const WaveData* current = &m_waves.front();
    for (const auto& wave : m_waves) {
        if (gameTime >= wave.startTime) {
            current = &wave;
        } else {
            // Since waves are assumed to be sorted by time, we can break early
            break;
        }
    }
    return current;
}

int WaveManager::getCurrentWaveIndex(float gameTime) const {
    if (m_waves.empty()) return -1;

    int currentIndex = 0;
    for (size_t i = 0; i < m_waves.size(); ++i) {
        if (gameTime >= m_waves[i].startTime) {
            currentIndex = static_cast<int>(i);
        } else {
            break;
        }
    }
    return currentIndex;
}

const WaveData* WaveManager::getWave(int index) const {
    if (index >= 0 && index < static_cast<int>(m_waves.size())) {
        return &m_waves[index];
    }
    return nullptr;
}
