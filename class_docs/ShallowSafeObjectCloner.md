# ShallowSafeObjectCloner

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static object CloneObject(object obj)

## Private Members
- - private static readonly Func<object, object> _cloneFunc;
- - private static readonly ShallowObjectCloner _unsafeInstance;
- - private static ShallowObjectCloner _instance;

## Protected Members
- - protected override object DoCloneObject(object obj)
- - protected abstract object DoCloneObject(object obj);

## Internal Members
- - internal static bool IsSafeVariant()
- - internal static void SwitchTo(bool isSafe)

## Other Members
- - static ShallowSafeObjectCloner()
- - static ShallowObjectCloner()
