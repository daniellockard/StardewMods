# ResourceClump

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int greenRainBush1Index = 44;
- - public const int greenRainBush2Index = 46;
- - public const int stumpIndex = 600;
- - public const int hollowLogIndex = 602;
- - public const int meteoriteIndex = 622;
- - public const int boulderIndex = 672;
- - public const int mineRock1Index = 752;
- - public const int mineRock2Index = 754;
- - public const int mineRock3Index = 756;
- - public const int mineRock4Index = 758;
- - public const int quarryBoulderIndex = 148;
- - public readonly NetInt width = new NetInt();
- - public readonly NetInt height = new NetInt();
- - public readonly NetInt parentSheetIndex = new NetInt();
- - public readonly NetString textureName = new NetString();
- - public readonly NetFloat health = new NetFloat();
- - public readonly NetVector2 netTile = new NetVector2();
- - public float shakeTimer;
- - public override Vector2 Tile
- - public ResourceClump()
- - public ResourceClump(int parentSheetIndex, int width, int height, Vector2 tile, int? health = null, string textureName = null)
- - public override void initNetFields()
- - public override bool isPassable(Character c = null)
- - public bool IsGreenRainBush()
- - public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
- - public bool destroy(Tool t, GameLocation location, Vector2 tileLocation)
- - public override Rectangle getBoundingBox()
- - public bool occupiesTile(int x, int y)
- - public override void draw(SpriteBatch spriteBatch)
- - public override void loadSprite()
- - public override bool performUseAction(Vector2 tileLocation)
- - public override bool tickUpdate(GameTime time)

## Private Members
- - private Texture2D texture;
- - private int lastToolHitTicker;

## Protected Members
- - protected virtual int GetDefaultHealth(int parentSheetIndex)

## Internal Members
- *(None)*

## Other Members
- *(None)*
