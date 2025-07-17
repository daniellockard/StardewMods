# StaticDelegateBuilder

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly object CreatedDelegate;
- - public readonly string Error;
- - public CachedDelegate(object createdDelegate, string error)
- - public static bool TryCreateDelegate<TDelegate>(string fullMethodName, out TDelegate createdDelegate, out string error) where TDelegate : Delegate

## Private Members
- - private struct CachedDelegate
- - private static readonly Dictionary<Type, Dictionary<string, CachedDelegate>> CachedDelegates = new Dictionary<Type, Dictionary<string, CachedDelegate>>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
