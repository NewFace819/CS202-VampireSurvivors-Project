#pragma once
#include <vector>
#include <algorithm>

// Event types for the game
enum class GameEvent {
    PlayerLevelUp,
    PlayerTookDamage,
    PlayerGainedExp,
    EnemyDied
};

class Observer {
public:
    virtual ~Observer() = default;
    virtual void onNotify(GameEvent event) = 0;
};

class Subject {
public:
    void addObserver(Observer* observer) {
        m_observers.push_back(observer);
    }

    void removeObserver(Observer* observer) {
        m_observers.erase(std::remove(m_observers.begin(), m_observers.end(), observer), m_observers.end());
    }

protected:
    void notify(GameEvent event) {
        for (auto observer : m_observers) {
            observer->onNotify(event);
        }
    }

private:
    std::vector<Observer*> m_observers;
};
