# FruitTree

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const string DefaultTextureName = "TileSheets\\fruitTrees";
- - public const float shakeRate = (float)Math.PI / 200f;
- - public const float shakeDecayRate = 0.0030679617f;
- - public const int minWoodDebrisForFallenTree = 12;
- - public const int minWoodDebrisForStump = 5;
- - public const int startingHealth = 10;
- - public const int leafFallRate = 3;
- - public const int DaysUntilMaturity = 28;
- - public const int maxFruitsOnTrees = 3;
- - public const int seedStage = 0;
- - public const int sproutStage = 1;
- - public const int saplingStage = 2;
- - public const int bushStage = 3;
- - public const int treeStage = 4;
- - public Texture2D texture;
- - public readonly NetInt growthStage = new NetInt();
- - public string obsolete_treeType;
- - public readonly NetString treeId = new NetString();
- - public readonly NetInt daysUntilMature = new NetInt(28);
- - public int? obsolete_fruitsOnTree;
- - public readonly NetList<Item, NetRef<Item>> fruit = new NetList<Item, NetRef<Item>>();
- - public readonly NetInt struckByLightningCountdown = new NetInt();
- - public readonly NetFloat health = new NetFloat(10f);
- - public readonly NetBool flipped = new NetBool();
- - public readonly NetBool stump = new NetBool();
- - public readonly NetBool greenHouseTileTree = new NetBool();
- - public readonly NetBool shakeLeft = new NetBool();
- - public readonly NetBool falling = new NetBool();
- - public bool destroy;
- - public float shakeRotation;
- - public float maxShake;
- - public float alpha = 1f;
- - public readonly NetLong lastPlayerToHit = new NetLong();
- - public float shakeTimer;
- - public readonly NetInt growthRate = new NetInt(1);
- - public string textureName { get; private set; }
- - public bool GreenHouseTileTree
- - public FruitTree()
- - public FruitTree(string id, int growthStage = 0)
- - public override void initNetFields()
- - public int GetSpriteRowNumber()
- - public override void loadSprite()
- - public override bool isActionable()
- - public bool IgnoresSeasonsHere()
- - public override Rectangle getBoundingBox()
- - public override Rectangle getRenderBounds()
- - public override bool performUseAction(Vector2 tileLocation)
- - public override bool tickUpdate(GameTime time)
- - public int GetQuality()
- - public virtual void shake(Vector2 tileLocation, bool doEvenIfStillShaking)
- - public override bool isPassable(Character c = null)
- - public static bool IsTooCloseToAnotherTree(Vector2 tileLocation, GameLocation environment, bool fruitTreesOnly = false)
- - public static bool IsGrowthBlocked(Vector2 tileLocation, GameLocation environment)
- - public FruitTreeData GetData()
- - public static bool TryGetData(string id, out FruitTreeData data)
- - public string GetDisplayName()
- - public override void dayUpdate()
- - public static int GrowthStageToDaysUntilMature(int growthStage)
- - public static int DaysUntilMatureToGrowthStage(int daysUntilMature)
- - public bool TryAddFruit()
- - public virtual bool IsWinterTreeHere()
- - public virtual bool IsInSeasonHere()
- - public virtual Season GetCosmeticSeason()
- - public override bool seasonUpdate(bool onLoad)
- - public override bool performToolAction(Tool t, int explosion, Vector2 tileLocation)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)
- - public override void draw(SpriteBatch spriteBatch)

## Private Members
- - private List<Leaf> leaves = new List<Leaf>();
- - private Item TryCreateFruit(FruitTreeFruitData drop)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
