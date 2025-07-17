# RandomizedPlantFurniture

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetInt topIndex = new NetInt();
- - public NetInt middleIndex = new NetInt();
- - public NetInt bottomIndex = new NetInt();
- - public RandomizedPlantFurniture(string which, Vector2 tile)
- - public RandomizedPlantFurniture(string which, Vector2 tile, int random_seed)
- - public RandomizedPlantFurniture()
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public override bool IsHeldOverHead()
- - public override void drawWhenHeld(SpriteBatch spriteBatch, Vector2 objectPosition, Farmer f)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
- - public override void drawAtNonTileSpot(SpriteBatch spriteBatch, Vector2 location, float layerDepth, float alpha = 1f)
- - public virtual void DrawFurniture(SpriteBatch sb, Vector2 location, float alpha, Vector2 origin, float scale, float base_sort_y)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)
- - protected override float getScaleSize()

## Internal Members
- *(None)*

## Other Members
- *(None)*
