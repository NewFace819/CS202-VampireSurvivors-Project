#pragma once
#include <SFML/Graphics.hpp>
#include <cmath>
#include "Entities/Entity.h"
#include "Entities/Enemy/EnemyBase.h"

// Physics utilities for handling knockback and basic dynamics
class Physics {
public:
    // Preferred overload: the caller already holds an EnemyBase*, so no downcast is
    // needed. Called once per projectile hit, which is a hot path in dense waves.
    static void ApplyKnockback(EnemyBase* enemy, const sf::Vector2f& impactDirection, float force, float entityMass = 1.0f) {
        if (!enemy || entityMass <= 0.f) return;
        enemy->applyKnockback(impactDirection, force);
    }

    // Generic fallback for callers that only have an Entity*.
    static void ApplyKnockback(Entity* entity, const sf::Vector2f& impactDirection, float force, float entityMass = 1.0f) {
        if (!entity || entityMass <= 0.f) return;
        
        // Cast to EnemyBase to apply knockback directly
        EnemyBase* enemy = dynamic_cast<EnemyBase*>(entity);
        if (enemy) {
            enemy->applyKnockback(impactDirection, force);
        }
    }

    // Resolves soft collisions between enemies to prevent them from stacking completely on top of each other
    static void ResolveSwarmOverlap(Entity* e1, Entity* e2) {
        if (!e1 || !e2) return;

        sf::Vector2f p1 = e1->getPosition();
        sf::Vector2f p2 = e2->getPosition();
        sf::Vector2f delta = p1 - p2;
        
        float distSq = delta.x * delta.x + delta.y * delta.y;
        float minSeparation = 15.0f; // Minimal radius to keep enemies apart

        if (distSq > 0.0001f && distSq < minSeparation * minSeparation) {
            float dist = std::sqrt(distSq);
            sf::Vector2f normal = delta / dist;
            float overlap = minSeparation - dist;

            // Push each entity away by half the overlap
            sf::Vector2f push = normal * (overlap * 0.5f);
            
            // Adjust position slightly to resolve overlap (simple separation)
            e1->setPosition(p1 + push);
            e2->setPosition(p2 - push);
        }
    }
};
