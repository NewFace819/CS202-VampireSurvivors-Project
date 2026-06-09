#include "Physics/Collision.h"
#include <cmath>

namespace Collision {

    bool checkCircleCircle(const sf::Vector2f& pos1, float radius1, 
                           const sf::Vector2f& pos2, float radius2) {
        float dx = pos2.x - pos1.x;
        float dy = pos2.y - pos1.y;
        float distSquared = dx * dx + dy * dy;
        float radiusSum = radius1 + radius2;
        
        return distSquared <= (radiusSum * radiusSum);
    }

    bool checkCircleAABB(const sf::Vector2f& circlePos, float circleRadius,
                         const sf::FloatRect& aabb) {
        // Find the closest point to the circle within the rectangle
        float closestX = std::max(aabb.left, std::min(circlePos.x, aabb.left + aabb.width));
        float closestY = std::max(aabb.top, std::min(circlePos.y, aabb.top + aabb.height));

        // Calculate the distance between the circle's center and this closest point
        float dx = circlePos.x - closestX;
        float dy = circlePos.y - closestY;

        // If the distance is less than the circle's radius, an intersection occurs
        return (dx * dx + dy * dy) < (circleRadius * circleRadius);
    }

    void resolveCircleAABB(sf::Vector2f& circlePos, float circleRadius,
                           const sf::Vector2f& velocity, const sf::FloatRect& aabb) {
        // Implement Axis-Separated resolution to allow sliding along walls
        // (Implementation details left for Phase 2)
    }

}
