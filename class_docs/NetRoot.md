# NetRoot

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetClock Clock { get; } = new NetClock();
- - public override bool Dirty => base.DirtyTick <= Clock.GetLocalTick();
- - public NetRoot()
- - public NetRoot(T value)
- - public void TickTree()
- - public override void Read(BinaryReader reader, NetVersion _)
- - public void Read(BinaryReader reader)
- - public override void Write(BinaryWriter writer)
- - public override void ReadFull(BinaryReader reader, NetVersion _)
- - public static NetRoot<T> Connect(BinaryReader reader)
- - public void ReadConnectionPacket(BinaryReader reader)
- - public void CreateConnectionPacket(BinaryWriter writer, long? connection)
- - public void Disconnect(long connection)
- - public virtual NetRoot<T> Clone()
- - public void CloneInto(NetRef<T> netref)

## Private Members
- - private Dictionary<long, int> connections = new Dictionary<long, int>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
