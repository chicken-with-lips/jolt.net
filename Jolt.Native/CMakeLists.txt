cmake_minimum_required(VERSION 3.22)

include(FetchContent)

set(CMAKE_BUILD_TYPE Release CACHE STRING "Choose the type of build." FORCE)
set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++17")
set(CMAKE_POSITION_INDEPENDENT_CODE ON)

if ("${CMAKE_CXX_COMPILER_ID}" STREQUAL "MSVC")
    set(CMAKE_CONFIGURATION_TYPES "Debug;Release;Distribution")
elseif ("${CMAKE_CXX_COMPILER_ID}" STREQUAL "Clang")
    set(CMAKE_CONFIGURATION_TYPES "Debug;Release;ReleaseASAN;ReleaseUBSAN;ReleaseCoverage;Distribution")
endif ()

project(Jolt.Native VERSION 1.0 LANGUAGES CXX)

add_library(${PROJECT_NAME} SHARED
    src/Core/BodyInterface.cpp
    src/Core/JobSystem.cpp
    src/Core/TempAllocator.cpp
    src/Core/TempAllocatorImpl.cpp
    src/Core/TempAllocatorMalloc.cpp
    src/JobSystem/JobSystemThreadPool.cpp
    src/Physics/Collision/Body/Body.cpp
    src/Physics/Collision/Body/BodyCreationSettings.cpp
    src/Physics/Collision/Body/MotionProperties.cpp
    src/Physics/Collision/Shape/BoxShape.cpp
    src/Physics/Collision/Shape/ConvexShape.cpp
    src/Physics/Collision/Shape/Shape.cpp
    src/Physics/Collision/Shape/ShapeResult.cpp
    src/Physics/Collision/Shape/SphereShape.cpp
    src/Physics/Collision/BroadPhase/BroadPhaseLayerInterface.cpp
    src/Physics/PhysicsSystem.cpp
    src/Statics.cpp src/Physics/Collision/BroadPhase/BroadPhaseQuery.cpp)

FetchContent_Declare(
    jolt
    GIT_REPOSITORY https://github.com/jrouwe/JoltPhysics.git
    GIT_TAG master
)

set(jolt TARGET_UNIT_TESTS OFF)
set(jolt TARGET_HELLO_WORLD OFF)
set(jolt TARGET_PERFORMANCE_TEST OFF)
set(jolt TARGET_SAMPLES OFF)

FetchContent_MakeAvailable(jolt)

add_subdirectory("${jolt_SOURCE_DIR}/Build")

include_directories(${PROJECT_NAME}
    PRIVATE "${jolt_SOURCE_DIR}"
    )

link_directories(${jolt_BINARY_DIR})

target_link_libraries(${PROJECT_NAME}
    Jolt
    )

add_custom_command(TARGET ${PROJECT_NAME} POST_BUILD COMMAND ${CMAKE_COMMAND} -E copy $<TARGET_FILE:${PROJECT_NAME}> /home/jolly_samurai/Projects/chicken-with-lips/duck/Build/Debug/net6.0/${PROJECT_NAME}.so)