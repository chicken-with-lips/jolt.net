using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Core;

internal static class TempAllocator
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_TempAllocator_Destroy")]
    public static extern void Destroy(IntPtr tempAllocator);
}
