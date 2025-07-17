# Fly

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float rotationIncrement = (float)Math.PI / 64f;
- - public const int volumeTileRange = 16;
- - public const int spawnTime = 1000;
- - public int spawningCounter = 1000;
- - public int wasHitCounter;
- - public float targetRotation;
- - public static ICue buzz;
- - public bool turningRight;
- - public bool hard;
- - public Fly()
- - public Fly(Vector2 position)
- - public Fly(Vector2 position, bool hard)
- - public void setHard()
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void drawAboveAllLayers(SpriteBatch b)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override void behaviorAtGameTick(GameTime time)
- - public override void Removed()

## Private Members
- *(None)*

## Protected Members
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
