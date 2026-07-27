#include "Core/Physics/SpatialHashGrid.h"
#include "Entities/Enemy/EnemyBase.h"
#include <cmath>

SpatialHashGrid::SpatialHashGrid(float cellSize) : m_cellSize(cellSize) {
    m_cells.resize(10000); 
}

void SpatialHashGrid::clear() {
    for (auto& cell : m_cells) {
        cell.clear();
    }
}

int SpatialHashGrid::getHashKey(int gridX, int gridY) const {
    int hash = (gridX * 73856093 ^ gridY * 19349663) % m_cells.size();
    if (hash < 0) hash += m_cells.size();
    return hash;
}

void SpatialHashGrid::insertEntity(EnemyBase* entity) {
    if (!entity) return;
    int x = static_cast<int>(std::floor(entity->getPosition().x / m_cellSize));
    int y = static_cast<int>(std::floor(entity->getPosition().y / m_cellSize));
    int key = getHashKey(x, y);
    m_cells[key].push_back(entity);
}

std::vector<EnemyBase*> SpatialHashGrid::getNeighbors(const sf::Vector2f& position) {
    std::vector<EnemyBase*> neighbors;
    
    int baseX = static_cast<int>(std::floor(position.x / m_cellSize));
    int baseY = static_cast<int>(std::floor(position.y / m_cellSize));
    
    for (int dx = -1; dx <= 1; ++dx) {
        for (int dy = -1; dy <= 1; ++dy) {
            int key = getHashKey(baseX + dx, baseY + dy);
            for (EnemyBase* e : m_cells[key]) {
                neighbors.push_back(e);
            }
        }
    }
    
    return neighbors;
}
