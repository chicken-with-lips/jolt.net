namespace ChickenWithLips.Jolt.Physics.Collision.BroadPhase;

public abstract class BroadPhaseLayerBase
    : ObjectBase<BroadPhaseLayerBase>, IBroadPhaseLayerInterface
{
    private Native.Physics.Collision.BroadPhase.BroadPhaseLayerInterface.GetBroadPhaseLayer _getBroadPhaseLayer;
    private Native.Physics.Collision.BroadPhase.BroadPhaseLayerInterface.GetBroadPhaseLayerName _getBroadPhaseLayerName;
    private Native.Physics.Collision.BroadPhase.BroadPhaseLayerInterface.GetNumBroadPhaseLayers _getNumBroadPhaseLayers;

    public BroadPhaseLayerBase() : base(IntPtr.Zero)
    {
        _getBroadPhaseLayer = OnGetBroadPhaseLayer;
        _getBroadPhaseLayerName = OnGetBroadPhaseLayerName;
        _getNumBroadPhaseLayers = OnGetNumBroadPhaseLayers;

        NativePtr = Native.Physics.Collision.BroadPhase.BroadPhaseLayerInterface.Create(
            _getNumBroadPhaseLayers,
            _getBroadPhaseLayer,
            _getBroadPhaseLayerName
        );

        ManuallyRegisterCache(NativePtr, this);
    }

    public abstract uint GetNumBroadPhaseLayers();

    public abstract byte GetBroadPhaseLayer(ushort layer);

    public abstract string GetBroadPhaseLayerName(byte layer);

    private uint OnGetNumBroadPhaseLayers()
    {
        return GetNumBroadPhaseLayers();
    }

    private byte OnGetBroadPhaseLayer(ushort layer)
    {
        return GetBroadPhaseLayer(layer);
    }

    private string OnGetBroadPhaseLayerName(byte layer)
    {
        return GetBroadPhaseLayerName(layer);
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (! IsDisposed) {
            Native.Physics.Collision.BroadPhase.BroadPhaseLayerInterface.Destroy(NativePtr);
        }
    }
}
