# CalderaMonkey

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Rectangle movementRectangle;
- - public CalderaMonkey()
- - public CalderaMonkey(Vector2 start_position)
- - public override bool update(GameTime time, GameLocation environment)
- - public override void draw(SpriteBatch b)
- - public override void drawAboveFrontLayer(SpriteBatch b)

## Private Members
- - private const int phase_tailBOB = 0;
- - private const int phase_footPaddle = 1;
- - private const int phase_relaxing = 2;
- - private const int phase_scream = 3;
- - private int currentPhase;
- - private int currentFrame;
- - private float nextFrameTimer;
- - private float nextPhaseTimer;
- - private float currentFrameDelay;
- - private List<Vector2> buddies = new List<Vector2>();
- - private Texture2D texture;
- - private Texture2D swimShadow;
- - private void setFrame(int frame)

## Protected Members
- - protected Rectangle _baseSourceRectangle = new Rectangle(0, 309, 20, 24);
- - protected Vector2 movementDirection = Vector2.Zero;

## Internal Members
- *(None)*

## Other Members
- *(None)*
