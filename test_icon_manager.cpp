#include "Core/Data/IconManager.h"
#include <iostream>

int main() {
    auto rect = IconManager::GetInstance().getIconRect("Garlic");
    std::cout << "Garlic: " << rect.left << ", " << rect.top << ", " << rect.width << ", " << rect.height << "\n";
    auto axe = IconManager::GetInstance().getIconRect("Axe");
    std::cout << "Axe: " << axe.left << ", " << axe.top << ", " << axe.width << ", " << axe.height << "\n";
    auto cross = IconManager::GetInstance().getIconRect("Cross");
    std::cout << "Cross: " << cross.left << ", " << cross.top << ", " << cross.width << ", " << cross.height << "\n";
    return 0;
}
