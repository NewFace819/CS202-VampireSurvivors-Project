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

#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#define NOMINMAX
#include <windows.h>

// Tell Windows this process handles high-DPI itself. Without it, on a display scaled
// to 125% the app sees a 1536x864 screen instead of the real 1920x1080, so a window
// sized from GetSystemMetrics(SM_CXSCREEN) only covers part of the display and the
// result is upscaled by the OS, which is blurry. Must run before any window exists.
static void enableHighDpiAwareness() {
    using SetCtxFn = BOOL (WINAPI*)(HANDLE);
    if (HMODULE user32 = GetModuleHandleW(L"user32.dll")) {
        if (auto setCtx = reinterpret_cast<SetCtxFn>(
                reinterpret_cast<void*>(GetProcAddress(user32, "SetProcessDpiAwarenessContext")))) {
            // DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2
            if (setCtx(reinterpret_cast<HANDLE>(-4))) return;
        }
    }
    SetProcessDPIAware();
}
#endif

int main() {
#ifdef _WIN32
    enableHighDpiAwareness();
#endif
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
