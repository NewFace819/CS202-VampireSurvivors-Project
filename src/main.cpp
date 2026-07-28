#include "Core/GameManager.h"
#include <iostream>
#include <crtdbg.h>

int main() {
    _CrtSetReportMode(_CRT_ASSERT, _CRTDBG_MODE_FILE);
    _CrtSetReportFile(_CRT_ASSERT, _CRTDBG_FILE_STDERR);
    _set_abort_behavior(0, _WRITE_ABORT_MSG | _CALL_REPORTFAULT);
    try {
        GameManager game;
        game.run();
    } catch (const std::exception& e) {
        std::cerr << "Exception: " << e.what() << "\n";
        return 1;
    } catch (...) {
        std::cerr << "Unknown exception!\n";
        return 1;
    }
    return 0;
}
