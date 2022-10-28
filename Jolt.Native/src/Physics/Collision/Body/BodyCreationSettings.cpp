
#include <iostream>
#include "Jolt/Jolt.h"
#include "Jolt/Physics/Collision/Shape/Shape.h"
#include "Jolt/Physics/Body/MotionType.h"
#include "Jolt/Physics/Body/BodyCreationSettings.h"

using namespace JPH;

extern "C" {

void *jolt_BodyCreationSettings_CreateWithShapeSettings(ShapeSettings *inShape, Vec3& inPosition, Quat& inRotation,
                                                        EMotionType inMotionType,
                                                        uint16 inObjectLayer) {
    std::cout << "jolt_BodyCreationSettings_CreateWithShapeSettings: " << inObjectLayer << std::endl;
    return new BodyCreationSettings(inShape, inPosition, inRotation, inMotionType, inObjectLayer);
}

void *jolt_BodyCreationSettings_CreateWithShape(Shape *inShape, Vec3& inPosition, Quat& inRotation,
                                                EMotionType inMotionType,
                                                uint16 inObjectLayer) {
    return new BodyCreationSettings(inShape, inPosition, inRotation, inMotionType, inObjectLayer);
}

}