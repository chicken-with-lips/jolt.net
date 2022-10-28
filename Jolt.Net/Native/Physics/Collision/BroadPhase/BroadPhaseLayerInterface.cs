using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.Physics.Collision.BroadPhase;

internal static class BroadPhaseLayerInterface
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_BroadPhaseLayerInterface_Create")]
    public static extern IntPtr Create(GetNumBroadPhaseLayers getNumBroadPhaseLayers, GetBroadPhaseLayer getBroadPhaseLayer, GetBroadPhaseLayerName getBroadPhaseLayerName);

    [DllImport("Jolt.Native", EntryPoint = "jolt_BroadPhaseLayerInterface_Delete")]
    public static extern void Destroy(IntPtr bpInterface);


    public delegate uint GetNumBroadPhaseLayers();

    public delegate byte GetBroadPhaseLayer(ushort layer);

    public delegate string GetBroadPhaseLayerName(byte layer);
}
