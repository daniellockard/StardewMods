# Chest

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum SpecialChestTypes
- - public const int capacity = 36;
- - public readonly NetInt startingLidFrame = new NetInt(501);
- - public readonly NetInt lidFrameCount = new NetInt(5);
- - public readonly NetInt frameCounter = new NetInt(-1);
- - public NetRef<Inventory> netItems = new NetRef<Inventory>(new Inventory());
- - public readonly NetLongDictionary<Inventory, NetRef<Inventory>> separateWalletItems = new NetLongDictionary<Inventory, NetRef<Inventory>>();
- - public readonly NetColor tint = new NetColor(Color.White);
- - public readonly NetColor playerChoiceColor = new NetColor(Color.Black);
- - public readonly NetBool playerChest = new NetBool();
- - public readonly NetBool fridge = new NetBool();
- - public readonly NetBool giftbox = new NetBool();
- - public readonly NetInt giftboxIndex = new NetInt();
- - public readonly NetBool giftboxIsStarterGift = new NetBool();
- - public readonly NetInt bigCraftableSpriteIndex = new NetInt(-1);
- - public readonly NetBool dropContents = new NetBool(value: false);
- - public string mailToAddOnItemDump;
- - public readonly NetBool synchronized = new NetBool(value: false);
- - public int _shippingBinFrameCounter;
- - public bool _farmerNearby;
- - public NetVector2 kickStartTile = new NetVector2(new Vector2(-1000f, -1000f));
- - public Vector2? localKickStartTile;
- - public float kickProgress = -1f;
- - public readonly NetEvent0 openChestEvent = new NetEvent0();
- - public readonly NetEnum<SpecialChestTypes> specialChestType = new NetEnum<SpecialChestTypes>();
- - public readonly NetString globalInventoryId = new NetString();
- - public readonly NetMutex mutex = new NetMutex();
- - public SpecialChestTypes SpecialChestType
- - public string GlobalInventoryId
- - public Color Tint
- - public Inventory Items => netItems.Value;
- - public Chest()
- - public Chest(bool playerChest, Vector2 tileLocation, string itemId = "130")
- - public Chest(bool playerChest, string itemId = "130")
- - public Chest(string itemId, Vector2 tile_location, int starting_lid_frame, int lid_frame_count)
- - public Chest(List<Item> items, Vector2 location, bool giftbox = false, int giftboxIndex = 0, bool giftboxIsStarterGift = false)
- - public void resetLidFrame()
- - public void fixLidFrame()
- - public int getLastLidFrame()
- - public void HandleChestHit(ChestHitArgs args)
- - public override bool performToolAction(Tool t)
- - public bool TryMoveToSafePosition(int? preferDirection = null)
- - public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
- - public void SetSpecialChestType()
- - public void destroyAndDropContents(Vector2 pointToDropAt)
- - public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
- - public void dumpContents()
- - public NetMutex GetMutex()
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public virtual void OpenMiniShippingMenu()
- - public virtual void performOpenChest()
- - public virtual void grabItemFromChest(Item item, Farmer who)
- - public virtual Item addItem(Item item)
- - public virtual int GetActualCapacity()
- - public virtual void CheckAutoLoad(Farmer who)
- - public virtual void ShowMenu()
- - public virtual void grabItemFromInventory(Item item, Farmer who)
- - public IInventory GetItemsForPlayer()
- - public IInventory GetItemsForPlayer(long id)
- - public virtual bool isEmpty()
- - public virtual void clearNulls()
- - public override void updateWhenCurrentLocation(GameTime time)
- - public virtual void UpdateFarmerNearby(bool animate = true)
- - public override void actionOnPlayerEntry()
- - public virtual void SetBigCraftableSpriteIndex(int sprite_index, int starting_lid_frame = -1, int lid_frame_count = 3)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
- - public virtual void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f, bool local = false)
- - public override bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)

## Private Members
- - private int currentLidFrame;
- - private ChestHitTimer HitTimerInstance

## Protected Members
- - protected override void initNetFields()

## Internal Members
- - internal ChestHitTimer hitTimerInstance;

## Other Members
- *(None)*
