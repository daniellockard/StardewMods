# Pickaxe

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int hitMargin = 8;
- - public const int BoulderStrength = 4;
- - public NetInt additionalPower = new NetInt(0);
- - public Pickaxe()
- - public override bool beginUsing(GameLocation location, int x, int y, Farmer who)
- - public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)

## Private Members
- - private int boulderTileX;
- - private int boulderTileY;
- - private int hitsToBoulder;

## Protected Members
- - protected override void initNetFields()
- - protected override void MigrateLegacyItemId()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)

## Internal Members
- *(None)*

## Other Members
- *(None)*
