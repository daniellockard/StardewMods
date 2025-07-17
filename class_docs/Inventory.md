# Inventory

**Summary:** Handles player or container inventory.

## Public Members
- - public NetFields NetFields { get; } = new NetFields("Inventory");
- - public int Count => Items.Count;
- - public bool IsReadOnly => Items.IsReadOnly;
- - public Item this[int index]
- - public bool IsLocalPlayerInventory { get; set; }
- - public long LastTickSlotChanged { get; private set; }
- - public event OnSlotChangedDelegate OnSlotChanged;
- - public event OnInventoryReplacedDelegate OnInventoryReplaced;
- - public Inventory()
- - public bool HasAny()
- - public bool HasEmptySlots()
- - public int CountItemStacks()
- - public void OverwriteWith(IList<Item> list)
- - public IList<Item> GetRange(int index, int count)
- - public void AddRange(ICollection<Item> collection)
- - public void RemoveRange(int index, int count)
- - public void RemoveEmptySlots()
- - public bool ContainsId(string itemId)
- - public bool ContainsId(string itemId, int minimum)
- - public int CountId(string itemId)
- - public IEnumerable<Item> GetById(string itemId)
- - public int Reduce(Item item, int count, bool reduceRemainderFromInventory = false)
- - public int ReduceId(string itemId, int count)
- - public bool RemoveButKeepEmptySlot(Item item)
- - public IEnumerator<Item> GetEnumerator()
- - public void Add(Item item)
- - public void Clear()
- - public bool Contains(Item item)
- - public void CopyTo(Item[] array, int arrayIndex)
- - public bool Remove(Item item)
- - public int IndexOf(Item item)
- - public void Insert(int index, Item item)
- - public void RemoveAt(int index)
- - public XmlSchema GetSchema()
- - public void ReadXml(XmlReader reader)
- - public void WriteXml(XmlWriter writer)

## Private Members
- - private readonly NetObjectList<Item> Items = new NetObjectList<Item>();
- - private InventoryIndex ItemsById;
- - private int? CachedItemStackCount;
- - private InventoryIndex GetItemsById()
- - private void HandleArrayReplaced(NetList<Item, NetRef<Item>> list, IList<Item> before, IList<Item> after)
- - private void HandleElementChanged(NetList<Item, NetRef<Item>> list, int index, Item before, Item after)
- - private void ClearIndex()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
