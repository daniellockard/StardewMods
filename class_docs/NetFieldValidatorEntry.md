# NetFieldValidatorEntry

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public string Name { get; }
- - public object Value { get; }
- - public FieldInfo FromField { get; }
- - public NetFieldValidatorEntry(string name, object value, FieldInfo fromField)
- - public static bool TryGetNetField(INetObject<NetFields> owner, FieldInfo field, out NetFieldValidatorEntry netField)
- - public bool IsMarkedNotNetField()
- - public static bool IsMarkedNotImplicitNetField(Type type)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
