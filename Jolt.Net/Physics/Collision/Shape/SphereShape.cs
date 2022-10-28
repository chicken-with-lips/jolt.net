using System.Numerics;

namespace ChickenWithLips.Jolt.Physics.Collision.Shape;

public class SphereShape : ConvexShape
{
    public SphereShape()
        : base(IntPtr.Zero, false)
    {
    }

    protected SphereShape(IntPtr ptr, bool automaticallyRegisterInCache = false)
        : base(ptr, automaticallyRegisterInCache)
    {
    }
}

public class SphereShapeSettings : ConvexShapeSettings<SphereShape>
{
    public float Radius => Native.Physics.Collision.Shape.SphereShapeSettings.GetRadius(NativePtr);

    /// <summary>
    /// Default constructor for deserialization.
    /// </summary>
    public SphereShapeSettings()
        : base(Native.Physics.Collision.Shape.SphereShapeSettings.CreateDefault(), true)
    {
    }

    public SphereShapeSettings(float radius, PhysicsMaterial material = null)
        : base(Native.Physics.Collision.Shape.SphereShapeSettings.Create(radius, material?.NativePtr ?? IntPtr.Zero), true)
    {
    }
}
