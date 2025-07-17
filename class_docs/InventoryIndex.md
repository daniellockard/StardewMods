# InventoryIndex

**Summary:** Handles player or container inventory.

## Public Members
- - public InventoryIndex(Action<InventoryIndex, Item> addImpl, Action<InventoryIndex, Item> removeImpl)
- - public static InventoryIndex ById(IList<Item> items)
- - public int CountKeys()
- - public int CountItems()
- - public bool Contains(string key)
- - public bool TryGet(string key, out IReadOnlyList<Item> items)
- - public bool TryGetMutable(string key, out IList<Item> items)
- - public void Add(Item item)
- - public void AddWithKey(string key, Item item)
- - public void Remove(Item item)
- - public void RemoveKey(string key)
- - public void RemoveItem(string key, Item item)
- - public delegate void OnInventoryReplacedDelegate(Inventory inventory, IList<Item> before, IList<Item> after);
- - public delegate void OnSlotChangedDelegate(Inventory inventory, int index, Item before, Item after);
- - public readonly struct ForEachItemContext
- - public readonly Item Item;
- - public readonly Action RemoveItem;
- - public readonly Action<Item> ReplaceItemWith;
- - public readonly GetForEachItemPathDelegate GetPath;
- - public ForEachItemContext(Item item, Action remove, Action<Item> replaceWith, GetForEachItemPathDelegate getPath)
- - public IList<string> GetDisplayPath(bool includeItem = false)

## Private Members
- - private readonly Dictionary<string, List<Item>> Index = new Dictionary<string, List<Item>>();
- - private readonly Action<InventoryIndex, Item> AddImpl;
- - private readonly Action<InventoryIndex, Item> RemoveImpl;
- - private void AddDisplayPath(IList<string> path, object pathValue)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
