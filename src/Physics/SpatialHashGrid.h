#pragma once
#include <vector>
#include <SFML/Graphics.hpp>
#include "Physics/Agent.h"

class SpatialHashGrid {
public:
    SpatialHashGrid(float cellSize);

    void insertEntity(Agent* entity);
    void removeEntity(Agent* entity);
    void updateEntityCell(Agent* entity);

    std::vector<Agent*> getNeighbors(const sf::Vector2f& position);

private:
    float m_cellSize;
    // Map a 2D integer coordinate to a 1D index
    int getHashKey(const sf::Vector2f& position) const;

    // The grid: a 1D vector acting as a hash map or 2D array
    // Note: For a robust system, this could be a std::unordered_map or a dynamically resizing 1D array.
    // For this skeleton, we represent the buckets simply.
    std::vector<std::vector<Agent*>> m_cells; 
};
