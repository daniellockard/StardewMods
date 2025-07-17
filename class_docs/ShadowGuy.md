# ShadowGuy

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int visionDistance = 8;
- - public const int spellCooldown = 1500;
- - public bool spottedPlayer;
- - public bool casting;
- - public bool teleporting;
- - public int coolDown = 1500;
- - public IEnumerator<Point> teleportationPath;
- - public float rotationTimer;
- - public ShadowGuy()
- - public ShadowGuy(Vector2 position)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void draw(SpriteBatch b)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public void castTeleport()
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void localDeathAnimation()
- - protected override void sharedDeathAnimation()

## Internal Members
- *(None)*

## Other Members
- *(None)*
