# RockGolem

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool seenPlayer = new NetBool();
- - public RockGolem()
- - public RockGolem(Vector2 position)
- - public RockGolem(Vector2 position, MineShaft mineArea)
- - public RockGolem(Vector2 position, int difficultyMod)
- - public RockGolem(Vector2 position, bool alreadySpawned)
- - public override List<Item> getExtraDropItems()
- - public override void BuffForAdditionalDifficulty(int additional_difficulty)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void noMovementProgressNearPlayerBehavior()
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void localDeathAnimation()
- - protected override void sharedDeathAnimation()
- - protected override void updateMonsterSlaveAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
