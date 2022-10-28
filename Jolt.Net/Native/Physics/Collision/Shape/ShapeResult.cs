using System.Numerics;
using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Physics.Collision.Shape;

internal static class ShapeResult
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeResult_GetState")]
    public static extern byte Create(IntPtr shapeResult);

    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeResult_IsValid")]
    public static extern bool IsValid(IntPtr shapeResult);

    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeResult_IsEmpty")]
    public static extern bool IsEmpty(IntPtr shapeResult);

    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeResult_HasError")]
    public static extern bool HasError(IntPtr shapeResult);

    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeResult_GetError")]
    public static extern string GetError(IntPtr shapeResult);

    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeResult_Get")]
    public static extern IntPtr Get(IntPtr shapeResult);
}
