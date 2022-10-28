using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Core;

internal static class TempAllocatorMalloc
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_TempAllocatorMalloc_Create")]
    public static extern IntPtr Create();
}
