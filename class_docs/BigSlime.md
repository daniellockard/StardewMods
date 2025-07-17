# BigSlime

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetColor c = new NetColor();
- - public readonly NetRef<Item> heldItem = new NetRef<Item>();
- - public BigSlime()
- - public BigSlime(Vector2 position, MineShaft mine)
- - public BigSlime(Vector2 position, int mineArea)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override List<Item> getExtraDropItems()
- - public override void draw(SpriteBatch b)
- - public override Rectangle GetBoundingBox()
- - public override void shedChunks(int number, float scale)

## Private Members
- - private float heldObjectBobTimer;

## Protected Members
- - protected override void initNetFields()
- - protected override void localDeathAnimation()
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
