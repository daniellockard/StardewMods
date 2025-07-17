# Skeleton

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool spottedPlayer;
- - public readonly NetBool throwing = new NetBool();
- - public readonly NetBool isMage = new NetBool();
- - public Skeleton()
- - public Skeleton(Vector2 position, bool isMage = false)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override List<Item> getExtraDropItems()
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void shedChunks(int number)
- - public override void BuffForAdditionalDifficulty(int additional_difficulty)
- - public override void update(GameTime time, GameLocation location)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- - private int controllerAttemptTimer;

## Protected Members
- - protected override void initNetFields()
- - protected override void sharedDeathAnimation()
- - protected override void updateMonsterSlaveAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
