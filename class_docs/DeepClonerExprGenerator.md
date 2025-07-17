# DeepClonerExprGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- *(None)*

## Private Members
- - private static readonly ConcurrentDictionary<FieldInfo, bool> _readonlyFields = new ConcurrentDictionary<FieldInfo, bool>();
- - private static FieldInfo _attributesFieldInfo = typeof(FieldInfo).GetPrivateField("m_fieldAttributes");
- - private static object GenerateProcessMethod(Type type, bool unboxStruct)
- - private static object GenerateProcessArrayMethod(Type type)
- - private static object GenerateProcessTupleMethod(Type type)

## Protected Members
- *(None)*

## Internal Members
- - internal static object GenerateClonerInternal(Type realType, bool asObject)
- - internal static void ForceSetField(FieldInfo field, object obj, object value)

## Other Members
- *(None)*
