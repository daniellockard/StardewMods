# StorageFurniture

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetObjectList<Item> heldItems = new NetObjectList<Item>();
- - public readonly NetMutex mutex = new NetMutex();
- - public StorageFurniture()
- - public StorageFurniture(string itemId, Vector2 tile, int initialRotations)
- - public StorageFurniture(string itemId, Vector2 tile)
- - public override bool canBeRemoved(Farmer who)
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public virtual void ShowMenu()
- - public virtual void ShowChestMenu()
- - public virtual void GrabItemFromInventory(Item item, Farmer who)
- - public virtual bool HighlightItems(Item item)
- - public virtual void GrabItemFromChest(Item item, Farmer who)
- - public virtual void ClearNulls()
- - public virtual Item AddItem(Item item)
- - public virtual void ShowShopMenu()
- - public virtual void OnMenuClose()
- - public virtual string GetShopMenuContext()
- - public override bool canBeTrashed()
- - public override void DayUpdate()
- - public virtual int SortItems(Item a, Item b)
- - public virtual bool onDresserItemWithdrawn(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock)
- - public override void updateWhenCurrentLocation(GameTime time)
- - public virtual bool onDresserItemDeposited(ISalable deposited_salable)
- - public override bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override Item GetOneNew()

## Internal Members
- *(None)*

## Other Members
- *(None)*
