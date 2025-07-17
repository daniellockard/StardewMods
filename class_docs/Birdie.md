# Birdie

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int brownBird = 25;
- - public const int blueBird = 45;
- - public const int flyingSpeed = 6;
- - public const int walkingSpeed = 1;
- - public const int pecking = 0;
- - public const int flyingAway = 1;
- - public const int sleeping = 2;
- - public const int stopped = 3;
- - public const int walking = 4;
- - public Birdie(int tileX, int tileY, int startingIndex = 25)
- - public Birdie(Vector2 position, float yOffset, int startingIndex = 25, bool stationary = false)
- - public void hop(Farmer who)
- - public override void drawAboveFrontLayer(SpriteBatch b)
- - public override void draw(SpriteBatch b)
- - public override bool update(GameTime time, GameLocation environment)

## Private Members
- - private int state;
- - private float flightOffset;
- - private bool stationary;
- - private int characterCheckTimer = 200;
- - private int walkTimer;
- - private void donePecking(Farmer who)
- - private void playFlap(Farmer who)
- - private void playPeck(Farmer who)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
