# Pan

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Pan()
- - public Pan(int upgradeLevel)
- - public override bool beginUsing(GameLocation location, int x, int y, Farmer who)
- - public static void playSlosh(Farmer who)
- - public override void tickUpdate(GameTime time, Farmer who)
- - public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public List<Item> getPanItems(GameLocation location, Farmer who)

## Private Members
- - private readonly NetEvent0 finishEvent = new NetEvent0();
- - private void finish()
- - private void doFinish()

## Protected Members
- - protected override Item GetOneNew()
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
