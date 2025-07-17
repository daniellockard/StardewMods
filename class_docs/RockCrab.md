# RockCrab

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool waiter;
- - public readonly NetBool shellGone = new NetBool();
- - public readonly NetInt shellHealth = new NetInt(5);
- - public readonly NetBool isStickBug = new NetBool();
- - public RockCrab()
- - public RockCrab(Vector2 position)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public RockCrab(Vector2 position, string name)
- - public void makeStickBug()
- - public override bool hitWithTool(Tool t)
- - public override void shedChunks(int number)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void update(GameTime time, GameLocation location)
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
