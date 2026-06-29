#pragma once
#include <SFML/Graphics.hpp>
#include <cmath>
#include "../Entities/Entity.h"

// Physics utilities for handling knockback and basic dynamics
class Physics {
public:
    // Applies an instantaneous knockback force to an entity based on the impact direction and the entity's mass
    static void ApplyKnockback(Entity* entity, const sf::Vector2f& impactDirection, float force, float entityMass = 1.0f) {
        if (!entity || entityMass <= 0.0f) return;

        // F = m * a -> a = F / m
        // Instantaneous acceleration added to velocity
        float acceleration = force / entityMass;
        
        sf::Vector2f currentVel = entity->getVelocity();
        sf::Vector2f newVel = currentVel + (impactDirection * acceleration);
        
        entity->setVelocity(newVel);
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
