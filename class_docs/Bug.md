# Bug

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool isArmoredBug = new NetBool(value: false);
- - public Bug()
- - public Bug(Vector2 position, int facingDirection, string specialType)
- - public Bug(Vector2 position, int areaType)
- - public Bug(Vector2 position, int facingDirection, MineShaft mine)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void BuffForAdditionalDifficulty(int additional_difficulty)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override List<Item> getExtraDropItems()
- - public override void draw(SpriteBatch b)
- - public override void shedChunks(int number, float scale)

## Private Members
- - private void collide(GameLocation location)

## Protected Members
- - protected override void initNetFields()
- - protected override void updateMonsterSlaveAnimation(GameTime time)
- - protected override void localDeathAnimation()

## Internal Members
- *(None)*

## Other Members
- *(None)*
