using System.Numerics;

namespace ChickenWithLips.Jolt.Physics.Body;

/// <summary>
/// The Body class only keeps track of state for static bodies, the MotionProperties class keeps the additional state needed for a moving Body. It has a 1-on-1 relationship with the body.
/// </summary>
public class MotionProperties : ObjectBase<MotionProperties>
{
    #region Properties

    public MotionQuality MotionQuality {
        get => Native.Physics.Body.MotionProperties.GetMotionQuality(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetMotionQuality(NativePtr, value);
    }

    public Vector3 LinearVelocity {
        get => Native.Physics.Body.MotionProperties.GetLinearVelocity(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetLinearVelocity(NativePtr, ref value);
    }

    public Vector3 LinearVelocityClamped {
        set => Native.Physics.Body.MotionProperties.SetLinearVelocityClamped(NativePtr, ref value);
    }

    public Vector3 AngularVelocityClamped {
        set => Native.Physics.Body.MotionProperties.SetAngularVelocityClamped(NativePtr, ref value);
    }

    public Vector3 AngularVelocity {
        get => Native.Physics.Body.MotionProperties.GetAngularVelocity(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetAngularVelocity(NativePtr, ref value);
    }

    public float MaxLinearVelocity {
        get => Native.Physics.Body.MotionProperties.GetMaxLinearVelocity(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetMaxLinearVelocity(NativePtr, value);
    }

    public float MaxAngularVelocity {
        get => Native.Physics.Body.MotionProperties.GetMaxAngularVelocity(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetMaxAngularVelocity(NativePtr, value);
    }

    public float LinearDamping {
        get => Native.Physics.Body.MotionProperties.GetLinearDamping(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetLinearDamping(NativePtr, value);
    }

    public float AngularDamping {
        get => Native.Physics.Body.MotionProperties.GetAngularDamping(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetAngularDamping(NativePtr, value);
    }

    public float GravityFactor {
        get => Native.Physics.Body.MotionProperties.GetGravityFactor(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetGravityFactor(NativePtr, value);
    }

    public float InverseMass {
        get => Native.Physics.Body.MotionProperties.GetInverseMass(NativePtr);
        set => Native.Physics.Body.MotionProperties.SetInverseMass(NativePtr, value);
    }

    public float InverseMassUnchecked => Native.Physics.Body.MotionProperties.GetInverseMassUnchecked(NativePtr);
    public Vector3 InverseInertiaDiagonal => Native.Physics.Body.MotionProperties.GetInverseInertiaDiagonal(NativePtr);
    public Quaternion InertiaRotation => Native.Physics.Body.MotionProperties.GetInertiaRotation(NativePtr);
    public Matrix4x4 LocalSpaceInverseInertia => Native.Physics.Body.MotionProperties.GetLocalSpaceInverseInertia(NativePtr);
    public Matrix4x4 LocalSpaceInverseInertiaUnchecked => Native.Physics.Body.MotionProperties.GetLocalSpaceInverseInertiaUnchecked(NativePtr);

    #endregion


    #region Methods

    private MotionProperties(IntPtr ptr, bool automaticallyRegisterInCache = false) : base(ptr, automaticallyRegisterInCache)
    {
    }

    public void SetInverseInertia(Vector3 diagonal, Quaternion rotation)
    {
        Native.Physics.Body.MotionProperties.SetInverseInertia(NativePtr, ref diagonal, ref rotation);
    }

    public void MoveKinematic(Vector3 deltaPosition, Quaternion deltaRotation, float deltaTime)
    {
        Native.Physics.Body.MotionProperties.MoveKinematic(NativePtr, ref deltaPosition, ref deltaRotation, deltaTime);
    }

    public Matrix4x4 InverseInertiaForRotation(Matrix4x4 rotation)
    {
        return Native.Physics.Body.MotionProperties.GetInverseInertiaForRotation(NativePtr, ref rotation);
    }

    public Vector3 MultiplyWorldSpaceInverseInertiaByVector(Quaternion bodyRotation, Vector3 v)
    {
        return Native.Physics.Body.MotionProperties.MultiplyWorldSpaceInverseInertiaByVector(NativePtr, ref bodyRotation, ref v);
    }

    public Vector3 PointVelocityCom(Vector3 pointRelativeToCom)
    {
        return Native.Physics.Body.MotionProperties.GetPointVelocityCOM(NativePtr, ref pointRelativeToCom);
    }

    public void ClampLinearVelocity()
    {
        Native.Physics.Body.MotionProperties.ClampLinearVelocity(NativePtr);
    }

    public void ClampAngularVelocity()
    {
        Native.Physics.Body.MotionProperties.ClampAngularVelocity(NativePtr);
    }

    internal static MotionProperties? Create(IntPtr ptr)
    {
        return GetOrCreateCache(ptr, ptr => new MotionProperties(ptr, false));
    }

    #endregion
}
