# OverlaidDictionary

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int Length => compositeDict.Count;
- - public Object this[Vector2 key]
- - public Dictionary<Vector2, Object>.KeyCollection Keys => compositeDict.Keys;
- - public Dictionary<Vector2, Object>.ValueCollection Values => compositeDict.Values;
- - public IEnumerable<KeyValuePair<Vector2, Object>> Pairs => compositeDict;
- - public void OnValueAdded(Vector2 key, Object value)
- - public void OnValueRemoved(Vector2 key, Object value)
- - public void SetEqualityComparer(IEqualityComparer<Vector2> comparer, ref NetVector2Dictionary<Object, NetRef<Object>> base_dict, ref OverlayDictionary<Vector2, Object> overlay_dict)
- - public OverlaidDictionary(NetVector2Dictionary<Object, NetRef<Object>> baseDict, OverlayDictionary<Vector2, Object> overlayDict)
- - public bool Any()
- - public int Count()
- - public void Lock()
- - public void Unlock()
- - public void Add(Vector2 key, Object value)
- - public bool TryAdd(Vector2 key, Object value)
- - public void Clear()
- - public bool ContainsKey(Vector2 key)
- - public bool Remove(Vector2 key)
- - public bool TryGetValue(Vector2 key, out Object value)
- - public Object GetValueOrDefault(Vector2 key, Object defaultValue = null)
- - public IEnumerator<SerializableDictionary<Vector2, Object>> GetEnumerator()
- - public void Add(SerializableDictionary<Vector2, Object> dict)

## Private Members
- - private NetVector2Dictionary<Object, NetRef<Object>> baseDict;
- - private OverlayDictionary<Vector2, Object> overlayDict;
- - private Dictionary<Vector2, Object> compositeDict;
- - private bool _locked;
- - private Dictionary<Vector2, Object> _changes = new Dictionary<Vector2, Object>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
