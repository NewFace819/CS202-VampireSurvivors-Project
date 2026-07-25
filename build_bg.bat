@echo off
echo Generating library background texture...
C:\Users\Admin\AppData\Local\Python\bin\python.exe generate_library_bg.py

if %ERRORLEVEL% equ 0 (
    echo Opening generated image...
    start "" "assets\ExportedProject\Assets\App\Art\Sprites\Addressable\backgrounds\bg_library.png"
) else (
    echo Generation failed! Check errors above.
    pause
)
