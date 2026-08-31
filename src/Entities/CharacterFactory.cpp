#include "Entities/CharacterFactory.h"
#include "States/Game/PlayingState.h"
#include <iostream>
#include <fstream>
#include <nlohmann/json.hpp>

namespace {
    std::vector<sf::IntRect> getFramesFromAtlas(const std::string& name) {
        static nlohmann::json charAtlas;
        static bool loaded = false;
        if (!loaded) {
            std::ifstream atlasFile("assets/data/characters_atlas.json");
            if (atlasFile.is_open()) {
                atlasFile >> charAtlas;
                atlasFile.close();
            } else {
                std::cerr << "CharacterFactory: Could not open assets/Data/characters_atlas.json\n";
            }
            loaded = true;
        }

        std::vector<sf::IntRect> frames;
        if (charAtlas.contains(name) && charAtlas[name].contains("frames")) {
            for (const auto& f : charAtlas[name]["frames"]) {
                frames.push_back(sf::IntRect(f["x"], f["y"], f["width"], f["height"]));
            }
        }
        return frames;
    }

    std::vector<sf::IntRect> getIndividualCharFrames(const std::string& texPath, const std::string& atlasPath, const std::string& prefix, int frameCount) {
        std::vector<sf::IntRect> frames;
        sf::Texture tempTex;
        if (!tempTex.loadFromFile(texPath)) return frames;
        int texHeight = static_cast<int>(tempTex.getSize().y);
        std::ifstream atlasFile(atlasPath);
        if (atlasFile.is_open()) {
            try {
                nlohmann::json json;
                atlasFile >> json;
                for (int i = 1; i <= frameCount; ++i) {
                    std::string numStr = (i < 10 ? "0" : "") + std::to_string(i);
                    std::string key = prefix + "_" + numStr;
                    auto it = json.find(key);
                    if (it == json.end()) it = json.find(prefix + "_i" + numStr);
                    if (it == json.end()) it = json.find(prefix + numStr);
                    if (it == json.end()) it = json.find(prefix + "_" + std::to_string(i));
                    if (it != json.end()) {
                        int x = it->value("x", 0);
                        int y = it->value("y", 0);
                        int w = it->value("width", 32);
                        int h = it->value("height", 32);
                        int y_sfml = texHeight - y - h;
                        frames.push_back(sf::IntRect(x, y_sfml, w, h));
                    }
                }
            } catch (...) {}
        }
        return frames;
    }
}

void CharacterFactory::configurePlayer(Player& player, CharacterType type, std::vector<std::string>& outStartingWeapons) {
    outStartingWeapons.clear();

    switch (type) {
        case CharacterType::Antonio:
            player.setSprite("assets/Graphics/Characters/characters.png", getFramesFromAtlas("Antonio"));
            outStartingWeapons.push_back("Whip");
            break;
        case CharacterType::Imelda:
            player.setSprite("assets/Graphics/Characters/characters.png", getFramesFromAtlas("Imelda"));
            outStartingWeapons.push_back("Magic Wand");
            break;
        case CharacterType::Gennaro:
            player.setSprite("assets/Graphics/Characters/characters.png", getFramesFromAtlas("Gennaro"));
            outStartingWeapons.push_back("Knife");
            break;
        case CharacterType::Arca:
            player.setSprite("assets/Graphics/Characters/characters.png", getFramesFromAtlas("Arca"));
            outStartingWeapons.push_back("Fire Wand");
            break;
        case CharacterType::Lama:
            player.setSprite("assets/Graphics/Characters/characters.png", getFramesFromAtlas("Lama"));
            outStartingWeapons.push_back("Axe");
            break;
        case CharacterType::Pasqualina:
            player.setSprite("assets/Graphics/Characters/character_pasqualina.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_pasqualina.png", "assets/data/CharacterAtlas/character_pasqualina_atlas.json", "Pasqualina", 4));
            outStartingWeapons.push_back("Runetracer");
            break;
        case CharacterType::Porta:
            player.setSprite("assets/Graphics/Characters/character_porta.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_porta.png", "assets/data/CharacterAtlas/character_porta_atlas.json", "Porta", 4));
            outStartingWeapons.push_back("Lightning Ring");
            break;
        case CharacterType::Poe:
            player.setSprite("assets/Graphics/Characters/character_poe.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_poe.png", "assets/data/CharacterAtlas/character_poe_atlas.json", "Old3", 4));
            outStartingWeapons.push_back("Garlic");
            break;
        case CharacterType::Clerici:
            player.setSprite("assets/Graphics/Characters/character_suora.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_suora.png", "assets/data/CharacterAtlas/character_suora_atlas.json", "Suora", 4));
            outStartingWeapons.push_back("Santa Water");
            break;
        case CharacterType::Dommario:
            player.setSprite("assets/Graphics/Characters/character_dommario.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_dommario.png", "assets/data/CharacterAtlas/character_dommario_atlas.json", "Dommario", 4));
            outStartingWeapons.push_back("King Bible");
            break;
        case CharacterType::Krochi:
            player.setSprite("assets/Graphics/Characters/character_krochi.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_krochi.png", "assets/data/CharacterAtlas/character_krochi_atlas.json", "Krochi", 4));
            outStartingWeapons.push_back("Cross");
            break;
        case CharacterType::Christine:
            player.setSprite("assets/Graphics/Characters/character_christine.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_christine.png", "assets/data/CharacterAtlas/character_christine_atlas.json", "Christine", 4));
            outStartingWeapons.push_back("PENTAGRAM");
            break;
        case CharacterType::Pugnala:
            player.setSprite("assets/Graphics/Characters/character_pugnala.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_pugnala.png", "assets/data/CharacterAtlas/character_pugnala_atlas.json", "Pugnala", 4));
            outStartingWeapons.push_back("GUNS");
            break;
        case CharacterType::Giovanna:
            player.setSprite("assets/Graphics/Characters/character_giovanna.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_giovanna.png", "assets/data/CharacterAtlas/character_giovanna_atlas.json", "Giovanna", 5));
            outStartingWeapons.push_back("GATTI");
            break;
        case CharacterType::Poppea:
            player.setSprite("assets/Graphics/Characters/character_poppea.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_poppea.png", "assets/data/CharacterAtlas/character_poppea_atlas.json", "Poppea", 4));
            outStartingWeapons.push_back("SONG");
            break;
        case CharacterType::Concetta:
            player.setSprite("assets/Graphics/Characters/character_concetta.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_concetta.png", "assets/data/CharacterAtlas/character_concetta_atlas.json", "Concetta", 4));
            outStartingWeapons.push_back("TRAPANO");
            break;
        case CharacterType::Mortaccio:
            player.setSprite("assets/Graphics/Characters/character_mortaccio.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_mortaccio.png", "assets/data/CharacterAtlas/character_mortaccio_atlas.json", "Mortaccio", 4));
            outStartingWeapons.push_back("BONE");
            break;
        case CharacterType::Cavallo:
            player.setSprite("assets/Graphics/Characters/character_cavallo.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_cavallo.png", "assets/data/CharacterAtlas/character_cavallo_atlas.json", "Cavallo", 4));
            outStartingWeapons.push_back("CHERRY");
            break;
        case CharacterType::Ramba:
            player.setSprite("assets/Graphics/Characters/character_ramba.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_ramba.png", "assets/data/CharacterAtlas/character_ramba_atlas.json", "Ramba", 4));
            outStartingWeapons.push_back("CART2");
            break;
        case CharacterType::OSole:
            player.setSprite("assets/Graphics/Characters/character_osole.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_osole.png", "assets/data/CharacterAtlas/character_osole_atlas.json", "Dog", 5));
            outStartingWeapons.push_back("FLOWER");
            break;
        case CharacterType::Ambrojoe:
            player.setSprite("assets/Graphics/Characters/character_ambrojoe.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_ambrojoe.png", "assets/data/CharacterAtlas/character_ambrojoe_atlas.json", "Hat", 4));
            outStartingWeapons.push_back("ROBBA");
            break;
        case CharacterType::Gallo:
            player.setSprite("assets/Graphics/Characters/character_gallo.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_gallo.png", "assets/data/CharacterAtlas/character_gallo_atlas.json", "Gallo", 4));
            outStartingWeapons.push_back("LANCET");
            break;
        case CharacterType::Divano:
            player.setSprite("assets/Graphics/Characters/character_divano.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_divano.png", "assets/data/CharacterAtlas/character_divano_atlas.json", "Divano", 4));
            outStartingWeapons.push_back("LAUREL");
            break;
        case CharacterType::ZiAssunta:
            player.setSprite("assets/Graphics/Characters/character_assunta.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_assunta.png", "assets/data/CharacterAtlas/character_assunta_atlas.json", "Assunta", 4));
            outStartingWeapons.push_back("VENTO");
            break;
        case CharacterType::Exdash:
            player.setSprite("assets/Graphics/Characters/character_exdash.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_exdash.png", "assets/data/CharacterAtlas/character_exdash_atlas.json", "Exdash", 6));
            outStartingWeapons.push_back("SILF2");
            break;
        case CharacterType::Toasty:
            player.setSprite("assets/Graphics/Characters/character_panini.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_panini.png", "assets/data/CharacterAtlas/character_panini_atlas.json", "uExdash", 6));
            outStartingWeapons.push_back("SILF");
            break;
        case CharacterType::Smith:
            player.setSprite("assets/Graphics/Characters/character_smith.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_smith.png", "assets/data/CharacterAtlas/character_smith_atlas.json", "nExdash", 6));
            outStartingWeapons.push_back("SILF3");
            break;
        case CharacterType::Random:
            player.setSprite("assets/Graphics/Characters/character_random.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_random.png", "assets/data/CharacterAtlas/character_random_atlas.json", "random", 30));
            outStartingWeapons.push_back("VOID");
            break;
        case CharacterType::Minnah:
            player.setSprite("assets/Graphics/Characters/character_minnah.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_minnah.png", "assets/data/CharacterAtlas/character_minnah_atlas.json", "Minnah", 4));
            outStartingWeapons.push_back("VAMPIRICA");
            break;
        case CharacterType::Leda:
            player.setSprite("assets/Graphics/Characters/character_leda.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_leda.png", "assets/data/CharacterAtlas/character_leda_atlas.json", "XLLeda", 4));
            outStartingWeapons.push_back("HOLY_MISSILE");
            break;
        case CharacterType::Cosmo:
            player.setSprite("assets/Graphics/Characters/character_cosmo.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_cosmo.png", "assets/data/CharacterAtlas/character_cosmo_atlas.json", "Cosmic", 4));
            outStartingWeapons.push_back("VOID");
            break;
        case CharacterType::Peppino:
            player.setSprite("assets/Graphics/Characters/character_peppino.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_peppino.png", "assets/data/CharacterAtlas/character_peppino_atlas.json", "Peppino", 1));
            outStartingWeapons.push_back("VORTEX");
            break;
        case CharacterType::BigTrouser:
            player.setSprite("assets/Graphics/Characters/character_trouser.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_trouser.png", "assets/data/CharacterAtlas/character_trouser_atlas.json", "Pantalone", 4));
            outStartingWeapons.push_back("CANDYBOX");
            break;
        case CharacterType::MissingN0:
            player.setSprite("assets/Graphics/Characters/character_missing.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_missing.png", "assets/data/CharacterAtlas/character_missing_atlas.json", "_0x00000000", 4));
            outStartingWeapons.push_back("VOID");
            break;
        case CharacterType::Gains:
            player.setSprite("assets/Graphics/Characters/character_boros.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_boros.png", "assets/data/CharacterAtlas/character_boros_atlas.json", "Gains", 5));
            outStartingWeapons.push_back("HEAVENSWORD");
            break;
        case CharacterType::Gyorunton:
            player.setSprite("assets/Graphics/Characters/character_dragogion.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_dragogion.png", "assets/data/CharacterAtlas/character_dragogion_atlas.json", "Dragogion", 4));
            outStartingWeapons.push_back("TRIASSO1");
            break;
        case CharacterType::Sigma:
            player.setSprite("assets/Graphics/Characters/characters.png", getFramesFromAtlas("Sigma"));
            outStartingWeapons = {
                "Whip", "Magic Wand", "Knife", "Fire Wand", "Axe", "Cross", 
                "Garlic", "King Bible", "Santa Water", "Runetracer", "Lightning Ring", 
                "Bone", "Cherry Bomb", "Song Of Mana", "GUNS1", "GUNS2"
            };
            break;
        case CharacterType::Marrabbio:
            player.setSprite("assets/Graphics/Characters/character_marrabbio.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_marrabbio.png", "assets/data/CharacterAtlas/character_marrabbio_atlas.json", "Marrabbio", 4));
            outStartingWeapons.push_back("THOUSAND");
            break;
        case CharacterType::Avatar:
            player.setSprite("assets/Graphics/Characters/character_avatar.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_avatar.png", "assets/data/CharacterAtlas/character_avatar_atlas.json", "v", 4));
            outStartingWeapons.push_back("MISSPELL");
            break;
        case CharacterType::RedDeath:
            player.setSprite("assets/Graphics/Characters/character_reddeath.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_reddeath.png", "assets/data/CharacterAtlas/character_reddeath_atlas.json", "newXLReaper", 5));
            outStartingWeapons.push_back("SCYTHE");
            break;
        case CharacterType::Robbert:
            player.setSprite("assets/Graphics/Characters/character_robbert.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_robbert.png", "assets/data/CharacterAtlas/character_robbert_atlas.json", "Robert", 5));
            outStartingWeapons.push_back("BATTILIA");
            break;
        case CharacterType::ZiAppunta:
            player.setSprite("assets/Graphics/Characters/character_ziappunta.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_ziappunta.png", "assets/data/CharacterAtlas/character_ziappunta_atlas.json", "player_ziappunta", 4));
            outStartingWeapons.push_back("EX_AMMO1");
            break;
        case CharacterType::SheMoon:
            player.setSprite("assets/Graphics/Characters/character_shemoon.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_shemoon.png", "assets/data/CharacterAtlas/character_shemoon_atlas.json", "Sheemonita", 5));
            outStartingWeapons.push_back("ICELANCE");
            break;
        case CharacterType::Santa:
            player.setSprite("assets/Graphics/Characters/character_santa.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_santa.png", "assets/data/CharacterAtlas/character_santa_atlas.json", "Santa", 4));
            outStartingWeapons.push_back("SANTAJAVELIN");
            break;
        case CharacterType::Gazebo:
            player.setSprite("assets/Graphics/Characters/character_gazebo.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_gazebo.png", "assets/data/CharacterAtlas/character_gazebo_atlas.json", "Gazebo", 4));
            outStartingWeapons.push_back("EX_GAEA1");
            break;
        case CharacterType::ChulaReh:
            player.setSprite("assets/Graphics/Characters/character_chulareh.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_chulareh.png", "assets/data/CharacterAtlas/character_chulareh_atlas.json", "chulareh", 4));
            outStartingWeapons.push_back("EX_MAGISTONE1");
            break;
        case CharacterType::SpaceDude:
            player.setSprite("assets/Graphics/Characters/character_spacedude.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_spacedude.png", "assets/data/CharacterAtlas/character_spacedude_atlas.json", "xSpaceDude", 4));
            outStartingWeapons.push_back("PHASER");
            break;
        case CharacterType::BatsBatsBats:
            player.setSprite("assets/Graphics/Characters/character_batsbatsbats.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_batsbatsbats.png", "assets/data/CharacterAtlas/character_batsbatsbats_atlas.json", "bbbats", 4));
            outStartingWeapons.push_back("BATTILIA2");
            break;
        case CharacterType::Rose:
            player.setSprite("assets/Graphics/Characters/character_rose.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_rose.png", "assets/data/CharacterAtlas/character_rose_atlas.json", "xRose", 4));
            outStartingWeapons.push_back("VENTO2");
            break;
        case CharacterType::Torino:
            player.setSprite("assets/Graphics/Characters/character_torino.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_torino.png", "assets/data/CharacterAtlas/character_torino_atlas.json", "Torino", 4));
            outStartingWeapons.push_back("VOID");
            break;
        case CharacterType::ScorejOni:
            player.setSprite("assets/Graphics/Characters/character_scorej.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_scorej.png", "assets/data/CharacterAtlas/character_scorej_atlas.json", "Scorej", 4));
            outStartingWeapons.push_back("VOID");
            outStartingWeapons.push_back("LIGHTNING");
            break;
        case CharacterType::Gyoruntin:
            player.setSprite("assets/Graphics/Characters/character_gyoruntin.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_gyoruntin.png", "assets/data/CharacterAtlas/character_gyoruntin_atlas.json", "Gyoruntin", 5));
            outStartingWeapons.push_back("ROCHER");
            break;
        case CharacterType::Secretino:
            player.setSprite("assets/Graphics/Characters/character_secretino.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_secretino.png", "assets/data/CharacterAtlas/character_secretino_atlas.json", "secretino", 4));
            outStartingWeapons.push_back("EX_MAGISTONE2");
            break;
        case CharacterType::SpaceDette:
            player.setSprite("assets/Graphics/Characters/character_spacedette.png", 
                              getIndividualCharFrames("assets/Graphics/Characters/character_spacedette.png", "assets/data/CharacterAtlas/character_spacedette_atlas.json", "SDette", 4));
            outStartingWeapons.push_back("PHASER2");
            break;
        default:
            player.setSprite("assets/Graphics/Characters/characters.png", getFramesFromAtlas("Antonio"));
            outStartingWeapons.push_back("Whip");
            break;
    }
}
