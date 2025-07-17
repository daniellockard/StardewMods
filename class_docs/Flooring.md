# Flooring

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly Vector2 Offset;
- - public readonly byte Direction;
- - public readonly byte InvDirection;
- - public NeighborLoc(Vector2 a, byte b, byte c)
- - public readonly Flooring feature;
- - public readonly byte direction;
- - public readonly byte invDirection;
- - public Neighbor(Flooring a, byte b, byte c)
- - public const byte N = 1;
- - public const byte E = 2;
- - public const byte S = 4;
- - public const byte W = 8;
- - public const byte NE = 16;
- - public const byte NW = 32;
- - public const byte SE = 64;
- - public const byte SW = 128;
- - public const byte Cardinals = 15;
- - public static readonly Vector2 N_Offset = new Vector2(0f, -1f);
- - public static readonly Vector2 E_Offset = new Vector2(1f, 0f);
- - public static readonly Vector2 S_Offset = new Vector2(0f, 1f);
- - public static readonly Vector2 W_Offset = new Vector2(-1f, 0f);
- - public static readonly Vector2 NE_Offset = new Vector2(1f, -1f);
- - public static readonly Vector2 NW_Offset = new Vector2(-1f, -1f);
- - public static readonly Vector2 SE_Offset = new Vector2(1f, 1f);
- - public static readonly Vector2 SW_Offset = new Vector2(-1f, 1f);
- - public const string wood = "0";
- - public const string stone = "1";
- - public const string ghost = "2";
- - public const string iceTile = "3";
- - public const string straw = "4";
- - public const string gravel = "5";
- - public const string boardwalk = "6";
- - public const string colored_cobblestone = "7";
- - public const string cobblestone = "8";
- - public const string steppingStone = "9";
- - public const string brick = "10";
- - public const string plankFlooring = "11";
- - public const string townFlooring = "12";
- - public Texture2D floorTexture;
- - public Texture2D floorTextureWinter;
- - public static Dictionary<byte, int> drawGuide;
- - public static List<int> drawGuideList;
- - public readonly NetString whichFloor = new NetString();
- - public readonly NetInt whichView = new NetInt();
- - public Flooring()
- - public Flooring(string which)
- - public override void initNetFields()
- - public virtual void ApplyFlooringFlags()
- - public static Dictionary<string, string> GetFloorPathItemLookup()
- - public FloorPathData GetData()
- - public static bool TryGetData(string id, out FloorPathData data)
- - public override Rectangle getBoundingBox()
- - public static void populateDrawGuide()
- - public override void loadSprite()
- - public override void doCollisionAction(Rectangle positionOfCollider, int speedOfCollision, Vector2 tileLocation, Character who)
- - public override bool isPassable(Character c = null)
- - public string getFootstepSound()
- - public Point GetTextureCorner(bool useSeasonalVariants = true)
- - public Texture2D GetTexture(bool useSeasonalVariants = true)
- - public bool ShouldDrawWinterVersion()
- - public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)
- - public override void draw(SpriteBatch spriteBatch)
- - public override bool tickUpdate(GameTime time)
- - public void OnAdded(GameLocation loc, Vector2 tilePos)
- - public void OnRemoved()
- - public void OnNeighborAdded(byte direction)
- - public void OnNeighborRemoved(byte direction)

## Private Members
- - private struct NeighborLoc
- - private struct Neighbor
- - private byte neighborMask;
- - private static readonly NeighborLoc[] _offsets = new NeighborLoc[8]
- - private List<Neighbor> _neighbors = new List<Neighbor>();
- - private List<Neighbor> gatherNeighbors()

## Protected Members
- - protected static Dictionary<string, string> _FloorPathItemLookup;
- - protected static void LoadFloorPathItemLookup()

## Internal Members
- *(None)*

## Other Members
- *(None)*
