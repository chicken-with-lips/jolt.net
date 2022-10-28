using System.Numerics;
using ChickenWithLips.Jolt.Core;
using ChickenWithLips.Jolt.Physics.Collision.BroadPhase;

namespace ChickenWithLips.Jolt.Physics;

/// <summary>
/// The main class for the physics system. It contains all rigid bodies and simulates them.
/// </summary>
/// <remarks>
/// The main simulation is performed by the Update() call on multiple threads (if the JobSystem is configured to use
/// them). Please refer to the general architecture overview in the Docs folder for more information.
/// </remarks>
public class PhysicsSystem : ObjectBase<PhysicsSystem>
{

    /// <summary>If objects are closer than this distance, they are considered to be colliding (used for GJK) (unit: meter).</summary>
    public const float DefaultCollisionTolerance = 1.0e-4f;

    /// <summary>A factor that determines the accuracy of the penetration depth calculation. If the change of the squared distance is less than tolerance * current_penetration_depth^2 the algorithm will terminate. (unit: dimensionless).</summary>
    public const float DefaultPenetrationTolerance = 1.0e-4f; ///< Stop when there's less than 1% change

    /// <summary>How much padding to add around objects.</summary>
    public const float DefaultConvexRadius = 0.05f;

    /// <summary>Used by (Tapered)CapsuleShape to determine when supporting face is an edge rather than a point (unit: meter).</summary>
    public const float CapsuleProjectionSlop = 0.02f;

    /// <summary>Maximum amount of jobs to allow.</summary>
    public const int MaxPhysicsJobs = 2048;

    /// <summary>Maximum amount of barriers to allow.</summary>
    public const int MaxPhysicsBarriers = 8;

    public Vector3 Gravity {
        get => Native.Physics.PhysicsSystem.GetGravity(NativePtr);
        set => Native.Physics.PhysicsSystem.SetGravity(NativePtr, value);
    }

    public BodyInterface BodyInterface => BodyInterface.Create(Native.Physics.PhysicsSystem.GetBodyInterface(NativePtr));
    public BodyInterface BodyNoLockInterface => BodyInterface.Create(Native.Physics.PhysicsSystem.GetBodyNoLockInterface(NativePtr));

    public PhysicsSystem()
        : base(Native.Physics.PhysicsSystem.Create(), true)
    {
    }

    /// <summary>
    ///Initialize the system.
    /// </summary>
    /// <param name="maxBodies">Maximum number of bodies to support.</param>
    /// <param name="bodyMutexesCount">Number of body mutexes to use. Should be a power of 2 in the range [1, 64], use 0 to auto detect.</param>
    /// <param name="maxBodyPairs">Maximum amount of body pairs to process (anything else will fall through the world), this number should generally be much higher than the max amount of contact points as there will be lots of bodies close that are not actually touching.</param>
    /// <param name="maxContactConstraints">Maximum amount of contact constraints to process (anything else will fall through the world).</param>
    /// <param name="broadPhaseLayerInterface">Information on the mapping of object layers to broad phase layers, note since this is a virtual interface, the instance needs to stay alive during the lifetime of the PhysicsSystem.</param>
    /// <param name="objectVsBroadPhaseLayerFilter">Filter callback function that is used to determine if an object layer collides with a broad phase layer.</param>
    /// <param name="objectLayerPairFilter">Filter callback function that is used to determine if two object layers collide.</param>
    public void Init(uint maxBodies, uint bodyMutexesCount, uint maxBodyPairs,
        uint maxContactConstraints, IBroadPhaseLayerInterface broadPhaseLayerInterface,
        ObjectVsBroadPhaseLayerFilter objectVsBroadPhaseLayerFilter,
        ObjectLayerPairFilter objectLayerPairFilter)
    {
        Native.Physics.PhysicsSystem.Init(NativePtr, maxBodies, bodyMutexesCount, maxBodyPairs,
            maxContactConstraints, broadPhaseLayerInterface.NativePtr,
            objectVsBroadPhaseLayerFilter,
            objectLayerPairFilter);
    }

    /// <summary>
    /// Optimize the broadphase, needed only if you've added many bodies prior to calling Update() for the first time.
    /// </summary>
    public void OptimizeBroadPhase()
    {
        Native.Physics.PhysicsSystem.OptimizeBroadPhase(NativePtr);
    }

    /// <summary>
    /// Simulate the system.
    /// </summary>
    /// <remarks>
    /// The world steps for a total of <see cref="deltaTime"/>. This is divided in <see cref="collisionSteps"/>
    /// iterations. Each iteration consists of collision detection followed by <see cref="integrationSubSteps"/>
    /// integration steps.
    /// </remarks>
    public void Update(float deltaTime, int collisionSteps, int integrationSubSteps, ITempAllocator tempAllocator, IJobSystem jobSystem)
    {
        Native.Physics.PhysicsSystem.Update(NativePtr, deltaTime, collisionSteps, integrationSubSteps, tempAllocator.NativePtr, jobSystem.NativePtr);
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);

        if (!IsDisposed) {
            Native.Physics.PhysicsSystem.Destroy(NativePtr);
        }
    }
}

/// <summary>
/// Function to test if an object can collide with a broadphase layer. Used while finding collision pairs.
/// </summary>
public delegate bool ObjectVsBroadPhaseLayerFilter(ushort layer1, byte layer2);

/// <summary>
/// Function to test if two objects can collide based on their object layer. Used while finding collision pairs.
/// </summary>
public delegate bool ObjectLayerPairFilter(ushort layer1, ushort layer2);
