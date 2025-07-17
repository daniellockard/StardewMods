# FishTankFurniture

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum FishTankCategories
- - public const int TANK_DEPTH = 10;
- - public const int FLOOR_DECORATION_OFFSET = 4;
- - public const int TANK_SORT_REGION = 20;
- - public List<Vector4> bubbles = new List<Vector4>();
- - public List<TankFish> tankFish = new List<TankFish>();
- - public NetEvent0 refreshFishEvent = new NetEvent0();
- - public bool fishDirty = true;
- - public List<KeyValuePair<Rectangle, Vector2>?> floorDecorations = new List<KeyValuePair<Rectangle, Vector2>?>();
- - public List<Vector2> decorationSlots = new List<Vector2>();
- - public List<int> floorDecorationIndices = new List<int>();
- - public NetInt generationSeed = new NetInt();
- - public Item localDepositedItem;
- - public FishTankFurniture()
- - public FishTankFurniture(string itemId, Vector2 tile, int initialRotations)
- - public FishTankFurniture(string itemId, Vector2 tile)
- - public override void actionOnPlayerEntryOrPlacement(GameLocation environment, bool dropDown)
- - public virtual void ResetFish()
- - public Texture2D GetAquariumTexture()
- - public virtual int GetCapacityForCategory(FishTankCategories category)
- - public FishTankCategories GetCategoryFromItem(Item item)
- - public bool HasRoomForThisItem(Item item)
- - public override string GetShopMenuContext()
- - public override void ShowMenu()
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public virtual bool CanBeDeposited(Item item)
- - public override void DayUpdate()
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
- - public Dictionary<string, string> GetAquariumData()
- - public override bool onDresserItemWithdrawn(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock)
- - public virtual void UpdateFish()
- - public virtual void UpdateDecorAndFish()
- - public virtual void AddFloorDecoration(Rectangle source_rect)
- - public override void OnMenuClose()
- - public Vector2 GetFishSortRegion()
- - public float GetGlassDrawLayer()
- - public float GetBaseDrawLayer()
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
- - public int GetItemCount(string itemId)
- - public virtual Rectangle GetTankBounds()

## Private Members
- - private Texture2D _aquariumTexture;

## Protected Members
- - protected int _currentDecorationIndex;
- - protected Dictionary<Item, TankFish> _fishLookup = new Dictionary<Item, TankFish>();
- - protected override void initNetFields()
- - protected override Item GetOneNew()
- - protected virtual void _AdvanceDecorationIndex()

## Internal Members
- *(None)*

## Other Members
- *(None)*
