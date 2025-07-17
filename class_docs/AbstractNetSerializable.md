# AbstractNetSerializable

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public ushort DeltaAggregateTicks;
- - public uint DirtyTick
- - public virtual bool Dirty => dirtyTick != uint.MaxValue;
- - public bool NeedsTick
- - public bool ChildNeedsTick
- - public string Name { get; set; }
- - public INetRoot Root { get; protected set; }
- - public INetSerializable Parent
- - public INetSerializable NetFields => this;
- - public void ResetNewestReceivedChangeVersion()
- - public void MarkDirty()
- - public void MarkClean()
- - public bool Tick()
- - public abstract void Read(BinaryReader reader, NetVersion version);
- - public abstract void Write(BinaryWriter writer);
- - public abstract void ReadFull(BinaryReader reader, NetVersion version);
- - public abstract void WriteFull(BinaryWriter writer);

## Private Members
- - private uint dirtyTick = uint.MaxValue;
- - private uint minNextDirtyTime;
- - private bool needsTick;
- - private bool childNeedsTick;
- - private INetSerializable parent;

## Protected Members
- - protected NetVersion ChangeVersion;
- - protected void SetDirtySooner(uint tick)
- - protected void SetDirtyLater(uint tick)
- - protected virtual void CleanImpl()
- - protected virtual bool tickImpl()
- - protected uint GetLocalTick()
- - protected NetVersion GetLocalVersion()
- - protected virtual void SetParent(INetSerializable parent)
- - protected virtual void SetChildParents()
- - protected virtual void ClearChildParents()
- - protected virtual void ValidateChild(INetSerializable child)
- - protected virtual void ValidateChildren()
- - protected virtual void ForEachChild(Action<INetSerializable> childAction)

## Internal Members
- *(None)*

## Other Members
- *(None)*
