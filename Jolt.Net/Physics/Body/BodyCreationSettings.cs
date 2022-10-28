using System.Numerics;
using ChickenWithLips.Jolt.Physics.Collision.Shape;

namespace ChickenWithLips.Jolt.Physics.Body;

public class BodyCreationSettings : ObjectBase<BodyCreationSettings>
{
    public BodyCreationSettings(IShapeSettings shape, Vector3 position, Quaternion rotation, MotionType motionType, ushort objectLayer)
        : base(Native.Physics.Body.BodyCreationSettings.CreateWithShapeSettings(shape.NativePtr, ref position, ref rotation, motionType, objectLayer))
    {
    }

    public BodyCreationSettings(Shape shape, Vector3 position, Quaternion rotation, MotionType motionType, ushort objectLayer)
        : base(Native.Physics.Body.BodyCreationSettings.CreateWithShape(shape.NativePtr, ref position, ref rotation, motionType, objectLayer))
    {
    }
}
