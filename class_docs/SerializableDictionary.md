# SerializableDictionary

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public struct ChangeArgs
- - public readonly ChangeType Type;
- - public readonly TKey Key;
- - public readonly TValue Value;
- - public ChangeArgs(ChangeType type, TKey k, TValue v)
- - public delegate void ChangeCallback(object sender, ChangeArgs args);
- - public event ChangeCallback CollectionChanged;
- - public SerializableDictionary()
- - public SerializableDictionary(IDictionary<TKey, TValue> data)
- - public static SerializableDictionary<TKey, TValue> BuildFrom<TSourceValue>(IDictionary<TKey, TSourceValue> data, Func<TSourceValue, TValue> getValue)
- - public static SerializableDictionary<TKey, TValue> BuildFrom<TSourceKey, TSourceValue>(IDictionary<TSourceKey, TSourceValue> data, Func<TSourceKey, TKey> getKey, Func<TSourceValue, TValue> getValue)
- - public new void Add(TKey key, TValue value)
- - public new bool Remove(TKey key)
- - public new void Clear()
- - public XmlSchema GetSchema()
- - public void ReadXml(XmlReader reader)
- - public void WriteXml(XmlWriter writer)

## Private Members
- - private static XmlSerializer _keySerializer;
- - private static XmlSerializer _valueSerializer;
- - private void OnCollectionChanged(object sender, ChangeArgs args)

## Protected Members
- - protected SerializableDictionary(IEqualityComparer<TKey> comparer = null)
- - protected SerializableDictionary(IDictionary<TKey, TValue> data, IEqualityComparer<TKey> comparer = null)
- - protected virtual void AddDuringDeserialization(TKey key, TValue value)

## Internal Members
- *(None)*

## Other Members
- - static SerializableDictionary()
