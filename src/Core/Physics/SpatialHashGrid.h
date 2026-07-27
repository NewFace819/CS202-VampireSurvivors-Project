#pragma once
#include <vector>
#include <SFML/Graphics.hpp>

class EnemyBase;

class SpatialHashGrid {
public:
    SpatialHashGrid(float cellSize);

    void clear();
    void insertEntity(EnemyBase* entity);
    std::vector<EnemyBase*> getNeighbors(const sf::Vector2f& position);

private:
    float m_cellSize;
    int getHashKey(int gridX, int gridY) const;
    std::vector<std::vector<EnemyBase*>> m_cells; 
};
