# Frog

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Frog(Vector2 position, bool waterLeaper = false, bool forceFlip = false)
- - public void startSplash(Farmer who)
- - public override bool update(GameTime time, GameLocation environment)
- - public override void draw(SpriteBatch b)
- - public override void drawAboveFrontLayer(SpriteBatch b)

## Private Members
- - private bool waterLeaper;
- - private bool leapingIntoWater;
- - private bool splash;
- - private int characterCheckTimer = 200;
- - private int beforeFadeTimer;
- - private float alpha = 1f;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
