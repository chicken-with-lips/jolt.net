using System.Numerics;

namespace ChickenWithLips.Jolt.Physics.Collision.Shape;

public class BoxShape : ConvexShape
{
    public BoxShape()
        : base(IntPtr.Zero, false)
    {
    }

    protected BoxShape(IntPtr ptr, bool automaticallyRegisterInCache = false)
        : base(ptr, automaticallyRegisterInCache)
    {
    }
}

public class BoxShapeSettings : ConvexShapeSettings<BoxShape>
{
    public Vector3 HalfExtent => Native.Physics.Collision.Shape.BoxShapeSettings.GetHalfExtent(NativePtr);
    public float ConvexRadius => Native.Physics.Collision.Shape.BoxShapeSettings.GetConvexRadius(NativePtr);

    /// <summary>
    /// Default constructor for deserialization.
    /// </summary>
    public BoxShapeSettings()
        : base(Native.Physics.Collision.Shape.BoxShapeSettings.CreateDefault(), true)
    {
    }

    /// <summary>
    /// Create a box with half edge length and convex radius.
    /// </summary>
    /// <remarks>Internally the convex radius will be subtracted from the half extent so the total box will not grow with the convex radius.</remarks>
    public BoxShapeSettings(Vector3 halfExtent, float convexRadius = PhysicsSystem.DefaultConvexRadius, PhysicsMaterial material = null)
        : base(Native.Physics.Collision.Shape.BoxShapeSettings.Create(ref halfExtent, convexRadius, material?.NativePtr ?? IntPtr.Zero), true)
    {
    }
}
