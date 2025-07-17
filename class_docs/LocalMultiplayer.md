# LocalMultiplayer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public delegate void StaticInstanceMethod(object staticVarsHolder);
- - public static Type StaticVarHolderType;
- - public static StaticInstanceMethod StaticSetDefault;
- - public static StaticInstanceMethod StaticSave;
- - public static StaticInstanceMethod StaticLoad;
- - public static bool IsLocalMultiplayer(bool is_local_only = false)
- - public static void Initialize()
- - public static void SaveOptions()

## Private Members
- - private static DynamicMethod staticDefaultMethod;
- - private static DynamicMethod staticSaveMethod;
- - private static DynamicMethod staticLoadMethod;
- - private static void GetStaticFieldsAndDefaults()
- - private static void GenerateDynamicMethodsForStatics()

## Protected Members
- *(None)*

## Internal Members
- - internal static List<FieldInfo> staticFields;
- - internal static List<object> staticDefaults;

## Other Members
- *(None)*
