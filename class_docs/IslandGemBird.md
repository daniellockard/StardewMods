# IslandGemBird

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum GemBirdType
- - public Texture2D texture;
- - public NetVector2 position = new NetVector2();
- - public NetFloat height = new NetFloat();
- - public int[] idleAnimation = new int[1];
- - public int[] lookBackAnimation = new int[17]
- - public int[] scratchAnimation = new int[19]
- - public int[] flyAnimation = new int[11]
- - public int[] currentAnimation;
- - public float frameTimer;
- - public int currentFrameIndex;
- - public float idleAnimationTime;
- - public NetFloat alpha = new NetFloat(1f);
- - public NetBool flying = new NetBool();
- - public NetColor color = new NetColor();
- - public NetString itemIndex = new NetString("0");
- - public NetFields NetFields { get; } = new NetFields("IslandGemBird");
- - public IslandGemBird()
- - public IslandGemBird(Vector2 tile_position, GemBirdType bird_type)
- - public static Color GetColor(GemBirdType bird_type)
- - public static string GetItemIndex(GemBirdType bird_type)
- - public static GemBirdType GetBirdTypeForLocation(string location)
- - public void Draw(SpriteBatch b)
- - public void InitNetFields()
- - public bool Update(GameTime time, GameLocation location)

## Private Members
- *(None)*

## Protected Members
- - protected float _destroyTimer;

## Internal Members
- *(None)*

## Other Members
- *(None)*
