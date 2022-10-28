#include "Jolt/Jolt.h"
#include "Jolt/Physics/Body/Body.h"

using namespace JPH;

extern "C" {

const BodyID &jolt_Body_GetID(Body *body) {
    return body->GetID();
}

void *jolt_Body_GetMotionProperties(Body *body) {
    return body->GetMotionProperties();
}

void *jolt_Body_GetMotionPropertiesUnchecked(Body *body) {
    return body->GetMotionPropertiesUnchecked();
}

bool jolt_Body_IsActive(Body *body) {
    return body->IsActive();
}

bool jolt_Body_IsStatic(Body *body) {
    return body->IsStatic();
}

bool jolt_Body_IsKinematic(Body *body) {
    return body->IsKinematic();
}

bool jolt_Body_IsDynamic(Body *body) {
    return body->IsDynamic();
}

bool jolt_Body_CanBeKinematicOrDynamic(Body *body) {
    return body->CanBeKinematicOrDynamic();
}

void jolt_Body_SetIsSensor(Body *body, bool inIsSensor) {
    body->SetIsSensor(inIsSensor);
}

bool jolt_Body_IsSensor(Body *body) {
    return body->IsSensor();
}


}