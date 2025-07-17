# NetExtendableRef

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetExtendableRef()
- - public NetExtendableRef(T value)

## Private Members
- - private void clearValueParent(T targetValue)
- - private void setValueParent(T targetValue)

## Protected Members
- - protected override void ForEachChild(Action<INetSerializable> childAction)
- - protected override void ReadValueFull(T value, BinaryReader reader, NetVersion version)
- - protected override void ReadValueDelta(BinaryReader reader, NetVersion version)
- - protected override void targetValueChanged(T oldValue, T newValue)
- - protected override void WriteValueFull(BinaryWriter writer)
- - protected override void WriteValueDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
