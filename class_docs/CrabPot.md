# CrabPot

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int lidFlapTimerInterval = 60;
- - public float yBob;
- - public readonly NetVector2 directionOffset = new NetVector2();
- - public readonly NetRef<Object> bait = new NetRef<Object>();
- - public int tileIndexToShow;
- - public bool lidFlapping;
- - public bool lidClosing;
- - public float lidFlapTimer;
- - public new float shakeTimer;
- - public Vector2 shake;
- - public CrabPot()
- - public bool NeedsBait(Farmer player)
- - public List<Vector2> getOverlayTiles()
- - public void addOverlayTiles()
- - public void removeOverlayTiles()
- - public static bool IsValidCrabPotLocationTile(GameLocation location, int x, int y)
- - public override void actionOnPlayerEntry()
- - public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
- - public void updateOffset()
- - public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
- - public override bool AttemptAutoLoad(IInventory inventory, Farmer who)
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public override void performRemoveAction()
- - public override void DayUpdate()
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)

## Private Members
- - private int ignoreRemovalTimer;

## Protected Members
- - protected override void initNetFields()
- - protected void addOverlayTilesIfNecessary(int tile_x, int tile_y, List<Vector2> tiles)
- - protected bool checkLocation(float tile_x, float tile_y)
- - protected override Item GetOneNew()

## Internal Members
- *(None)*

## Other Members
- *(None)*
