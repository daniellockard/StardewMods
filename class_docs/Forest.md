# Forest

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const string raccoonStumpCheckFlag = "checkedRaccoonStump";
- - public const string raccoontreeFlag = "raccoonTreeFallen";
- - public Rectangle MarnieLivestockArea = new Rectangle(94, 17, 10, 5);
- - public readonly NetObjectList<FarmAnimal> marniesLivestock = new NetObjectList<FarmAnimal>();
- - public readonly NetList<Rectangle, NetRectangle> travelingMerchantBounds = new NetList<Rectangle, NetRectangle>();
- - public readonly NetBool netTravelingMerchantDay = new NetBool(value: false);
- - public ResourceClump obsolete_log;
- - public readonly NetBool stumpFixed = new NetBool();
- - public NetMutex derbyMutex = new NetMutex();
- - public bool travelingMerchantDay
- - public Forest()
- - public Forest(string map, string name)
- - public override void seasonUpdate(bool onLoad = false)
- - public static void fixStump(GameLocation location)
- - public void removeSewerTrash()
- - public override void cleanupBeforePlayerExit()
- - public override void MakeMapModifications(bool force = false)
- - public static bool isWizardHouseUnlocked()
- - public bool ShouldTravelingMerchantVisitToday()
- - public Point GetTravelingMerchantCartTile()
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character, bool pathfinding, bool projectile = false, bool ignoreCharacterRequirement = false, bool skipCollisionEffects = false)
- - public override bool isTilePlaceable(Vector2 v, bool itemIsPassable = false)
- - public override void DayUpdate(int dayOfMonth)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public void fadedForStumpFix()
- - public void doneWithStumpFix()
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public override void draw(SpriteBatch spriteBatch)

## Private Members
- - private int numRaccoonBabies = -1;
- - private int chimneyTimer = 500;
- - private bool hasShownCCUpgrade;
- - private Rectangle hatterSource = new Rectangle(600, 1957, 64, 32);
- - private Vector2 hatterPos = new Vector2(2056f, 6016f);
- - private void adjustDerbyFisherman(NPC npc)
- - private void showCommunityUpgradeShortcuts()

## Protected Members
- - protected override void initNetFields()
- - protected override void resetLocalState()
- - protected override void resetSharedState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
