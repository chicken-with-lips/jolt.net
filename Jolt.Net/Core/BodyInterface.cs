using System.Numerics;
using ChickenWithLips.Jolt.Physics;
using ChickenWithLips.Jolt.Physics.Body;

namespace ChickenWithLips.Jolt.Core;

public class BodyInterface : ObjectBase<BodyInterface>
{
    protected BodyInterface(IntPtr ptr, bool automaticallyRegisterInCache)
        : base(ptr, automaticallyRegisterInCache)
    {
    }

    public Body CreateBody(BodyCreationSettings settings)
    {
        return Body.Create(Native.Core.BodyInterface.CreateBody(NativePtr, settings.NativePtr));
    }

    public Body CreateAndAddBody(BodyCreationSettings settings, Activation activationMode)
    {
        return Body.Create(Native.Core.BodyInterface.CreateAndAddBody(NativePtr, settings.NativePtr, activationMode));
    }

    public void DestroyBody(BodyID bodyId)
    {
        Native.Core.BodyInterface.DestroyBody(NativePtr, ref bodyId);
    }

    public void AddBody(BodyID bodyId, Activation activationMode)
    {
        Native.Core.BodyInterface.AddBody(NativePtr, ref bodyId, activationMode);
    }

    public void RemoveBody(BodyID bodyId)
    {
        Native.Core.BodyInterface.RemoveBody(NativePtr, ref bodyId);
    }

    public void SetObjectLayer(BodyID bodyId, ushort inLayer)
    {
        Native.Core.BodyInterface.SetObjectLayer(NativePtr, ref bodyId, inLayer);
    }

    public ushort GetObjectLayer(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetObjectLayer(NativePtr, ref bodyId);
    }

    public void SetPositionAndRotation(BodyID bodyId, Vector3 position, Quaternion rotation, Activation activationMode)
    {
        Native.Core.BodyInterface.SetPositionAndRotation(NativePtr, ref bodyId, ref position, ref rotation, activationMode);
    }

    /// <summary>
    /// Will only update the position/rotation and activate the body when the difference is larger than a very small
    /// number. This avoids updating the broadphase/waking up a body when the resulting position/orientation doesn't
    /// really change.
    /// </summary>
    public void SetPositionAndRotationWhenChanged(BodyID bodyId, Vector3 position, Quaternion rotation, Activation activationMode)
    {
        Native.Core.BodyInterface.SetPositionAndRotationWhenChanged(NativePtr, ref bodyId, ref position, ref rotation, activationMode);
    }

    public void GetPositionAndRotation(BodyID bodyId, out Vector3 position, out Quaternion rotation)
    {
        Native.Core.BodyInterface.GetPositionAndRotation(NativePtr, ref bodyId, out position, out rotation);
    }

    public void SetPosition(BodyID bodyId, Vector3 position, Activation activationMode)
    {
        Native.Core.BodyInterface.SetPosition(NativePtr, ref bodyId, ref position, activationMode);
    }

    public Vector3 GetPosition(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetPosition(NativePtr, ref bodyId);
    }

    public Vector3 GetCenterOfMassPosition(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetCenterOfMassPosition(NativePtr, ref bodyId);
    }

    public void SetRotation(BodyID bodyId, Quaternion rotation, Activation activationMode)
    {
        Native.Core.BodyInterface.SetRotation(NativePtr, ref bodyId, ref rotation, activationMode);
    }

    public Quaternion GetRotation(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetRotation(NativePtr, ref bodyId);
    }

    public Matrix4x4 GetWorldTransform(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetWorldTransform(NativePtr, ref bodyId);
    }

    public Matrix4x4 GetCenterOfMassTransform(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetCenterOfMassTransform(NativePtr, ref bodyId);
    }

    /// <summary>
    /// Set velocity of body such that it will be positioned at targetPosition/Rotation in deltaTime seconds (will activate body if needed).
    /// </summary>
    public void MoveKinematic(BodyID bodyId, Vector3 targetPosition, Quaternion targetRotation, float deltaTime)
    {
        Native.Core.BodyInterface.MoveKinematic(NativePtr, ref bodyId, ref targetPosition, ref targetRotation, deltaTime);
    }

    /// <summary>Linear or angular velocity (functions will activate body if needed).</summary>
    /// <remarks>
    /// Note that the linear velocity is the velocity of the center of mass, which may not coincide with the position of
    /// your object, to correct for this: \f$VelocityCOM = Velocity - AngularVelocity \times ShapeCOM\f$
    /// </remarks>
    public void SetLinearAndAngularVelocity(BodyID bodyId, Vector3 linearVelocity, Vector3 angularVelocity)
    {
        Native.Core.BodyInterface.SetLinearAndAngularVelocity(NativePtr, ref bodyId, ref linearVelocity, ref angularVelocity);
    }
    
    public void GetLinearAndAngularVelocity(BodyID bodyId, out Vector3 linearVelocity, out Vector3 angularVelocity)
    {
        Native.Core.BodyInterface.GetLinearAndAngularVelocity(NativePtr, ref bodyId, out linearVelocity, out angularVelocity);
    }

    public void SetLinearVelocity(BodyID bodyId, Vector3 linearVelocity)
    {
        Native.Core.BodyInterface.SetLinearVelocity(NativePtr, ref bodyId, ref linearVelocity);
    }

    public Vector3 GetLinearVelocity(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetLinearVelocity(NativePtr, ref bodyId);
    }

    /// <summary>
    /// Add velocity to current velocity.
    /// </summary>
    public void AddLinearVelocity(BodyID bodyId, Vector3 linearVelocity)
    {
        Native.Core.BodyInterface.AddLinearVelocity(NativePtr, ref bodyId, ref linearVelocity);
    }

    /// <summary>
    /// Add linear and angular to current velocity.
    /// </summary>
    public void AddLinearAndAngularVelocity(BodyID bodyId, Vector3 linearVelocity, Vector3 angularVelocity)
    {
        Native.Core.BodyInterface.AddLinearAndAngularVelocity(NativePtr, ref bodyId, ref linearVelocity, ref angularVelocity);
    }

    public void SetAngularVelocity(BodyID bodyId, Vector3 angularVelocity)
    {
        Native.Core.BodyInterface.SetAngularVelocity(NativePtr, ref bodyId, ref angularVelocity);
    }

    public Vector3 GetAngularVelocity(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetAngularVelocity(NativePtr, ref bodyId);
    }

    /// <summary>
    /// Velocity of point (in world space, e.g. on the surface of the body) of the body.
    /// </summary>
    public Vector3 GetPointVelocity(BodyID bodyId, Vector3 point)
    {
        return Native.Core.BodyInterface.GetPointVelocity(NativePtr, ref bodyId, ref point);
    }

    /// <summary>Set the complete motion state of a body.</summary>
    /// <remarks>
    /// Note that the linear velocity is the velocity of the center of mass, which may not coincide with the position of
    /// your object, to correct for this: \f$VelocityCOM = Velocity - AngularVelocity \times ShapeCOM\f$
    /// </remarks>
    public void SetPositionRotationAndVelocity(BodyID bodyId, Vector3 position, Quaternion rotation, Vector3 linearVelocity, Vector3 angularVelocity)
    {
        Native.Core.BodyInterface.SetPositionRotationAndVelocity(NativePtr, ref bodyId, ref position, ref rotation, ref linearVelocity, ref angularVelocity);
    }

    public void AddForce(BodyID bodyId, Vector3 force)
    {
        Native.Core.BodyInterface.AddForce(NativePtr, ref bodyId, ref force);
    }

    public void AddForce(BodyID bodyId, Vector3 force, Vector3 point)
    {
        Native.Core.BodyInterface.AddForce(NativePtr, ref bodyId, ref force, ref point);
    }

    public void AddTorque(BodyID bodyId, Vector3 torque)
    {
        Native.Core.BodyInterface.AddTorque(NativePtr, ref bodyId, ref torque);
    }

    public void AddForceAndTorque(BodyID bodyId, Vector3 force, Vector3 torque)
    {
        Native.Core.BodyInterface.AddForceAndTorque(NativePtr, ref bodyId, ref force, ref torque);
    }

    public void AddImpulse(BodyID bodyId, Vector3 impulse)
    {
        Native.Core.BodyInterface.AddImpulse(NativePtr, ref bodyId, ref impulse);
    }

    public void AddImpulse(BodyID bodyId, Vector3 impulse, Vector3 point)
    {
        Native.Core.BodyInterface.AddImpulse(NativePtr, ref bodyId, ref impulse, ref point);
    }

    public void AddAngularImpulse(BodyID bodyId, Vector3 angularImpulse)
    {
        Native.Core.BodyInterface.AddAngularImpulse(NativePtr, ref bodyId, ref angularImpulse);
    }

    public void SetMotionType(BodyID bodyId, MotionType motionType, Activation activationMode)
    {
        Native.Core.BodyInterface.SetMotionType(NativePtr, ref bodyId, motionType, activationMode);
    }

    public MotionType GetMotionType(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetMotionType(NativePtr, ref bodyId);
    }

    public Matrix4x4 GetInverseInertia(BodyID bodyId)

    {
        return Native.Core.BodyInterface.GetInverseInertia(NativePtr, ref bodyId);
    }

    public void SetRestitution(BodyID bodyId, float restitution)
    {
        Native.Core.BodyInterface.SetRestitution(NativePtr, ref bodyId, restitution);
    }

    public float GetRestitution(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetRestitution(NativePtr, ref bodyId);
    }

    public void SetFriction(BodyID bodyId, float friction)
    {
        Native.Core.BodyInterface.SetFriction(NativePtr, ref bodyId, friction);
    }

    public float GetFriction(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetFriction(NativePtr, ref bodyId);
    }

    public void SetGravityFactor(BodyID bodyId, float gravityFactor)
    {
        Native.Core.BodyInterface.SetGravityFactor(NativePtr, ref bodyId, gravityFactor);
    }

    public float GetGravityFactor(BodyID bodyId)
    {
        return Native.Core.BodyInterface.GetGravityFactor(NativePtr, ref bodyId);
    }

    internal static BodyInterface? Create(IntPtr ptr)
    {
        return GetOrCreateCache(ptr, ptr => new BodyInterface(ptr, false));
    }
}
