using System.Runtime.InteropServices;
using ChickenWithLips.Jolt.Physics.Body;

namespace ChickenWithLips.Jolt.Native.Physics.Body;

internal static class Body
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_GetID")]
    public static extern BodyID GetID(IntPtr body);
    
    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_GetMotionProperties")]
    public static extern IntPtr GetMotionProperties(IntPtr body);
    
    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_GetMotionPropertiesUnchecked")]
    public static extern IntPtr GetMotionPropertiesUnchecked(IntPtr body);

    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_IsActive")]
    public static extern bool IsActive(IntPtr body);

    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_IsStatic")]
    public static extern bool IsStatic(IntPtr body);

    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_IsKinematic")]
    public static extern bool IsKinematic(IntPtr body);

    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_IsDynamic")]
    public static extern bool IsDynamic(IntPtr body);

    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_CanBeKinematicOrDynamic")]
    public static extern bool CanBeKinematicOrDynamic(IntPtr body);

    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_SetIsSensor")]
    public static extern void SetIsSensor(IntPtr body, bool inIsSensor);

    [DllImport("Jolt.Native", EntryPoint = "jolt_Body_IsSensor")]
    public static extern bool IsSensor(IntPtr body);
}
