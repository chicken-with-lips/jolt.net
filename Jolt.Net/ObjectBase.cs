namespace ChickenWithLips.Jolt;

using System;

public interface ObjectBase
{
    public IntPtr NativePtr { get; }
}

public abstract class ObjectBase<T> : ObjectBase, IDisposable
    where T : class
{
    #region Members

    public IntPtr NativePtr { get; protected set; }

    #endregion

    #region Methods

    protected ObjectBase(IntPtr ptr, bool automaticallyRegisterInCache = false)
    {
        NativePtr = ptr;

        if (automaticallyRegisterInCache) {
            ManuallyRegisterCache(ptr, this);
        }
    }

    ~ObjectBase()
    {
        Dispose(false);
    }

    protected static T GetOrCreateCache(IntPtr ptr, ObjectCache.CreateInstance createInstance)
    {
        return ObjectCache.Instance.GetOrCreate<T>(ptr, createInstance);
    }

    protected static void ManuallyRegisterCache(IntPtr ptr, ObjectBase instance)
    {
        ObjectCache.Instance.ManuallyRegisterCache(ptr, instance);
    }

    #endregion

    #region IDisposable

    #region Properties

    public bool IsDisposed { get; private set; }

    #endregion

    public virtual void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (IsDisposed) {
            return;
        }

        ObjectCache.Instance.Remove(NativePtr);

        IsDisposed = true;
    }

    protected void ThrowExceptionIfDisposed()
    {
        if (IsDisposed) {
            throw new ObjectDisposedException(typeof(T).FullName);
        }
    }

    #endregion
}
