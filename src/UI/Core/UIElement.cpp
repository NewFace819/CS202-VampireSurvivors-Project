#include "UIElement.h"

void UIElement::SetPosition(const sf::Vector2f& pos)
{
    m_position = pos;
}

void UIElement::SetSize(const sf::Vector2f& size)
{
    m_size = size;
}

void UIElement::SetBounds(float x, float y, float w, float h)
{
    // Size first so any SetSize override can use m_size before SetPosition runs
    SetSize(sf::Vector2f(w, h));
    SetPosition(sf::Vector2f(x, y));
}

sf::Vector2f UIElement::GetPosition() const
{
    return m_position;
}

sf::Vector2f UIElement::GetSize() const
{
    return m_size;
}

void UIElement::SetActive(bool active)
{
    m_isActive = active;
}

bool UIElement::IsActive() const
{
    return m_isActive;
}
