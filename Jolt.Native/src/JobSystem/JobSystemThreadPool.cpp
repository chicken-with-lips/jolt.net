#include "Jolt/Jolt.h"
#include "Jolt/Core/JobSystemThreadPool.h"

using namespace JPH;

extern "C" {

void *jolt_JobSystemThreadPool_Create(int maxJobs, int maxBarriers, int threadCount) {
    return (void *) new JobSystemThreadPool();
}

}