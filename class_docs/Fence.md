# Fence

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int debrisPieces = 4;
- - public static int fencePieceWidth = 16;
- - public static int fencePieceHeight = 32;
- - public const int gateClosedPosition = 0;
- - public const int gateOpenedPosition = 88;
- - public const int sourceRectForSoloGate = 17;
- - public const int globalHealthMultiplier = 2;
- - public const int N = 1000;
- - public const int E = 100;
- - public const int S = 500;
- - public const int W = 10;
- - public const string woodFenceId = "322";
- - public const string stoneFenceId = "323";
- - public const string ironFenceId = "324";
- - public const string hardwoodFenceId = "298";
- - public const string gateId = "325";
- - public Lazy<Texture2D> fenceTexture;
- - public static Dictionary<int, int> fenceDrawGuide;
- - public new readonly NetFloat health = new NetFloat();
- - public readonly NetFloat maxHealth = new NetFloat();
- - public int? obsolete_whichType;
- - public readonly NetInt gatePosition = new NetInt();
- - public int gateMotion;
- - public readonly NetBool isGate = new NetBool();
- - public readonly NetBool repairQueued = new NetBool();
- - public Fence(Vector2 tileLocation, string itemId, bool isGate)
- - public Fence()
- - public virtual void ResetHealth(float amount_adjustment)
- - public virtual void repair()
- - public static void populateFenceDrawGuide()
- - public virtual void PerformRepairIfNecessary()
- - public override void updateWhenCurrentLocation(GameTime time)
- - public static Dictionary<string, FenceData> GetFenceLookup()
- - public FenceData GetData()
- - public static bool TryGetData(string itemId, out FenceData data)
- - public int getDrawSum()
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public virtual void toggleGate(bool open, bool is_toggling_counterpart = false, Farmer who = null)
- - public void toggleGate(Farmer who, bool open, bool is_toggling_counterpart = false)
- - public override void dropItem(GameLocation location, Vector2 origin, Vector2 destination)
- - public override bool performToolAction(Tool t)
- - public virtual bool IsValidRemovalTool(Tool tool)
- - public override bool minutesElapsed(int minutes)
- - public override void actionOnPlayerEntry()
- - public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
- - public virtual float GetRepairHealthAdjustment()
- - public virtual string GetRepairSound()
- - public virtual bool CanRepairWithThisItem(Item item)
- - public override bool performDropDownAction(Farmer who)
- - public virtual Texture2D loadFenceTexture()
- - public override void drawWhenHeld(SpriteBatch spriteBatch, Vector2 objectPosition, Farmer f)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scale, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public bool countsForDrawing(string otherItemId)
- - public override bool isPassable()
- - public override void draw(SpriteBatch b, int x, int y, float alpha = 1f)

## Private Members
- *(None)*

## Protected Members
- - protected static Dictionary<string, FenceData> _FenceLookup;
- - protected FenceData _data;
- - protected override void initNetFields()
- - protected override void MigrateLegacyItemId()
- - protected virtual void OnIdChanged()
- - protected static void _LoadFenceData()

## Internal Members
- *(None)*

## Other Members
- *(None)*
