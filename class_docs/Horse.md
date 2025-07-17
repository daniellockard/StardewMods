# Horse

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetLong ownerId = new NetLong();
- - public readonly NetBool mounting = new NetBool();
- - public readonly NetBool dismounting = new NetBool();
- - public readonly NetRef<Hat> hat = new NetRef<Hat>();
- - public readonly NetMutex mutex = new NetMutex();
- - public Action<string> onFootstepAction;
- - public bool ateCarrotToday;
- - public Guid HorseId
- - public Farmer rider
- - public override bool IsVillager => false;
- - public Horse()
- - public Horse(Guid horseId, int xTile, int yTile)
- - public override void reloadData()
- - public override bool canTalk()
- - public Farmer getOwner()
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void ChooseAppearance(LocalizedContentManager content = null)
- - public override void dayUpdate(int dayOfMonth)
- - public override Rectangle GetBoundingBox()
- - public override bool canPassThroughActionTiles()
- - public void squeezeForGate()
- - public override void update(GameTime time, GameLocation location)
- - public override void OnLocationRemoved()
- - public virtual void OnMountFootstep(Farmer who)
- - public virtual void PerformDefaultHorseFootstep(string step_type)
- - public void dismount(bool from_demolish = false)
- - public Stable TryFindStable()
- - public bool TryFindStable(out GameLocation location, out Stable stable)
- - public void nameHorse(string name)
- - public override bool checkAction(Farmer who, GameLocation l)
- - public void SyncPositionToRider()
- - public override void draw(SpriteBatch b)

## Private Members
- - private readonly NetGuid horseId = new NetGuid();
- - private readonly NetFarmerRef netRider = new NetFarmerRef();
- - private Vector2 dismountTile;
- - private int ridingAnimationDirection;
- - private bool roomForHorseAtDismountTile;
- - private bool squeezingThroughGate;
- - private int munchingCarrotTimer;

## Protected Members
- - protected override string translateName()
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
