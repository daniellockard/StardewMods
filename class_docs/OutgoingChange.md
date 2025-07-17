# OutgoingChange

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool Removal;
- - public TValue Value;
- - public OutgoingChange(bool removal, TValue value)
- - public delegate void ContentsChangeEvent(TValue value);
- - public bool InterpolationWait = true;
- - public int Count => Set.Count;
- - public bool IsReadOnly => false;
- - public event ContentsChangeEvent OnValueAdded;
- - public event ContentsChangeEvent OnValueRemoved;
- - public NetHashSet()
- - public NetHashSet(IEnumerable<TValue> values)
- - public bool Add(TValue item)
- - public void Clear()
- - public bool Contains(TValue item)
- - public void CopyTo(TValue[] array, int arrayIndex)
- - public bool Equals(NetHashSet<TValue> other)
- - public void ExceptWith(IEnumerable<TValue> other)
- - public IEnumerator<TValue> GetEnumerator()
- - public void IntersectWith(IEnumerable<TValue> other)
- - public bool IsProperSubsetOf(IEnumerable<TValue> other)
- - public bool IsProperSupersetOf(IEnumerable<TValue> other)
- - public bool IsSubsetOf(IEnumerable<TValue> other)
- - public bool IsSupersetOf(IEnumerable<TValue> other)
- - public bool Overlaps(IEnumerable<TValue> other)
- - public bool Remove(TValue item)
- - public int RemoveWhere(Predicate<TValue> match)
- - public bool SetEquals(IEnumerable<TValue> other)
- - public void SymmetricExceptWith(IEnumerable<TValue> other)
- - public void UnionWith(IEnumerable<TValue> other)
- - public override bool Equals(object obj)
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void Write(BinaryWriter writer)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void WriteFull(BinaryWriter writer)
- - public override int GetHashCode()
- - public abstract TValue ReadValue(BinaryReader reader);
- - public abstract void WriteValue(BinaryWriter writer, TValue value);

## Private Members
- - private readonly HashSet<TValue> Set = new HashSet<TValue>();
- - private readonly List<IncomingChange> IncomingChanges = new List<IncomingChange>();
- - private readonly List<OutgoingChange> OutgoingChanges = new List<OutgoingChange>();
- - private void removedEvent(TValue value)
- - private void addedEvent(TValue value)

## Protected Members
- - protected override bool tickImpl()
- - protected override void CleanImpl()

## Internal Members
- *(None)*

## Other Members
- *(None)*
