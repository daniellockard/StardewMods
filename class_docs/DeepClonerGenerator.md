# DeepClonerGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static T CloneObject<T>(T obj)
- - public static object CloneObjectTo(object objFrom, object objTo, bool isDeep)

## Private Members
- - private static object CloneClassRoot(object obj)
- - private static T CloneStructInternal<T>(T obj, DeepCloneState state)
- - private static object GenerateCloner(Type t, bool asObject)

## Protected Members
- *(None)*

## Internal Members
- - internal static object CloneClassInternal(object obj, DeepCloneState state)
- - internal static T[] Clone1DimArraySafeInternal<T>(T[] obj, DeepCloneState state)
- - internal static T[] Clone1DimArrayStructInternal<T>(T[] obj, DeepCloneState state)
- - internal static T[] Clone1DimArrayClassInternal<T>(T[] obj, DeepCloneState state)
- - internal static T[,] Clone2DimArrayInternal<T>(T[,] obj, DeepCloneState state)
- - internal static Array CloneAbstractArrayInternal(Array obj, DeepCloneState state)
- - internal static Func<T, DeepCloneState, T> GetClonerForValueType<T>()

## Other Members
- *(None)*
