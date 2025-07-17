# OverheadParrot

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Vector2 velocity;
- - public float age;
- - public float flyOffset;
- - public float height = 64f;
- - public Rectangle sourceRect;
- - public Vector2 drawOffset;
- - public int[] spriteFlapFrames = new int[8] { 0, 0, 0, 0, 1, 2, 2, 1 };
- - public int currentFlapIndex;
- - public int flapFrameAccumulator;
- - public Vector2 swayAmount;
- - public Vector2 lastDrawPosition;
- - public OverheadParrot(Vector2 start_position)
- - public override bool update(GameTime time, GameLocation environment)
- - public Vector2 GetDrawPosition()
- - public Vector2 GetShadowPosition()
- - public override void draw(SpriteBatch b)
- - public override void drawAboveFrontLayer(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected Texture2D _texture;
- - protected bool _shouldDrawShadow;

## Internal Members
- *(None)*

## Other Members
- *(None)*
