# ArgUtility

**Summary:** Utility or helper class.

## Public Members
- - public static string[] SplitBySpace(string value)
- - public static string[] SplitBySpace(string value, int limit)
- - public static string SplitBySpaceAndGet(string value, int index, string defaultValue = null)
- - public static string[] SplitBySpaceQuoteAware(string input)
- - public static string[] SplitQuoteAware(string input, char delimiter, StringSplitOptions splitOptions = StringSplitOptions.None, bool keepQuotesAndEscapes = false)
- - public static string UnsplitQuoteAware(string[] input, char delimiter, int startAt = 0, int count = int.MaxValue)
- - public static string EscapeQuotes(string input)
- - public static bool HasIndex<T>(T[] array, int index)
- - public static T[] GetSubsetOf<T>(T[] array, int startAt, int length = -1)
- - public static string Get(string[] array, int index, string defaultValue = null, bool allowBlank = true)
- - public static bool TryGet(string[] array, int index, out string value, out string error, bool allowBlank = true, [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetOptional(string[] array, int index, out string value, out string error, string defaultValue = null, bool allowBlank = true, [CallerArgumentExpression("value")] string name = null)
- - public static bool GetBool(string[] array, int index, bool defaultValue = false)
- - public static bool TryGetBool(string[] array, int index, out bool value, out string error, [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetOptionalBool(string[] array, int index, out bool value, out string error, bool defaultValue = false, [CallerArgumentExpression("value")] string name = null)
- - public static int GetDirection(string[] array, int index, int defaultValue = 0)
- - public static bool TryGetDirection(string[] array, int index, out int value, out string error, [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetOptionalDirection(string[] array, int index, out int value, out string error, int defaultValue = 0, [CallerArgumentExpression("value")] string name = null)
- - public static TEnum GetEnum<TEnum>(string[] array, int index, TEnum defaultValue = default(TEnum)) where TEnum : struct
- - public static bool TryGetEnum<TEnum>(string[] array, int index, out TEnum value, out string error, [CallerArgumentExpression("value")] string name = null) where TEnum : struct
- - public static bool TryGetOptionalEnum<TEnum>(string[] array, int index, out TEnum value, out string error, TEnum defaultValue = default(TEnum), [CallerArgumentExpression("value")] string name = null) where TEnum : struct
- - public static float GetFloat(string[] array, int index, float defaultValue = 0f)
- - public static bool TryGetFloat(string[] array, int index, out float value, out string error, [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetOptionalFloat(string[] array, int index, out float value, out string error, float defaultValue = 0f, [CallerArgumentExpression("value")] string name = null)
- - public static int GetInt(string[] array, int index, int defaultValue = 0)
- - public static bool TryGetInt(string[] array, int index, out int value, out string error, [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetOptionalInt(string[] array, int index, out int value, out string error, int defaultValue = 0, [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetPoint(string[] array, int index, out Point value, out string error, [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetRectangle(string[] array, int index, out Rectangle value, out string error, [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetVector2(string[] array, int index, out Vector2 value, out string error, bool integerOnly = false, [CallerArgumentExpression("value")] string name = null)
- - public static string GetRemainder(string[] array, int index, string defaultValue = null, char delimiter = ' ')
- - public static bool TryGetRemainder(string[] array, int index, out string value, out string error, char delimiter = ' ', [CallerArgumentExpression("value")] string name = null)
- - public static bool TryGetOptionalRemainder(string[] array, int index, out string value, string defaultValue = null, char delimiter = ' ')

## Private Members
- - private static string GetFieldLabel(int index, string name)

## Protected Members
- *(None)*

## Internal Members
- - internal static string GetMissingRequiredIndexError(string[] array, int index, string name)
- - internal static string GetValueParseError(string[] array, int index, string name, bool required, string typeSummary)

## Other Members
- *(None)*
