# DeepClonerCache

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static object GetOrAddClass<T>(Type type, Func<Type, T> adder)
- - public static object GetOrAddDeepClassTo<T>(Type type, Func<Type, T> adder)
- - public static object GetOrAddShallowClassTo<T>(Type type, Func<Type, T> adder)
- - public static object GetOrAddStructAsObject<T>(Type type, Func<Type, T> adder)
- - public static T GetOrAddConvertor<T>(Type from, Type to, Func<Type, Type, T> adder)
- - public static void ClearCache()

## Private Members
- - private static readonly ConcurrentDictionary<Type, object> _typeCache = new ConcurrentDictionary<Type, object>();
- - private static readonly ConcurrentDictionary<Type, object> _typeCacheDeepTo = new ConcurrentDictionary<Type, object>();
- - private static readonly ConcurrentDictionary<Type, object> _typeCacheShallowTo = new ConcurrentDictionary<Type, object>();
- - private static readonly ConcurrentDictionary<Type, object> _structAsObjectCache = new ConcurrentDictionary<Type, object>();
- - private static readonly ConcurrentDictionary<Tuple<Type, Type>, object> _typeConvertCache = new ConcurrentDictionary<Tuple<Type, Type>, object>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
