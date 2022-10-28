#include "Jolt/Jolt.h"
#include "Jolt/Physics/Collision/Shape/BoxShape.h"

using namespace JPH;

extern "C" {

void *jolt_BoxShapeSettings_CreateDefault() {
    return new BoxShapeSettings();
}

void *jolt_BoxShapeSettings_Create(Vec3& inHalfExtent, float inConvexRadius, PhysicsMaterial *inMaterial) {
    return new BoxShapeSettings(inHalfExtent, inConvexRadius, inMaterial);
}

Vec3 jolt_BoxShapeSettings_GetHalfExtent(BoxShapeSettings *settings) {
    return settings->mHalfExtent;
}

float jolt_BoxShapeSettings_GetConvexRadius(BoxShapeSettings *settings) {
    return settings->mConvexRadius;
}

}