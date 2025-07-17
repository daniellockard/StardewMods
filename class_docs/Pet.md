# Pet

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const string type_cat = "Cat";
- - public const string type_dog = "Dog";
- - public NetGuid petId = new NetGuid(Guid.NewGuid());
- - public const int bedTime = 2000;
- - public const int maxFriendship = 1000;
- - public const string behavior_Walk = "Walk";
- - public const string behavior_Sleep = "Sleep";
- - public const string behavior_SitDown = "SitDown";
- - public const string behavior_Sprint = "Sprint";
- - public readonly NetString petType = new NetString("Dog");
- - public readonly NetString whichBreed = new NetString("0");
- - public readonly NetString homeLocationName = new NetString();
- - public readonly NetEvent1Field<long, NetLong> petPushEvent = new NetEvent1Field<long, NetLong>();
- - public NetLongDictionary<int, NetInt> lastPetDay = new NetLongDictionary<int, NetInt>();
- - public NetBool grantedFriendshipForPet = new NetBool(value: false);
- - public NetInt friendshipTowardFarmer = new NetInt(0);
- - public NetInt timesPet = new NetInt(0);
- - public readonly NetRef<Hat> hat = new NetRef<Hat>();
- - public NetBool isSleepingOnFarmerBed = new NetBool(value: false);
- - public readonly NetMutex mutex = new NetMutex();
- - public override bool IsVillager => false;
- - public string CurrentBehavior
- - public override void reloadData()
- - public Pet(int xTile, int yTile, string petBreed, string petType)
- - public Pet()
- - public virtual void OnPetPush(long farmerId)
- - public override int getTimeFarmerMustPushBeforeStartShaking()
- - public override int getTimeFarmerMustPushBeforePassingThrough()
- - public override void behaviorOnFarmerLocationEntry(GameLocation location, Farmer who)
- - public override void behaviorOnLocalFarmerLocationEntry(GameLocation location)
- - public override bool canTalk()
- - public PetData GetPetData()
- - public static bool TryGetData(string petType, out PetData data)
- - public void GetPetIcon(out string assetName, out Rectangle sourceRect)
- - public virtual string getPetTextureName()
- - public void reloadBreedSprite()
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void ChooseAppearance(LocalizedContentManager content = null)
- - public void warpToFarmHouse(Farmer who)
- - public virtual void UpdateSleepingOnBed()
- - public override void dayUpdate(int dayOfMonth)
- - public void GrantLoveMailIfNecessary()
- - public PetBowl GetPetBowl()
- - public virtual void WarpToPetBowl()
- - public void setAtFarmPosition()
- - public override bool shouldCollideWithBuildingLayer(GameLocation location)
- - public override bool canPassThroughActionTiles()
- - public void unassignPetBowl()
- - public void applyButterflyPowder(Farmer who, string responseKey)
- - public override bool checkAction(Farmer who, GameLocation l)
- - public virtual void playContentSound()
- - public void hold(Farmer who)
- - public override void behaviorOnFarmerPushing()
- - public override void update(GameTime time, GameLocation location, long id, bool move)
- - public override void update(GameTime time, GameLocation location)
- - public Item TryGetGiftItem(List<PetGift> gifts)
- - public bool TryBehaviorChange(List<PetBehaviorChanges> changes)
- - public PetBehavior GetCurrentPetBehavior()
- - public virtual void RunState(GameTime time)
- - public virtual void OnNewBehavior()
- - public void _PerformAnimationSound(Farmer who)
- - public void PlaySound(string sound, bool is_voice, int range_from_border, int range)
- - public bool IsSoundInRange(int range_from_border, int sound_range)
- - public virtual void _TryAnimationEndBehaviorChange(Farmer who)
- - public override Rectangle GetBoundingBox()
- - public virtual void drawHat(SpriteBatch b, Vector2 shake)
- - public override void draw(SpriteBatch b)
- - public virtual bool withinLocalPlayerThreshold(int threshold)
- - public override bool withinPlayerThreshold(int threshold)
- - public void hitGround(Farmer who)

## Private Members
- - private readonly NetString netCurrentBehavior = new NetString();
- - private int pushingTimer;

## Protected Members
- - protected int behaviorTimer = -1;
- - protected int animationLoopsLeft;
- - protected string _currentBehavior;
- - protected int _walkFromPushTimer;
- - protected override string translateName()
- - protected override void initNetFields()
- - protected override void updateSlaveAnimation(GameTime time)
- - protected void _OnNewBehavior()

## Internal Members
- *(None)*

## Other Members
- *(None)*
