# LightningStrikeEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public Vector2 boltPosition;
- - public bool createBolt;
- - public bool bigFlash;
- - public bool smallFlash;
- - public bool destroyedTerrainFeature;
- - public void Read(BinaryReader reader)
- - public void Write(BinaryWriter writer)
- - public static Texture2D houseTextures = Game1.content.Load<Texture2D>("Buildings\\houses");
- - public NetRef<BuildingPaintColor> housePaintColor = new NetRef<BuildingPaintColor>();
- - public const int default_layout = 0;
- - public const int riverlands_layout = 1;
- - public const int forest_layout = 2;
- - public const int mountains_layout = 3;
- - public const int combat_layout = 4;
- - public const int fourCorners_layout = 5;
- - public const int beach_layout = 6;
- - public const int mod_layout = 7;
- - public const int layout_max = 7;
- - public readonly NetInt grandpaScore = new NetInt(0);
- - public NetBool farmCaveReady = new NetBool(value: false);
- - public Item lastItemShipped;
- - public bool hasSeenGrandpaNote;
- - public bool hasMatureFairyRoseTonight;
- - public readonly NetBool greenhouseUnlocked = new NetBool();
- - public readonly NetBool greenhouseMoved = new NetBool();
- - public readonly NetEvent1<LightningStrikeEvent> lightningStrikeEvent = new NetEvent1<LightningStrikeEvent>();
- - public Point? mapGrandpaShrinePosition;
- - public Point? mapMainMailboxPosition;
- - public Point? mainFarmhouseEntry;
- - public Vector2? mapSpouseAreaCorner;
- - public Vector2? mapShippingBinPosition;
- - public Point spousePatioSpot;
- - public const int numCropsForCrow = 16;
- - public Farm()
- - public Farm(string mapPath, string name)
- - public override bool IsBuildableLocation()
- - public override void AddDefaultBuildings(bool load = true)
- - public override string GetDisplayName()
- - public virtual Vector2 GetStarterShippingBinLocation()
- - public virtual Vector2 GetStarterPetBowlLocation()
- - public virtual Vector2 GetStarterFarmhouseLocation()
- - public virtual Vector2 GetGreenhouseStartLocation()
- - public virtual void ClearGreenhouseGrassTiles()
- - public static string getMapNameFromTypeInt(int type)
- - public void onNewGame()
- - public override void DayUpdate(int dayOfMonth)
- - public void doDailyMountainFarmUpdate()
- - public override bool catchOceanCrabPotFishFromThisSpot(int x, int y)
- - public void addCrows()
- - public static Point getFrontDoorPositionForFarmer(Farmer who)
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public void spawnGroundMonsterOffScreen()
- - public void spawnFlyingMonstersOffScreen()
- - public virtual void requestGrandpaReevaluation()
- - public override void OnMapLoad(Map map)
- - public override void OnBuildingMoved(Building building)
- - public override bool ShouldExcludeFromNpcPathfinding()
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public void grandpaStatueCallback(Item item, Farmer who)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public IInventory getShippingBin(Farmer who)
- - public void shipItem(Item i, Farmer who)
- - public void UnsetFarmhouseValues()
- - public void showShipment(Item item, bool playThrowSound = true)
- - public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string location = null)
- - public virtual void UpdatePatio()
- - public override void MakeMapModifications(bool force = false)
- - public virtual Vector2 GetSpouseOutdoorAreaCorner()
- - public virtual void CacheOffBasePatioArea()
- - public virtual void ReapplyBasePatioArea()
- - public void addSpouseOutdoorArea(string spouseName)
- - public void addGrandpaCandles()
- - public override void pokeTileForConstruction(Vector2 tile)
- - public override bool shouldShadowBeDrawnAboveBuildingsLayer(Vector2 p)
- - public override void draw(SpriteBatch b)
- - public virtual Point GetMainMailboxPosition()
- - public virtual Point GetGrandpaShrinePosition()
- - public virtual Point GetMainFarmHouseEntry()
- - public virtual Building GetMainFarmHouse()
- - public override void ResetForEvent(Event ev)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
- - public bool isTileOpenBesidesTerrainFeatures(Vector2 tile)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public bool ShouldSpawnMountainOres()
- - public bool ShouldSpawnForestFarmForage()
- - public bool ShouldSpawnBeachFarmForage()
- - public bool SpawnsForage()
- - public bool doesFarmCaveNeedHarvesting()

## Private Members
- - private TemporaryAnimatedSprite shippingBinLid;
- - private Rectangle shippingBinLidOpenArea = new Rectangle(4480, 832, 256, 192);
- - private readonly NetRef<Inventory> sharedShippingBin = new NetRef<Inventory>(new Inventory());
- - private readonly NetEvent1Field<Vector2, NetVector2> spawnCrowEvent = new NetEvent1Field<Vector2, NetVector2>();
- - private void doSpawnCrow(Vector2 v)
- - private void openShippingBinLid()
- - private void closeShippingBinLid()
- - private void updateShippingBinLid(GameTime time)
- - private bool isShippingBinLidOpen(bool requiredToBeFullyOpen = false)
- - private void doLightningStrike(LightningStrikeEvent lightning)

## Protected Members
- - protected Dictionary<string, Dictionary<Point, Tile>> _baseSpouseAreaTiles = new Dictionary<string, Dictionary<Point, Tile>>();
- - protected Rectangle? _mountainForageRectangle;
- - protected bool? _shouldSpawnForestFarmForage;
- - protected bool? _shouldSpawnBeachFarmForage;
- - protected bool? _oceanCrabPotOverride;
- - protected string _fishLocationOverride;
- - protected float _fishChanceOverride;
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
