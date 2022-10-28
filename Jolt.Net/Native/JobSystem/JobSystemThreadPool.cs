using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Native.JobSystem;

internal static class JobSystemThreadPool
{
    [DllImport("Jolt.Native", EntryPoint = "jolt_JobSystemThreadPool_Create")]
    public static extern IntPtr Create(int maxJobs, int maxBarriers, int threadCount);
}
