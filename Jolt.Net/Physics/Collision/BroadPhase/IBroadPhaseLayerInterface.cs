namespace ChickenWithLips.Jolt.Physics.Collision.BroadPhase;

public interface IBroadPhaseLayerInterface
{
    public IntPtr NativePtr { get; }

    /// <summary>Return the number of broadphase layers there are.</summary>
    public uint GetNumBroadPhaseLayers();

    /// <summary>Convert an object layer to the corresponding broadphase layer.</summary>
    public byte GetBroadPhaseLayer(ushort layer);

    /// <summary>Get the user readable name of a broadphase layer (debugging purposes).</summary>
    public string GetBroadPhaseLayerName(byte layer);
}
