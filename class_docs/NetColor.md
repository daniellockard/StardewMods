# NetColor

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public byte R
- - public byte G
- - public byte B
- - public byte A
- - public NetColor()
- - public NetColor(Color value)
- - public override void Set(Color newValue)
- - public new bool Equals(NetColor other)
- - public bool Equals(Color other)

## Private Members
- *(None)*

## Protected Members
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
