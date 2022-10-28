using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Core;

internal static class TempAllocatorImpl
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_TempAllocatorImpl_Create")]
    public static extern IntPtr Create(int size);
}
