#pragma once
#include <vector>
#include <SFML/Graphics.hpp>

class EnemyBase;

class SpatialHashGrid {
public:
    SpatialHashGrid(float cellSize);

    void clear();
    void insertEntity(EnemyBase* entity);

    // Returns entities in the surrounding cells. Kept for compatibility; allocates.
    std::vector<EnemyBase*> getNeighbors(const sf::Vector2f& position);

    // Allocation-free variants: the caller owns `out` and reuses its capacity
    // across frames. `radius` widens the scan so queries larger than one cell
    // (big auras, area weapons) cannot silently miss entities.
    void getNeighbors(const sf::Vector2f& position, std::vector<EnemyBase*>& out) const;
    void getNeighborsInRadius(const sf::Vector2f& position, float radius, std::vector<EnemyBase*>& out) const;

private:
    float m_cellSize;
    int getHashKey(int gridX, int gridY) const;
    std::vector<std::vector<EnemyBase*>> m_cells;
    // Only the cells actually touched this frame, so clear() does not walk all 10000.
    std::vector<int> m_usedCells; 
};
