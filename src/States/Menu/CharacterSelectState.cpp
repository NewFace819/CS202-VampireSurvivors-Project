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
        
        CharacterType type = CharacterType::Antonio;
        if (characterIds.front() == "IMELDA") type = CharacterType::Imelda;
        else if (characterIds.front() == "PASQUALINA") type = CharacterType::Pasqualina;
        else if (characterIds.front() == "GENNARO") type = CharacterType::Gennaro;
        else if (characterIds.front() == "ARCA") type = CharacterType::Arca;
        else if (characterIds.front() == "PORTA") type = CharacterType::Porta;
        else if (characterIds.front() == "LAMA") type = CharacterType::Lama;
        else if (characterIds.front() == "CAMILLO" || characterIds.front() == "POE") type = CharacterType::Poe;
        else if (characterIds.front() == "GERMANA" || characterIds.front() == "CLERICI") type = CharacterType::Clerici;
        else if (characterIds.front() == "DOMMARIO") type = CharacterType::Dommario;
        else if (characterIds.front() == "CROCI" || characterIds.front() == "KROCHI") type = CharacterType::Krochi;
        else if (characterIds.front() == "CRISTINA" || characterIds.front() == "CHRISTINE") type = CharacterType::Christine;
        else if (characterIds.front() == "PUGNALA") type = CharacterType::Pugnala;
        else if (characterIds.front() == "GIOVANNA") type = CharacterType::Giovanna;
        else if (characterIds.front() == "POPPEA") type = CharacterType::Poppea;
        else if (characterIds.front() == "CONCETTA") type = CharacterType::Concetta;
        else if (characterIds.front() == "MORTACCIO") type = CharacterType::Mortaccio;
        else if (characterIds.front() == "CAVALLO") type = CharacterType::Cavallo;
        else if (characterIds.front() == "MARIA" || characterIds.front() == "BIANCA_RAMBA") type = CharacterType::Ramba;
        else if (characterIds.front() == "TATANKA" || characterIds.front() == "O_SOLE") type = CharacterType::OSole;
        else if (characterIds.front() == "AMBROGIO" || characterIds.front() == "AMBROJOE") type = CharacterType::Ambrojoe;
        else if (characterIds.front() == "PINO" || characterIds.front() == "IGANA_GALLO" || characterIds.front() == "GALLO") type = CharacterType::Gallo;
        else if (characterIds.front() == "FEBBRA" || characterIds.front() == "DIVANO") type = CharacterType::Divano;
        else if (characterIds.front() == "ASSUNTA" || characterIds.front() == "ZI_ASSUNTA") type = CharacterType::ZiAssunta;
        else if (characterIds.front() == "EXDASH") type = CharacterType::Exdash;
        else if (characterIds.front() == "PANINI" || characterIds.front() == "TOASTY" || characterIds.front() == "TOASTIE") type = CharacterType::Toasty;
        else if (characterIds.front() == "SMITH" || characterIds.front() == "SMITH_IV") type = CharacterType::Smith;
        else if (characterIds.front() == "ARENGIJUS" || characterIds.front() == "RANDOM") type = CharacterType::Random;
        else if (characterIds.front() == "GRAZIELLA" || characterIds.front() == "MINNAH") type = CharacterType::Minnah;
        else if (characterIds.front() == "VERANDA" || characterIds.front() == "LEDA") type = CharacterType::Leda;
        else if (characterIds.front() == "PAVONE" || characterIds.front() == "COSMO") type = CharacterType::Cosmo;
        else if (characterIds.front() == "PEPPINO") type = CharacterType::Peppino;
        else if (characterIds.front() == "PANTALONE" || characterIds.front() == "BIG_TROUSERS" || characterIds.front() == "BIG_TROUSER" || characterIds.front() == "TROUSER") type = CharacterType::BigTrouser;
        else if (characterIds.front() == "FINO" || characterIds.front() == "MISSINGNO" || characterIds.front() == "MISSINGN0") type = CharacterType::MissingN0;
        else if (characterIds.front() == "BOROS" || characterIds.front() == "GAINS") type = CharacterType::Gains;
        else if (characterIds.front() == "DRAGOGION" || characterIds.front() == "GYORUNTON") type = CharacterType::Gyorunton;
        else if (characterIds.front() == "NEO" || characterIds.front() == "MARRABBIO") type = CharacterType::Marrabbio;
        else if (characterIds.front() == "AVATAR") type = CharacterType::Avatar;
        else if (characterIds.front() == "NOSTRO" || characterIds.front() == "RED_DEATH" || characterIds.front() == "RED") type = CharacterType::RedDeath;
        else if (characterIds.front() == "SIGMA") type = CharacterType::Sigma;
        else if (characterIds.front() == "TUPU" || characterIds.front() == "ROBBERT") type = CharacterType::Robbert;
        else if (characterIds.front() == "EX_ZIAPPUNTA" || characterIds.front() == "ZIAPPUNTA") type = CharacterType::ZiAppunta;
        else if (characterIds.front() == "SHEMOONITA" || characterIds.front() == "SHEMOON" || characterIds.front() == "SHE_MOON") type = CharacterType::SheMoon;
        else if (characterIds.front() == "SANTA") type = CharacterType::Santa;
        else if (characterIds.front() == "YOLO" || characterIds.front() == "GAZEBO") type = CharacterType::Gazebo;
        else if (characterIds.front() == "EX_CHULAREH" || characterIds.front() == "CHULAREH" || characterIds.front() == "CHULA_REH") type = CharacterType::ChulaReh;
        else if (characterIds.front() == "SPACEDUDE" || characterIds.front() == "SPACE_DUDE" || characterIds.front() == "SPACE") type = CharacterType::SpaceDude;
        else if (characterIds.front() == "BATSBATSBATS" || characterIds.front() == "BATS" || characterIds.front() == "BAT_BAT") type = CharacterType::BatsBatsBats;
        else if (characterIds.front() == "ROSE") type = CharacterType::Rose;
        else if (characterIds.front() == "TORINO") type = CharacterType::Torino;
        else if (characterIds.front() == "SCOREJ" || characterIds.front() == "SCOREJ_ONI" || characterIds.front() == "SCOREJ-ONI") type = CharacterType::ScorejOni;
        else if (characterIds.front() == "GYORUNTIN") type = CharacterType::Gyoruntin;

        m_manager->changeState(std::make_unique<StageSelectState>(m_manager, type));
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
