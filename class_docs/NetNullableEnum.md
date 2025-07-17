# NetNullableEnum

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetNullableEnum()
- - public NetNullableEnum(T value)
- - public override void Set(T? newValue)
- - public new IEnumerator<string> GetEnumerator()
- - public void Add(string value)

## Private Members
- - private bool xmlInitialized;

## Protected Members
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
