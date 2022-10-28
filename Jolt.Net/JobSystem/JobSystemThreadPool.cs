using ChickenWithLips.Jolt.Core;

namespace ChickenWithLips.Jolt.JobSystem;

/// <summary>
/// Implementation of a JobSystem using a thread pool
/// </summary>
/// <remarks>
/// Note that this is considered an example implementation. It is expected that when you integrate
/// the physics engine into your own project that you'll provide your own implementation of the
/// JobSystem built on top of whatever job system your project uses.
/// </remarks>
public class JobSystemThreadPool : ObjectBase<JobSystemThreadPool>, IJobSystem
{
    public JobSystemThreadPool(int maxJobs, int maxBarriers, int threadCount)
        : base(Native.JobSystem.JobSystemThreadPool.Create(maxJobs, maxBarriers, threadCount), true)
    {
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (!IsDisposed) {
            Native.Core.JobSystem.Destroy(NativePtr);
        }
    }
}
