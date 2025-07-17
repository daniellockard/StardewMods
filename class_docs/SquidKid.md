# SquidKid

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public float lastFireball;
- - public new int yOffset;
- - public SquidKid()
- - public SquidKid(Vector2 position)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void drawAboveAllLayers(SpriteBatch b)
- - public override void update(GameTime time, GameLocation location)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- - private readonly NetEvent0 fireballEvent = new NetEvent0();
- - private readonly NetEvent0 hurtAnimationEvent = new NetEvent0();
- - private int numFireballsLeft;
- - private float firingTimer;
- - private Vector2 fireballFired()

## Protected Members
- - protected override void initNetFields()
- - protected override void sharedDeathAnimation()
- - protected override void localDeathAnimation()
- - protected override void updateAnimation(GameTime time)
- - protected override void updateMonsterSlaveAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
