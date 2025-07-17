# NetRefTypes

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public static Type ReadType(this BinaryReader reader)
- - public static void WriteType(this BinaryWriter writer, Type type)
- - public static void WriteTypeOf<T>(this BinaryWriter writer, T value)

## Private Members
- - private static Dictionary<string, Type> types = new Dictionary<string, Type>();
- - private static Type ReadGenericType(this BinaryReader reader)
- - private static void WriteGenericType(this BinaryWriter writer, Type type)
- - private static Type GetType(string typeName)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
