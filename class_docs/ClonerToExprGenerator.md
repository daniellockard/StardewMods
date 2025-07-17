# ClonerToExprGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- *(None)*

## Private Members
- - private static object GenerateProcessMethod(Type type, bool isDeepClone)
- - private static object GenerateProcessArrayMethod(Type type, bool isDeep)

## Protected Members
- *(None)*

## Internal Members
- - internal static object GenerateClonerInternal(Type realType, bool isDeepClone)
- - internal static T[] ShallowClone1DimArraySafeInternal<T>(T[] objFrom, T[] objTo)
- - internal static T[] Clone1DimArraySafeInternal<T>(T[] objFrom, T[] objTo, DeepCloneState state)
- - internal static T[] Clone1DimArrayStructInternal<T>(T[] objFrom, T[] objTo, DeepCloneState state)
- - internal static T[] Clone1DimArrayClassInternal<T>(T[] objFrom, T[] objTo, DeepCloneState state)
- - internal static T[,] Clone2DimArrayInternal<T>(T[,] objFrom, T[,] objTo, DeepCloneState state, bool isDeep)
- - internal static Array CloneAbstractArrayInternal(Array objFrom, Array objTo, DeepCloneState state, bool isDeep)

## Other Members
- *(None)*
