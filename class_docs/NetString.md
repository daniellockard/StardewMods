# NetString

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public delegate string FilterString(string newValue);
- - public int Length => base.Value.Length;
- - public event FilterString FilterStringEvent;
- - public NetString()
- - public NetString(string value)
- - public override void Set(string newValue)
- - public bool Contains(string substr)

## Private Members
- *(None)*

## Protected Members
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
