#include <iostream>
#include "Jolt/Jolt.h"
#include "Jolt/Core/JobSystemThreadPool.h"
#include "Jolt/Physics/Collision/BroadPhase/BroadPhaseLayer.h"

using namespace JPH;


typedef uint(*GetNumBroadPhaseLayers)();

typedef BroadPhaseLayer(*GetBroadPhaseLayer)(ushort layer);

typedef const char *(*GetBroadPhaseLayerName)(uint8 layer);

class BroadPhaseLayerInterfaceWrapper : public BroadPhaseLayerInterface {
private:
    ::GetNumBroadPhaseLayers m_GetNumBroadPhaseLayers;
    ::GetBroadPhaseLayer m_GetBroadPhaseLayer;
    ::GetBroadPhaseLayerName m_GetBroadPhaseLayerName;

public:
    BroadPhaseLayerInterfaceWrapper(::GetNumBroadPhaseLayers GetNumBroadPhaseLayers,
                                    ::GetBroadPhaseLayer GetBroadPhaseLayer,
                                    ::GetBroadPhaseLayerName GetBroadPhaseLayerName) {
        m_GetNumBroadPhaseLayers = GetNumBroadPhaseLayers;
        m_GetBroadPhaseLayer = GetBroadPhaseLayer;
        m_GetBroadPhaseLayerName = GetBroadPhaseLayerName;
    }

    virtual uint GetNumBroadPhaseLayers() const override {
        return (*m_GetNumBroadPhaseLayers)();
    }

    virtual BroadPhaseLayer GetBroadPhaseLayer(ObjectLayer inLayer) const override {
        return (*m_GetBroadPhaseLayer)((uint16)inLayer);
    }

#if defined(JPH_EXTERNAL_PROFILE) || defined(JPH_PROFILE_ENABLED)

    /// Get the user readable name of a broadphase layer (debugging purposes)
    virtual const char *GetBroadPhaseLayerName(BroadPhaseLayer inLayer) const override {
        return (*m_GetBroadPhaseLayerName)((uint8) inLayer);
    }

#endif
};

extern "C" {

void *jolt_BroadPhaseLayerInterface_Create(::GetNumBroadPhaseLayers GetNumBroadPhaseLayers,
                                       ::GetBroadPhaseLayer GetBroadPhaseLayer,
                                       ::GetBroadPhaseLayerName GetBroadPhaseLayerName) {
    return (void *) new BroadPhaseLayerInterfaceWrapper(GetNumBroadPhaseLayers, GetBroadPhaseLayer,
                                                        GetBroadPhaseLayerName);
}

void jolt_BroadPhaseLayerInterface_Destroy(BroadPhaseLayerInterface *bpInterface) {
    delete bpInterface;
}

}