# WateringCan

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool isBottomless = new NetBool();
- - public int waterCanMax = 40;
- - public int WaterLeft
- - public bool IsBottomless
- - public WateringCan()
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public override string getDescription()
- - public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
- - public override bool CanUseOnStandingTile()
- - public override void tickUpdate(GameTime time, Farmer who)

## Private Members
- - private readonly NetInt waterLeft = new NetInt(40);

## Protected Members
- - protected bool _emptyCanPlayed;
- - protected override void initNetFields()
- - protected override void MigrateLegacyItemId()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)
- - protected virtual void OnUpgradeLevelChanged()

## Internal Members
- *(None)*

## Other Members
- *(None)*
