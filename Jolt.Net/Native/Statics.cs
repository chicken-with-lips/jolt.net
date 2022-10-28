using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native;

internal static class Statics
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_Statics_RegisterDefaultAllocator")]
    public static extern void RegisterDefaultAllocator();

    [DllImport("Jolt.Native", EntryPoint = "jolt_Statics_RegisterTypes")]
    public static extern void RegisterTypes();

    [DllImport("Jolt.Native", EntryPoint = "jolt_Statics_RegisterFactory")]
    public static extern void RegisterFactory();
}
