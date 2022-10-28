using ChickenWithLips.Jolt.Native.Physics.Collision.Shape;

namespace ChickenWithLips.Jolt.Physics.Collision.Shape;

public abstract class Shape : ObjectBase<Shape>
{
    public ShapeType Type => Native.Physics.Collision.Shape.Shape.GetType(NativePtr);
    public ShapeSubType SubType => Native.Physics.Collision.Shape.Shape.GetSubType(NativePtr);

    protected Shape(IntPtr ptr, bool automaticallyRegisterInCache = false) : base(ptr, automaticallyRegisterInCache)
    {
    }

    internal static ShapeType? Create<ShapeType>(IntPtr ptr) where ShapeType : Shape, new()
    {
        if (ptr == IntPtr.Zero) {
            return null;
        }

        return ObjectCache.Instance.GetOrCreate<ShapeType>(ptr, delegate(IntPtr ptr) {
            var shape = new ShapeType();
            shape.NativePtr = ptr;

            return shape;
        });
    }
}

public interface IShapeSettings
{
    public IntPtr NativePtr { get; }
}

public abstract class ShapeSettings<ShapeType> : ObjectBase<ShapeSettings<ShapeType>>, IShapeSettings
    where ShapeType : Shape, new()
{
    protected ShapeSettings(IntPtr ptr, bool automaticallyRegisterInCache = false)
        : base(ptr, automaticallyRegisterInCache)
    {
    }

    public ShapeResult<ShapeType> Create()
    {
        return ShapeResult<ShapeType>.Create(Native.Physics.Collision.Shape.ShapeSettings.Create(NativePtr));
    }
}

public class ShapeResult<ShapeType> : ObjectBase<ShapeResult<ShapeType>>
    where ShapeType : Shape, new()
{
    /// <summary>Checks if the result is still uninitialized.</summary>
    public bool IsEmpty => Native.Physics.Collision.Shape.ShapeResult.IsEmpty(NativePtr);

    /// <summary>Checks if the result is valid.</summary>
    public bool IsValid => Native.Physics.Collision.Shape.ShapeResult.IsValid(NativePtr);

    /// <summary>Check if we had an error.</summary>
    public bool HasError => Native.Physics.Collision.Shape.ShapeResult.HasError(NativePtr);

    /// <summary>Check if we had an error.</summary>
    public string Error => Native.Physics.Collision.Shape.ShapeResult.GetError(NativePtr);

    /// <summary>Get the result value.</summary>
    public ShapeType? Value => Shape.Create<ShapeType>(Native.Physics.Collision.Shape.ShapeResult.Get(NativePtr));

    protected ShapeResult(IntPtr ptr, bool automaticallyRegisterInCache = false) : base(ptr, automaticallyRegisterInCache)
    {
    }

    internal static ShapeResult<ShapeType>? Create(IntPtr ptr)
    {
        return GetOrCreateCache(ptr, ptr => new ShapeResult<ShapeType>(ptr, false));
    }
}

/// <summary>
/// Shapes are categorized in groups, each shape can return which group it belongs to through its Shape::GetType
/// function.
/// </summary>
public enum ShapeType : byte
{
    /// <summary>Used by ConvexShape, all shapes that use the generic convex vs convex collision detection system (box, sphere, capsule, tapered capsule, cylinder, triangle).</summary>
    Convex,

    /// <summary>Used by CompoundShape.</summary>
    Compound,

    /// <summary>Used by DecoratedShape.</summary>
    Decorated,

    /// <summary>Used by MeshShape.</summary>
    Mesh,

    /// <summary>Used by HeightFieldShape.</summary>
    HeightField,

    // User defined shapes
    User1,
    User2,
    User3,
    User4,
}


/// <summary>This enumerates all shape types, each shape can return its type through Shape::GetSubType</summary>
public enum ShapeSubType : byte
{
    // Convex shapes
    Sphere,
    Box,
    Triangle,
    Capsule,
    TaperedCapsule,
    Cylinder,
    ConvexHull,

    // Compound shapes
    StaticCompound,
    MutableCompound,

    // Decorated shapes
    RotatedTranslated,
    Scaled,
    OffsetCenterOfMass,

    // Other shapes
    Mesh,
    HeightField,

    // User defined shapes
    User1,
    User2,
    User3,
    User4,
    User5,
    User6,
    User7,
    User8,
}
