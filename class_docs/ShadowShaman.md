# ShadowShaman

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int visionDistance = 8;
- - public const int spellCooldown = 1500;
- - public bool spottedPlayer;
- - public readonly NetBool casting = new NetBool();
- - public int coolDown = 1500;
- - public float rotationTimer;
- - public ShadowShaman()
- - public ShadowShaman(Vector2 position)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void draw(SpriteBatch b)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void sharedDeathAnimation()
- - protected override void localDeathAnimation()
- - protected override void updateMonsterSlaveAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
