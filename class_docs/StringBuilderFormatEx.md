# StringBuilderFormatEx

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static bool StringsEqual(this StringBuilder sb, string value)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, StringBuilder value)
- - public static void Init()
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, uint uintVal, uint padAmount, char padChar, uint baseVal)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, uint uintVal)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, uint uintVal, uint padAmount)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, uint uintVal, uint padAmount, char padChar)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, int intVal, uint padAmount, char padChar, uint baseVal)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, int intVal)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, int intVal, uint padAmount)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, int intVal, uint padAmount, char padChar)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, ulong uintVal, uint padAmount, char padChar, uint baseVal)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, ulong uintVal)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, ulong uintVal, uint padAmount)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, ulong uintVal, uint padAmount, char padChar)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, long intVal, uint padAmount, char padChar, uint baseVal)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, long intVal)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, long intVal, uint padAmount)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, long intVal, uint padAmount, char padChar)
- - public static StringBuilder AppendEx(this StringBuilder stringBuilder, float floatVal, uint decimalPlaces, uint padAmount, char padChar)
- - public static StringBuilder AppendFormatEx(this StringBuilder stringBuilder, float floatVal)
- - public static StringBuilder AppendFormatEx(this StringBuilder stringBuilder, float floatVal, uint decimalPlaces)
- - public static StringBuilder AppendFormatEx(this StringBuilder stringBuilder, float floatVal, uint decimalPlaces, uint padAmount)
- - public static StringBuilder AppendFormatEx<TA>(this StringBuilder stringBuilder, string formatString, TA arg1) where TA : IConvertible
- - public static StringBuilder AppendFormatEx<TA, TB>(this StringBuilder stringBuilder, string formatString, TA arg1, TB arg2) where TA : IConvertible where TB : IConvertible
- - public static StringBuilder AppendFormatEx<TA, TB, TC>(this StringBuilder stringBuilder, string formatString, TA arg1, TB arg2, TC arg3) where TA : IConvertible where TB : IConvertible where TC : IConvertible
- - public static StringBuilder AppendFormatEx<TA, TB, TC, TD>(this StringBuilder stringBuilder, string formatString, TA arg1, TB arg2, TC arg3, TD arg4) where TA : IConvertible where TB : IConvertible where TC : IConvertible where TD : IConvertible
- - public static StringBuilder AppendFormatEx<TA, TB, TC, TD, TE>(this StringBuilder stringBuilder, string formatString, TA arg1, TB arg2, TC arg3, TD arg4, TE arg5) where TA : IConvertible where TB : IConvertible where TC : IConvertible where TD : IConvertible where TE : IConvertible

## Private Members
- - private static readonly char[] MsDigits;
- - private const uint MsDefaultDecimalPlaces = 5u;
- - private const char MsDefaultPadChar = '0';
- - private static char[] _buffer;
- - private static char[] _getBuffer(int len)
- - private static void AppendFormatValue<T>(this StringBuilder stringBuilder, T arg, uint padding, uint baseValue, uint decimalPlaces) where T : IConvertible

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- - static StringBuilderFormatEx()
