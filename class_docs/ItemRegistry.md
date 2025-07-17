# ItemRegistry

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public static readonly List<IItemDataDefinition> ItemTypes = new List<IItemDataDefinition>();
- - public const string type_object = "(O)";
- - public const string type_bigCraftable = "(BC)";
- - public const string type_boots = "(B)";
- - public const string type_floorpaper = "(FL)";
- - public const string type_furniture = "(F)";
- - public const string type_hat = "(H)";
- - public const string type_mannequin = "(M)";
- - public const string type_pants = "(P)";
- - public const string type_shirt = "(S)";
- - public const string type_tool = "(T)";
- - public const string type_trinket = "(TR)";
- - public const string type_wallpaper = "(WP)";
- - public const string type_weapon = "(W)";
- - public static void AddTypeDefinition(IItemDataDefinition definition)
- - public static IItemDataDefinition GetTypeDefinition(string identifier)
- - public static IItemDataDefinition RequireTypeDefinition(string identifier)
- - public static TItemDataDefinition RequireTypeDefinition<TItemDataDefinition>(string identifier) where TItemDataDefinition : class, IItemDataDefinition
- - public static ObjectDataDefinition GetObjectTypeDefinition()
- - public static void ResetCache()
- - public static bool HasItemId(Item item, string itemId)
- - public static bool IsQualifiedItemId(string itemId)
- - public static string QualifyItemId(string itemId)
- - public static string ManuallyQualifyItemId(string itemId, string typeDefinitionId, bool overrideIfQualified = false)
- - public static ItemMetadata GetMetadata(string itemId)
- - public static bool Exists(string itemId)
- - public static ItemMetadata ResolveMetadata(string itemId)
- - public static ParsedItemData GetData(string itemId)
- - public static ParsedItemData GetDataOrErrorItem(string itemId)
- - public static Item Create(string itemId, int amount = 1, int quality = 0, bool allowNull = false)
- - public static TItem Create<TItem>(string itemId, int amount = 1, int quality = 0, bool allowNull = false) where TItem : Item
- - public static string GetErrorItemName()
- - public static string GetErrorItemName(string itemId)
- - public static string GetUnnamedItemName()
- - public static string GetUnnamedItemName(string itemId)

## Private Members
- - private static readonly Dictionary<string, IItemDataDefinition> IdentifierLookup = new Dictionary<string, IItemDataDefinition>();
- - private static readonly Dictionary<string, ItemMetadata> CachedItems = new Dictionary<string, ItemMetadata>();
- - private static void RebuildCache()

## Protected Members
- *(None)*

## Internal Members
- - internal static void RegisterItemTypes()
- - internal static IItemDataDefinition GetTypeDefinitionFor(ItemMetadata metadata)

## Other Members
- *(None)*
