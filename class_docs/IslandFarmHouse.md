# IslandFarmHouse

**Summary:** Represents the player's farm, its state, and related locations.

## Public Members
- - public readonly NetRef<Chest> fridge = new NetRef<Chest>(new Chest(playerChest: true));
- - public Point fridgePosition;
- - public NetBool visited = new NetBool(value: false)
- - public IslandFarmHouse()
- - public IslandFarmHouse(string map, string name)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override List<Rectangle> getWalls()
- - public Point? GetFridgePositionFromMap()
- - public override List<Rectangle> getFloors()
- - public virtual void InitializeBeds()
- - public override void drawAboveFrontLayer(SpriteBatch b)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)

## Private Members
- - private Color nightLightingColor = new Color(180, 180, 0);
- - private Color rainLightingColor = new Color(90, 90, 0);

## Protected Members
- - protected override void resetLocalState()
- - protected override void initNetFields()
- - protected override void _updateAmbientLighting()

## Internal Members
- *(None)*

## Other Members
- *(None)*
