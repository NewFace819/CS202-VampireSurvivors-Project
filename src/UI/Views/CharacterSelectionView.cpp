#include "CharacterSelectionView.h"
#include "../Panels/MainBoardPanel.h"
#include "../Panels/RosterGridPanel.h"
#include "../Panels/DetailPanel.h"
#include "../Panels/StatsPanel.h"
#include "../Elements/GoldDisplayWidget.h"
#include "../Elements/UIButton.h"
#include "../../Core/Data/PlayerProgressionManager.h"
#include "../../Core/Data/CharacterDataManager.h"
#include "../../Core/Data/CharacterProfile.h"
#include "../../Core/Data/PowerUpDataManager.h"
#include "../Elements/UIPlayerCoopCard.h"
#include <SFML/Window/Event.hpp>
#include <SFML/Graphics/RenderWindow.hpp>

CharacterSelectionView::CharacterSelectionView(TextureAtlas& atlas, const sf::Font& font, const sf::Font* boldFont, const CharacterDataManager& characterData, PlayerProgressionManager* progressionManager, const WeaponDataManager* weaponManager, const PowerUpDataManager* powerUpManager, TextureAtlas* itemsAtlas)
    : m_mainBoard(std::make_unique<MainBoardPanel>(atlas, font, boldFont, itemsAtlas))
    , m_statsPanel(std::make_unique<StatsPanel>(atlas, font, itemsAtlas))
    , m_goldDisplay(std::make_unique<GoldDisplayWidget>(atlas, progressionManager, font))
    , m_confirmButton(std::make_unique<UIButton>(atlas, "button_c5_normal", 10, 10, 10, 10))
    , m_backButton(std::make_unique<UIButton>(atlas, "button_c8_normal", 10, 10, 10, 10))
    , m_enterCoopButton(std::make_unique<UIButton>(atlas, "button_c9_normal", 10, 10, 10, 10))
    , m_p1Card(std::make_unique<UIPlayerCoopCard>(atlas, font, boldFont, "Player 1"))
    , m_p2Card(std::make_unique<UIPlayerCoopCard>(atlas, font, boldFont, "Player 2"))
    , m_font(font)
{
    m_confirmButton->SetText("Confirm", font, 24);
    m_confirmButton->SetCornerScale(2.5f);
    m_backButton->SetText("BACK", font, 24);
    m_backButton->SetCornerScale(2.0f);
    
    m_enterCoopButton->SetText("Enter Co-op", font, 24);
    m_enterCoopButton->SetHoverTexture("button_c9_mouseover");
    m_enterCoopButton->SetPressTexture("button_c9_pressed");
    m_enterCoopButton->SetCornerScale(2.0f);
    
    // Load cursors for START state
    for (int i = 1; i <= 8; ++i) {
        AssetTextureData data = atlas.GetTextureData("arrow_0" + std::to_string(i));
        if (data.texture) m_cursorFrames.push_back(data);
    }
    if (!m_cursorFrames.empty()) {
        m_leftCursor.setTexture(*m_cursorFrames[0].texture);
        m_leftCursor.setTextureRect(m_cursorFrames[0].rect);
        m_rightCursor.setTexture(*m_cursorFrames[0].texture);
        m_rightCursor.setTextureRect(m_cursorFrames[0].rect);
        m_leftCursor.setOrigin(m_cursorFrames[0].rect.width / 2.0f, m_cursorFrames[0].rect.height / 2.0f);
        m_rightCursor.setOrigin(m_cursorFrames[0].rect.width / 2.0f, m_cursorFrames[0].rect.height / 2.0f);
        m_leftCursor.setScale(2.0f, 2.0f);
        m_rightCursor.setScale(-2.0f, 2.0f);
    }
    
    m_confirmButton->SetState(ButtonState::Disabled); // Initially disabled

    if(m_mainBoard && m_mainBoard->GetRosterGrid())
    {
        if(progressionManager)
        {
            m_mainBoard->GetRosterGrid()->InitializeRoster(characterData, *progressionManager, weaponManager);
        }
        
        m_mainBoard->GetRosterGrid()->SetOnSelectionChanged([this, &characterData, progressionManager, weaponManager, powerUpManager, &atlas](const std::string& characterId)
        {
            if (m_selectionState == SelectionState::ReadyToStart)
            {
                SetState(m_isCoopMode ? SelectionState::SelectingP2 : SelectionState::SelectingP1);
            }

            m_hoveredCharacterId = characterId;
            const CharacterProfile& profile = characterData.GetCharacterById(characterId);
            bool isUnlocked = (progressionManager && progressionManager->IsCharacterUnlocked(characterId));
            
            if(m_mainBoard->GetDetailPanel())
            {
                m_mainBoard->GetDetailPanel()->SetCharacterProfile(profile, weaponManager, isUnlocked);
            }

            if(m_statsPanel)
            {
                m_statsPanel->SetCharacterProfile(profile, progressionManager, powerUpManager);
            }

            if(isUnlocked)
            {
                if (m_selectionState == SelectionState::SelectingP1 || m_selectionState == SelectionState::SelectingP2)
                {
                    m_confirmButton->SetText("CONFIRM", m_font, 24);
                    m_confirmButton->SetState(ButtonState::Normal);
                }
                
                // Live update the co-op cards if hovering
                if (m_isCoopMode)
                {
                    if (m_selectionState == SelectionState::SelectingP1) m_p1Card->SetCharacterProfile(&profile, weaponManager, atlas);
                    else if (m_selectionState == SelectionState::SelectingP2) m_p2Card->SetCharacterProfile(&profile, weaponManager, atlas);
                }
            }
            else
            {
                m_confirmButton->SetText("BUY", m_font, 24);
                int gold = progressionManager ? progressionManager->GetGold() : 0;
                if (gold >= 500 && (m_selectionState == SelectionState::SelectingP1 || m_selectionState == SelectionState::SelectingP2)) {
                    m_confirmButton->SetState(ButtonState::Normal);
                } else {
                    m_confirmButton->SetState(ButtonState::Disabled);
                }
                
                // Clear the co-op cards if hovering a locked character
                if (m_isCoopMode)
                {
                    if (m_selectionState == SelectionState::SelectingP1) m_p1Card->SetCharacterProfile(nullptr, weaponManager, atlas);
                    else if (m_selectionState == SelectionState::SelectingP2) m_p2Card->SetCharacterProfile(nullptr, weaponManager, atlas);
                }
            }
        });
    }

    m_confirmButton->SetOnClickCallback([this, progressionManager, &characterData, weaponManager, powerUpManager, &atlas]()
    {
        if (m_selectionState == SelectionState::SelectingP1 || m_selectionState == SelectionState::SelectingP2)
        {
            if (progressionManager && !progressionManager->IsCharacterUnlocked(m_hoveredCharacterId))
            {
                if (progressionManager->GetGold() >= 500)
                {
                    progressionManager->SpendGold(500);
                    progressionManager->UnlockCharacter(m_hoveredCharacterId);
                    progressionManager->Save();

                    if (m_mainBoard && m_mainBoard->GetRosterGrid()) {
                        m_mainBoard->GetRosterGrid()->UnlockCard(m_hoveredCharacterId);
                    }

                    m_confirmButton->SetText("CONFIRM", m_font, 24);
                    
                    const CharacterProfile& profile = characterData.GetCharacterById(m_hoveredCharacterId);
                    if (m_mainBoard->GetDetailPanel()) {
                        m_mainBoard->GetDetailPanel()->SetCharacterProfile(profile, weaponManager, true);
                    }
                    if (m_isCoopMode) {
                        if (m_selectionState == SelectionState::SelectingP1) m_p1Card->SetCharacterProfile(&profile, weaponManager, atlas);
                        else if (m_selectionState == SelectionState::SelectingP2) m_p2Card->SetCharacterProfile(&profile, weaponManager, atlas);
                    }
                }
                return;
            }

            if (m_selectionState == SelectionState::SelectingP1)
            {
                m_p1CharacterId = m_hoveredCharacterId;
                m_p1Card->SetSelected(true);
                
                if (m_isCoopMode)
                {
                    SetState(SelectionState::SelectingP2);
                    if(m_mainBoard && m_mainBoard->GetRosterGrid())
                    {
                        m_mainBoard->GetRosterGrid()->ClearSelection();
                    }
                    m_hoveredCharacterId = "";
                    m_confirmButton->SetState(ButtonState::Disabled);
                }
                else
                {
                    SetState(SelectionState::ReadyToStart);
                }
            }
            else if (m_selectionState == SelectionState::SelectingP2)
            {
                m_p2CharacterId = m_hoveredCharacterId;
                m_p2Card->SetSelected(true);
                SetState(SelectionState::ReadyToStart);
            }
        }
        else if (m_selectionState == SelectionState::ReadyToStart)
        {
            if(m_onConfirmClicked)
            {
                std::vector<std::string> chosen;
                if (!m_p1CharacterId.empty()) chosen.push_back(m_p1CharacterId);
                if (m_isCoopMode && !m_p2CharacterId.empty()) chosen.push_back(m_p2CharacterId);
                m_onConfirmClicked(chosen);
            }
        }
    });

    m_enterCoopButton->SetOnClickCallback([this]()
    {
        if (!m_isCoopMode)
        {
            m_isCoopMode = true;
            m_isShrinking = true;
            m_shrinkLerpTime = 0.0f;
            m_enterCoopButton->SetState(ButtonState::Disabled);
            
            if(m_mainBoard && m_mainBoard->GetRosterGrid())
            {
                m_mainBoard->GetRosterGrid()->ClearSelection();
            }
            m_hoveredCharacterId = "";
            m_confirmButton->SetState(ButtonState::Disabled);
        }
    });

    m_backButton->SetOnClickCallback([this]()
    {
        if(m_onBackClicked)
        {
            m_onBackClicked();
        }
    });
}

CharacterSelectionView::~CharacterSelectionView() = default;

void CharacterSelectionView::InitializeLayout(const sf::Vector2f& viewportSize)
{
    SetSize(viewportSize);

    // ── Board ─────────────────────────────────────────────────────────────
    float boardW = std::min(BOARD_WIDTH, viewportSize.x - 40.0f);
    float currentBoardH = BOARD_HEIGHT;
    if (m_isCoopMode)
        currentBoardH -= 240.0f * m_shrinkLerpTime;

    float boardX = (viewportSize.x - boardW) / 2.0f;
    float boardY = std::max(80.0f, (viewportSize.y - BOARD_HEIGHT) / 2.0f + 50.0f);

    if (m_mainBoard)
    {
        m_mainBoard->SetBounds(boardX, boardY, boardW, currentBoardH);
    }

    // ── Stats panel (left side — hide if no room) ─────────────────────────
    float statsX = boardX - STATS_WIDTH - STATS_MARGIN_RIGHT;
    if (m_statsPanel)
    {
        if (statsX >= 0.0f)
            m_statsPanel->SetBounds(statsX, boardY + 100.0f, STATS_WIDTH, STATS_HEIGHT);
        else
            m_statsPanel->SetBounds(-2000.0f, -2000.0f, STATS_WIDTH, STATS_HEIGHT); // hidden
    }

    // ── Confirm / Start button (bottom-right) ─────────────────────────────
    const float CONFIRM_W = 314.0f, CONFIRM_H = 90.0f;
    float confirmX = viewportSize.x - CONFIRM_W - 80.0f;
    float confirmY = viewportSize.y - CONFIRM_H - BUTTON_MARGIN_BOTTOM;
    if (m_confirmButton)
        m_confirmButton->SetBounds(confirmX, confirmY, CONFIRM_W, CONFIRM_H);

    // ── Back button (top-left, always visible) ────────────────────────────
    const float BACK_W = 130.0f, BACK_H = 54.0f;
    const float TOP_Y  = 20.0f;
    if (m_backButton)
        m_backButton->SetBounds(20.0f, TOP_Y, BACK_W, BACK_H);

    // ── Co-op toggle button (top-right) ───────────────────────────────────
    const float COOP_W = 200.0f;
    float coopX = viewportSize.x - COOP_W - 80.0f;
    if (m_enterCoopButton)
        m_enterCoopButton->SetBounds(coopX, TOP_Y, COOP_W, BACK_H);

    // ── Co-op player cards ────────────────────────────────────────────────
    if (m_isCoopMode)
    {
        const float CARD_W = 220.0f, CARD_H = 250.0f, GAP = 50.0f;
        float cardsY = boardY + currentBoardH + 30.0f;
        float halfGap = GAP / 2.0f;

        if (m_p1Card)
            m_p1Card->SetBounds(viewportSize.x / 2.0f - CARD_W - halfGap, cardsY, CARD_W, CARD_H);
        if (m_p2Card)
            m_p2Card->SetBounds(viewportSize.x / 2.0f + halfGap, cardsY, CARD_W, CARD_H);
    }

    // ── Gold display ──────────────────────────────────────────────────────
    if (m_goldDisplay)
        m_goldDisplay->SetPosition(sf::Vector2f(GoldDisplayWidget::DEFAULT_X, GoldDisplayWidget::DEFAULT_Y));
}

void CharacterSelectionView::SetState(SelectionState state)
{
    m_selectionState = state;
    
    if (state == SelectionState::ReadyToStart)
    {
        if (m_confirmButton)
        {
            m_confirmButton->SetText("START", m_font, 40);
        }
        
        if (m_mainBoard && m_mainBoard->GetDetailPanel())
        {
            m_mainBoard->GetDetailPanel()->SetTint(sf::Color(220, 180, 0)); // Brighter yellow/gold
        }
        if (m_mainBoard && m_mainBoard->GetRosterGrid())
        {
            m_mainBoard->GetRosterGrid()->SetCardConfirmedState(true);
        }
        
        if (m_enterCoopButton && !m_isCoopMode)
        {
            m_enterCoopButton->SetState(ButtonState::Disabled);
        }
    }
    else
    {
        if (m_confirmButton)
        {
            m_confirmButton->SetText("Confirm", m_font, 24);
        }
        if (m_mainBoard && m_mainBoard->GetDetailPanel())
        {
            m_mainBoard->GetDetailPanel()->SetTint(sf::Color::White);
        }
        if (m_mainBoard && m_mainBoard->GetRosterGrid())
        {
            m_mainBoard->GetRosterGrid()->SetCardConfirmedState(false);
        }
        
        if (m_enterCoopButton && !m_isCoopMode)
        {
            m_enterCoopButton->SetState(ButtonState::Normal);
        }
    }
}

void CharacterSelectionView::UpdateCursors(float deltaTime)
{
    if (m_selectionState != SelectionState::ReadyToStart || m_cursorFrames.empty() || !m_confirmButton) return;
    
    m_cursorAnimTimer += deltaTime;
    if (m_cursorAnimTimer >= CURSOR_FRAME_DURATION) {
        m_cursorAnimTimer = 0.0f;
        m_currentCursorFrame = (m_currentCursorFrame + 1) % m_cursorFrames.size();

        m_leftCursor.setTexture(*m_cursorFrames[m_currentCursorFrame].texture);
        m_leftCursor.setTextureRect(m_cursorFrames[m_currentCursorFrame].rect);
        m_leftCursor.setOrigin(m_cursorFrames[m_currentCursorFrame].rect.width / 2.0f, m_cursorFrames[m_currentCursorFrame].rect.height / 2.0f);

        m_rightCursor.setTexture(*m_cursorFrames[m_currentCursorFrame].texture);
        m_rightCursor.setTextureRect(m_cursorFrames[m_currentCursorFrame].rect);
        m_rightCursor.setOrigin(m_cursorFrames[m_currentCursorFrame].rect.width / 2.0f, m_cursorFrames[m_currentCursorFrame].rect.height / 2.0f);
    }
    
    sf::Vector2f pos = m_confirmButton->GetPosition();
    sf::Vector2f size = m_confirmButton->GetSize();
    float padding = 35.0f;
    m_leftCursor.setPosition(pos.x - padding, pos.y + size.y / 2.0f);
    m_rightCursor.setPosition(pos.x + size.x + padding, pos.y + size.y / 2.0f);
}

void CharacterSelectionView::SetOnBackClicked(std::function<void()> callback)
{
    m_onBackClicked = callback;
}

void CharacterSelectionView::SetOnConfirmClicked(std::function<void(const std::vector<std::string>&)> callback)
{
    m_onConfirmClicked = callback;
}

void CharacterSelectionView::Update(float deltaTime)
{
    if (m_isShrinking)
    {
        m_shrinkLerpTime += deltaTime * 3.0f; // 0.33s animation
        if (m_shrinkLerpTime >= 1.0f)
        {
            m_shrinkLerpTime = 1.0f;
            m_isShrinking = false;
        }
        InitializeLayout(m_size); // Re-layout with new lerp value
    }

    UpdateCursors(deltaTime);

    if(m_mainBoard) m_mainBoard->Update(deltaTime);
    if(m_statsPanel) m_statsPanel->Update(deltaTime);
    if(m_goldDisplay) m_goldDisplay->Update(deltaTime);
    if(m_confirmButton) m_confirmButton->Update(deltaTime);
    if(m_backButton) m_backButton->Update(deltaTime);
    if(m_enterCoopButton) m_enterCoopButton->Update(deltaTime);
    
    if (m_isCoopMode)
    {
        if (m_p1Card) m_p1Card->Update(deltaTime);
        if (m_p2Card) m_p2Card->Update(deltaTime);
    }
}

void CharacterSelectionView::HandleEvent(const sf::Event& event, const sf::RenderWindow& window)
{
    if(m_mainBoard) m_mainBoard->HandleEvent(event, window);
    if(m_statsPanel) m_statsPanel->HandleEvent(event, window);
    if(m_goldDisplay) m_goldDisplay->HandleEvent(event, window);
    if(m_confirmButton) m_confirmButton->HandleEvent(event, window);
    if(m_backButton) m_backButton->HandleEvent(event, window);
    if(m_enterCoopButton) m_enterCoopButton->HandleEvent(event, window);
}

void CharacterSelectionView::Draw(sf::RenderTarget& target)
{
    if(m_mainBoard) m_mainBoard->Draw(target);
    if(m_statsPanel) m_statsPanel->Draw(target);
    if(m_goldDisplay) m_goldDisplay->Draw(target);
    if(m_confirmButton) m_confirmButton->Draw(target);
    if(m_backButton) m_backButton->Draw(target);
    if(m_enterCoopButton) m_enterCoopButton->Draw(target);
    
    if (m_isCoopMode)
    {
        if (m_p1Card) m_p1Card->Draw(target);
        if (m_p2Card) m_p2Card->Draw(target);
    }
    
    if (m_selectionState == SelectionState::ReadyToStart && !m_cursorFrames.empty())
    {
        target.draw(m_leftCursor);
        target.draw(m_rightCursor);
    }
}
