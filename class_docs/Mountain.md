# Mountain

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int daysBeforeLandslide = 31;
- - public bool treehouseBuilt;
- - public bool treehouseDoorDirty;
- - public Mountain()
- - public Mountain(string map, string name)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public void ApplyTreehouseIfNecessary()
- - public override void MakeMapModifications(bool force = false)
- - public override void DayUpdate(int dayOfMonth)
- - public override void cleanupBeforePlayerExit()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
- - public override bool isTilePlaceable(Vector2 tileLocation, bool itemIsPassable = false)
- - public override void draw(SpriteBatch spriteBatch)

## Private Members
- - private TemporaryAnimatedSprite minecartSteam;
- - private bool bridgeRestored;
- - private readonly NetBool oreBoulderPresent = new NetBool();
- - private readonly NetBool railroadAreaBlocked = new NetBool(Game1.stats.DaysPlayed < 31);
- - private readonly NetBool landslide = new NetBool(Game1.stats.DaysPlayed < 5);
- - private Rectangle landSlideRect = new Rectangle(3200, 256, 192, 320);
- - private Rectangle railroadBlockRect = new Rectangle(512, 0, 256, 320);
- - private int oldTime;
- - private Rectangle boulderSourceRect = new Rectangle(439, 1385, 39, 48);
- - private Rectangle raildroadBlocksourceRect = new Rectangle(640, 2176, 64, 80);
- - private Rectangle landSlideSourceRect = new Rectangle(646, 1218, 48, 80);
- - private Vector2 boulderPosition = new Vector2(47f, 3f) * 64f - new Vector2(4f, 3f) * 4f;
- - private void restoreBridge()
- - private void quarryDayUpdate()
- - private bool isTileOpenForQuarryStone(int tileX, int tileY)

## Protected Members
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
