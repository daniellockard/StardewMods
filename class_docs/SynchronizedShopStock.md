# SynchronizedShopStock

**Summary:** Represents a shop or merchant interface.

## Public Members
- - public NetFields NetFields { get; } = new NetFields("SynchronizedShopStock");
- - public SynchronizedShopStock()
- - public virtual void Clear()
- - public void OnItemPurchased(string shop_id, ISalable item, Dictionary<ISalable, ItemStockInformation> stock, int amount)
- - public string GetQualifiedSyncedKey(string shop_id, ItemStockInformation item)
- - public void UpdateLocalStockWithSyncedQuanitities(string shop_id, Dictionary<ISalable, ItemStockInformation> local_stock)

## Private Members
- - private readonly NetStringDictionary<int, NetInt> stockDictionary = new NetStringDictionary<int, NetInt>();
- - private void initNetFields()

## Protected Members
- - protected static HashSet<string> _usedKeys = new HashSet<string>();
- - protected static List<ISalable> _stockSalables = new List<ISalable>();

## Internal Members
- *(None)*

## Other Members
- *(None)*
