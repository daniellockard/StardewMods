# BreakableContainer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const string barrelId = "118";
- - public const string frostBarrelId = "120";
- - public const string darkBarrelId = "122";
- - public const string desertBarrelId = "124";
- - public const string volcanoBarrelId = "174";
- - public const string waterBarrelId = "262";
- - public override string TypeDefinitionId => "(BC)";
- - public BreakableContainer()
- - public BreakableContainer(Vector2 tile, string itemId, int health = 3, int debrisType = 12, string hitSound = "woodWhack", string breakSound = "barrelBreak")
- - public static BreakableContainer GetBarrelForMines(Vector2 tile, MineShaft mine)
- - public static BreakableContainer GetBarrelForVolcanoDungeon(Vector2 tile)
- - public override bool performToolAction(Tool t)
- - public override bool onExplosion(Farmer who)
- - public Color GetChipColor()
- - public void releaseContents(Farmer who)
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)

## Private Members
- - private readonly NetInt debris = new NetInt();
- - private new int shakeTimer;
- - private new readonly NetInt health = new NetInt();
- - private readonly NetString hitSound = new NetString();
- - private readonly NetString breakSound = new NetString();
- - private readonly NetRectangle breakDebrisSource = new NetRectangle();
- - private readonly NetRectangle breakDebrisSource2 = new NetRectangle();

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
