#pragma once

#include <memory>
#include <string>
#include "Entities/Weapons/WeaponBase.h"

class WeaponFactory {
public:
    static std::unique_ptr<WeaponBase> createWeapon(const std::string& weaponName);
};
