#include "Core/Physics/SpatialHashGrid.h"
#include "Entities/Enemy/EnemyBase.h"
#include <cmath>

SpatialHashGrid::SpatialHashGrid(float cellSize) : m_cellSize(cellSize) {
    // More buckets than expected entities keeps hash collisions rare at high counts.
    // Costs ~1.5 MB and nothing per frame, since clear() only visits used cells.
    m_cells.resize(65536);
}

void SpatialHashGrid::clear() {
    // Only touch cells that actually received an entity last frame. Walking all
    // 10000 every frame was pure overhead when a few dozen are ever occupied.
    for (int key : m_usedCells) {
        m_cells[key].clear();
    }
    m_usedCells.clear();
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
    if (m_cells[key].empty()) {
        m_usedCells.push_back(key);
    }
    m_cells[key].push_back(entity);
}

std::vector<EnemyBase*> SpatialHashGrid::getNeighbors(const sf::Vector2f& position) {
    std::vector<EnemyBase*> neighbors;
    getNeighbors(position, neighbors);
    return neighbors;
}

void SpatialHashGrid::getNeighbors(const sf::Vector2f& position, std::vector<EnemyBase*>& out) const {
    getNeighborsInRadius(position, 0.f, out);
}

void SpatialHashGrid::getNeighborsInRadius(const sf::Vector2f& position, float radius,
                                           std::vector<EnemyBase*>& out) const {
    out.clear();

    int baseX = static_cast<int>(std::floor(position.x / m_cellSize));
    int baseY = static_cast<int>(std::floor(position.y / m_cellSize));

    // A 3x3 scan only reaches one cell out. Anything bigger than a cell needs a
    // wider ring or it would miss entities at its own edges.
    int span = 1 + static_cast<int>(std::ceil(radius / m_cellSize));

    for (int dx = -span; dx <= span; ++dx) {
        for (int dy = -span; dy <= span; ++dy) {
            int key = getHashKey(baseX + dx, baseY + dy);
            for (EnemyBase* e : m_cells[key]) {
                out.push_back(e);
            }
        }
    }
}
