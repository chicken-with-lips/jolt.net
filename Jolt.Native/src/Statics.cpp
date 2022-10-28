#include "Jolt/Jolt.h"
#include "Jolt/RegisterTypes.h"
#include "Jolt/Core/Factory.h"

using namespace JPH;

extern "C" {

void jolt_Statics_RegisterDefaultAllocator() {
    RegisterDefaultAllocator();
}

void jolt_Statics_RegisterTypes() {
    RegisterTypes();
}

void jolt_Statics_RegisterFactory() {
    Factory::sInstance = new Factory();
}

}