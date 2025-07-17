# AngryRoger

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float rotationIncrement = (float)Math.PI / 64f;
- - public int wasHitCounter;
- - public float targetRotation;
- - public bool turningRight;
- - public int identifier = Game1.random.Next(-99999, 99999);
- - public new int yOffset;
- - public int yOffsetExtra;
- - public string lightSourceId;
- - public AngryRoger()
- - public AngryRoger(Vector2 position)
- - public AngryRoger(Vector2 position, string name)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void drawAboveAllLayers(SpriteBatch b)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void localDeathAnimation()
- - protected override void sharedDeathAnimation()
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
