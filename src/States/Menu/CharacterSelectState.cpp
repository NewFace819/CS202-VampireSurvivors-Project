#include "States/Menu/CharacterSelectState.h"
#include "States/Menu/StageSelectState.h"
#include "Core/GameManager.h"
#include <iostream>
#include <algorithm>

CharacterSelectState::CharacterSelectState(GameManager* manager) : m_manager(manager) {
    if (!m_font.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "CharacterSelectState: Could not load font!\n";
    }
    if (!m_boldFont.loadFromFile("assets/fonts/Courier_HintedSmooth.ttf")) {
        std::cerr << "CharacterSelectState: Could not load bold font!\n";
    }

    if (!m_uiAtlas.loadFromFile("assets/Graphics/Spritesheets/UI.png", "assets/Data/ui_atlas.json", true)) {
        std::cerr << "CharacterSelectState: Could not load UI atlas!\n";
    }
    
    if (!m_illustAtlas.loadFromFile("assets/Graphics/Spritesheets/illustrations.png", "assets/Data/illustration_atlas.json", true)) {
        std::cerr << "CharacterSelectState: Could not load illustration atlas!\n";
    }

    if (!m_itemsAtlas.loadFromFile("assets/Graphics/Spritesheets/items.png", "assets/Data/items_atlas.json", true)) {
        std::cerr << "CharacterSelectState: Could not load items atlas!\n";
    }

    // Load data managers
    m_characterData.LoadData("assets/Data/CHARACTER_DATA.json");
    m_weaponData.LoadData("assets/Data/WEAPON_DATA.json");
    m_powerUpData.LoadFromJson("assets/Data/POWERUP_DATA.json");
    
    if (!m_progressionData.Load("save_data.json")) {
        m_progressionData.InitializeUnlockedCharacters(m_characterData.GetAllCharacters());
    }
    
    m_view = std::make_unique<CharacterSelectionView>(
        m_uiAtlas, 
        m_font, 
        &m_boldFont,
        m_characterData, 
        &m_progressionData,
        &m_weaponData,
        &m_powerUpData,
        &m_itemsAtlas
    );

    float width = m_manager->getWindow().getSize().x;
    float height = m_manager->getWindow().getSize().y;
    m_view->InitializeLayout(sf::Vector2f(width, height));

    m_view->SetOnBackClicked([this]() {
        m_manager->popState();
    });

    m_view->SetOnConfirmClicked([this](const std::vector<std::string>& characterIds) {
        if (characterIds.empty()) return;
        std::cout << "Starting game with characters: ";
        for (const auto& id : characterIds) std::cout << id << " ";
        std::cout << std::endl;
        
        auto parseCharacterType = [](const std::string& charId) -> CharacterType {
            if (charId == "IMELDA") return CharacterType::Imelda;
            if (charId == "PASQUALINA") return CharacterType::Pasqualina;
            if (charId == "GENNARO") return CharacterType::Gennaro;
            if (charId == "ARCA") return CharacterType::Arca;
            if (charId == "PORTA") return CharacterType::Porta;
            if (charId == "LAMA") return CharacterType::Lama;
            if (charId == "CAMILLO" || charId == "POE") return CharacterType::Poe;
            if (charId == "GERMANA" || charId == "CLERICI") return CharacterType::Clerici;
            if (charId == "DOMMARIO") return CharacterType::Dommario;
            if (charId == "CROCI" || charId == "KROCHI") return CharacterType::Krochi;
            if (charId == "CRISTINA" || charId == "CHRISTINE") return CharacterType::Christine;
            if (charId == "PUGNALA") return CharacterType::Pugnala;
            if (charId == "GIOVANNA") return CharacterType::Giovanna;
            if (charId == "POPPEA") return CharacterType::Poppea;
            if (charId == "CONCETTA") return CharacterType::Concetta;
            if (charId == "MORTACCIO") return CharacterType::Mortaccio;
            if (charId == "CAVALLO") return CharacterType::Cavallo;
            if (charId == "MARIA" || charId == "BIANCA_RAMBA") return CharacterType::Ramba;
            if (charId == "TATANKA" || charId == "O_SOLE") return CharacterType::OSole;
            if (charId == "AMBROGIO" || charId == "AMBROJOE") return CharacterType::Ambrojoe;
            if (charId == "PINO" || charId == "IGANA_GALLO" || charId == "GALLO") return CharacterType::Gallo;
            if (charId == "FEBBRA" || charId == "DIVANO") return CharacterType::Divano;
            if (charId == "ASSUNTA" || charId == "ZI_ASSUNTA") return CharacterType::ZiAssunta;
            if (charId == "EXDASH") return CharacterType::Exdash;
            if (charId == "PANINI" || charId == "TOASTY" || charId == "TOASTIE") return CharacterType::Toasty;
            if (charId == "SMITH" || charId == "SMITH_IV") return CharacterType::Smith;
            if (charId == "ARENGIJUS" || charId == "RANDOM") return CharacterType::Random;
            if (charId == "GRAZIELLA" || charId == "MINNAH") return CharacterType::Minnah;
            if (charId == "VERANDA" || charId == "LEDA") return CharacterType::Leda;
            if (charId == "PAVONE" || charId == "COSMO") return CharacterType::Cosmo;
            if (charId == "PEPPINO") return CharacterType::Peppino;
            if (charId == "PANTALONE" || charId == "BIG_TROUSERS" || charId == "BIG_TROUSER" || charId == "TROUSER") return CharacterType::BigTrouser;
            if (charId == "FINO" || charId == "MISSINGNO" || charId == "MISSINGN0") return CharacterType::MissingN0;
            if (charId == "BOROS" || charId == "GAINS") return CharacterType::Gains;
            if (charId == "DRAGOGION" || charId == "GYORUNTON") return CharacterType::Gyorunton;
            if (charId == "NEO" || charId == "MARRABBIO") return CharacterType::Marrabbio;
            if (charId == "AVATAR") return CharacterType::Avatar;
            if (charId == "NOSTRO" || charId == "RED_DEATH" || charId == "RED") return CharacterType::RedDeath;
            if (charId == "SIGMA") return CharacterType::Sigma;
            if (charId == "TUPU" || charId == "ROBBERT") return CharacterType::Robbert;
            if (charId == "EX_ZIAPPUNTA" || charId == "ZIAPPUNTA") return CharacterType::ZiAppunta;
            if (charId == "SHEMOONITA" || charId == "SHEMOON" || charId == "SHE_MOON") return CharacterType::SheMoon;
            if (charId == "SANTA") return CharacterType::Santa;
            if (charId == "YOLO" || charId == "GAZEBO") return CharacterType::Gazebo;
            if (charId == "EX_CHULAREH" || charId == "CHULAREH" || charId == "CHULA_REH") return CharacterType::ChulaReh;
            if (charId == "SPACEDUDE" || charId == "SPACE_DUDE" || charId == "SPACE") return CharacterType::SpaceDude;
            if (charId == "BATSBATSBATS" || charId == "BATS" || charId == "BAT_BAT") return CharacterType::BatsBatsBats;
            if (charId == "ROSE") return CharacterType::Rose;
            if (charId == "TORINO") return CharacterType::Torino;
            if (charId == "SCOREJ" || charId == "SCOREJ_ONI" || charId == "SCOREJ-ONI") return CharacterType::ScorejOni;
            if (charId == "GYORUNTIN") return CharacterType::Gyoruntin;
            if (charId == "EX_GIOCARE" || charId == "SECRETINO") return CharacterType::Secretino;
            if (charId == "SPACEDUDETTE" || charId == "SPACE_DETTE" || charId == "SPACEDETTE") return CharacterType::SpaceDette;
            return CharacterType::Antonio;
        };

        std::vector<CharacterType> selectedTypes;
        for (const auto& id : characterIds) {
            selectedTypes.push_back(parseCharacterType(id));
        }

        m_manager->changeState(std::make_unique<StageSelectState>(m_manager, selectedTypes));
    });

    for (int i = 0; i < 3; ++i) {
        sf::Sprite sprite;
        std::string key = "illustrations_" + std::to_string(i);
        AssetTextureData data = m_illustAtlas.GetTextureData(key);
        if (data.texture) {
            sprite.setTexture(*data.texture);
            sprite.setTextureRect(data.rect);
            sprite.setOrigin(data.rect.width / 2.0f, data.rect.height / 2.0f);
        }
        
        sf::Color c = sprite.getColor();
        if (i == 1) c.a = 90;
        else if (i == 2) c.a = 150;
        sprite.setColor(c);
        
        m_illustrations.push_back(sprite);
    }

    float textureGap = width / 3.0f;
    if (m_illustrations.size() == 3) {
        m_illustrations[0].setPosition(width / 2.0f, height / 2.0f + 280.0f);
        m_illustrations[0].setScale(2.5f, 2.5f);
        
        m_illustrations[1].setPosition(width / 2.0f - textureGap, height / 2.0f + 230.0f);
        m_illustrations[1].setScale(4.9f, 4.9f);
        
        m_illustrations[2].setPosition(width / 2.0f + textureGap, height / 2.0f);
        m_illustrations[2].setScale(-3.0f, 3.0f);
    }

    m_topBarBg.setSize(sf::Vector2f(width, 99.0f));
    m_topBarBg.setPosition(0.0f, 0.0f);
    m_topBarBg.setFillColor(sf::Color(0, 0, 0, 130));

    SetupCompositeBackground();
}

void CharacterSelectState::SetupCompositeBackground() {
    float width = m_manager->getWindow().getSize().x;
    float height = m_manager->getWindow().getSize().y;
    
    m_compositeTexture.create(width, height);
    m_compositeTexture.clear(sf::Color::Black);

    sf::Texture bgTex;
    if (bgTex.loadFromFile("assets/Graphics/Backgrounds/introBG_0.png")) {
        sf::Sprite bgSprite(bgTex);
        bgSprite.setOrigin(bgTex.getSize().x / 2.0f, bgTex.getSize().y / 2.0f);
        bgSprite.setPosition(width / 2.0f, height / 2.0f);

        float scaleX = width / static_cast<float>(bgTex.getSize().x);
        float scaleY = height / static_cast<float>(bgTex.getSize().y);
        float scale = std::max(scaleX, scaleY);
        bgSprite.setScale(scale, scale);

        m_compositeTexture.draw(bgSprite);
    }

    sf::Texture titleTex;
    if (titleTex.loadFromFile("assets/Graphics/Backgrounds/title.png")) {
        sf::Sprite titleSprite(titleTex);
        titleSprite.setOrigin(titleTex.getSize().x / 2.0f, titleTex.getSize().y / 2.0f);
        titleSprite.setPosition(width / 2.0f, height / 2.0f - 216.f);
        titleSprite.setScale(1.8f, 1.8f);
        m_compositeTexture.draw(titleSprite);
    }

    m_compositeTexture.display();
    m_compositeSprite.setTexture(m_compositeTexture.getTexture());
}

void CharacterSelectState::enter() {
}

void CharacterSelectState::handleEvent(const sf::Event& event, sf::RenderWindow& window) {
    if(m_view) m_view->HandleEvent(event, window);
}

void CharacterSelectState::update(float dt) {
    if(m_view) m_view->Update(dt);
}

void CharacterSelectState::draw(sf::RenderWindow& window) {
    window.clear(sf::Color::Black);
    window.draw(m_compositeSprite);

    for (const auto& sprite : m_illustrations) {
        window.draw(sprite);
    }

    window.draw(m_topBarBg);

    if(m_view) {
        m_view->Draw(window);
    }
}

void CharacterSelectState::exit() {
}
