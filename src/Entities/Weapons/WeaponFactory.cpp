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
    if (weaponName == "Cross" || weaponName == "CROSS") return std::make_unique<Cross>();
    if (weaponName == "Heaven Sword" || weaponName == "HEAVENSWORD") return std::make_unique<HeavenSword>();
    if (weaponName == "Garlic" || weaponName == "GARLIC") return std::make_unique<Garlic>();
    if (weaponName == "Soul Eater" || weaponName == "SOULEATER") return std::make_unique<SoulEater>();
    if (weaponName == "King Bible" || weaponName == "HOLYBOOK") return std::make_unique<KingBible>();
    if (weaponName == "Unholy Vespers" || weaponName == "VESPERS") return std::make_unique<UnholyVespers>();
    if (weaponName == "Santa Water" || weaponName == "HOLYWATER") return std::make_unique<SantaWater>();
    if (weaponName == "La Borra" || weaponName == "BORRA") return std::make_unique<LaBorra>();
    if (weaponName == "Runetracer" || weaponName == "DIAMOND" || weaponName == "GATTI") return std::make_unique<Runetracer>();
    if (weaponName == "NO FUTURE" || weaponName == "NOFUTURE") return std::make_unique<NoFuture>();
    if (weaponName == "Lightning Ring" || weaponName == "LIGHTNING" || weaponName == "PENTAGRAM") return std::make_unique<LightningRing>();
    if (weaponName == "Thunder Loop" || weaponName == "THUNDERLOOP") return std::make_unique<ThunderLoop>();
    
    if (weaponName == "Bone" || weaponName == "BONE") return std::make_unique<Bone>();
    if (weaponName == "Cherry Bomb" || weaponName == "CHERRY") return std::make_unique<CherryBomb>();
    if (weaponName == "Song Of Mana" || weaponName == "SONG") return std::make_unique<SongOfMana>();

    if (weaponName == "Phiera Der Tuphello" || weaponName == "GUNS1") return std::make_unique<PhieraDerTuphello>();
    if (weaponName == "Eight The Sparrow" || weaponName == "GUNS2") return std::make_unique<EightTheSparrow>();

    // ponytail: fallback existing weapon mechanics used for unbuilt projectile logic and evolutions; upgrade when standalone weapon classes are added
    if (weaponName == "GUNS3" || weaponName == "PHIERAGGI") return std::make_unique<MagicWand>();
    if (weaponName == "MANNAJA") return std::make_unique<Garlic>();
    if (weaponName == "TRAPANO" || weaponName == "TRAPANO2") return std::make_unique<Knife>();
    if (weaponName == "CART" || weaponName == "CART2" || weaponName == "FLOWER" || weaponName == "STIGRANGATTI") return std::make_unique<Runetracer>();
    
    return nullptr;
}
