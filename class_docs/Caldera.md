# Caldera

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Texture2D mapBaseTilesheet;
- - public NetBool visited = new NetBool();
- - public Caldera()
- - public Caldera(string filename, string locationName)
- - public override bool CanRefillWateringCanOnTile(int tileX, int tileY)
- - public override void DayUpdate(int dayOfMonth)
- - public override void drawWaterTile(SpriteBatch b, int x, int y)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override bool isActionableTile(int xTile, int yTile, Farmer who)
- - public override void drawBackground(SpriteBatch b)
- - public override bool performToolAction(Tool t, int tileX, int tileY)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void resetLocalState()
- - protected override void resetSharedState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
