# Debris

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum DebrisType
- - public const int copperDebris = 0;
- - public const int ironDebris = 2;
- - public const int coalDebris = 4;
- - public const int goldDebris = 6;
- - public const int coinsDebris = 8;
- - public const int iridiumDebris = 10;
- - public const int woodDebris = 12;
- - public const int stoneDebris = 14;
- - public const int bigStoneDebris = 32;
- - public const int bigWoodDebris = 34;
- - public const int timesToBounce = 2;
- - public const float gravity = 0.4f;
- - public const float timeToWaitBeforeRemoval = 600f;
- - public const int marginForChunkPickup = 64;
- - public const int white = 10000;
- - public const int green = 100001;
- - public const int blue = 100002;
- - public const int red = 100003;
- - public const int yellow = 100004;
- - public const int black = 100005;
- - public const int charcoal = 100007;
- - public const int gray = 100006;
- - public readonly NetInt chunkType = new NetInt();
- - public readonly NetInt sizeOfSourceRectSquares = new NetInt(8);
- - public float timeSinceDoneBouncing;
- - public readonly NetFloat scale = new NetFloat(1f).Interpolated(interpolate: true, wait: true);
- - public readonly NetLong DroppedByPlayerID = new NetLong().Interpolated(interpolate: false, wait: false);
- - public readonly NetBool floppingFish = new NetBool();
- - public bool isFishable;
- - public bool movingFinalYLevel;
- - public readonly NetEnum<DebrisType> debrisType = new NetEnum<DebrisType>(DebrisType.CHUNKS);
- - public readonly NetBool isSinking = new NetBool(value: false);
- - public readonly NetString debrisMessage = new NetString("");
- - public readonly NetColor nonSpriteChunkColor = new NetColor(Color.White);
- - public readonly NetColor chunksColor = new NetColor();
- - public readonly NetString spriteChunkSheetName = new NetString();
- - public readonly NetString itemId = new NetString();
- - public Character toHover;
- - public readonly NetFarmerRef player = new NetFarmerRef();
- - public int itemQuality
- - public int chunkFinalYLevel
- - public int chunkFinalYTarget
- - public bool chunksMoveTowardPlayer
- - public Texture2D spriteChunkSheet
- - public Item item
- - public NetFields NetFields { get; } = new NetFields("Debris");
- - public NetObjectShrinkList<Chunk> Chunks => chunks;
- - public Debris()
- - public virtual void InitNetFields()
- - public Debris(int debris_type, Vector2 debrisOrigin, Vector2 playerPosition)
- - public Debris(int resource_type, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, float velocityMultiplyer = 1f)
- - public Debris(int debrisType, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, int groundLevel, Color? color = null)
- - public Debris(string item_id, Vector2 debrisOrigin, Vector2 playerPosition)
- - public Debris(string item_id, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, float velocityMultiplyer = 1f)
- - public virtual void InitializeItem(string item_id)
- - public virtual void InitializeResource(int item_id)
- - public Debris(Item item, Vector2 debrisOrigin)
- - public Debris(Item item, Vector2 debrisOrigin, Vector2 targetLocation)
- - public Debris(int number, Vector2 debrisOrigin, Color messageColor, float scale, Character toHover)
- - public Debris(string message, int numberOfChunks, Vector2 debrisOrigin, Color messageColor, float scale, float rotation)
- - public Debris(string spriteSheet, int numberOfChunks, Vector2 debrisOrigin)
- - public Debris(string spriteSheet, Rectangle sourceRect, int numberOfChunks, Vector2 debrisOrigin)
- - public Debris(string spriteSheet, Rectangle sourceRect, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, int groundLevel, int sizeOfSourceRectSquares)
- - public Debris(string spriteSheet, Rectangle sourceRect, int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, int groundLevel)
- - public virtual bool isEssentialItem()
- - public virtual bool collect(Farmer farmer, Chunk chunk = null)
- - public static Color getColorForDebris(int type)
- - public void InitializeChunks(int numberOfChunks, Vector2 debrisOrigin, Vector2 playerPosition, float velocityMultiplyer = 1f)
- - public bool shouldControlThis(GameLocation location)
- - public bool updateChunks(GameTime time, GameLocation location)
- - public void updateHoverPosition(Chunk chunk)
- - public static string getNameOfDebrisTypeFromIntId(int id)

## Private Members
- - private float relativeXPosition;
- - private readonly NetObjectShrinkList<Chunk> chunks = new NetObjectShrinkList<Chunk>();
- - private readonly NetInt netItemQuality = new NetInt();
- - private readonly NetInt netChunkFinalYLevel = new NetInt();
- - private readonly NetInt netChunkFinalYTarget = new NetInt();
- - private bool movingUp;
- - private float animationTimer;
- - private int timeBeforeReturnToDroppingPlayer = 1200;
- - private Texture2D _spriteChunkSheet;
- - private readonly NetRef<Item> netItem = new NetRef<Item>();
- - private Vector2 approximatePosition()
- - private bool playerInRange(Vector2 position, Farmer farmer)
- - private Farmer findBestPlayer(GameLocation location)

## Protected Members
- - protected NetBool _chunksMoveTowardsPlayer = new NetBool(value: false).Interpolated(interpolate: false, wait: false);

## Internal Members
- *(None)*

## Other Members
- *(None)*
