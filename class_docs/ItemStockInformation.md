# ItemStockInformation

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public int Price;
- - public int Stock;
- - public string TradeItem;
- - public int? TradeItemCount;
- - public LimitedStockMode LimitedStockMode;
- - public string SyncedKey;
- - public ISalable ItemToSyncStack;
- - public StackDrawType? StackDrawType;
- - public List<string> ActionsOnPurchase;
- - public ItemStockInformation(int price, int stock, string tradeItem = null, int? tradeItemCount = null, LimitedStockMode stockMode = (LimitedStockMode)0, string syncedKey = null, ISalable itemToSyncStack = null, StackDrawType? stackDrawType = null, List<string> actionsOnPurchase = null)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
