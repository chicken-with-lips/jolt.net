
#include "Jolt/Jolt.h"
#include "Jolt/Physics/Body/Body.h"

using namespace JPH;

extern "C" {

EMotionQuality jolt_MotionProperties_GetMotionQuality(MotionProperties *props) {
    return props->GetMotionQuality();
}

void jolt_MotionProperties_SetMotionQuality(MotionProperties *props, EMotionQuality inQuality) {
    props->SetMotionQuality(inQuality);
}

Vec3 jolt_MotionProperties_GetLinearVelocity(MotionProperties *props) {
    return props->GetLinearVelocity();
}

void jolt_MotionProperties_SetLinearVelocity(MotionProperties *props, Vec3& inLinearVelocity) {
    props->SetLinearVelocity(inLinearVelocity);
}

void jolt_MotionProperties_SetLinearVelocityClamped(MotionProperties *props, Vec3& inLinearVelocity) {
    props->SetLinearVelocityClamped(inLinearVelocity);
}

Vec3 jolt_MotionProperties_GetAngularVelocity(MotionProperties *props) {
    return props->GetAngularVelocity();
}

void jolt_MotionProperties_SetAngularVelocity(MotionProperties *props, Vec3& inAngularVelocity) {
    props->SetAngularVelocity(inAngularVelocity);
}

void jolt_MotionProperties_SetAngularVelocityClamped(MotionProperties *props, Vec3& inAngularVelocity) {
    props->SetAngularVelocityClamped(inAngularVelocity);
}

void jolt_MotionProperties_MoveKinematic(MotionProperties*props, Vec3& inDeltaPosition, Quat& inDeltaRotation, float inDeltaTime) {
    props->MoveKinematic(inDeltaPosition, inDeltaRotation, inDeltaTime);
}

float jolt_MotionProperties_GetMaxLinearVelocity(MotionProperties *props) {
    return props->GetMaxLinearVelocity();
}

void jolt_MotionProperties_SetMaxLinearVelocity(MotionProperties *props, float inLinearVelocity) {
    props->SetMaxLinearVelocity(inLinearVelocity);
}

float jolt_MotionProperties_GetMaxAngularVelocity(MotionProperties *props) {
    return props->GetMaxAngularVelocity();
}

void jolt_MotionProperties_SetMaxAngularVelocity(MotionProperties *props, float inAngularVelocity) {
    props->SetMaxAngularVelocity(inAngularVelocity);
}

void jolt_MotionProperties_ClampLinearVelocity(MotionProperties *props) {
    props->ClampLinearVelocity();
}

void jolt_MotionProperties_ClampAngularVelocity(MotionProperties *props) {
    props->ClampAngularVelocity();
}

float jolt_MotionProperties_GetLinearDamping(MotionProperties *props) {
    return props->GetLinearDamping();
}

void jolt_MotionProperties_SetLinearDamping(MotionProperties *props, float inLinearDamping) {
    props->SetLinearDamping(inLinearDamping);
}

float jolt_MotionProperties_GetAngularDamping(MotionProperties *props) {
    return props->GetAngularDamping();
}

void jolt_MotionProperties_SetAngularDamping(MotionProperties *props, float inAngularDamping) {
    props->SetAngularDamping(inAngularDamping);
}

float jolt_MotionProperties_GetGravityFactor(MotionProperties *props) {
    return props->GetGravityFactor();
}

void jolt_MotionProperties_SetGravityFactor(MotionProperties *props, float inGravityFactor) {
    props->SetGravityFactor(inGravityFactor);
}

float jolt_MotionProperties_GetInverseMass(MotionProperties *props) {
    return props->GetInverseMass();
}

float jolt_MotionProperties_GetInverseMassUnchecked(MotionProperties *props) {
    return props->GetInverseMassUnchecked();
}

void jolt_MotionProperties_SetInverseMass(MotionProperties *props, float inInverseMass) {
    props->SetInverseMass(inInverseMass);
}

Vec3 jolt_MotionProperties_GetInverseInertiaDiagonal(MotionProperties *props) {
    return props->GetInverseInertiaDiagonal();
}

Quat jolt_MotionProperties_GetInertiaRotation(MotionProperties *props) {
    return props->GetInertiaRotation();
}

void jolt_MotionProperties_SetInverseInertia(MotionProperties *props, Vec3& inDiagonal, Quat& inRot) {
    props->SetInverseInertia(inDiagonal, inRot);
}

Mat44 jolt_MotionProperties_GetLocalSpaceInverseInertia(MotionProperties *props) {
    return props->GetLocalSpaceInverseInertia();
}

Mat44 jolt_MotionProperties_GetLocalSpaceInverseInertiaUnchecked(MotionProperties *props) {
    return props->GetLocalSpaceInverseInertiaUnchecked();
}

Mat44 jolt_MotionProperties_GetInverseInertiaForRotation(MotionProperties *props, Mat44Arg inRotation) {
    return props->GetInverseInertiaForRotation(inRotation);
}

Vec3 jolt_MotionProperties_MultiplyWorldSpaceInverseInertiaByVector(MotionProperties *props, Quat& inBodyRotation, Vec3& inV) {
    return props->MultiplyWorldSpaceInverseInertiaByVector(inBodyRotation, inV);
}

Vec3 jolt_MotionProperties_GetPointVelocityCOM(MotionProperties *props, Vec3& inPointRelativeToCOM) {
    return props->GetPointVelocityCOM(inPointRelativeToCOM);
}

}