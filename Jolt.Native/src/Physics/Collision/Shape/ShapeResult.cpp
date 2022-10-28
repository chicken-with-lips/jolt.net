#include "Jolt/Jolt.h"
#include "Jolt/Physics/Collision/Shape/Shape.h"

using namespace JPH;

class ShapeResult {
private:
    ShapeSettings::ShapeResult mResult;

public:
    ShapeResult(ShapeSettings::ShapeResult result) {
        mResult = result;
    }

    ShapeSettings::ShapeResult Get() {
        return mResult;
    }
};

extern "C" {

void *jolt_ShapeSettings_Create(ShapeSettings *settings) {
    return new ShapeResult(settings->Create());
}

void jolt_ShapeSettings_DestroyResult(ShapeResult *result) {
    delete result;
}

bool jolt_ShapeResult_IsValid(ShapeResult *result) {
    return result->Get().IsValid();
}

bool jolt_ShapeResult_IsEmpty(ShapeResult *result) {
    return result->Get().IsEmpty();
}

bool jolt_ShapeResult_HasError(ShapeResult *result) {
    return result->Get().HasError();
}

const char *jolt_ShapeResult_GetError(ShapeResult *result) {
    return result->Get().GetError().c_str();
}

void *jolt_ShapeResult_Get(ShapeResult *result) {
    return result->Get().Get();
}

}