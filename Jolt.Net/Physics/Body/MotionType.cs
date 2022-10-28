namespace ChickenWithLips.Jolt.Physics.Body;

public enum MotionType : byte
{
    /// <summary>Non movable.</summary>
    Static,

    /// <summary>Movable using velocities only, does not respond to forces.</summary>
    Kinematic,

    /// <summary>Responds to forces as a normal physics object.</summary>
    Dynamic,
};
