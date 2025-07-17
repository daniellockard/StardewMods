# NetRefBase

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public delegate void ConflictResolveEvent(T rejected, T accepted);
- - public XmlSerializer Serializer;
- - public event ConflictResolveEvent OnConflictResolve;
- - public NetRefBase()
- - public NetRefBase(T value)
- - public void MarkReassigned()
- - public override void Set(T newValue)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void WriteFull(BinaryWriter writer)

## Private Members
- - private enum RefDeltaType : byte
- - private RefDeltaType deltaType;
- - private T createType(Type type)
- - private void serialize(BinaryWriter writer, XmlSerializer serializer = null)
- - private T deserialize(BinaryReader reader, XmlSerializer serializer = null)
- - private void writeBaseValue(BinaryWriter writer)
- - private T readBaseValue(BinaryReader reader, NetVersion version)

## Protected Members
- - protected NetVersion reassigned;
- - protected override void SetParent(INetSerializable parent)
- - protected override void CleanImpl()
- - protected T ReadType(BinaryReader reader)
- - protected void WriteType(BinaryWriter writer)
- - protected abstract void ReadValueFull(T value, BinaryReader reader, NetVersion version);
- - protected abstract void ReadValueDelta(BinaryReader reader, NetVersion version);
- - protected abstract void WriteValueFull(BinaryWriter writer);
- - protected abstract void WriteValueDelta(BinaryWriter writer);
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
