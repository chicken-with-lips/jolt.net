using System.Runtime.InteropServices;

namespace ChickenWithLips.Jolt.Physics.Body;

[StructLayout(LayoutKind.Sequential)]
public readonly struct BodyID
{
    /// <summary>The value for an invalid body ID.</summary>
    public const uint InvalidBodyID = 0xffffffff;

    /// <summary>This bit is used by the broadphase.</summary>
    public const uint BroadPhaseBit = 0x00800000;

    /// <summary>Maximum value for body index (also the maximum amount of bodies supported - 1).</summary>
    public const uint MaxBodyIndex = 0x7fffff;

    /// <summary>Maximum value for the sequence number.</summary>
    public const byte MaxSequenceNumber = 0xff;

    /// <summary>Get index in body array.</summary>
    public uint Index => _id & MaxBodyIndex;


    /// <summary>Get sequence number of body.</summary>
    /// <remarks>
    /// The sequence number can be used to check if a body ID with the same body index has been reused by another body.
    /// It is mainly used in multi threaded situations where a body is removed and its body index is immediately reused
    /// by a body created from another thread. Functions querying the broadphase can (after acquiring a body lock)
    /// detect that the body has been removed (we assume that this won't happen more than 128 times in a row).
    /// </remarks>
    public byte SequenceNumber => (byte)(_id >> 24);

    /// <summary>Returns the index and sequence number combined in an uint32.</summary>
    public uint IndexAndSequenceNumber => _id;

    /// <summary>Check if the ID is valid.</summary>
    public bool IsInvalid => _id == InvalidBodyID;

    private readonly uint _id;

    /// <summary>Construct invalid body ID.</summary>
    public BodyID()
    {
        _id = InvalidBodyID;
    }

    /// <summary>Construct from index and sequence number combined in a single uint32 (use with care!).</summary>
    public BodyID(uint id)
    {
        _id = id;
    }

    /// <summary>Construct from index and sequence number.</summary>
    public BodyID(uint id, byte sequenceNumber)
    {
        _id = ((uint)sequenceNumber) << 24 | id;
    }
}
