#include "WeaponFactory.h"
#include "AllWeapons.h"

std::unique_ptr<WeaponBase> WeaponFactory::createWeapon(const std::string& weaponName) {
    if (weaponName == "Whip") return std::make_unique<Whip>();
    if (weaponName == "Bloody Tear") return std::make_unique<BloodyTear>();
    if (weaponName == "Magic Wand") return std::make_unique<MagicWand>();
    if (weaponName == "Holy Wand") return std::make_unique<HolyWand>();
    if (weaponName == "Knife") return std::make_unique<Knife>();
    if (weaponName == "Thousand Edge") return std::make_unique<ThousandEdge>();
    if (weaponName == "Fire Wand") return std::make_unique<FireWand>();
    if (weaponName == "Hellfire") return std::make_unique<Hellfire>();
    if (weaponName == "Axe") return std::make_unique<Axe>();
    if (weaponName == "Death Spiral") return std::make_unique<DeathSpiral>();
    if (weaponName == "Cross") return std::make_unique<Cross>();
    if (weaponName == "Garlic" || weaponName == "GARLIC") return std::make_unique<Garlic>();
    if (weaponName == "King Bible") return std::make_unique<KingBible>();
    if (weaponName == "Santa Water") return std::make_unique<SantaWater>();
    if (weaponName == "Runetracer" || weaponName == "DIAMOND") return std::make_unique<Runetracer>();
    if (weaponName == "Lightning Ring" || weaponName == "LIGHTNING") return std::make_unique<LightningRing>();
    
    return nullptr;
}
