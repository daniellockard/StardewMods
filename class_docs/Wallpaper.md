# Wallpaper

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetRectangle sourceRect = new NetRectangle();
- - public readonly NetBool isFloor = new NetBool(value: false);
- - public readonly NetString setId = new NetString(null);
- - public override string TypeDefinitionId
- - public override string Name => base.name;
- - public Wallpaper()
- - public Wallpaper(int which, bool isFloor = false)
- - public Wallpaper(string setId, int which)
- - public virtual ModWallpaperOrFlooring GetSetData()
- - public override string getDescription()
- - public override bool performDropDownAction(Farmer who)
- - public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
- - public override bool canBePlacedHere(GameLocation l, Vector2 tile, CollisionMask collisionMask = CollisionMask.All, bool showError = false)
- - public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
- - public override bool isPlaceable()
- - public override int salePrice(bool ignoreProfitMargins = false)
- - public override int maximumStackSize()
- - public override void drawWhenHeld(SpriteBatch spriteBatch, Vector2 objectPosition, Farmer f)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)

## Private Members
- - private static readonly Rectangle wallpaperContainerRect = new Rectangle(39, 31, 16, 16);
- - private static readonly Rectangle floorContainerRect = new Rectangle(55, 31, 16, 16);

## Protected Members
- - protected ModWallpaperOrFlooring setData;
- - protected override void initNetFields()
- - protected override string loadDisplayName()
- - protected override Item GetOneNew()

## Internal Members
- *(None)*

## Other Members
- *(None)*
