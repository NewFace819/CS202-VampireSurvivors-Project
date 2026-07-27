#pragma once
#include "States/Game/GameState.h"
#include <SFML/Graphics.hpp>
#include <vector>
#include <memory>

#include "UI/Views/CharacterSelectionView.h"
#include "Core/Data/CharacterDataManager.h"
#include "Core/Data/WeaponDataManager.h"
#include "Core/Data/PowerUpDataManager.h"
#include "Core/Data/PlayerProgressionManager.h"
#include "Core/Resources/TextureAtlas.h"

class GameManager;

class CharacterSelectState : public GameState {
public:
    CharacterSelectState(GameManager* manager);
    void enter() override;
    void update(float dt) override;
    void draw(sf::RenderWindow& window) override;
    void exit() override;
    void handleEvent(const sf::Event& event, sf::RenderWindow& window) override;

private:
    void SetupCompositeBackground();

    GameManager* m_manager;
    sf::Font m_font;
    sf::Font m_boldFont;
    
    CharacterDataManager m_characterData;
    WeaponDataManager m_weaponData;
    PowerUpDataManager m_powerUpData;
    PlayerProgressionManager m_progressionData;
    
    TextureAtlas m_uiAtlas;
    TextureAtlas m_illustAtlas;
    TextureAtlas m_itemsAtlas;  // items atlas for stat icons
    
    std::unique_ptr<CharacterSelectionView> m_view;
    
    sf::RenderTexture m_compositeTexture;
    sf::Sprite m_compositeSprite;
    std::vector<sf::Sprite> m_illustrations;
    sf::RectangleShape m_topBarBg;
};
