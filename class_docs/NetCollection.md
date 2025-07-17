# NetCollection

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public delegate void ContentsChangeEvent(T value);
- - public int Count => list.Count;
- - public bool IsReadOnly => false;
- - public bool InterpolationWait
- - public T this[int index]
- - public T this[Guid guid] => elements[guid];
- - public event ContentsChangeEvent OnValueAdded;
- - public event ContentsChangeEvent OnValueRemoved;
- - public NetCollection()
- - public NetCollection(IEnumerable<T> values)
- - public bool TryGetValue(Guid id, out T value)
- - public void Add(T item)
- - public bool Equals(NetCollection<T> other)
- - public List<T>.Enumerator GetEnumerator()
- - public void Clear()
- - public void Set(ICollection<T> other)
- - public bool Contains(T item)
- - public bool ContainsGuid(Guid guid)
- - public Guid GuidOf(T item)
- - public int IndexOf(T item)
- - public void Insert(int index, T item)
- - public void CopyTo(T[] array, int arrayIndex)
- - public bool Remove(T item)
- - public void RemoveAt(int index)
- - public void Remove(Guid guid)
- - public int RemoveWhere(Func<T, bool> match)
- - public void Filter(Func<T, bool> f)
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void Write(BinaryWriter writer)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void WriteFull(BinaryWriter writer)

## Private Members
- - private List<Guid> guids = new List<Guid>();
- - private List<T> list = new List<T>();
- - private NetGuidDictionary<T, NetRef<T>> elements = new NetGuidDictionary<T, NetRef<T>>();

## Protected Members
- - protected override void ForEachChild(Action<INetSerializable> childAction)

## Internal Members
- *(None)*

## Other Members
- *(None)*
