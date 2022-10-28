#include "Jolt/Jolt.h"
#include "Jolt/Core/JobSystemThreadPool.h"
#include "Jolt/Physics/Body/BodyInterface.h"

using namespace JPH;

extern "C" {

void *jolt_BodyInterface_CreateBody(BodyInterface *bodyInterface, BodyCreationSettings *settings) {
    return bodyInterface->CreateBody(*settings);
}

BodyID jolt_BodyInterface_CreateAndAddBody(BodyInterface *bodyInterface, BodyCreationSettings *settings,
                                           EActivation activationMode) {
    return bodyInterface->CreateAndAddBody(*settings, activationMode);
}

void jolt_BodyInterface_DestroyBody(BodyInterface *bodyInterface, BodyID &bodyID) {
    bodyInterface->DestroyBody(bodyID);
}

void jolt_BodyInterface_AddBody(BodyInterface *bodyInterface, BodyID &bodyID, EActivation activationMode) {
    bodyInterface->AddBody(bodyID, activationMode);
}

void jolt_BodyInterface_RemoveBody(BodyInterface *bodyInterface, BodyID &bodyID) {
    bodyInterface->RemoveBody(bodyID);
}

void jolt_BodyInterface_SetObjectLayer(BodyInterface *bodyInterface, BodyID &inBodyID, uint16 inLayer) {
    bodyInterface->SetObjectLayer(inBodyID, inLayer);
}

ObjectLayer jolt_BodyInterface_GetObjectLayer(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetObjectLayer(inBodyID);
}

void jolt_BodyInterface_SetPositionAndRotation(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inPosition,
                                               Quat &inRotation, EActivation inActivationMode) {
    bodyInterface->SetPositionAndRotation(inBodyID, inPosition, inRotation, inActivationMode);
}

void
jolt_BodyInterface_SetPositionAndRotationWhenChanged(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inPosition,
                                                     Quat &inRotation, EActivation inActivationMode) {
    bodyInterface->SetPositionAndRotationWhenChanged(inBodyID, inPosition, inRotation, inActivationMode);
}

void jolt_BodyInterface_GetPositionAndRotation(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &outPosition,
                                               Quat &outRotation) {
    bodyInterface->GetPositionAndRotation(inBodyID, outPosition, outRotation);
}

void jolt_BodyInterface_SetPosition(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inPosition,
                                    EActivation inActivationMode) {
    bodyInterface->SetPosition(inBodyID, inPosition, inActivationMode);
}

Vec3 jolt_BodyInterface_GetPosition(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetPosition(inBodyID);
}

Vec3 jolt_BodyInterface_GetCenterOfMassPosition(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetCenterOfMassPosition(inBodyID);
}

void jolt_BodyInterface_SetRotation(BodyInterface *bodyInterface, BodyID &inBodyID, Quat &inRotation,
                                    EActivation inActivationMode) {
    bodyInterface->SetRotation(inBodyID, inRotation, inActivationMode);
}

Quat jolt_BodyInterface_GetRotation(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetRotation(inBodyID);
}

Mat44 jolt_BodyInterface_GetWorldTransform(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetWorldTransform(inBodyID);
}
Mat44 jolt_BodyInterface_GetCenterOfMassTransform(BodyInterface *bodyInterface, BodyID inBodyID) {
    return bodyInterface->GetCenterOfMassTransform(inBodyID);
}

void jolt_BodyInterface_MoveKinematic(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inTargetPosition,
                                      Quat &inTargetRotation, float inDeltaTime) {
    bodyInterface->MoveKinematic(inBodyID, inTargetPosition, inTargetRotation, inDeltaTime);
}

void jolt_BodyInterface_SetLinearAndAngularVelocity(BodyInterface *bodyInterface, BodyID &inBodyID,
                                                    Vec3 &inLinearVelocity, Vec3 &inAngularVelocity) {
    bodyInterface->SetLinearAndAngularVelocity(inBodyID, inLinearVelocity, inAngularVelocity);
}

void jolt_BodyInterface_GetLinearAndAngularVelocity(BodyInterface *bodyInterface, BodyID &inBodyID,
                                                    Vec3 &outLinearVelocity, Vec3 &outAngularVelocity) {
    bodyInterface->GetLinearAndAngularVelocity(inBodyID, outLinearVelocity, outAngularVelocity);
}

void
jolt_BodyInterface_SetLinearVelocity(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inLinearVelocity) {
    bodyInterface->SetLinearVelocity(inBodyID, inLinearVelocity);
}

Vec3 jolt_BodyInterface_GetLinearVelocity(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetLinearVelocity(inBodyID);
}

void jolt_BodyInterface_AddLinearVelocity(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inLinearVelocity) {
    bodyInterface->AddLinearVelocity(inBodyID, inLinearVelocity);
}


void
jolt_BodyInterface_AddLinearAndAngularVelocity(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inLinearVelocity,
                                               Vec3 &inAngularVelocity) {
    bodyInterface->AddLinearAndAngularVelocity(inBodyID, inLinearVelocity, inAngularVelocity);
}

void
jolt_BodyInterface_SetAngularVelocity(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inAngularVelocity) {
    bodyInterface->SetAngularVelocity(inBodyID, inAngularVelocity);
}

Vec3 jolt_BodyInterface_GetAngularVelocity(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetAngularVelocity(inBodyID);
}

Vec3 jolt_BodyInterface_GetPointVelocity(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inPoint) {
    return bodyInterface->GetPointVelocity(inBodyID, inPoint);
}

void jolt_BodyInterface_SetPositionRotationAndVelocity(BodyInterface *bodyInterface, BodyID &inBodyID,
                                                       Vec3 &inPosition, Quat &inRotation, Vec3 &inLinearVelocity,
                                                       Vec3 &inAngularVelocity) {
    bodyInterface->SetPositionRotationAndVelocity(inBodyID, inPosition, inRotation, inLinearVelocity,
                                                  inAngularVelocity);
}

void jolt_BodyInterface_AddForce(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inForce) {
    bodyInterface->AddForce(inBodyID, inForce);
}

void
jolt_BodyInterface_AddForcePoint(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inForce, Vec3 &inPoint) {
    bodyInterface->AddForce(inBodyID, inForce, inPoint);
}

void jolt_BodyInterface_AddTorque(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inTorque) {
    bodyInterface->AddTorque(inBodyID, inTorque);
}

void jolt_BodyInterface_AddForceAndTorque(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inForce,
                                          Vec3 &inTorque) {
    bodyInterface->AddForceAndTorque(inBodyID, inForce, inTorque);
}

void jolt_BodyInterface_AddImpulse(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inImpulse) {
    bodyInterface->AddImpulse(inBodyID, inImpulse);
}

void
jolt_BodyInterface_AddImpulsePoint(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inImpulse, Vec3 &inPoint) {
    bodyInterface->AddImpulse(inBodyID, inImpulse, inPoint);
}

void
jolt_BodyInterface_AddAngularImpulse(BodyInterface *bodyInterface, BodyID &inBodyID, Vec3 &inAngularImpulse) {
    bodyInterface->AddAngularImpulse(inBodyID, inAngularImpulse);
}

void jolt_BodyInterface_SetMotionType(BodyInterface *bodyInterface, BodyID &inBodyID, EMotionType inMotionType,
                                      EActivation inActivationMode) {
    bodyInterface->SetMotionType(inBodyID, inMotionType, inActivationMode);
}

EMotionType jolt_BodyInterface_GetMotionType(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetMotionType(inBodyID);
}

Mat44 jolt_BodyInterface_GetInverseInertia(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetInverseInertia(inBodyID);
}

void jolt_BodyInterface_SetRestitution(BodyInterface *bodyInterface, BodyID &inBodyID, float inRestitution) {
    bodyInterface->SetRestitution(inBodyID, inRestitution);
}

float jolt_BodyInterface_GetRestitution(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetRestitution(inBodyID);
}

void jolt_BodyInterface_SetFriction(BodyInterface *bodyInterface, BodyID &inBodyID, float inFriction) {
    bodyInterface->SetFriction(inBodyID, inFriction);
}

float jolt_BodyInterface_GetFriction(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetFriction(inBodyID);
}

void jolt_BodyInterface_SetGravityFactor(BodyInterface *bodyInterface, BodyID &inBodyID, float inGravityFactor) {
    bodyInterface->SetGravityFactor(inBodyID, inGravityFactor);
}

float jolt_BodyInterface_GetGravityFactor(BodyInterface *bodyInterface, BodyID &inBodyID) {
    return bodyInterface->GetGravityFactor(inBodyID);
}

const void *
jolt_BodyInterface_GetMaterial(BodyInterface *bodyInterface, BodyID &inBodyID, SubShapeID &inSubShapeID) {
    return bodyInterface->GetMaterial(inBodyID, inSubShapeID);
}


void jolt_BodyInterface_InvalidateContactCache(BodyInterface *bodyInterface, BodyID &inBodyID) {
    bodyInterface->InvalidateContactCache(inBodyID);
}

}