# ShopBuilder

**Summary:** Represents a shop or merchant interface.

## Public Members
- - public static Dictionary<ISalable, ItemStockInformation> GetShopStock(string shopId)
- - public static Dictionary<ISalable, ItemStockInformation> GetShopStock(string shopId, ShopData shop)
- - public static bool CheckItemCondition(string conditions, bool applyPierreMissingStockList, out bool isOutOfSeason)
- - public static ToolUpgradeData GetToolUpgradeData(ToolData tool, Farmer player)
- - public static int GetToolUpgradeConventionalPrice(int level)
- - public static IEnumerable<ShopOwnerData> GetCurrentOwners(ShopData shop)
- - public static int GetBasePrice(ItemQueryResult output, ShopData shopData, ShopItemData itemData, ISalable item, bool outOfSeasonPrice, bool useObjectDataPrice = false)
- - public static bool TrackSeenItems(HashSet<string> stockedItems, ISalable item)

## Private Members
- - private static string GetToolUpgradeConventionalTradeItem(int level)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
