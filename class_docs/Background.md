# Background

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int defaultChunkIndex;
- - public int numChunksInSheet;
- - public double chanceForDeviationFromDefault;
- - public Color c;
- - public int yOffset;
- - public TemporaryAnimatedSpriteList tempSprites;
- - public bool cursed;
- - public Background(Summit location)
- - public Background(GameLocation location, Color color, bool onlyMapBG)
- - public Background(GameLocation location, Texture2D bgImage, int seedValue, int chunksWide, int chunksHigh, int chunkWidth, int chunkHeight, float zoom, int defaultChunkIndex, int numChunksInSheet, double chanceForDeviation, Color c)
- - public virtual void update(Rectangle viewport)
- - public virtual void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected Texture2D backgroundImage;
- - protected Texture2D cloudsTexture;
- - protected Vector2 position = Vector2.Zero;
- - protected int chunksWide;
- - protected int chunksHigh;
- - protected int chunkWidth;
- - protected int chunkHeight;
- - protected int[] chunks;
- - protected float zoom;
- - protected bool summitBG;
- - protected bool onlyMapBG;
- - protected int initialViewportY;
- - protected GameLocation location;

## Internal Members
- *(None)*

## Other Members
- *(None)*
