# Style

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool ShowRootObjectType;
- - public string ObjectDelimiter;
- - public string MemberDelimiter;
- - public string MemberNameValueDelimiter;
- - public bool TrailingNewline;
- - public static Style TypeAndMembersSingleLine = new Style
- - public static Style MembersOnlyMultiline = new Style
- - public Style()
- - public static string Format(object obj, Style style)

## Private Members
- - private static readonly StringBuilder _stringBuilder = new StringBuilder();
- - private static readonly Dictionary<Type, ToStringDescription> _cache = new Dictionary<Type, ToStringDescription>();
- - private static int CompareToStringMembers(ToStringMember a, ToStringMember b)

## Protected Members
- *(None)*

## Internal Members
- - internal enum BlockState
- - internal enum DeflateFlavor

## Other Members
- *(None)*
