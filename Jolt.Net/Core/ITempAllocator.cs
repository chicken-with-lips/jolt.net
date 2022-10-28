namespace ChickenWithLips.Jolt.Core;

/// <summary>Allocator for temporary allocations.</summary>
/// <remarks>
/// This allocator works as a stack: The blocks must always be freed in the reverse order as they are allocated.
/// Note that allocations and frees can take place from different threads, but the order is guaranteed though job
/// dependencies, so it is not needed to use any form of locking.
/// </remarks>
public interface ITempAllocator : ObjectBase
{
}
