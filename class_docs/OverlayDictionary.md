# OverlayDictionary

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public TValue this[TKey key]
- - public ICollection<TKey> Keys => _dictionary.Keys;
- - public ICollection<TValue> Values => _dictionary.Values;
- - public int Count => _dictionary.Count;
- - public bool IsReadOnly => ((ICollection<KeyValuePair<TKey, TValue>>)_dictionary).IsReadOnly;
- - public event Action<TKey, TValue> onValueAdded;
- - public event Action<TKey, TValue> onValueRemoved;
- - public OverlayDictionary()
- - public OverlayDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
- - public OverlayDictionary(IEqualityComparer<TKey> comparer)
- - public void Add(TKey key, TValue value)
- - public void Add(KeyValuePair<TKey, TValue> item)
- - public void Clear()
- - public bool Contains(KeyValuePair<TKey, TValue> item)
- - public bool ContainsKey(TKey key)
- - public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
- - public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
- - public bool Remove(TKey key)
- - public bool Remove(KeyValuePair<TKey, TValue> item)
- - public bool TryGetValue(TKey key, out TValue value)
- - public TValue GetValueOrDefault(TKey key, TValue defaultValue = default(TValue))

## Private Members
- *(None)*

## Protected Members
- - protected Dictionary<TKey, TValue> _dictionary;
- - protected List<KeyValuePair<TKey, TValue>> _removedPairs = new List<KeyValuePair<TKey, TValue>>();

## Internal Members
- *(None)*

## Other Members
- *(None)*
