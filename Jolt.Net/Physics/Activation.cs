namespace ChickenWithLips.Jolt.Physics;

/// <summary>
/// Enum used by AddBody to determine if the body needs to be initially active.
/// </summary>
public enum Activation
{
    /// <summary>Activate the body, making it part of the simulation.</summary>
    Activate,

    /// <summary>Leave activation state as it is (will not deactivate an active body).</summary>
    DontActivate
};
