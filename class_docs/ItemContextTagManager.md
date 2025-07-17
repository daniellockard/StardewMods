# ItemContextTagManager

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public static HashSet<string> GetBaseContextTags(string itemId)
- - public static bool HasBaseTag(string itemId, string tag)
- - public static bool DoesTagQueryMatch(string tagQueryString, HashSet<string> tags)
- - public static bool DoAllTagsMatch(IList<string> requiredTags, HashSet<string> actualTags)
- - public static bool DoAnyTagsMatch(IList<string> requiredTags, HashSet<string> actualTags)
- - public static bool DoesTagMatch(string tag, HashSet<string> tags)
- - public static string SanitizeContextTag(string tag)
- - public static Color? GetColorFromTags(Item item)

## Private Members
- - private static readonly Dictionary<string, HashSet<string>> BaseTagsCache = new Dictionary<string, HashSet<string>>();

## Protected Members
- *(None)*

## Internal Members
- - internal static void ResetCache()

## Other Members
- *(None)*
