# BusStop

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int busDefaultXTile = 21;
- - public const int busDefaultYTile = 6;
- - public Vector2 busPosition;
- - public Vector2 busMotion;
- - public bool drivingOff;
- - public bool drivingBack;
- - public bool leaving;
- - public int TicketPrice { get; set; } = 500;
- - public BusStop()
- - public BusStop(string mapPath, string name)
- - public override bool IgnoreTouchActions()
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void DayUpdate(int dayOfMonth)
- - public override bool answerDialogue(Response answer)
- - public override void cleanupBeforePlayerExit()
- - public void busDriveOff()
- - public void busDriveBack()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override bool shouldHideCharacters()
- - public override void draw(SpriteBatch spriteBatch)

## Private Members
- - private TemporaryAnimatedSprite minecartSteam;
- - private TemporaryAnimatedSprite busDoor;
- - private int forceWarpTimer;
- - private Rectangle busSource = new Rectangle(288, 1247, 128, 64);
- - private Rectangle pamSource = new Rectangle(384, 1311, 15, 19);
- - private Vector2 pamOffset = new Vector2(0f, 29f);
- - private void playerReachedBusDoor(Character c, GameLocation l)
- - private void busStartMovingOff(int extraInfo)
- - private void doorOpenAfterReturn(int extraInfo)
- - private void busLeftToDesert()

## Protected Members
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
