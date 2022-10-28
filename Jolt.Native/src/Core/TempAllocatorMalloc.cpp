#include "Jolt/Jolt.h"
#include "Jolt/Core/TempAllocator.h"

using namespace JPH;

extern "C" {

void *jolt_TempAllocatorMalloc_Create() {
    return new TempAllocatorMalloc();
}

}