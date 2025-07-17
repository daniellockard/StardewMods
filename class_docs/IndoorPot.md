# IndoorPot

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetRef<HoeDirt> hoeDirt = new NetRef<HoeDirt>();
- - public readonly NetRef<Bush> bush = new NetRef<Bush>();
- - public readonly NetBool bushLoadDirty = new NetBool(value: true);
- - public override string TypeDefinitionId => "(BC)";
- - public override GameLocation Location
- - public override Vector2 TileLocation
- - public IndoorPot()
- - public IndoorPot(Vector2 tileLocation)
- - public override void DayUpdate()
- - public void Water()
- - public bool IsPlantableItem(Item item)
- - public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
- - public override bool performToolAction(Tool t)
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public override void actionOnPlayerEntry()
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
