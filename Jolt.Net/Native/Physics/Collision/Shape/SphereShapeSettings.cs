using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Physics.Collision.Shape;

internal static class SphereShapeSettings
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_SphereShapeSettings_CreateDefault")]
    public static extern IntPtr CreateDefault();

    [DllImport("Jolt.Native", EntryPoint = "jolt_SphereShapeSettings_Create")]
    public static extern IntPtr Create(float inRadius, IntPtr inMaterial);

    [DllImport("Jolt.Native", EntryPoint = "jolt_SphereShapeSettings_GetRadius")]
    public static extern float GetRadius(IntPtr settings);
}
