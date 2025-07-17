# DefaultResolvers

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static IEnumerable<ItemQueryResult> ALL_ITEMS(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> DISH_OF_THE_DAY(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> FLAVORED_ITEM(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> ITEMS_LOST_ON_DEATH(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> ITEMS_SOLD_BY_PLAYER(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> LOCATION_FISH(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> LOST_BOOK_OR_ITEM(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> LOST_UNIQUE_ITEMS(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> MONSTER_SLAYER_REWARDS(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> MOVIE_CONCESSIONS_FOR_GUEST(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> RANDOM_ARTIFACT_FOR_DIG_SPOT(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> RANDOM_BASE_SEASON_ITEM(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> RANDOM_ITEMS(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> SECRET_NOTE_OR_ITEM(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> SHOP_TOWN_KEY(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> TOOL_UPGRADES(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static IEnumerable<ItemQueryResult> PET_ADOPTION(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
- - public static Dictionary<string, ResolveItemQueryDelegate> ItemResolvers { get; }
- - public static void Register(string queryKey, ResolveItemQueryDelegate queryDelegate)
- - public static ItemQueryResult[] TryResolve(string query, ItemQueryContext context, ItemQuerySearchMode filter = ItemQuerySearchMode.All, string perItemCondition = null, int? maxItems = null, bool avoidRepeat = false, HashSet<string> avoidItemIds = null, Action<string, string> logError = null)
- - public static IList<ItemQueryResult> TryResolve(ISpawnItemData data, ItemQueryContext context, ItemQuerySearchMode filter = ItemQuerySearchMode.All, bool avoidRepeat = false, HashSet<string> avoidItemIds = null, Func<string, string> formatItemId = null, Action<string, string> logError = null, Item inputItem = null)
- - public static Item TryResolveRandomItem(string query, ItemQueryContext context, bool avoidRepeat = false, HashSet<string> avoidItemIds = null, Action<string, string> logError = null)
- - public static Item TryResolveRandomItem(ISpawnItemData data, ItemQueryContext context, bool avoidRepeat = false, HashSet<string> avoidItemIds = null, Func<string, string> formatItemId = null, Item inputItem = null, Action<string, string> logError = null)
- - public static ISalable ApplyItemFields(ISalable item, ISpawnItemData data, ItemQueryContext context, Item inputItem = null)
- - public static ISalable ApplyItemFields(ISalable item, int minStackSize, int maxStackSize, int toolUpgradeLevel, string objectInternalName, string objectDisplayName, string objectColor, int quality, bool isRecipe, List<QuantityModifier> stackSizeModifiers, QuantityModifierMode stackSizeModifierMode, List<QuantityModifier> qualityModifiers, QuantityModifierMode qualityModifierMode, Dictionary<string, string> modData, ItemQueryContext context, Item inputItem = null)
- - public static string FormatLogMessage(string template, ISpawnItemData data, ItemQueryContext context)

## Private Members
- - private static void LogNothing(string query, string error)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- - static ItemQueryResolver()
