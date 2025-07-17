# DustSpirit

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool seenFarmer;
- - public bool runningAwayFromFarmer;
- - public bool chargingFarmer;
- - public byte voice;
- - public ICue meep;
- - public DustSpirit()
- - public DustSpirit(Vector2 position)
- - public DustSpirit(Vector2 position, bool chargingTowardFarmer)
- - public override void draw(SpriteBatch b)
- - public override void shedChunks(int number, float scale)
- - public void offScreenBehavior(Character c, GameLocation l)
- - public virtual bool CaughtInWeb()
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void sharedDeathAnimation()
- - protected override void localDeathAnimation()
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
