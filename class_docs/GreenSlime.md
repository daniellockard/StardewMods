# GreenSlime

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float mutationFactor = 0.25f;
- - public const int matingInterval = 120000;
- - public const int childhoodLength = 120000;
- - public const int durationOfMating = 2000;
- - public const double chanceToMate = 0.001;
- - public static int matingRange = 192;
- - public const int AQUA_SLIME = 9999899;
- - public NetIntDelta stackedSlimes = new NetIntDelta(0)
- - public float randomStackOffset;
- - public NetEvent1Field<Vector2, NetVector2> attackedEvent = new NetEvent1Field<Vector2, NetVector2>();
- - public readonly NetBool leftDrift = new NetBool();
- - public readonly NetBool cute = new NetBool(value: true);
- - public int readyToJump = -1;
- - public int matingCountdown;
- - public new int yOffset;
- - public int wagTimer;
- - public int readyToMate = 120000;
- - public readonly NetInt ageUntilFullGrown = new NetInt();
- - public int animateTimer;
- - public int timeSinceLastJump;
- - public readonly NetInt specialNumber = new NetInt();
- - public readonly NetBool firstGeneration = new NetBool();
- - public readonly NetColor color = new NetColor();
- - public readonly NetBool prismatic = new NetBool();
- - public GreenSlime()
- - public GreenSlime(Vector2 position)
- - public GreenSlime(Vector2 position, int mineLevel)
- - public GreenSlime(Vector2 position, Color color)
- - public void makeTigerSlime(bool onlyAppearance = false)
- - public void makePrismatic()
- - public override void reloadSprite(bool onlyAppearance = false)
- - public virtual void OnAttacked(Vector2 trajectory)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void shedChunks(int number, float scale)
- - public override void collisionWithFarmerBehavior()
- - public override void onDealContactDamage(Farmer who)
- - public override void draw(SpriteBatch b)
- - public void moveTowardOtherSlime(GreenSlime other, bool moveAway, GameTime time)
- - public void doneMating()
- - public override void noMovementProgressNearPlayerBehavior()
- - public void mateWith(GreenSlime mateToPursue, GameLocation location)
- - public override List<Item> getExtraDropItems()
- - public override void dayUpdate(int dayOfMonth)
- - public override void update(GameTime time, GameLocation location)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- - private readonly NetBool pursuingMate = new NetBool();
- - private readonly NetBool avoidingMate = new NetBool();
- - private GreenSlime mate;
- - private readonly NetVector2 facePosition = new NetVector2();
- - private readonly NetEvent1Field<Vector2, NetVector2> jumpEvent = new NetEvent1Field<Vector2, NetVector2>
- - private void doJump(Vector2 trajectory)

## Protected Members
- - protected override void initNetFields()
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
