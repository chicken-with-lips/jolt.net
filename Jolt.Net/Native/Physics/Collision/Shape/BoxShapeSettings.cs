using System.Numerics;
using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Physics.Collision.Shape;

internal static class BoxShapeSettings
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_BoxShapeSettings_CreateDefault")]
    public static extern IntPtr CreateDefault();

    [DllImport("Jolt.Native", EntryPoint = "jolt_BoxShapeSettings_Create")]
    public static extern IntPtr Create(ref Vector3 inHalfExtent, float inConvexRadius, IntPtr inMaterial);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BoxShapeSettings_GetHalfExtent")]
    public static extern Vector3 GetHalfExtent(IntPtr settings);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BoxShapeSettings_GetConvexRadius")]
    public static extern float GetConvexRadius(IntPtr settings);
}
