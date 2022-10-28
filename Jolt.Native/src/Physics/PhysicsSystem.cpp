#include "Jolt/Jolt.h"
#include "Jolt/Physics/PhysicsSystem.h"

using namespace JPH;

extern "C" {

void *jolt_PhysicsSystem_Create() {
    return (void *) new PhysicsSystem();
}

void
jolt_PhysicsSystem_Init(PhysicsSystem *physicsSystem, uint inMaxBodies, uint inNumBodyMutexes, uint inMaxBodyPairs,
                        uint inMaxContactConstraints, BroadPhaseLayerInterface *inBroadPhaseLayerInterface,
                        ObjectVsBroadPhaseLayerFilter inObjectVsBroadPhaseLayerFilter,
                        ObjectLayerPairFilter inObjectLayerPairFilter) {
    physicsSystem->Init(
            inMaxBodies,
            inNumBodyMutexes,
            inMaxBodyPairs,
            inMaxContactConstraints,
            *inBroadPhaseLayerInterface,
            inObjectVsBroadPhaseLayerFilter,
            inObjectLayerPairFilter
    );
}

void jolt_PhysicsSystem_Destroy(PhysicsSystem *physicsSystem) {
    delete physicsSystem;
}

Vec3 jolt_PhysicsSystem_GetGravity(PhysicsSystem *physicsSystem) {
    return physicsSystem->GetGravity();
}

void jolt_PhysicsSystem_SetGravity(PhysicsSystem *physicsSystem, Vec3 gravity) {
    physicsSystem->SetGravity(gravity);
}

void jolt_PhysicsSystem_OptimizeBroadPhase(PhysicsSystem *physicsSystem) {
    physicsSystem->OptimizeBroadPhase();
}

void jolt_PhysicsSystem_Update(PhysicsSystem *physicsSystem, float inDeltaTime, int inCollisionSteps,
                               int inIntegrationSubSteps, TempAllocator *inTempAllocator, JobSystem *inJobSystem) {
    physicsSystem->Update(inDeltaTime, inCollisionSteps, inIntegrationSubSteps, inTempAllocator, inJobSystem);
}

void *jolt_PhysicsSystem_GetBodyInterface(PhysicsSystem *physicsSystem) {
    return &physicsSystem->GetBodyInterface();
}

void *jolt_PhysicsSystem_GetBodyNoLockInterface(PhysicsSystem *physicsSystem) {
    return &physicsSystem->GetBodyInterfaceNoLock();
}

}