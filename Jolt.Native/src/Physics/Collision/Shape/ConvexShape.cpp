#include "Jolt/Jolt.h"
#include "Jolt/Physics/Collision/Shape/ConvexShape.h"

using namespace JPH;

extern "C" {

void jolt_ConvexShape_SetDensity(ConvexShape *shape, float inDensity) {
    shape->SetDensity(inDensity);
}

float jolt_ConvexShape_GetDensity(ConvexShape *shape) {
    return shape->GetDensity();
}

}