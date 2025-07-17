# IslandLocation

**Summary:** Represents a place or area in the game world.

## Public Members
- - public const int TOTAL_WALNUTS = 130;
- - public List<ParrotPlatform> parrotPlatforms = new List<ParrotPlatform>();
- - public NetList<ParrotUpgradePerch, NetRef<ParrotUpgradePerch>> parrotUpgradePerches = new NetList<ParrotUpgradePerch, NetRef<ParrotUpgradePerch>>();
- - public NetList<Point, NetPoint> buriedNutPoints = new NetList<Point, NetPoint>();
- - public NetRef<IslandGemBird> locationGemBird = new NetRef<IslandGemBird>();
- - public IslandLocation()
- - public void ApplyUnsafeMapOverride(string override_map, Rectangle? source_rect, Rectangle dest_rect)
- - public override string doesTileHaveProperty(int xTile, int yTile, string propertyName, string layerName, bool ignoreTileSheetProperties = false)
- - public virtual void SetBuriedNutLocations()
- - public virtual List<Vector2> GetAdditionalWalnutBushes()
- - public IslandLocation(string map, string name)
- - public override bool SeedsIgnoreSeasonsHere()
- - public override bool catchOceanCrabPotFishFromThisSpot(int x, int y)
- - public override bool answerDialogue(Response answer)
- - public override void cleanupBeforePlayerExit()
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false, bool skipCollisionEffects = false)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void tryToAddCritters(bool onlyIfOnScreen = false)
- - public override void DayUpdate(int dayOfMonth)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public void AddAdditionalWalnutBushes()
- - public override bool isActionableTile(int xTile, int yTile, Farmer who)
- - public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
- - public override void digUpArtifactSpot(int xLocation, int yLocation, Farmer who)
- - public virtual bool IsBuriedNutLocation(Point point)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string locationName = null)
- - public override void draw(SpriteBatch b)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override bool IsLocationSpecificOccupantOnTile(Vector2 tileLocation)
- - public override void seasonUpdate(bool onLoad = false)
- - public override void updateSeasonalTileSheets(Map map = null)
- - public override void drawWater(SpriteBatch b)
- - public virtual void DrawParallaxHorizon(SpriteBatch b, bool horizontal_parallax = true)
- - public bool AreMoonlightJelliesOut()

## Private Members
- *(None)*

## Protected Members
- - protected Texture2D _dayParallaxTexture;
- - protected Texture2D _nightParallaxTexture;
- - protected TemporaryAnimatedSpriteList underwaterSprites = new TemporaryAnimatedSpriteList();
- - protected override void initNetFields()
- - protected void addMoonlightJellies(int numTries, Random r, Rectangle exclusionRect)
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
