# IslandNorth

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool bridgeFixed = new NetBool
- - public readonly NetBool traderActivated = new NetBool
- - public readonly NetBool caveOpened = new NetBool
- - public readonly NetBool treeNutShot = new NetBool
- - public List<SuspensionBridge> suspensionBridges = new List<SuspensionBridge>();
- - public override void SetBuriedNutLocations()
- - public virtual void ApplyFixedBridge()
- - public virtual void ApplyIslandTraderHut()
- - public virtual void ApplyCaveOpened()
- - public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
- - public IslandNorth()
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false, bool skipCollisionEffects = false)
- - public IslandNorth(string map, string name)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override List<Vector2> GetAdditionalWalnutBushes()
- - public override bool catchOceanCrabPotFishFromThisSpot(int x, int y)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
- - public override bool isTilePlaceable(Vector2 tile_location, bool itemIsPassable = false)
- - public override void DayUpdate(int dayOfMonth)
- - public void digSiteUpdate()
- - public override bool performOrePanTenMinuteUpdate(Random r)
- - public override bool performToolAction(Tool t, int tileX, int tileY)
- - public override void explosionAt(float x, float y)
- - public override void drawBackground(SpriteBatch b)
- - public override void draw(SpriteBatch b)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override bool IsLocationSpecificPlacementRestriction(Vector2 tileLocation)
- - public override void MakeMapModifications(bool force = false)

## Private Members
- - private float boulderKnockTimer;
- - private float boulderTextTimer;
- - private string boulderTextString;
- - private int boulderKnocksLeft;
- - private Rectangle boulderPosition = new Rectangle(1344, 3008, 128, 64);
- - private float doneHittingBoulderWithToolTimer;
- - private bool isTileOpenForDigSiteStone(int tileX, int tileY)

## Protected Members
- - protected bool _sawFlameSpriteSouth;
- - protected bool _sawFlameSpriteNorth;
- - protected bool hasTriedFirstEntryDigSiteLoad;
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
