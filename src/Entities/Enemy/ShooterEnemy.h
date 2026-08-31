#pragma once
#include "Entities/Enemy/EnemyBase.h"

class ShooterEnemy : public EnemyBase {
public:
    ShooterEnemy();
    ~ShooterEnemy() override = default;

    void init(const sf::Vector2f& startPos, const EnemyStats& stats, sf::Texture* texture = nullptr) override;
    void update(float dt) override;

    bool wantsToShoot() const override { return m_wantsToShoot; }
    void resetShootFlag() override { m_wantsToShoot = false; }
    bool isShooter() const override { return true; }

private:
    float m_shootTimer = 0.f;
    bool m_wantsToShoot = false;
};
