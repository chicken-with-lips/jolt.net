using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Physics.Collision.Shape;

internal static class ConvexShape
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_ConvexShape_SetDensity")]
    public static extern void SetDensity(IntPtr shape, float inDensity);

    [DllImport("Jolt.Native", EntryPoint = "jolt_ConvexShape_GetDensity")]
    public static extern float GetDensity(IntPtr shape);
}
