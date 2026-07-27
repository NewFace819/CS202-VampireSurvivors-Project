#pragma once
#include <string>
#include <vector>
#include <optional>
#include "Entities/Weapons/PassiveItem.h"
#include "Entities/Weapons/WeaponBase.h"
#include <memory>

struct EvolutionRecipe {
    std::string baseWeapon;
    std::string requiredPassive;
    std::string evolvedWeapon;
};

// Static registry of all weapon evolution recipes.
inline const std::vector<EvolutionRecipe>& getEvolutionRecipes() {
    static const std::vector<EvolutionRecipe> recipes = {
        { "Whip",       "Hollow Heart",   "Bloody Tear"   },
        { "Magic Wand", "Empty Tome",     "Holy Wand"     },
        { "Knife",      "Bracer",         "Thousand Edge" },
        { "Fire Wand",  "Spinach",        "Hellfire"      },
        { "Axe",        "Candelabrador",  "Death Spiral"  }
    };
    return recipes;
}

#include <cstdlib>

// Check if any evolution is possible given the current weapons and passive items.
// Returns a random eligible evolution index, or -1 if none.
inline int findAvailableEvolution(
    const std::vector<std::unique_ptr<WeaponBase>>& weapons,
    const std::vector<PassiveItem>& passives)
{
    const auto& recipes = getEvolutionRecipes();
    std::vector<int> eligible;

    for (int r = 0; r < static_cast<int>(recipes.size()); ++r) {
        const auto& recipe = recipes[r];
        // Check if the base weapon is at max level
        bool hasMaxWeapon = false;
        for (const auto& w : weapons) {
            if (w->getName() == recipe.baseWeapon && w->isMaxLevel()) {
                hasMaxWeapon = true;
                break;
            }
        }
        if (!hasMaxWeapon) continue;

        // Check if the required passive is owned
        bool hasPassive = false;
        for (const auto& p : passives) {
            if (p.name == recipe.requiredPassive && p.isOwned()) {
                hasPassive = true;
                break;
            }
        }
        if (!hasPassive) continue;

        eligible.push_back(r);
    }

    if (eligible.empty()) {
        return -1;
    }

    // Pick one eligible index randomly
    int randomIndex = std::rand() % eligible.size();
    return eligible[randomIndex];
}

