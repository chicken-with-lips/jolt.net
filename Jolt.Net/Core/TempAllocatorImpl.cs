namespace ChickenWithLips.Jolt.Core;

/// <summary>
/// Default implementation of the temp allocator that allocates a large block through malloc upfront.
/// </summary>
public class TempAllocatorImpl : ObjectBase<TempAllocatorImpl>, ITempAllocator
{
    public TempAllocatorImpl(int size)
        : base(Native.Core.TempAllocatorImpl.Create(size), true)
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
