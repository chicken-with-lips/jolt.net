#include "Jolt/Jolt.h"
#include "Jolt/Core/TempAllocator.h"

using namespace JPH;

extern "C" {

void jolt_TempAllocator_Destroy(TempAllocator *tempAllocator) {
    delete tempAllocator;
}

}