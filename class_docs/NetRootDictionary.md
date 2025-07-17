# NetRootDictionary

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
- - public KeyValuePair<TKey, TValue> Current => _current;
- - public Enumerator(Dictionary<TKey, NetRoot<TValue>> roots)
- - public bool MoveNext()
- - public void Dispose()
- - public XmlSerializer Serializer;
- - public Dictionary<TKey, NetRoot<TValue>> Roots = new Dictionary<TKey, NetRoot<TValue>>();
- - public TValue this[TKey key]
- - public int Count => Roots.Count;
- - public bool IsReadOnly => ((IDictionary)Roots).IsReadOnly;
- - public ICollection<TKey> Keys => Roots.Keys;
- - public ICollection<TValue> Values => Roots.Values.Select((NetRoot<TValue> root) => root.Get()).ToList();
- - public NetRootDictionary()
- - public NetRootDictionary(IEnumerable<KeyValuePair<TKey, TValue>> values)
- - public void Add(KeyValuePair<TKey, TValue> item)
- - public void Add(TKey key, TValue value)
- - public void Clear()
- - public bool Contains(KeyValuePair<TKey, TValue> item)
- - public bool ContainsKey(TKey key)
- - public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
- - public Enumerator GetEnumerator()
- - public bool Remove(KeyValuePair<TKey, TValue> item)
- - public bool Remove(TKey key)
- - public bool TryGetValue(TKey key, out TValue value)
- - public struct NetVersion : IEquatable<NetVersion>
- - public uint this[int peerId]
- - public NetVersion(NetVersion other)
- - public int Size()
- - public void Set(NetVersion other)
- - public void Merge(NetVersion other)
- - public bool IsPriorityOver(NetVersion other)
- - public bool IsSimultaneousWith(NetVersion other)
- - public bool IsPrecededBy(NetVersion other)
- - public bool IsFollowedBy(NetVersion other)
- - public bool IsIndependent(NetVersion other)
- - public override string ToString()
- - public bool Equals(NetVersion other)
- - public override int GetHashCode()
- - public void Write(BinaryWriter writer)
- - public void Read(BinaryReader reader)
- - public void Clear()

## Private Members
- - private Dictionary<TKey, NetRoot<TValue>> _roots;
- - private Dictionary<TKey, NetRoot<TValue>>.Enumerator _enumerator;
- - private KeyValuePair<TKey, TValue> _current;
- - private bool _done;
- - private List<uint> _vector;
- - private List<uint> vector
- - private bool isOrdered(NetVersion other, Func<uint, uint, bool> comparison)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
