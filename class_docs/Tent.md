# Tent

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetInt health = new NetInt(5);
- - public static Vector2 lastTentTouchedByPlayer = Vector2.Zero;
- - public Tent()
- - public override void initNetFields()
- - public Tent(Vector2 tileLocation)
- - public override Rectangle getBoundingBox()
- - public override bool isPassable(Character c = null)
- - public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
- - public override void dayUpdate()
- - public override bool performUseAction(Vector2 tileLocation)
- - public override void onDestroy()
- - public override bool tickUpdate(GameTime time)
- - public override void draw(SpriteBatch spriteBatch)

## Private Members
- - private int invincTimer;
- - private Vector2 shakeOffset;
- - private bool goingToSleep;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
