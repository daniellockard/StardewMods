# GreenhouseBuilding

**Summary:** Represents a building on the farm (barn, coop, etc.).

## Public Members
- - public GreenhouseBuilding(Vector2 tileLocation)
- - public GreenhouseBuilding()
- - public override void drawBackground(SpriteBatch b)
- - public Farm GetFarm()
- - public override bool OnUseHumanDoor(Farmer who)
- - public override string isThereAnythingtoPreventConstruction(GameLocation location, Vector2 tile_position)
- - public override bool doesTileHaveProperty(int tile_x, int tile_y, string property_name, string layer_name, ref string property_value)
- - public virtual bool CanDrawEntranceTiles()
- - public virtual void DrawEntranceTiles(SpriteBatch b)
- - public override void drawShadow(SpriteBatch b, int localX = -1, int localY = -1)
- - public enum IndoorsType

## Private Members
- *(None)*

## Protected Members
- - protected Farm _farm;

## Internal Members
- *(None)*

## Other Members
- *(None)*
