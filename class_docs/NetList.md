# NetList

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public delegate void ElementChangedEvent(NetList<T, TField> list, int index, T oldValue, T newValue);
- - public delegate void ArrayReplacedEvent(NetList<T, TField> list, IList<T> before, IList<T> after);
- - public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
- - public T Current => _current;
- - public Enumerator(NetList<T, TField> list)
- - public bool MoveNext()
- - public void Dispose()
- - public virtual T this[int index]
- - public int Count => count.Value;
- - public int Capacity => array.Value.Count;
- - public bool IsReadOnly => false;
- - public event ElementChangedEvent OnElementChanged;
- - public event ArrayReplacedEvent OnArrayReplaced;
- - public NetList()
- - public NetList(IEnumerable<T> values)
- - public NetList(int capacity)
- - public virtual void Add(T item)
- - public virtual void Clear()
- - public virtual void CopyFrom(IList<T> list)
- - public void Set(IList<T> list)
- - public void MoveFrom(NetList<T, TField> list)
- - public bool Any()
- - public virtual bool Contains(T item)
- - public void CopyTo(T[] array, int arrayIndex)
- - public List<T> GetRange(int index, int count)
- - public void AddRange(IEnumerable<T> collection)
- - public void RemoveRange(int index, int count)
- - public bool Equals(NetList<T, TField> other)
- - public Enumerator GetEnumerator()
- - public virtual int IndexOf(T item)
- - public virtual void Insert(int index, T item)
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public bool Remove(T item)
- - public virtual void RemoveAt(int index)
- - public int RemoveWhere(Func<T, bool> match)
- - public void Filter(Func<T, bool> f)
- - public override void Write(BinaryWriter writer)
- - public override void WriteFull(BinaryWriter writer)
- - public override string ToString()

## Private Members
- - private readonly NetList<T, TField> _list;
- - private int _index;
- - private T _current;
- - private bool _done;
- - private const int initialSize = 10;
- - private const double resizeFactor = 1.5;
- - private void hookField(int index, TField field)
- - private void hookArray(NetArray<T, TField> array)
- - private void Resize(int capacity)
- - private void EnsureCapacity(int neededCapacity)
- - private void fillNull()

## Protected Members
- - protected readonly NetInt count = new NetInt(0).Interpolated(interpolate: false, wait: false);
- - protected readonly NetRef<NetArray<T, TField>> array = new NetRef<NetArray<T, TField>>(new NetArray<T, TField>(10)).Interpolated(interpolate: false, wait: false);
- - protected override void ForEachChild(Action<INetSerializable> childAction)

## Internal Members
- *(None)*

## Other Members
- *(None)*
