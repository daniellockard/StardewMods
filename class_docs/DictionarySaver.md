# DictionarySaver

**Summary:** Handles saving or loading game data.

## Public Members
- - public static SaveablePair<TKey, TValue>[] ArrayFrom(IDictionary<TKey, TValue> data)
- - public static SaveablePair<TKey, TValue>[] ArrayFrom<TSourceValue>(IDictionary<TKey, TSourceValue> data, Func<TSourceValue, TValue> getValue)
- - public static SaveablePair<TKey, TValue>[] ArrayFrom<TSourceKey, TSourceValue>(IDictionary<TSourceKey, TSourceValue> data, Func<TSourceKey, TKey> getKey, Func<TSourceValue, TValue> getValue)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
