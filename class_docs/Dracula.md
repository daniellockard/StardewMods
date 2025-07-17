# Dracula

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int gloatingPhase = -1;
- - public const int walkRandomlyAndShootPhase = 0;
- - public const int spreadShotPhase = 1;
- - public const int summonDemonPhase = 2;
- - public const int summonMummyPhase = 3;
- - public int phase = -1;
- - public int phaseInternalTimer;
- - public int phaseInternalCounter;
- - public int shootTimer;
- - public int fullHealth;
- - public Point homePosition;
- - public Dracula()
- - public override void draw(SpriteBatch b)
- - public override int getLootDrop()
- - public override bool takeDamage(int damage)
- - public override bool move(Vector2 playerPosition, GameTime time)
- - public void fireSpread(Point origin, double offsetAngle)
- - public void summonEnemies(Point origin, int which)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
