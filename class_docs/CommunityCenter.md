# CommunityCenter

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int AREA_Pantry = 0;
- - public const int AREA_FishTank = 2;
- - public const int AREA_CraftsRoom = 1;
- - public const int AREA_BoilerRoom = 3;
- - public const int AREA_Vault = 4;
- - public const int AREA_Bulletin = 5;
- - public const int AREA_AbandonedJojaMart = 6;
- - public const int AREA_Bulletin2 = 7;
- - public const int AREA_JunimoHut = 8;
- - public List<NetMutex> bundleMutexes = new List<NetMutex>();
- - public readonly NetArray<bool, NetBool> areasComplete = new NetArray<bool, NetBool>(6);
- - public readonly NetInt numberOfStarsOnPlaque = new NetInt();
- - public readonly NetRef<Chest> missedRewardsChest = new NetRef<Chest>(new Chest(playerChest: true));
- - public readonly NetBool missedRewardsChestVisible = new NetBool(value: false);
- - public readonly NetEvent1Field<bool, NetBool> showMissedRewardsChestEvent = new NetEvent1Field<bool, NetBool>();
- - public const int PHASE_firstPause = 0;
- - public const int PHASE_junimoAppear = 1;
- - public const int PHASE_junimoDance = 2;
- - public const int PHASE_restore = 3;
- - public NetBundles bundles => Game1.netWorldState.Value.Bundles;
- - public NetIntDictionary<bool, NetBool> bundleRewards => Game1.netWorldState.Value.BundleRewards;
- - public CommunityCenter()
- - public CommunityCenter(string map_path, string name)
- - public CommunityCenter(string name)
- - public void refreshBundlesIngredientsInfo()
- - public static int getAreaNumberFromName(string name)
- - public unsafe void addJunimoNote(int area)
- - public int numberOfCompleteBundles()
- - public void addStarToPlaque()
- - public Dictionary<int, bool[]> bundlesDict()
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public void checkBundle(int area)
- - public void addJunimoNoteViewportTarget(int area)
- - public void checkForNewJunimoNotes()
- - public bool isJunimoNoteAtArea(int area)
- - public bool shouldNoteAppearInArea(int area)
- - public override void updateMap()
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override void MakeMapModifications(bool force = false)
- - public override void cleanupBeforeSave()
- - public override void cleanupBeforePlayerExit()
- - public bool isBundleComplete(int bundleIndex)
- - public bool couldThisIngredienteBeUsedInABundle(Object o)
- - public void areaCompleteReward(int whichArea)
- - public void loadArea(int area, bool showEffects = true)
- - public void addFishTank()
- - public void restoreAreaCutscene(int whichArea)
- - public void markAreaAsComplete(int area)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public Junimo getJunimoForArea(int whichArea)
- - public bool areAllAreasComplete()
- - public void junimoGoodbyeDance()
- - public void prepareForJunimoDance()
- - public override void draw(SpriteBatch b)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public static string getAreaNameFromNumber(int areaNumber)
- - public static string getAreaEnglishDisplayNameFromNumber(int areaNumber)
- - public static string getAreaDisplayNameFromNumber(int areaNumber)
- - public static StaticTile[] getJunimoNoteTileFrames(int area, Map map)

## Private Members
- - private readonly NetBool warehouse = new NetBool();
- - private readonly NetEvent0 newJunimoNoteCheckEvent = new NetEvent0();
- - private readonly NetEvent1Field<int, NetInt> restoreAreaCutsceneEvent = new NetEvent1Field<int, NetInt>();
- - private readonly NetEvent1Field<int, NetInt> areaCompleteRewardEvent = new NetEvent1Field<int, NetInt>();
- - private float messageAlpha;
- - private List<int> junimoNotesViewportTargets;
- - private Dictionary<int, List<int>> areaToBundleDictionary;
- - private Dictionary<int, int> bundleToAreaDictionary;
- - private Dictionary<string, List<List<int>>> bundlesIngredientsInfo;
- - private bool _isWatchingJunimoGoodbye;
- - private Vector2 missedRewardsChestTile = new Vector2(22f, 10f);
- - private const string missedRewardsTileSheetId = "indoors2";
- - private int restoreAreaTimer;
- - private int restoreAreaPhase;
- - private int restoreAreaIndex;
- - private ICue buildUpSound;
- - private void initAreaBundleConversions()
- - private Point getNotePosition(int area)
- - private string getMessageForAreaCompletion()
- - private int getNumberOfAreasComplete()
- - private void rewardGrabbed(Item item, Farmer who)
- - private void doCheckForNewJunimoNotes()
- - private void doShowMissedRewardsChest(bool isVisible)
- - private void checkForMissedRewards()
- - private int getAreaNumberFromLocation(Vector2 tileLocation)
- - private Rectangle getAreaBounds(int area)
- - private void doAreaCompleteReward(int whichArea)
- - private void doRestoreAreaCutscene(int whichArea)
- - private void setViewportToNextJunimoNoteTarget()
- - private void afterViewportGetsToJunimoNotePosition()
- - private void startGoodbyeDance()
- - private void endGoodbyeDance()
- - private void loadJunimoHut()

## Protected Members
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected override void resetLocalState()
- - protected void removeJunimo()

## Internal Members
- *(None)*

## Other Members
- *(None)*
