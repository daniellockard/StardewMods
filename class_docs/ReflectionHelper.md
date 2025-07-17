# ReflectionHelper

**Summary:** Utility or helper class.

## Public Members
- - public static bool IsEnum(this Type t)
- - public static bool IsValueType(this Type t)
- - public static bool IsClass(this Type t)
- - public static Type BaseType(this Type t)
- - public static FieldInfo[] GetAllFields(this Type t)
- - public static PropertyInfo[] GetPublicProperties(this Type t)
- - public static FieldInfo[] GetDeclaredFields(this Type t)
- - public static ConstructorInfo[] GetPrivateConstructors(this Type t)
- - public static ConstructorInfo[] GetPublicConstructors(this Type t)
- - public static MethodInfo GetPrivateMethod(this Type t, string methodName)
- - public static MethodInfo GetMethod(this Type t, string methodName)
- - public static MethodInfo GetPrivateStaticMethod(this Type t, string methodName)
- - public static FieldInfo GetPrivateField(this Type t, string fieldName)
- - public static bool IsSubclassOfTypeByName(this Type t, string typeName)
- - public static bool IsAssignableFrom(this Type from, Type to)
- - public static bool IsInstanceOfType(this Type from, object to)
- - public static Type[] GenericArguments(this Type t)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
