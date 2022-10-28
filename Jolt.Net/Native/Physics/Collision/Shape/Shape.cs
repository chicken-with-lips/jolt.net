using System.Numerics;
using System.Runtime.InteropServices;
using ChickenWithLips.Jolt.Physics.Collision.Shape;

namespace ChickenWithLips.Jolt.Native.Physics.Collision.Shape;

internal static class Shape
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_Shape_GetType")]
    public static extern ShapeType GetType(IntPtr shape);

    [DllImport("Jolt.Native", EntryPoint = "jolt_Shape_GetSubType")]
    public static extern ShapeSubType GetSubType(IntPtr shape);

    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeSettings_Destroy")]
    public static extern IntPtr DestroyResult(IntPtr result);
}
