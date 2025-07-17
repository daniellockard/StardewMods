# CosmeticDebris

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float gravity = 0.3f;
- - public const float bounciness = 0.45f;
- - public CosmeticDebris(Texture2D texture, Vector2 startingPosition, float rotationSpeed, float xVelocity, float yVelocity, int groundYLevel, Rectangle sourceRect, Color color, ICue tapSound, LightSource light, int lightTailLength, int disappearTime)
- - public override bool update(GameTime time)
- - public override void draw(SpriteBatch spriteBatch, bool localPosition = false, int xOffset = 0, int yOffset = 0, float extraAlpha = 1f)

## Private Members
- - private new Vector2 position;
- - private new float rotation;
- - private float rotationSpeed;
- - private float xVelocity;
- - private float yVelocity;
- - private new Rectangle sourceRect;
- - private int groundYLevel;
- - private int disappearTimer;
- - private int lightTailLength;
- - private int timeToDisappearAfterReachingGround;
- - private new int id;
- - private new Color color;
- - private ICue tapSound;
- - private LightSource light;
- - private Queue<Vector2> lightTail;
- - private new Texture2D texture;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
