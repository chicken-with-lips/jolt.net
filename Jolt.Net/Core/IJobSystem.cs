namespace ChickenWithLips.Jolt.Core;

/// <summary>A class that allows units of work (Jobs) to be scheduled across multiple threads.</summary>
/// <remarks>
/// <para>It allows dependencies between the jobs so that the jobs form a graph.</para>
/// <para>
/// The pattern for using this class is:
/// </para>
/// <code>
///     // Create job system
///     JobSystem *job_system = new JobSystemThreadPool(...);
///
///     // Create some jobs
///     JobHandle second_job = job_system->CreateJob("SecondJob", Color::sRed, []() { ... }, 1); // Create a job with 1 dependency
///     JobHandle first_job = job_system->CreateJob("FirstJob", Color::sGreen, [second_job]() { ....; second_job.RemoveDependency(); }, 0); // Job can start immediately, will start second job when it's done
///     JobHandle third_job = job_system->CreateJob("ThirdJob", Color::sBlue, []() { ... }, 0); // This job can run immediately as well and can run in parallel to job 1 and 2
///
///     // Add the jobs to the barrier so that we can execute them while we're waiting
///     Barrier *barrier = job_system->CreateBarrier();
///     barrier->AddJob(first_job);
///     barrier->AddJob(second_job);
///     barrier->AddJob(third_job);
///     job_system->WaitForJobs(barrier);
///
///     // Clean up
///     job_system->DestroyBarrier(barrier);
///     delete job_system;
/// </code>
///
/// <para>Jobs are guaranteed to be started in the order that their dependency counter becomes zero (in case they're
/// scheduled on a background thread) or in the order they're added to the barrier (when dependency count is zero and
/// when executing on the thread that calls WaitForJobs).</para>
/// </remarks>
public interface IJobSystem : ObjectBase
{
    public int MaxConcurrency => Native.Core.JobSystem.GetMaxConcurrency(NativePtr);
}
