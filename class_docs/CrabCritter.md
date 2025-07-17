# CrabCritter

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Rectangle movementRectangle;
- - public float nextCharacterCheck = 2f;
- - public float nextFrameChange;
- - public float nextMovementChange;
- - public bool moving;
- - public bool diving;
- - public bool skittering;
- - public Rectangle movementBounds;
- - public CrabCritter()
- - public CrabCritter(Vector2 start_position)
- - public override bool update(GameTime time, GameLocation environment)
- - public virtual void UpdateSpriteRectangle()
- - public override void draw(SpriteBatch b)
- - public override void drawAboveFrontLayer(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected float skitterTime = 5f;
- - protected Rectangle _baseSourceRectangle = new Rectangle(0, 272, 18, 18);
- - protected int _currentFrame;
- - protected int _crabVariant;
- - protected Vector2 movementDirection = Vector2.Zero;

## Internal Members
- *(None)*

## Other Members
- *(None)*
