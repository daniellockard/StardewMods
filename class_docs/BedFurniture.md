# BedFurniture

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum BedType
- - public static string DEFAULT_BED_INDEX = "2048";
- - public static string DOUBLE_BED_INDEX = "2052";
- - public static string CHILD_BED_INDEX = "2076";
- - public int bedTileOffset;
- - public static bool ignoreContextualBedSpotOffset = false;
- - public NetMutex mutex = new NetMutex();
- - public BedType bedType
- - public BedFurniture()
- - public BedFurniture(string itemId, Vector2 tile, int initialRotations)
- - public BedFurniture(string itemId, Vector2 tile)
- - public virtual bool IsBeingSleptIn()
- - public override void DayUpdate()
- - public virtual void ReserveForNPC()
- - public override void AttemptRemoval(Action<Furniture> removal_action)
- - public static BedFurniture GetBedAtTile(GameLocation location, int x, int y)
- - public static void ApplyWakeUpPosition(Farmer who)
- - public static void ShiftPositionForBed(Farmer who)
- - public virtual bool CanModifyBed(Farmer who)
- - public override int GetAdditionalFurniturePlacementStatus(GameLocation location, int x, int y, Farmer who = null)
- - public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
- - public override void performRemoveAction()
- - public override void hoverAction()
- - public override bool canBeRemoved(Farmer who)
- - public virtual Point GetBedSpot()
- - public override void actionOnPlayerEntryOrPlacement(GameLocation environment, bool dropDown)
- - public virtual void UpdateBedTile(bool check_bounds)
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
- - public override bool AllowPlacementOnThisTile(int x, int y)
- - public override bool IntersectsForCollision(Rectangle rect)
- - public override int GetAdditionalTilePropertyRadius()
- - public static bool IsBedHere(GameLocation location, int x, int y)
- - public override bool DoesTileHaveProperty(int tile_x, int tile_y, string property_name, string layer_name, ref string property_value)

## Private Members
- *(None)*

## Protected Members
- - protected bool _alreadyAttempingRemoval;
- - protected NetEnum<BedType> _bedType = new NetEnum<BedType>(BedType.Any);
- - protected override void initNetFields()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)

## Internal Members
- *(None)*

## Other Members
- *(None)*
