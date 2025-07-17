# Grub

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int healthToRunAway = 8;
- - public readonly NetBool leftDrift = new NetBool();
- - public readonly NetBool pupating = new NetBool();
- - public readonly NetBool hard = new NetBool();
- - public int metamorphCounter = 2000;
- - public readonly NetFloat targetRotation = new NetFloat();
- - public Grub()
- - public Grub(Vector2 position)
- - public Grub(Vector2 position, bool hard)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public void setHard()
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void defaultMovementBehavior(GameTime time)
- - public override void BuffForAdditionalDifficulty(int additional_difficulty)
- - public override void update(GameTime time, GameLocation location)
- - public override void draw(SpriteBatch b)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void updateMonsterSlaveAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
