#include "Jolt/Jolt.h"
#include "Jolt/Physics/Collision/Shape/Shape.h"

using namespace JPH;

extern "C" {

EShapeType jolt_Shape_GetType(Shape *shape) {
    return shape->GetType();
}

EShapeSubType jolt_Shape_GetSubType(Shape *shape) {
    return shape->GetSubType();
}

}