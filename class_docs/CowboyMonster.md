# CowboyMonster

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int MonsterAnimationDelay = 500;
- - public int health;
- - public int type;
- - public int speed;
- - public float movementAnimationTimer;
- - public Rectangle position;
- - public int movementDirection;
- - public bool movedLastTurn;
- - public bool oppositeMotionGuy;
- - public bool invisible;
- - public bool special;
- - public bool uninterested;
- - public bool flyer;
- - public Color tint = Color.White;
- - public Color flashColor = Color.Red;
- - public float flashColorTimer;
- - public int ticksSinceLastMovement;
- - public Vector2 acceleration;
- - public CowboyMonster(int which, int health, int speed, Point position)
- - public CowboyMonster(int which, Point position)
- - public virtual void draw(SpriteBatch b)
- - public virtual bool takeDamage(int damage)
- - public virtual int getLootDrop()
- - public virtual bool move(Vector2 playerPosition, GameTime time)
- - public void spikeyEndBehavior(int extraInfo)

## Private Members
- - private Point targetPosition;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
