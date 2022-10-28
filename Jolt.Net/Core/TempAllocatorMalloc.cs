namespace ChickenWithLips.Jolt.Core;

/// <summary>
/// Implementation of the TempAllocator that just falls back to malloc/free
/// </summary>
/// <remarks>
/// Note: This can be quite slow when running in the debugger as large memory blocks need to be initialized with 0xcd.
/// </remarks>
public class TempAllocatorMalloc : ObjectBase<TempAllocatorMalloc>, ITempAllocator
{
    public TempAllocatorMalloc()
        : base(Native.Core.TempAllocatorMalloc.Create(), true)
    {
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (!IsDisposed) {
            Native.Core.TempAllocator.Destroy(NativePtr);
        }
    }
}
