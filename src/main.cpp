#include "Core/GameManager.h"
#include <iostream>
#include <crtdbg.h>
#include <filesystem>

#if defined(__MINGW32__) && defined(_UCRT) && defined(_WIN64)
#include <setjmp.h>
#undef _setjmp
extern "C" int __cdecl _setjmp(jmp_buf _Buf, void* _Ctx) {
    return __intrinsic_setjmpex(_Buf, _Ctx);
}
#endif

int main() {
    _CrtSetReportMode(_CRT_ASSERT, _CRTDBG_MODE_FILE);
    _CrtSetReportFile(_CRT_ASSERT, _CRTDBG_FILE_STDERR);
    _set_abort_behavior(0, _WRITE_ABORT_MSG | _CALL_REPORTFAULT);
    if (!std::filesystem::exists("assets") && std::filesystem::exists("../assets")) std::filesystem::current_path("..");
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
