#pragma once
#include <SFML/Graphics.hpp>
#include "Entities/Agent.h"

namespace Collision {
    // Check if two circles intersect using squared distance (O(1), cache friendly)
    bool checkCircleCircle(const sf::Vector2f& pos1, float radius1, 
                           const sf::Vector2f& pos2, float radius2);

    // Check if a circle intersects an Axis-Aligned Bounding Box (AABB)
    bool checkCircleAABB(const sf::Vector2f& circlePos, float circleRadius,
                         const sf::FloatRect& aabb);

    // Axis-Separated Resolution for sliding along walls
    void resolveCircleAABB(sf::Vector2f& circlePos, float circleRadius,
                           const sf::Vector2f& velocity, const sf::FloatRect& aabb);
}
