# ShopLocation

**Summary:** Represents a place or area in the game world.

## Public Members
- - public const int maxItemsToSellFromPlayer = 11;
- - public readonly NetObjectList<Item> itemsFromPlayerToSell = new NetObjectList<Item>();
- - public readonly NetObjectList<Item> itemsToStartSellingTomorrow = new NetObjectList<Item>();
- - public ShopLocation()
- - public ShopLocation(string map, string name)
- - public virtual Dialogue getPurchasedItemDialogueForNPC(Object i, NPC n)
- - public override void DayUpdate(int dayOfMonth)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
