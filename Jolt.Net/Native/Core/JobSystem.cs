using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Core;

internal static class JobSystem
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_JobSystem_GetMaxConcurrency")]
    public static extern int GetMaxConcurrency(IntPtr jobSystem);

    [DllImport("Jolt.Native", EntryPoint = "jolt_JobSystem_Destroy")]
    public static extern void Destroy(IntPtr jobSystem);
}
