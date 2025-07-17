# HotHead

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetFarmerRef lastAttacker = new NetFarmerRef();
- - public NetFloat timeUntilExplode = new NetFloat(-1f);
- - public NetBool angry = new NetBool();
- - public HotHead()
- - public HotHead(Vector2 position)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void behaviorAtGameTick(GameTime time)
- - public virtual void DropBomb()
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void sharedDeathAnimation()

## Internal Members
- *(None)*

## Other Members
- *(None)*
