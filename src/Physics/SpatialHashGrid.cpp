#include "Physics/SpatialHashGrid.h"
#include <cmath>
#include <algorithm>

SpatialHashGrid::SpatialHashGrid(float cellSize) : m_cellSize(cellSize) {
    // For a 10000x10000 game world, size depends on constraints.
    // For the skeleton, we just ensure it has some capacity.
    m_cells.resize(10000); 
}

int SpatialHashGrid::getHashKey(const sf::Vector2f& position) const {
    int x = static_cast<int>(std::floor(position.x / m_cellSize));
    int y = static_cast<int>(std::floor(position.y / m_cellSize));
    
    // Simple hash function for 2D coordinates into a 1D array.
    // In production, use prime numbers for better distribution:
    // return (x * 73856093 ^ y * 19349663) % m_cells.size();
    
    int hash = (x * 73856093 ^ y * 19349663) % m_cells.size();
    if (hash < 0) hash += m_cells.size();
    return hash;
}

void SpatialHashGrid::insertEntity(Agent* entity) {
    if (!entity) return;
    int key = getHashKey(entity->getPosition());
    m_cells[key].push_back(entity);
}

void SpatialHashGrid::removeEntity(Agent* entity) {
    if (!entity) return;
    int key = getHashKey(entity->getPosition());
    auto& cell = m_cells[key];
    cell.erase(std::remove(cell.begin(), cell.end(), entity), cell.end());
}

void SpatialHashGrid::updateEntityCell(Agent* entity) {
    // In a full implementation, you check if the old key != new key.
    // If they differ, remove from old cell and insert into new cell.
}

std::vector<Agent*> SpatialHashGrid::getNeighbors(const sf::Vector2f& position) {
    std::vector<Agent*> neighbors;
    // For O(1) checks, query the current cell and 8 adjacent cells
    // int x = floor(position.x / m_cellSize); ...
    // Gather all entities in those 9 cells.
    
    int key = getHashKey(position);
    for (Agent* agent : m_cells[key]) {
        neighbors.push_back(agent);
    }
    
    return neighbors;
}
