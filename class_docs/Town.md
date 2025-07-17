# Town

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetInt daysUntilCommunityUpgrade = new NetInt(0);
- - public static Rectangle minuteHandSource = new Rectangle(363, 395, 5, 13);
- - public static Rectangle hourHandSource = new Rectangle(369, 399, 5, 9);
- - public static Rectangle clockNub = new Rectangle(375, 404, 4, 4);
- - public static Rectangle jojaFacadeTop = new Rectangle(424, 1275, 174, 50);
- - public static Rectangle jojaFacadeBottom = new Rectangle(424, 1325, 174, 51);
- - public static Rectangle jojaFacadeWinterOverlay = new Rectangle(66, 1678, 174, 25);
- - public Town()
- - public Town(string map, string name)
- - public override void UpdateMapSeats()
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public void checkedBoard()
- - public override void DayUpdate(int dayOfMonth)
- - public bool removeObjectAtTileWithName(int x, int y, string name)
- - public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
- - public override bool CanPlantTreesHere(string itemId, int tileX, int tileY, out string deniedMessage)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public void crackOpenAbandonedJojaMartDoor()
- - public override bool isTileFishable(int tileX, int tileY)
- - public void showImprovedPamHouse()
- - public static Point GetTheaterTileOffset()
- - public override void MakeMapModifications(bool force = false)
- - public override void cleanupBeforePlayerExit()
- - public void initiateMarnieLewisBush()
- - public void initiateMagnifyingGlassGet()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void draw(SpriteBatch spriteBatch)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)

## Private Members
- - private TemporaryAnimatedSprite minecartSteam;
- - private bool ccRefurbished;
- - private bool ccJoja;
- - private bool playerCheckedBoard;
- - private bool isShowingDestroyedJoja;
- - private bool isShowingUpgradedPamHouse;
- - private bool isShowingSpecialOrdersBoard;
- - private bool showBookseller;
- - private LocalizedContentManager mapLoader;
- - private Vector2 clockCenter = new Vector2(3392f, 1056f);
- - private Vector2 ccFacadePosition = new Vector2(3044f, 940f);
- - private Vector2 ccFacadePositionBottom = new Vector2(3044f, 1140f);
- - private void addClintMachineGraphics()
- - private void refurbishCommunityCenter()
- - private void showDestroyedJoja()
- - private void showTownCommunityUpgradeShortcuts()
- - private void marnie_landed(int extra)
- - private void mgThief_landed(int extra)
- - private void mgThief_speech(int extra)
- - private void mgThief_afterSpeech()
- - private void mgThief_afterGlass()
- - private void mg_disappear(int extra)

## Protected Members
- - protected override void initNetFields()
- - protected override LocalizedContentManager getMapLoader()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
