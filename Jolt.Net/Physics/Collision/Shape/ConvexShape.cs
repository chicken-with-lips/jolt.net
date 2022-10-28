using ChickenWithLips.Jolt.Native.Physics.Collision.Shape;

namespace ChickenWithLips.Jolt.Physics.Collision.Shape;

public abstract class ConvexShape : Shape
{
    public float Density { get; set; }

    protected ConvexShape(IntPtr ptr, bool automaticallyRegisterInCache = false) : base(ptr, automaticallyRegisterInCache)
    {
    }
}

public abstract class ConvexShapeSettings<ShapeType> : ShapeSettings<ShapeType> where ShapeType : Shape, new()
{
    public float Density {
        get => Native.Physics.Collision.Shape.ConvexShape.GetDensity(NativePtr);
        set => Native.Physics.Collision.Shape.ConvexShape.SetDensity(NativePtr, value);
    }

    protected ConvexShapeSettings(IntPtr ptr, bool automaticallyRegisterInCache = false)
        : base(ptr, automaticallyRegisterInCache)
    {
    }
}
