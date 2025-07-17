# Desert

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int busDefaultXTile = 17;
- - public const int busDefaultYTile = 24;
- - public bool drivingOff;
- - public bool drivingBack;
- - public bool leaving;
- - public static bool warpedToDesert;
- - public Desert()
- - public Desert(string mapPath, string name)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public virtual void OnDesertTrader()
- - public virtual void OnCamel()
- - public virtual void ShowCamelAnimation()
- - public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
- - public override bool answerDialogue(Response answer)
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public void lightMerchantLamps()
- - public override void cleanupBeforePlayerExit()
- - public void busDriveOff()
- - public void busDriveBack()
- - public override bool IgnoreTouchActions()
- - public override void performTouchAction(string[] action, Vector2 playerStandingPosition)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void DayUpdate(int dayOfMonth)
- - public override bool isTilePlaceable(Vector2 v, bool itemIsPassable = false)
- - public override bool shouldHideCharacters()
- - public override void draw(SpriteBatch spriteBatch)

## Private Members
- - private TemporaryAnimatedSprite busDoor;
- - private Vector2 busPosition;
- - private Vector2 busMotion;
- - private int chimneyTimer = 500;
- - private Rectangle desertMerchantBounds = new Rectangle(2112, 1280, 836, 280);
- - private Rectangle busSource = new Rectangle(288, 1247, 128, 64);
- - private Rectangle pamSource = new Rectangle(384, 1311, 15, 19);
- - private Rectangle transparentWindowSource = new Rectangle(0, 0, 21, 41);
- - private Vector2 pamOffset = new Vector2(0f, 29f);
- - private void playerReachedBusDoor(Character c, GameLocation l)
- - private bool IsTravelingDesertMerchantHere()
- - private void busStartMovingOff(int extraInfo)
- - private void doorOpenAfterReturn(int extraInfo)
- - private void busLeftToValley()

## Protected Members
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
