# Child

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int newborn = 0;
- - public const int baby = 1;
- - public const int crawler = 2;
- - public const int toddler = 3;
- - public readonly NetInt daysOld = new NetInt(0);
- - public NetLong idOfParent = new NetLong(0L);
- - public readonly NetBool darkSkinned = new NetBool(value: false);
- - public readonly NetRef<Hat> hat = new NetRef<Hat>();
- - public readonly NetMutex mutex = new NetMutex();
- - public override bool IsVillager => false;
- - public Child()
- - public Child(string name, bool isMale, bool isDarkSkinned, Farmer parent)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void ChooseAppearance(LocalizedContentManager content = null)
- - public override void MovePosition(GameTime time, Rectangle viewport, GameLocation currentLocation)
- - public override bool canPassThroughActionTiles()
- - public override void resetForNewDay(int dayOfMonth)
- - public override void reloadData()
- - public override void dayUpdate(int dayOfMonth)
- - public bool isInCrib()
- - public override bool hasDarkSkin()
- - public void toss(Farmer who)
- - public void performToss(Farmer who)
- - public void doneTossing(Farmer who)
- - public override Rectangle getMugShotSourceRect()
- - public override bool hasSpecialCollisionRules()
- - public override bool isColliding(GameLocation l, Vector2 tile)
- - public void tenMinuteUpdate()
- - public virtual int GetChildIndex()
- - public void toddlerReachedDestination(Character c, GameLocation l)
- - public override bool canTalk()
- - public override bool checkAction(Farmer who, GameLocation l)
- - public override void update(GameTime time, GameLocation location)
- - public void resetForPlayerEntry(GameLocation l)
- - public override void draw(SpriteBatch b, float alpha = 1f)
- - public override void draw(SpriteBatch b)
- - public override void behaviorOnLocalFarmerLocationEntry(GameLocation location)

## Private Members
- - private readonly NetEvent1Field<int, NetInt> setStateEvent = new NetEvent1Field<int, NetInt>();
- - private int previousState;
- - private void setState(int state)
- - private void doSetState(int state)
- - private void setCrawlerInNewDirection()
- - private List<FarmerSprite.AnimationFrame> getRandomCrawlerAnimation(int which = -1)
- - private List<FarmerSprite.AnimationFrame> getRandomNewbornAnimation()
- - private List<FarmerSprite.AnimationFrame> getRandomBabyAnimation()

## Protected Members
- - protected override void initNetFields()
- - protected override void updateSlaveAnimation(GameTime time)
- - protected override string translateName()

## Internal Members
- *(None)*

## Other Members
- *(None)*
