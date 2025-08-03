cmake_minimum_required(VERSION 3.10)
project(MyCPP_Tutorials C)

# C1 Examples
add_subdirectory(app1)
add_subdirectory(app2)
set(0_C1_1_SOURCES
    0_C1/HelloWorld.c
)

# Create executable
add_executable(0_C1_1 ${0_C1_1_SOURCES})