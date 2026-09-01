cmake_minimum_required(VERSION 3.16)
project(VampireSurvivorsClone)

# Require C++20
set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Default to an optimised build. Without this the game runs unoptimised (-O0),
# which is several times slower and cannot sustain large enemy counts.
# Override with -DCMAKE_BUILD_TYPE=Debug when you need to step through code.
if(NOT CMAKE_BUILD_TYPE AND NOT CMAKE_CONFIGURATION_TYPES)
    set(CMAKE_BUILD_TYPE Release CACHE STRING "Build type" FORCE)
    set_property(CACHE CMAKE_BUILD_TYPE PROPERTY STRINGS Debug Release RelWithDebInfo MinSizeRel)
endif()

# SFML 2.6.1 and nlohmann/json 3.11.2 declare cmake_minimum_required below 3.5,
# which CMake 4.x rejects outright -- a fresh clone fails to configure without
# this. Applies to the fetched dependencies only, not to our own targets.
set(CMAKE_POLICY_VERSION_MINIMUM 3.5 CACHE STRING "" FORCE)

# Fetch SFML
include(FetchContent)
FetchContent_Declare(
    SFML
    URL https://github.com/SFML/SFML/archive/refs/tags/2.6.1.zip
)
set(BUILD_SHARED_LIBS OFF CACHE BOOL "" FORCE)
FetchContent_MakeAvailable(SFML)

# Fetch nlohmann/json
FetchContent_Declare(json
  URL https://github.com/nlohmann/json/releases/download/v3.11.2/json.tar.xz
)
FetchContent_MakeAvailable(json)


# Define source files
file(GLOB_RECURSE SOURCES "src/*.cpp")

# Define executable
add_executable(${PROJECT_NAME} ${SOURCES})

# Include directories
target_include_directories(${PROJECT_NAME} PRIVATE src)

# Link SFML libraries
target_link_libraries(${PROJECT_NAME} PRIVATE 
    sfml-graphics
    sfml-window
    sfml-system
    sfml-audio
    nlohmann_json::nlohmann_json
)

# Make the assets available next to the executable.
#
# This previously used `cmd /C ... mklink /J`, which fails on a clean build: CMake paths
# use forward slashes, so cmd.exe reads "C:/Temp/..." as the switch "/Temp" and aborts
# with "Invalid switch". It only appeared to work locally because the junction already
# existed and `if not exist` skipped the broken command -- a fresh clone always failed.
#
# cmake -E is used instead: no shell, no quoting rules, and it works on every platform.
# copy_directory_if_different avoids recopying 40+ MB on every build, falling back to
# plain copy_directory on CMake older than 3.26.
if(CMAKE_VERSION VERSION_GREATER_EQUAL 3.26)
    set(ASSET_COPY_CMD copy_directory_if_different)
else()
    set(ASSET_COPY_CMD copy_directory)
endif()

add_custom_command(TARGET ${PROJECT_NAME} POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E ${ASSET_COPY_CMD}
            "${CMAKE_SOURCE_DIR}/assets"
            "$<TARGET_FILE_DIR:${PROJECT_NAME}>/assets"
    COMMENT "Copying assets next to the executable"
)
