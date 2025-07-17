# FarmHouse

**Summary:** Represents the player's farm, its state, and related locations.

## Public Members
- - public readonly NetRef<Chest> fridge = new NetRef<Chest>(new Chest(playerChest: true));
- - public readonly NetInt synchronizedDisplayedLevel = new NetInt(-1);
- - public Point fridgePosition = Point.Zero;
- - public Point spouseRoomSpot = Point.Zero;
- - public List<Warp> cellarWarps;
- - public readonly NetInt cribStyle = new NetInt(1)
- - public int previousUpgradeLevel = -1;
- - public virtual Farmer owner => Game1.MasterPlayer;
- - public virtual bool HasOwner
- - public virtual long OwnerId => owner?.UniqueMultiplayerID ?? 0;
- - public bool IsOwnerActivated
- - public bool IsOwnedByCurrentPlayer
- - public virtual int upgradeLevel
- - public FarmHouse()
- - public FarmHouse(string m, string name)
- - public static string GetStarterFlooring(Farm farm)
- - public static string GetStarterWallpaper(Farm farm)
- - public List<Child> getChildren()
- - public int getChildrenCount()
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false, bool skipCollisionEffects = false)
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public static void spouseSleepEndFunction(Character c, GameLocation location)
- - public virtual Point getFrontDoorSpot()
- - public virtual Point getPorchStandingSpot()
- - public Point getKitchenStandingSpot()
- - public virtual BedFurniture GetSpouseBed()
- - public Point getSpouseBedSpot(string spouseName)
- - public Point GetSpouseRoomSpot()
- - public BedFurniture GetBed(BedFurniture.BedType bed_type = BedFurniture.BedType.Any, int index = 0)
- - public Point GetPlayerBedSpot()
- - public BedFurniture GetPlayerBed()
- - public Point getBedSpot(BedFurniture.BedType bed_type = BedFurniture.BedType.Any)
- - public Point getEntryLocation()
- - public BedFurniture GetChildBed(int index)
- - public Point GetChildBedSpot(int index)
- - public override bool isTilePlaceable(Vector2 v, bool itemIsPassable = false)
- - public Point getRandomOpenPointInHouse(Random r, int buffer = 0, int tries = 30)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public Point getFireplacePoint()
- - public bool HasNpcSpouseOrRoommate()
- - public bool HasNpcSpouseOrRoommate(string spouseName)
- - public virtual void showSpouseRoom()
- - public virtual void AddCellarTiles()
- - public Cellar GetCellar()
- - public string GetCellarName()
- - public void UpdateForRenovation()
- - public void updateFarmLayout()
- - public override void MakeMapModifications(bool force = false)
- - public void PlaceInNearbySpace(Vector2 tileLocation, Object o)
- - public virtual void RefreshFloorObjectNeighbors()
- - public void moveObjectsForHouseUpgrade(int whichUpgrade)
- - public override void drawAboveFrontLayer(SpriteBatch b)
- - public override void updateMap()
- - public virtual void setMapForUpgradeLevel(int level)
- - public Point? GetFridgePositionFromMap()
- - public void createCellarWarps()
- - public void updateCellarWarps()
- - public virtual Point GetSpouseRoomCorner()
- - public virtual void loadSpouseRoom()
- - public virtual Rectangle? GetCribBounds()
- - public virtual void UpdateChildRoom()
- - public void playerDivorced()
- - public virtual List<Rectangle> getForbiddenPetWarpTiles()
- - public bool canPetWarpHere(Vector2 tile_position)
- - public override List<Rectangle> getWalls()
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override List<Rectangle> getFloors()
- - public virtual bool CanModifyCrib()

## Private Members
- - private string lastSpouseRoom;
- - private LocalizedContentManager mapLoader;
- - private int currentlyDisplayedUpgradeLevel;
- - private bool displayingSpouseRoom;
- - private Color nightLightingColor = new Color(180, 180, 0);
- - private Color rainLightingColor = new Color(90, 90, 0);
- - private void AddStarterGiftBox(Farm farm)
- - private void AddStarterFurniture(Farm farm)
- - private void SetStarterFlooring(Farm farm, string styleToOverride = null)
- - private void SetStarterWallpaper(Farm farm, string styleToOverride = null)
- - private void addFurnitureIfSpaceIsFreePenny(List<Object> objectsToStoreInChests, Furniture f, Furniture heldObject = null)
- - private void decoratePennyRoom(int whichStyle, List<Object> objectsToStoreInChests)

## Protected Members
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected virtual void _ApplyRenovations()
- - protected override void resetLocalState()
- - protected override LocalizedContentManager getMapLoader()
- - protected override void _updateAmbientLighting()

## Internal Members
- *(None)*

## Other Members
- *(None)*
