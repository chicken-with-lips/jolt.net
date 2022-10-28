#include "Jolt/Jolt.h"
#include "Jolt/Core/JobSystemThreadPool.h"

using namespace JPH;

extern "C" {

int jolt_JobSystem_GetMaxConcurrency(JobSystem *jobSystem) {
    return jobSystem->GetMaxConcurrency();
}

void jolt_JobSystem_Destroy(JobSystem *jobSystem) {
    delete jobSystem;
}

}