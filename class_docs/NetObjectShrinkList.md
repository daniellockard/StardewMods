# NetObjectShrinkList

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
- - public T Current => _current;
- - public Enumerator(NetArray<T, NetRef<T>> array)
- - public bool MoveNext()
- - public void Dispose()
- - public T this[int index]
- - public int Count
- - public bool IsReadOnly => false;
- - public NetObjectShrinkList()
- - public NetObjectShrinkList(IEnumerable<T> values)
- - public void Add(T item)
- - public void Clear()
- - public void CopyFrom(IList<T> list)
- - public void Set(IList<T> list)
- - public void MoveFrom(IList<T> list)
- - public bool Contains(T item)
- - public void CopyTo(T[] array, int arrayIndex)
- - public List<T> GetRange(int index, int count)
- - public void AddRange(IEnumerable<T> collection)
- - public void RemoveRange(int index, int count)
- - public bool Equals(NetObjectShrinkList<T> other)
- - public Enumerator GetEnumerator()
- - public int IndexOf(T item)
- - public void Insert(int index, T item)
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public bool Remove(T item)
- - public void RemoveAt(int index)
- - public override void Write(BinaryWriter writer)
- - public override void WriteFull(BinaryWriter writer)
- - public override string ToString()

## Private Members
- - private readonly NetArray<T, NetRef<T>> _array;
- - private int _index;
- - private T _current;
- - private bool _done;
- - private NetArray<T, NetRef<T>> array = new NetArray<T, NetRef<T>>();

## Protected Members
- - protected override void ForEachChild(Action<INetSerializable> childAction)

## Internal Members
- *(None)*

## Other Members
- *(None)*
