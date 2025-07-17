# WoodChipper

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int CHIP_TIME = 1000;
- - public readonly NetRef<Object> depositedItem = new NetRef<Object>();
- - public int nextSmokeTime;
- - public int nextShakeTime;
- - public override string TypeDefinitionId => "(BC)";
- - public void OnDepositedItemChange(NetRef<Object> field, Object old_value, Object new_value)
- - public WoodChipper()
- - public WoodChipper(Vector2 position)
- - public override void addWorkingAnimation()
- - public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
- - public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)

## Private Members
- *(None)*

## Protected Members
- - protected bool _isAnimatingChip;
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
