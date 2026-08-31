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

add_custom_command(TARGET ${PROJECT_NAME} POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E make_directory "$<TARGET_FILE_DIR:${PROJECT_NAME}>"
    COMMAND cmd /C "if not exist \"$<TARGET_FILE_DIR:${PROJECT_NAME}>/assets\" mklink /J \"$<TARGET_FILE_DIR:${PROJECT_NAME}>/assets\" \"${CMAKE_SOURCE_DIR}/assets\""
)
