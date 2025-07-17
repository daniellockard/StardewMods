# BlueSquid

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public float nextFire;
- - public int squidYOffset;
- - public float canMoveTimer;
- - public NetFloat projectileIntroTimer = new NetFloat();
- - public NetFloat projectileOutroTimer = new NetFloat();
- - public NetBool nearFarmer = new NetBool();
- - public NetFloat lastRotation = new NetFloat();
- - public bool justThrust;
- - public BlueSquid()
- - public BlueSquid(Vector2 position)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override Rectangle GetBoundingBox()
- - public override void drawAboveAllLayers(SpriteBatch b)
- - public override void noMovementProgressNearPlayerBehavior()
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
