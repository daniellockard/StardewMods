# SaveSerializer

**Summary:** Handles saving or loading game data.

## Public Members
- - public static XmlSerializer GetSerializer(Type type)
- - public static void SerializeFast(this XmlSerializer serializer, Stream stream, object obj)
- - public static void Serialize<T>(XmlWriter xmlWriter, T obj)
- - public static void SerializeFast(this XmlSerializer serializer, XmlWriter xmlWriter, object obj)
- - public static T Deserialize<T>(Stream stream)
- - public static T Deserialize<T>(XmlReader reader)
- - public static object DeserializeFast(this XmlSerializer serializer, Stream stream)
- - public static object DeserializeFast(this XmlSerializer serializer, XmlReader reader)

## Private Members
- - private static readonly Dictionary<Type, XmlSerializer> _serializerLookup = new Dictionary<Type, XmlSerializer>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
