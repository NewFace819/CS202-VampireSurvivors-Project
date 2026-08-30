cmake_minimum_required(VERSION 3.16)
project(VampireSurvivorsClone)

# Require C++20
set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

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
