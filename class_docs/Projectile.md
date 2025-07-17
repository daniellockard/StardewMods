# Projectile

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int travelTimeBeforeCollisionPossible = 100;
- - public const int goblinsCurseIndex = 0;
- - public const int flameBallIndex = 1;
- - public const int fearBolt = 2;
- - public const int shadowBall = 3;
- - public const int bone = 4;
- - public const int throwingKnife = 5;
- - public const int snowBall = 6;
- - public const int shamanBolt = 7;
- - public const int frostBall = 8;
- - public const int frozenBolt = 9;
- - public const int fireball = 10;
- - public const int slash = 11;
- - public const int arrowBolt = 12;
- - public const int launchedSlime = 13;
- - public const int magicArrow = 14;
- - public const int iceOrb = 15;
- - public const string projectileSheetName = "TileSheets\\Projectiles";
- - public const int timePerTailUpdate = 50;
- - public readonly NetInt boundingBoxWidth = new NetInt(21);
- - public static Texture2D projectileSheet;
- - public readonly NetInt currentTileSheetIndex = new NetInt();
- - public readonly NetString itemId = new NetString();
- - public readonly NetPosition position = new NetPosition();
- - public readonly NetInt tailLength = new NetInt();
- - public int tailCounter = 50;
- - public readonly NetString bounceSound = new NetString();
- - public readonly NetInt bouncesLeft = new NetInt();
- - public readonly NetInt piercesLeft = new NetInt(1);
- - public int travelTime;
- - public float hostTimeUntilAttackable = -1f;
- - public readonly NetFloat startingRotation = new NetFloat();
- - public readonly NetFloat rotationVelocity = new NetFloat();
- - public readonly NetFloat alpha = new NetFloat(1f);
- - public readonly NetFloat alphaChange = new NetFloat(0f);
- - public readonly NetFloat xVelocity = new NetFloat();
- - public readonly NetFloat yVelocity = new NetFloat();
- - public readonly NetVector2 acceleration = new NetVector2();
- - public readonly NetFloat maxVelocity = new NetFloat(-1f);
- - public readonly NetColor color = new NetColor(Color.White);
- - public Queue<Vector2> tail = new Queue<Vector2>();
- - public readonly NetInt maxTravelDistance = new NetInt(-1);
- - public float travelDistance;
- - public readonly NetInt projectileID = new NetInt(-1);
- - public readonly NetInt uniqueID = new NetInt(-1);
- - public NetFloat height = new NetFloat(0f);
- - public readonly NetBool damagesMonsters = new NetBool();
- - public readonly NetCharacterRef theOneWhoFiredMe = new NetCharacterRef();
- - public readonly NetBool ignoreTravelGracePeriod = new NetBool(value: false);
- - public readonly NetBool ignoreLocationCollision = new NetBool();
- - public readonly NetBool ignoreObjectCollisions = new NetBool();
- - public readonly NetBool ignoreMeleeAttacks = new NetBool(value: false);
- - public readonly NetBool ignoreCharacterCollisions = new NetBool(value: false);
- - public bool destroyMe;
- - public readonly NetFloat startingScale = new NetFloat(1f);
- - public readonly NetFloat scaleGrow = new NetFloat(0f);
- - public NetBool light = new NetBool();
- - public bool hasLit;
- - public string lightSourceId;
- - public bool IgnoreLocationCollision
- - public ModDataDictionary modData { get; } = new ModDataDictionary();
- - public ModDataDictionary modDataForSerialization
- - public NetFields NetFields { get; } = new NetFields("Projectile");
- - public virtual float localScale
- - public Projectile()
- - public abstract void behaviorOnCollisionWithPlayer(GameLocation location, Farmer player);
- - public abstract void behaviorOnCollisionWithTerrainFeature(TerrainFeature t, Vector2 tileLocation, GameLocation location);
- - public abstract void behaviorOnCollisionWithOther(GameLocation location);
- - public abstract void behaviorOnCollisionWithMonster(NPC n, GameLocation location);
- - public virtual bool update(GameTime time, GameLocation location)
- - public virtual bool isColliding(GameLocation location, out Character target, out TerrainFeature terrainFeature)
- - public abstract void updatePosition(GameTime time);
- - public virtual Rectangle getBoundingBox()
- - public virtual void draw(SpriteBatch b)
- - public Texture2D GetTexture()
- - public Rectangle GetSourceRect()

## Private Members
- - private void behaviorOnCollision(GameLocation location, Character target, TerrainFeature terrainFeature)

## Protected Members
- - protected float startingAlpha = 1f;
- - protected float? _rotation;
- - protected float? _localScale;
- - protected float rotation
- - protected virtual void InitNetFields()
- - protected virtual bool ShouldApplyCollisionLocally(GameLocation location)
- - protected virtual void updateTail(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
