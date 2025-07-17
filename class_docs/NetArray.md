# NetArray

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public delegate void FieldCreateEvent(int index, TField field);
- - public List<TField> Fields => elements;
- - public T this[int index]
- - public int Count => elements.Count;
- - public int Length => elements.Count;
- - public bool IsReadOnly => false;
- - public bool IsFixedSize => base.Parent != null;
- - public event FieldCreateEvent OnFieldCreate;
- - public NetArray()
- - public NetArray(IEnumerable<T> values)
- - public NetArray(int size)
- - public void Add(T item)
- - public void Clear()
- - public bool Contains(T item)
- - public void CopyTo(T[] array, int arrayIndex)
- - public void SetCount(int size)
- - public void Set(IList<T> values)
- - public bool Equals(NetArray<T, TField> other)
- - public override bool Equals(object obj)
- - public override int GetHashCode()
- - public IEnumerator<T> GetEnumerator()
- - public int IndexOf(T item)
- - public void Insert(int index, T item)
- - public bool Remove(T item)
- - public void RemoveAt(int index)
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void Write(BinaryWriter writer)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void WriteFull(BinaryWriter writer)
- - public override string ToString()

## Private Members
- - private int appendPosition;
- - private readonly List<TField> elements = new List<TField>();
- - private TField createField(int index)
- - private void ensureCapacity(int size)

## Protected Members
- - protected override void ForEachChild(Action<INetSerializable> childAction)

## Internal Members
- *(None)*

## Other Members
- *(None)*
