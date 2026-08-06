#pragma once

#include <memory>
#include <string>
#include "WeaponBase.h"

class WeaponFactory {
public:
    static std::unique_ptr<WeaponBase> createWeapon(const std::string& weaponName);
};
