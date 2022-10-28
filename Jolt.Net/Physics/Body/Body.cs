namespace ChickenWithLips.Jolt.Physics.Body;

/// <summary>A rigid body that can be simulated using the physics system.</summary>
/// <remarks>
/// <para>Note that internally all properties (position, velocity etc.) are tracked relative to the center of mass of
/// the object to simplify the simulation of the object.</para>
/// <para>The offset between the position of the body and the center of mass position of the body is
/// GetShape()->GetCenterOfMass(). The functions that get/set the position of the body all indicate if they are relative
/// to the center of mass or to the original position in which the shape was created.</para>
/// <para>The linear velocity is also velocity of the center of mass, to correct for this:
/// \f$VelocityCOM = Velocity - AngularVelocity \times ShapeCOM\f$.</para>
/// </remarks>
public class Body : ObjectBase<Body>
{
    public BodyID ID => Native.Physics.Body.Body.GetID(NativePtr);

    /// <summary>Access to the motion properties.</summary>
    public MotionProperties MotionProperties => MotionProperties.Create(Native.Physics.Body.Body.GetMotionProperties(NativePtr));

    /// <summary>Access to the motion properties (version that does not check if the object is kinematic or dynamic).</summary>
    public MotionProperties MotionPropertiesUnchecked => MotionProperties.Create(Native.Physics.Body.Body.GetMotionPropertiesUnchecked(NativePtr));


    /// <summary>If this body is currently actively simulating (true) or sleeping (false).</summary>
    public bool IsActive => Native.Physics.Body.Body.IsActive(NativePtr);

    /// <summary>Check if this body is static (not movable).</summary>
    public bool IsStatic => Native.Physics.Body.Body.IsStatic(NativePtr);

    /// <summary>Check if this body is kinematic (keyframed), which means that it will move according to its current velocity, but forces don't affect it.</summary>
    public bool IsKinematic => Native.Physics.Body.Body.IsKinematic(NativePtr);

    /// <summary>Check if this body is dynamic, which means that it moves and forces can act on it.</summary>
    public bool IsDynamic => Native.Physics.Body.Body.IsDynamic(NativePtr);

    /// <summary>Check if a body could be made kinematic or dynamic (if it was created dynamic or with mAllowDynamicOrKinematic set to true).</summary>
    public bool CanBeKinematicOrDynamic => Native.Physics.Body.Body.CanBeKinematicOrDynamic(NativePtr);

    /// <summary>Is the body to a sensor.</summary>
    /// <remarks>
    /// A sensor will receive collision callbacks, but will not cause any collision responses and can be used as a
    /// trigger volume. The cheapest sensor (in terms of CPU usage) is a sensor with motion type Static (they can be
    /// moved around using BodyInterface::SetPosition/SetPositionAndRotation). These sensors will only detect collisions
    /// with active Dynamic or Kinematic bodies. As soon as a body go to sleep, the contact point with the sensor will
    /// be lost. If you make a sensor Dynamic or Kinematic and activate them, the sensor will be able to detect
    /// collisions with sleeping bodies too. An active sensor will never go to sleep automatically. When you make a
    /// Dynamic or Kinematic sensor, make sure it is in an ObjectLayer that does not collide with Static bodies or other
    /// sensors to avoid extra overhead in the broad phase.
    /// </remarks>
    public bool IsSensor {
        get => Native.Physics.Body.Body.IsSensor(NativePtr);
        set => Native.Physics.Body.Body.SetIsSensor(NativePtr, value);
    }

    protected Body(IntPtr ptr, bool automaticallyRegisterInCache = false) : base(ptr, automaticallyRegisterInCache)
    {
    }

    internal static Body? Create(IntPtr ptr)
    {
        return GetOrCreateCache(ptr, ptr => new Body(ptr, false));
    }
}
