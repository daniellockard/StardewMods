# FishPond

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int MAXIMUM_OCCUPANCY = 10;
- - public static readonly float FISHING_MILLISECONDS = 1000f;
- - public static readonly int HARVEST_BASE_EXP = 10;
- - public static readonly float HARVEST_OUTPUT_EXP_MULTIPLIER = 0.04f;
- - public static readonly int QUEST_BASE_EXP = 20;
- - public static readonly float QUEST_SPAWNRATE_EXP_MULTIPIER = 5f;
- - public const int NUMBER_OF_NETTING_STYLE_TYPES = 4;
- - public readonly NetString fishType = new NetString();
- - public readonly NetInt lastUnlockedPopulationGate = new NetInt(0);
- - public readonly NetBool hasCompletedRequest = new NetBool(value: false);
- - public readonly NetBool goldenAnimalCracker = new NetBool(value: false);
- - public readonly NetBool isPlayingGoldenCrackerAnimation = new NetBool(value: false);
- - public readonly NetRef<Object> sign = new NetRef<Object>();
- - public readonly NetColor overrideWaterColor = new NetColor(Color.White);
- - public readonly NetRef<Item> output = new NetRef<Item>();
- - public readonly NetRef<Item> neededItem = new NetRef<Item>();
- - public readonly NetIntDelta neededItemCount = new NetIntDelta(0);
- - public readonly NetInt daysSinceSpawn = new NetInt(0);
- - public readonly NetInt nettingStyle = new NetInt(0);
- - public readonly NetInt seedOffset = new NetInt(0);
- - public readonly NetBool hasSpawnedFish = new NetBool(value: false);
- - public readonly NetMutex needsMutex = new NetMutex();
- - public List<PondFishSilhouette> _fishSilhouettes = new List<PondFishSilhouette>();
- - public List<JumpingFish> _jumpingFish = new List<JumpingFish>();
- - public TemporaryAnimatedSpriteList animations = new TemporaryAnimatedSpriteList();
- - public int FishCount => currentOccupants.Value;
- - public FishPond(Vector2 tileLocation)
- - public FishPond()
- - public virtual void OnFishTypeChanged(NetString field, string old_value, string new_value)
- - public virtual void Reseed()
- - public List<PondFishSilhouette> GetFishSilhouettes()
- - public void UpdateMaximumOccupancy()
- - public FishPondData GetFishPondData()
- - public static FishPondData GetRawData(string itemId)
- - public Item GetFishProduce(Random random = null)
- - public override bool doAction(Vector2 tileLocation, Farmer who)
- - public void AnimateHappyFish()
- - public Vector2 GetItemBucketTile()
- - public Vector2 GetRequestTile()
- - public Vector2 GetCenterTile()
- - public void ResolveNeeds(Farmer who)
- - public override void resetLocalState()
- - public override void dayUpdate(int dayOfMonth)
- - public override Color? GetWaterColor(Vector2 tile)
- - public bool JumpFish()
- - public void SpawnFish()
- - public override bool performActiveObjectDropInAction(Farmer who, bool probe)
- - public override void performToolAction(Tool t, int tileX, int tileY)
- - public override void performActionOnConstruction(GameLocation location, Farmer who)
- - public override void performActionOnBuildingPlacement()
- - public bool HasUnresolvedNeeds()
- - public void ClearPond()
- - public Object CatchFish()
- - public Object GetFishObject()
- - public override void Update(GameTime time)
- - public override bool isTileFishable(Vector2 tile)
- - public override bool CanRefillWateringCan()
- - public override Rectangle? getSourceRectForMenu()
- - public override void drawInMenu(SpriteBatch b, int x, int y)
- - public override void OnEndMove()
- - public override void draw(SpriteBatch b)
- - public bool IsValidSignItem(Item item)

## Private Members
- - private readonly NetEvent0 animateHappyFishEvent = new NetEvent0();
- - private Item CreateFishInstance()
- - private bool isLegalFishForPonds(string itemId)
- - private void showObjectThrownIntoPondAnimation(Farmer who, Object whichObject, Action callback = null)
- - private bool addFishToPond(Farmer who, Object fish)
- - private void doFishSpecificWaterColoring()
- - private bool TryGetNeededItemData(out string itemId, out int count)

## Protected Members
- - protected bool _hasAnimatedSpawnedFish;
- - protected float _delayUntilFishSilhouetteAdded;
- - protected int _numberOfFishToJump;
- - protected float _timeUntilFishHop;
- - protected Object _fishObject;
- - protected FishPondData _fishPondData;
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
