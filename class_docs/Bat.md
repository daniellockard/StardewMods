# Bat

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float rotationIncrement = (float)Math.PI / 64f;
- - public readonly NetInt wasHitCounter = new NetInt(0);
- - public float targetRotation;
- - public readonly NetBool turningRight = new NetBool();
- - public readonly NetBool seenPlayer = new NetBool();
- - public readonly NetBool cursedDoll = new NetBool();
- - public readonly NetBool hauntedSkull = new NetBool();
- - public readonly NetBool magmaSprite = new NetBool();
- - public readonly NetBool canLunge = new NetBool();
- - public int lungeFrequency = 3000;
- - public int lungeChargeTime = 500;
- - public int lungeSpeed = 30;
- - public int lungeDecelerationTicks = 60;
- - public int nextLunge = -1;
- - public int lungeTimer;
- - public Vector2 lungeVelocity = Vector2.Zero;
- - public Bat()
- - public Bat(Vector2 position)
- - public Bat(Vector2 position, int mineLevel)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override Debris ModifyMonsterLoot(Debris debris)
- - public override List<Item> getExtraDropItems()
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void shedChunks(int number, float scale)
- - public override void onDealContactDamage(Farmer who)
- - public override void drawAboveAllLayers(SpriteBatch b)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- - private ICue batFlap;
- - private float extraVelocity;
- - private float maxSpeed = 5f;
- - private List<Vector2> previousPositions = new List<Vector2>();

## Protected Members
- - protected override void initNetFields()
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
