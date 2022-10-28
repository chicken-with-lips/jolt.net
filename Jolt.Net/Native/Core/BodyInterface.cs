using System.Numerics;
using System.Runtime.InteropServices;
using ChickenWithLips.Jolt.Physics;
using ChickenWithLips.Jolt.Physics.Body;

namespace ChickenWithLips.Jolt.Native.Core;

internal static class BodyInterface
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_CreateBody")]
    public static extern IntPtr CreateBody(IntPtr bodyInterface, IntPtr bodyCreationSettings);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_CreateAndAddBody")]
    public static extern IntPtr CreateAndAddBody(IntPtr bodyInterface, IntPtr bodyCreationSettings, Activation activationMode);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_DestroyBody")]
    public static extern void DestroyBody(IntPtr bodyInterface, ref BodyID bodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddBody")]
    public static extern void AddBody(IntPtr bodyInterface, ref BodyID bodyId, Activation activationMode);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_RemoveBody")]
    public static extern void RemoveBody(IntPtr bodyInterface, ref BodyID bodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetObjectLayer")]
    public static extern void SetObjectLayer(IntPtr bodyInterface, ref BodyID inBodyId, ushort inLayer);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetObjectLayer")]
    public static extern ushort GetObjectLayer(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetPositionAndRotation")]
    public static extern void SetPositionAndRotation(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inPosition, ref Quaternion inRotation, Activation inActivationMode);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetPositionAndRotationWhenChanged")]
    public static extern void SetPositionAndRotationWhenChanged(IntPtr bodyInterface, ref BodyID inBodyID, ref Vector3 inPosition, ref Quaternion inRotation, Activation inActivationMode);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetPositionAndRotation")]
    public static extern void GetPositionAndRotation(IntPtr bodyInterface, ref BodyID inBodyId, out Vector3 outPosition, out Quaternion outRotation);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetPosition")]
    public static extern void SetPosition(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inPosition, Activation inActivationMode);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetPosition")]
    public static extern Vector3 GetPosition(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetCenterOfMassPosition")]
    public static extern Vector3 GetCenterOfMassPosition(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetRotation")]
    public static extern void SetRotation(IntPtr bodyInterface, ref BodyID inBodyId, ref Quaternion inRotation, Activation inActivationMode);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetRotation")]
    public static extern Quaternion GetRotation(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetWorldTransform")]
    public static extern Matrix4x4 GetWorldTransform(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetCenterOfMassTransform")]
    public static extern Matrix4x4 GetCenterOfMassTransform(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_MoveKinematic")]
    public static extern void MoveKinematic(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inTargetPosition, ref Quaternion inTargetRotation, float inDeltaTime);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetLinearAndAngularVelocity")]
    public static extern void SetLinearAndAngularVelocity(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inLinearVelocity, ref Vector3 inAngularVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetLinearAndAngularVelocity")]
    public static extern void GetLinearAndAngularVelocity(IntPtr bodyInterface, ref BodyID inBodyId, out Vector3 outLinearVelocity, out Vector3 outAngularVelocity);

    [DllImport("Jolt.Native", EntryPoint = "BodyInterface")]
    public static extern void SetLinearVelocity(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inLinearVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetLinearVelocity")]
    public static extern Vector3 GetLinearVelocity(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddLinearVelocity")]
    public static extern void AddLinearVelocity(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inLinearVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddLinearAndAngularVelocity")]
    public static extern void AddLinearAndAngularVelocity(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inLinearVelocity, ref Vector3 inAngularVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetAngularVelocity")]
    public static extern void SetAngularVelocity(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inAngularVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetAngularVelocity")]
    public static extern Vector3 GetAngularVelocity(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetPointVelocity")]
    public static extern Vector3 GetPointVelocity(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inPoint);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetPositionRotationAndVelocity")]
    public static extern void SetPositionRotationAndVelocity(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inPosition, ref Quaternion inRotation, ref Vector3 inLinearVelocity, ref Vector3 inAngularVelocity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddForce")]
    public static extern void AddForce(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inForce);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddForcePoint")]
    public static extern void AddForce(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inForce, ref Vector3 inPoint);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddTorque")]
    public static extern void AddTorque(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inTorque);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddForceAndTorque")]
    public static extern void AddForceAndTorque(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inForce, ref Vector3 inTorque);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddImpulse")]
    public static extern void AddImpulse(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inImpulse);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddImpulsePoint")]
    public static extern void AddImpulse(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inImpulse, ref Vector3 inPoint);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_AddAngularImpulse")]
    public static extern void AddAngularImpulse(IntPtr bodyInterface, ref BodyID inBodyId, ref Vector3 inAngularImpulse);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetMotionType")]
    public static extern void SetMotionType(IntPtr bodyInterface, ref BodyID inBodyId, MotionType inMotionType, Activation inActivationMode);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetMotionType")]
    public static extern MotionType GetMotionType(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetInverseInertia")]
    public static extern Matrix4x4 GetInverseInertia(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetRestitution")]
    public static extern void SetRestitution(IntPtr bodyInterface, ref BodyID inBodyId, float inRestitution);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetRestitution")]
    public static extern float GetRestitution(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetFriction")]
    public static extern void SetFriction(IntPtr bodyInterface, ref BodyID inBodyId, float inFriction);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetFriction")]
    public static extern float GetFriction(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_SetGravityFactor")]
    public static extern void SetGravityFactor(IntPtr bodyInterface, ref BodyID inBodyId, float inGravityFactor);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_GetGravityFactor")]
    public static extern float GetGravityFactor(IntPtr bodyInterface, ref BodyID inBodyId);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyInterface_InvalidateContactCache")]
    public static extern void InvalidateContactCache(IntPtr bodyInterface, ref BodyID inBodyId);
}
