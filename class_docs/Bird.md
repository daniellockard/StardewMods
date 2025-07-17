# Bird

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum BirdState
- - public Vector2 position;
- - public Point startPosition;
- - public Point endPosition;
- - public float pathPosition;
- - public float velocity;
- - public int framesUntilNextMove;
- - public BirdState birdState;
- - public PerchingBirds context;
- - public int peckFrames;
- - public int nextPeck;
- - public int peckDirection;
- - public int birdType;
- - public int flapFrames = 2;
- - public float flyArcHeight;
- - public Bird()
- - public Bird(Point point, PerchingBirds context, int bird_type = 0, int flap_frames = 2)
- - public virtual void Draw(SpriteBatch b)
- - public virtual void FlyToNewPoint()
- - public virtual void Update(GameTime time)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
