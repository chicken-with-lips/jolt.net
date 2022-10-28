#include "Jolt/Jolt.h"
#include "Jolt/Core/TempAllocator.h"

using namespace JPH;

extern "C" {

void *jolt_TempAllocatorImpl_Create(int size) {
    return new TempAllocatorImpl(size);
}

}