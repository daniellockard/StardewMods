# Serpent

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float rotationIncrement = (float)Math.PI / 64f;
- - public int wasHitCounter;
- - public float targetRotation;
- - public bool turningRight;
- - public readonly NetFarmerRef killer = new NetFarmerRef().Delayed(interpolationWait: false);
- - public List<Vector3> segments = new List<Vector3>();
- - public NetInt segmentCount = new NetInt(0);
- - public Serpent()
- - public Serpent(Vector2 position)
- - public Serpent(Vector2 position, string name)
- - public virtual void InitializeAttributes()
- - public bool IsRoyalSerpent()
- - public override bool TakesDamageFromHitbox(Rectangle area_of_effect)
- - public override bool OverlapsFarmerForDamage(Farmer who)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override List<Item> getExtraDropItems()
- - public override void drawAboveAllLayers(SpriteBatch b)
- - public override Rectangle GetBoundingBox()
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void sharedDeathAnimation()
- - protected override void localDeathAnimation()
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
