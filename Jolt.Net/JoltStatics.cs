using ChickenWithLips.Jolt.Native;

namespace ChickenWithLips.Jolt;

public static class JoltStatics
{
    public static void RegisterDefaultAllocator() => Statics.RegisterDefaultAllocator();
    public static void RegisterTypes() => Statics.RegisterTypes();
    public static void RegisterFactory() => Statics.RegisterFactory();
}
