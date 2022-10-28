using System.Numerics;
using System.Runtime.InteropServices;
using ChickenWithLips.Jolt.Physics.Body;

namespace ChickenWithLips.Jolt.Native.Physics.Body;

internal static class MotionProperties
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetMotionQuality")]
    public static extern MotionQuality GetMotionQuality(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetMotionQuality")]
    public static extern void SetMotionQuality(IntPtr props, MotionQuality inQuality);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetLinearVelocity")]
    public static extern Vector3 GetLinearVelocity(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetLinearVelocity")]
    public static extern void SetLinearVelocity(IntPtr props, ref Vector3 inLinearVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetLinearVelocityClamped")]
    public static extern void SetLinearVelocityClamped(IntPtr props, ref Vector3 inLinearVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetAngularVelocity")]
    public static extern Vector3 GetAngularVelocity(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetAngularVelocity")]
    public static extern void SetAngularVelocity(IntPtr props, ref Vector3 inAngularVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetAngularVelocityClamped")]
    public static extern void SetAngularVelocityClamped(IntPtr props, ref Vector3 inAngularVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_MoveKinematic")]
    public static extern void MoveKinematic(IntPtr props, ref Vector3 inDeltaPosition, ref Quaternion inDeltaRotation, float inDeltaTime);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetMaxLinearVelocity")]
    public static extern float GetMaxLinearVelocity(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetMaxLinearVelocity")]
    public static extern void SetMaxLinearVelocity(IntPtr props, float inLinearVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetMaxAngularVelocity")]
    public static extern float GetMaxAngularVelocity(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetMaxAngularVelocity")]
    public static extern void SetMaxAngularVelocity(IntPtr props, float inAngularVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_ClampLinearVelocity")]
    public static extern void ClampLinearVelocity(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_ClampAngularVelocity")]
    public static extern void ClampAngularVelocity(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetLinearDamping")]
    public static extern float GetLinearDamping(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetLinearDamping")]
    public static extern void SetLinearDamping(IntPtr props, float inLinearDamping);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetAngularDamping")]
    public static extern float GetAngularDamping(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetAngularDamping")]
    public static extern void SetAngularDamping(IntPtr props, float inAngularDamping);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetGravityFactor")]
    public static extern float GetGravityFactor(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetGravityFactor")]
    public static extern void SetGravityFactor(IntPtr props, float inGravityFactor);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetInverseMass")]
    public static extern float GetInverseMass(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetInverseMassUnchecked")]
    public static extern float GetInverseMassUnchecked(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetInverseMass")]
    public static extern void SetInverseMass(IntPtr props, float inInverseMass);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetInverseInertiaDiagonal")]
    public static extern Vector3 GetInverseInertiaDiagonal(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetInertiaRotation")]
    public static extern Quaternion GetInertiaRotation(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_SetInverseInertia")]
    public static extern void SetInverseInertia(IntPtr props, ref Vector3 inDiagonal, ref Quaternion inRot);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetLocalSpaceInverseInertia")]
    public static extern Matrix4x4 GetLocalSpaceInverseInertia(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetLocalSpaceInverseInertiaUnchecked")]
    public static extern Matrix4x4 GetLocalSpaceInverseInertiaUnchecked(IntPtr props);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetInverseInertiaForRotation")]
    public static extern Matrix4x4 GetInverseInertiaForRotation(IntPtr props, ref Matrix4x4 inRotation);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_MultiplyWorldSpaceInverseInertiaByVector")]
    public static extern Vector3 MultiplyWorldSpaceInverseInertiaByVector(IntPtr props, ref Quaternion inBodyRotation, ref Vector3 inV);

    [DllImport("Jolt.Native", EntryPoint = "jolt_MotionProperties_GetPointVelocityCOM")]
    public static extern Vector3 GetPointVelocityCOM(IntPtr props, ref Vector3 inPointRelativeToCom);
}
