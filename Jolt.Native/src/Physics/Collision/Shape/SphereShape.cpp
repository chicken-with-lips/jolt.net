#include "Jolt/Jolt.h"
#include "Jolt/Physics/Collision/Shape/SphereShape.h"

using namespace JPH;

extern "C" {

void *jolt_SphereShapeSettings_CreateDefault() {
    return new SphereShapeSettings();
}

void *jolt_SphereShapeSettings_Create(float inRadius, const PhysicsMaterial *inMaterial) {
    return new SphereShapeSettings(inRadius, inMaterial);
}

float jolt_BoxShapeSettings_GetRadius(SphereShapeSettings *settings) {
    return settings->mRadius;
}

}