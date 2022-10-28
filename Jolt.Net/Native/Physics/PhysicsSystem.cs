using System.Numerics;
using System.Runtime.InteropServices;
using ChickenWithLips.Jolt.Physics;

namespace ChickenWithLips.Jolt.Native.Physics;

internal static class PhysicsSystem
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_Create")]
    public static extern IntPtr Create();

    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_Destroy")]
    public static extern void Destroy(IntPtr physicsSystem);

    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_Init")]
    public static extern void Init(IntPtr physicsSystem, uint inMaxBodies, uint inNumBodyMutexes, uint inMaxBodyPairs,
        uint inMaxContactConstraints, IntPtr inBroadPhaseLayerInterface,
        ObjectVsBroadPhaseLayerFilter inObjectVsBroadPhaseLayerFilter,
        ObjectLayerPairFilter inObjectLayerPairFilter);

    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_GetGravity")]
    public static extern Vector3 GetGravity(IntPtr physicsSystem);

    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_SetGravity")]
    public static extern void SetGravity(IntPtr physicsSystem, Vector3 gravity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_OptimizeBroadPhase")]
    public static extern void OptimizeBroadPhase(IntPtr physicsSystem);

    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_Update")]
    public static extern void Update(IntPtr physicsSystem, float inDeltaTime, int inCollisionSteps, int inIntegrationSubSteps, IntPtr inTempAllocator, IntPtr inJobSystem);

    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_GetBodyInterface")]
    public static extern IntPtr GetBodyInterface(IntPtr physicsSystem);

    [DllImport("Jolt.Native", EntryPoint = "jolt_PhysicsSystem_GetBodyNoLockInterface")]
    public static extern IntPtr GetBodyNoLockInterface(IntPtr physicsSystem);
}
