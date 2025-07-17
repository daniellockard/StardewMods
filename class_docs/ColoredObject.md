# ColoredObject

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetColor color = new NetColor();
- - public readonly NetBool colorSameIndexAsParentSheetIndex = new NetBool();
- - public bool ColorSameIndexAsParentSheetIndex
- - public ColoredObject()
- - public ColoredObject(string itemId, int stack, Color color)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color colorOverride, bool drawShadow)
- - public override void drawWhenHeld(SpriteBatch spriteBatch, Vector2 objectPosition, Farmer f)
- - public double GetHue()
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
- - public static bool TrySetColor(Item input, Color color, out ColoredObject coloredItem)

## Private Members
- - private void drawSmokedFish(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float layerDepth, float transparency = 1f)

## Protected Members
- - protected override void initNetFields()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)

## Internal Members
- *(None)*

## Other Members
- *(None)*
