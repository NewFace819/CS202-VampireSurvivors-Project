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
        float closestX = std::max(aabb.left, std::min(circlePos.x, aabb.left + aabb.width));
        float closestY = std::max(aabb.top, std::min(circlePos.y, aabb.top + aabb.height));

        float dx = circlePos.x - closestX;
        float dy = circlePos.y - closestY;
        float distSquared = dx * dx + dy * dy;

        if (distSquared < circleRadius * circleRadius && distSquared > 0.00001f) {
            float dist = std::sqrt(distSquared);
            float penetration = circleRadius - dist;
            circlePos.x += (dx / dist) * penetration;
            circlePos.y += (dy / dist) * penetration;
        } else if (distSquared <= 0.00001f) {
            float distLeft = circlePos.x - aabb.left;
            float distRight = (aabb.left + aabb.width) - circlePos.x;
            float distTop = circlePos.y - aabb.top;
            float distBottom = (aabb.top + aabb.height) - circlePos.y;
            float minDist = std::min({distLeft, distRight, distTop, distBottom});
            if (minDist == distLeft) circlePos.x = aabb.left - circleRadius;
            else if (minDist == distRight) circlePos.x = aabb.left + aabb.width + circleRadius;
            else if (minDist == distTop) circlePos.y = aabb.top - circleRadius;
            else circlePos.y = aabb.top + aabb.height + circleRadius;
        }
    }

}
