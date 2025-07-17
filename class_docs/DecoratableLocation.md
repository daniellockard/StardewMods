# DecoratableLocation

**Summary:** Represents a place or area in the game world.

## Public Members
- - public readonly DecorationFacade wallPaper = new DecorationFacade();
- - public readonly NetStringList wallpaperIDs = new NetStringList();
- - public readonly NetStringDictionary<string, NetString> appliedWallpaper = new NetStringDictionary<string, NetString>
- - public readonly Dictionary<string, List<Vector3>> wallpaperTiles = new Dictionary<string, List<Vector3>>();
- - public readonly DecorationFacade floor = new DecorationFacade();
- - public readonly NetStringList floorIDs = new NetStringList();
- - public readonly NetStringDictionary<string, NetString> appliedFloor = new NetStringDictionary<string, NetString>
- - public readonly Dictionary<string, List<Vector3>> floorTiles = new Dictionary<string, List<Vector3>>();
- - public static bool LogTroubleshootingInfo;
- - public DecoratableLocation()
- - public DecoratableLocation(string mapPath, string name)
- - public override void updateLayout()
- - public virtual void ReadWallpaperAndFloorTileData()
- - public virtual TileSheet GetWallAndFloorTilesheet(string id)
- - public virtual KeyValuePair<string, int> GetFloorSource(string pattern_id)
- - public virtual KeyValuePair<string, int> GetWallpaperSource(string pattern_id)
- - public virtual void UpdateFloor(string floorId)
- - public virtual void UpdateWallpaper(string wallpaperId)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void MakeMapModifications(bool force = false)
- - public override bool CanFreePlaceFurniture()
- - public virtual bool isTileOnWall(int x, int y)
- - public int GetWallTopY(int x, int y)
- - public virtual void setFloors()
- - public virtual void setWallpapers()
- - public void SetFloor(string which, string which_room)
- - public void SetWallpaper(string which, string which_room)
- - public void OverrideSpecificWallpaper(string which, string which_room, string wallpaperStyleToOverride)
- - public void OverrideSpecificFlooring(string which, string which_room, string flooringStyleToOverride)
- - public string GetFloorID(int x, int y)
- - public string GetWallpaperID(int x, int y)
- - public bool IsWallAndFloorTilesheet(string tilesheet_id)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public Furniture getRandomFurniture(Random r)
- - public virtual string getFloorRoomIdAt(Point p)
- - public virtual int GetFirstFlooringTile()
- - public virtual int GetFlooringIndex(int base_tile_sheet, int tile_x, int tile_y)
- - public virtual List<Rectangle> getFloors()

## Private Members
- *(None)*

## Protected Members
- - protected Dictionary<string, TileSheet> _wallAndFloorTileSheets = new Dictionary<string, TileSheet>();
- - protected Map _wallAndFloorTileSheetMap;
- - protected override void initNetFields()
- - protected override void resetLocalState()
- - protected bool IsFloorableTile(int x, int y, string layer_name)
- - protected bool IsFloorableOrWallpaperableTile(int x, int y, string layerName)
- - protected bool IsFloorableOrWallpaperableTile(int x, int y, string layerName, out string reasonInvalid)

## Internal Members
- *(None)*

## Other Members
- *(None)*
