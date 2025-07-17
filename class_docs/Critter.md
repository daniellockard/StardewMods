# Critter

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int spriteWidth = 32;
- - public const int spriteHeight = 32;
- - public const float gravity = 0.25f;
- - public static string critterTexture = "TileSheets\\critters";
- - public Vector2 position;
- - public Vector2 startingPosition;
- - public int baseFrame;
- - public AnimatedSprite sprite;
- - public bool flip;
- - public float gravityAffectedDY;
- - public float yOffset;
- - public float yJumpOffset;
- - public Critter()
- - public Critter(int baseFrame, Vector2 position)
- - public virtual Rectangle getBoundingBox(int xOffset, int yOffset)
- - public virtual bool update(GameTime time, GameLocation environment)
- - public virtual void draw(SpriteBatch b)
- - public virtual void drawAboveFrontLayer(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected virtual string GenerateLightSourceId(int identifier)

## Internal Members
- *(None)*

## Other Members
- *(None)*
