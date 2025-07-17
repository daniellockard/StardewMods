# Spiker

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int targetDirection;
- - public NetBool moving = new NetBool(value: false);
- - public float nextMoveCheck;
- - public Spiker()
- - public Spiker(Vector2 position, int direction)
- - public override void update(GameTime time, GameLocation location)
- - public override void draw(SpriteBatch b)
- - public override void updateMovement(GameLocation location, GameTime time)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- - private void collide(GameLocation location)

## Protected Members
- - protected bool _localMoving;
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
