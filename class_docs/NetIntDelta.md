# NetIntDelta

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public int DirtyThreshold;
- - public int? Minimum;
- - public int? Maximum;
- - public NetIntDelta()
- - public NetIntDelta(int value)
- - public override void Set(int newValue)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void WriteFull(BinaryWriter writer)

## Private Members
- - private int networkValue;
- - private int fixRange(int value)

## Protected Members
- - protected override int interpolate(int startValue, int endValue, float factor)
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
