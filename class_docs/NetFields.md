# NetFields

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public static bool ShouldValidateNetFields;
- - public new string Name { get; }
- - public INetObject<NetFields> Owner { get; private set; }
- - public NetFields(string name)
- - public NetFields SetOwner(INetObject<NetFields> owner)
- - public static string GetNameForInstance<TBaseType>(TBaseType instance)
- - public IEnumerable<INetSerializable> GetFields()
- - public void CancelInterpolation()
- - public NetFields AddField(INetSerializable field, [CallerArgumentExpression("field")] string name = null)
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void Write(BinaryWriter writer)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void WriteFull(BinaryWriter writer)
- - public virtual void CopyFrom(NetFields source)

## Private Members
- - private readonly List<INetSerializable> fields = new List<INetSerializable>();

## Protected Members
- - protected override void SetParent(INetSerializable parent)
- - protected void ValidateNetFields()
- - protected override void ForEachChild(Action<INetSerializable> childAction)

## Internal Members
- *(None)*

## Other Members
- *(None)*
