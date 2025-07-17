# Tree

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float chanceForDailySeed = 0.05f;
- - public const float shakeRate = (float)Math.PI / 200f;
- - public const float shakeDecayRate = 0.0030679617f;
- - public const int minWoodDebrisForFallenTree = 12;
- - public const int minWoodDebrisForStump = 5;
- - public const int startingHealth = 10;
- - public const int leafFallRate = 3;
- - public const int stageForMossGrowth = 14;
- - public const string bushyTree = "1";
- - public const string leafyTree = "2";
- - public const string pineTree = "3";
- - public const string winterTree1 = "4";
- - public const string winterTree2 = "5";
- - public const string palmTree = "6";
- - public const string mushroomTree = "7";
- - public const string mahoganyTree = "8";
- - public const string palmTree2 = "9";
- - public const string greenRainTreeBushy = "10";
- - public const string greenRainTreeLeafy = "11";
- - public const string greenRainTreeFern = "12";
- - public const string mysticTree = "13";
- - public const int seedStage = 0;
- - public const int sproutStage = 1;
- - public const int saplingStage = 2;
- - public const int bushStage = 3;
- - public const int treeStage = 5;
- - public Lazy<Texture2D> texture;
- - public readonly NetInt growthStage = new NetInt();
- - public readonly NetString treeType = new NetString();
- - public readonly NetFloat health = new NetFloat();
- - public readonly NetBool flipped = new NetBool();
- - public readonly NetBool stump = new NetBool();
- - public readonly NetBool tapped = new NetBool();
- - public readonly NetBool hasSeed = new NetBool();
- - public readonly NetBool hasMoss = new NetBool();
- - public readonly NetBool isTemporaryGreenRainTree = new NetBool();
- - public readonly NetBool wasShakenToday = new NetBool();
- - public readonly NetBool fertilized = new NetBool();
- - public readonly NetBool shakeLeft = new NetBool().Interpolated(interpolate: false, wait: false);
- - public readonly NetBool falling = new NetBool();
- - public readonly NetBool destroy = new NetBool();
- - public float shakeRotation;
- - public float maxShake;
- - public float alpha = 1f;
- - public readonly NetLong lastPlayerToHit = new NetLong();
- - public float shakeTimer;
- - public readonly NetBool stopGrowingMoss = new NetBool();
- - public static Rectangle treeTopSourceRect = new Rectangle(0, 0, 48, 96);
- - public static Rectangle stumpSourceRect = new Rectangle(32, 96, 16, 32);
- - public static Rectangle shadowSourceRect = new Rectangle(663, 1011, 41, 30);
- - public string TextureName { get; private set; }
- - public Tree()
- - public Tree(string id, int growthStage, bool isGreenRainTemporaryTree = false)
- - public Tree(string id)
- - public override void initNetFields()
- - public static Dictionary<string, WildTreeData> GetWildTreeDataDictionary()
- - public static Dictionary<string, List<string>> GetWildTreeSeedLookup()
- - public static string ResolveTreeTypeFromSeed(string itemId)
- - public void CheckForNewTexture()
- - public void resetTexture()
- - public WildTreeData GetData()
- - public static bool TryGetData(string id, out WildTreeData data)
- - public override Rectangle getBoundingBox()
- - public override Rectangle getRenderBounds()
- - public override bool performUseAction(Vector2 tileLocation)
- - public override bool tickUpdate(GameTime time)
- - public Item TryGetDrop(WildTreeItemData drop, Random r, Farmer targetFarmer, string fieldName, Func<string, string> formatItemId = null, bool? isStump = null)
- - public void shake(Vector2 tileLocation, bool doEvenIfStillShaking)
- - public override bool isPassable(Character c = null)
- - public virtual int GetMaxSizeHere(bool ignoreSeason = false)
- - public bool IsInSeason()
- - public bool IsGrowthBlockedByNearbyTree()
- - public void onGreenRainDay(bool undo = false)
- - public override void dayUpdate()
- - public override void performPlayerEntryAction()
- - public override bool seasonUpdate(bool onLoad)
- - public override bool isActionable()
- - public virtual bool IsLeafy()
- - public Color? GetChopDebrisColor()
- - public Color? GetChopDebrisColor(WildTreeData data)
- - public override bool performToolAction(Tool t, int explosion, Vector2 tileLocation)
- - public static Item CreateMossItem()
- - public bool fertilize()
- - public bool instantDestroy(Vector2 tileLocation)
- - public void UpdateTapperProduct(Object tapper, Object previousOutput = null, bool onlyPerformRemovals = false)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)
- - public override void draw(SpriteBatch spriteBatch)

## Private Members
- - private List<Leaf> leaves = new List<Leaf>();
- - private int extraWoodCalculator(Vector2 tileLocation)

## Protected Members
- - protected static Dictionary<string, WildTreeData> _WildTreeData;
- - protected static Dictionary<string, List<string>> _WildTreeSeedLookup;
- - protected Season? localSeason;
- - protected static void _LoadWildTreeData()
- - protected string ChooseTexture()
- - protected void performSeedDestroy(Tool t, Vector2 tileLocation)
- - protected bool TryGetTapperOutput(List<WildTreeTapItemData> tapItems, string previousItemId, Random r, float timeMultiplier, out Object output, out int minutesUntilReady)
- - protected void performSproutDestroy(Tool t, Vector2 tileLocation)
- - protected void performBushDestroy(Vector2 tileLocation)
- - protected bool performTreeFall(Tool t, int explosion, Vector2 tileLocation)
- - protected void setSeason()

## Internal Members
- - internal static void ClearCache()

## Other Members
- *(None)*
