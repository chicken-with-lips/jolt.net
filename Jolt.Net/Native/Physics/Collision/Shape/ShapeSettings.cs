using System.Numerics;
using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Physics.Collision.Shape;

internal static class ShapeSettings
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeSettings_Create")]
    public static extern IntPtr Create(IntPtr settings);

    [DllImport("Jolt.Native", EntryPoint = "jolt_ShapeSettings_Destroy")]
    public static extern IntPtr DestroyResult(IntPtr result);
}
