#pragma once
#include <vector>
#include <memory>
#include <stdexcept>
#include <functional>

template <typename T>
class ObjectPool {
public:
    ObjectPool(size_t initialCapacity = 1000) {
        m_pool.reserve(initialCapacity);
        for (size_t i = 0; i < initialCapacity; ++i) {
            m_pool.push_back(std::make_unique<T>());
        }
    }

    // Acquires an object from the pool. If the pool is empty, it returns nullptr (Bounded).
    // Alternatively, it could dynamically expand, but the prompt specified "Bounded".
    T* acquire() {
        if (m_pool.empty()) {
            return nullptr; // Bounded pool limit reached
        }
        
        std::unique_ptr<T> obj = std::move(m_pool.back());
        m_pool.pop_back();
        
        T* rawPtr = obj.release();
        return rawPtr;
    }

    // Releases an object back to the pool
    void release(T* obj) {
        if (obj) {
            // Reset object state if necessary (assumes T has a reset() or init() method)
            m_pool.push_back(std::unique_ptr<T>(obj));
        }
    }

    size_t availableCount() const { return m_pool.size(); }

private:
    std::vector<std::unique_ptr<T>> m_pool;
};
