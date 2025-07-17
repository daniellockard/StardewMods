# BinaryReaderWriterExtensions

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static void ReadSkippable(this BinaryReader reader, Action readAction)
- - public static byte[] ReadSkippableBytes(this BinaryReader reader)
- - public static void Skip(this BinaryReader reader)
- - public static void WriteSkippable(this BinaryWriter writer, Action writeAction)
- - public static BitArray ReadBitArray(this BinaryReader reader)
- - public static void WriteBitArray(this BinaryWriter writer, BitArray bits)
- - public static void Write7BitEncoded(this BinaryWriter writer, uint value)
- - public static uint Read7BitEncoded(this BinaryReader reader)
- - public static Guid ReadGuid(this BinaryReader reader)
- - public static void WriteGuid(this BinaryWriter writer, Guid guid)
- - public static Vector2 ReadVector2(this BinaryReader reader)
- - public static void WriteVector2(this BinaryWriter writer, Vector2 vec)
- - public static Point ReadPoint(this BinaryReader reader)
- - public static void WritePoint(this BinaryWriter writer, Point p)
- - public static Rectangle ReadRectangle(this BinaryReader reader)
- - public static void WriteRectangle(this BinaryWriter writer, Rectangle rect)
- - public static Color ReadColor(this BinaryReader reader)
- - public static void WriteColor(this BinaryWriter writer, Color color)
- - public static T ReadEnum<T>(this BinaryReader reader) where T : struct, IConvertible
- - public static void WriteEnum<T>(this BinaryWriter writer, T enumValue) where T : struct, IConvertible
- - public static void WriteEnum(this BinaryWriter writer, object enumValue)
- - public static void Push(this BinaryWriter writer, string name)
- - public static void Pop(this BinaryWriter writer)
- - public delegate void FieldChange<in TSelf, in TValue>(TSelf field, TValue oldValue, TValue newValue);

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
