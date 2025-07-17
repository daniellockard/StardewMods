# Grass

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float defaultShakeRate = (float)Math.PI / 80f;
- - public const float maximumShake = (float)Math.PI / 8f;
- - public const float shakeDecayRate = (float)Math.PI / 350f;
- - public const byte springGrass = 1;
- - public const byte caveGrass = 2;
- - public const byte frostGrass = 3;
- - public const byte lavaGrass = 4;
- - public const byte caveGrass2 = 5;
- - public const byte cobweb = 6;
- - public const byte blueGrass = 7;
- - public static ICue grassSound;
- - public readonly NetByte grassType = new NetByte();
- - public readonly NetInt numberOfWeeds = new NetInt();
- - public readonly NetInt grassSourceOffset = new NetInt();
- - public Lazy<Texture2D> texture;
- - public Grass()
- - public Grass(int which, int numberOfWeeds)
- - public override void initNetFields()
- - public static void PlayGrassSound()
- - public virtual string textureName()
- - public override bool isPassable(Character c = null)
- - public override void loadSprite()
- - public override void OnAddedToLocation(GameLocation location, Vector2 tile)
- - public override Rectangle getBoundingBox()
- - public override Rectangle getRenderBounds()
- - public override void doCollisionAction(Rectangle positionOfCollider, int speedOfCollision, Vector2 tileLocation, Character who)
- - public bool reduceBy(int number, bool showDebris)
- - public override void performPlayerEntryAction()
- - public override bool tickUpdate(GameTime time)
- - public override void dayUpdate()
- - public void setUpRandom()
- - public override bool seasonUpdate(bool onLoad)
- - public override bool performToolAction(Tool t, int explosion, Vector2 tileLocation)
- - public bool TryDropItemsOnCut(Tool tool, bool addAnimation = true)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)
- - public override void draw(SpriteBatch spriteBatch)

## Private Members
- - private bool shakeLeft;
- - private int grassBladeHealth = 1;
- - private int[] whichWeed = new int[4];
- - private int[] offset1 = new int[4];
- - private int[] offset2 = new int[4];
- - private int[] offset3 = new int[4];
- - private int[] offset4 = new int[4];
- - private bool[] flip = new bool[4];
- - private double[] shakeRandom = new double[4];
- - private void createDestroySprites(GameLocation location, Vector2 tileLocation)

## Protected Members
- - protected float shakeRotation;
- - protected float maxShake;
- - protected float shakeRate;
- - protected void shake(float shake, float rate, bool left)

## Internal Members
- *(None)*

## Other Members
- *(None)*
