# NetEvent0

**Summary:** Represents a game event or cutscene.

## Public Members
- - public delegate void Event();
- - public readonly NetInt Counter = new NetInt();
- - public event Event onEvent;
- - public NetEvent0(bool interpolate = false)
- - public void Fire()
- - public void Poll()
- - public void Clear()
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void Write(BinaryWriter writer)
- - public override void WriteFull(BinaryWriter writer)

## Private Members
- - private int currentCount;

## Protected Members
- - protected override void ForEachChild(Action<INetSerializable> childAction)

## Internal Members
- *(None)*

## Other Members
- *(None)*
