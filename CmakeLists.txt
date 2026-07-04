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
)

# Create a directory junction (symlink) to assets instead of copying ~1GB every build.
# This runs only if the junction does not already exist.
add_custom_command(TARGET ${PROJECT_NAME} POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E make_directory "$<TARGET_FILE_DIR:${PROJECT_NAME}>"
    COMMAND cmd /C "if not exist \"$<TARGET_FILE_DIR:${PROJECT_NAME}>/assets\" mklink /J \"$<TARGET_FILE_DIR:${PROJECT_NAME}>/assets\" \"${CMAKE_SOURCE_DIR}/assets\""
    COMMENT "Linking assets directory (junction) if not already linked"
)
