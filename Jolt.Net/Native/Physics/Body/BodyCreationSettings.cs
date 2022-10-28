using System.Numerics;
using System.Runtime.InteropServices;
using ChickenWithLips.Jolt.Physics.Body;

namespace ChickenWithLips.Jolt.Native.Physics.Body;

internal static class BodyCreationSettings
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyCreationSettings_CreateWithShapeSettings")]
    public static extern IntPtr CreateWithShapeSettings(IntPtr inShape, ref Vector3 inPosition, ref Quaternion inRotation, MotionType inMotionType, ushort inObjectLayer);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BodyCreationSettings_CreateWithShape")]
    public static extern IntPtr CreateWithShape(IntPtr inShape, ref Vector3 inPosition, ref Quaternion inRotation, MotionType inMotionType, ushort inObjectLayer);
}
