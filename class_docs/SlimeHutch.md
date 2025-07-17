# SlimeHutch

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetInt slimeMatingsLeft = new NetInt();
- - public readonly NetArray<bool, NetBool> waterSpots = new NetArray<bool, NetBool>(4);
- - public SlimeHutch()
- - public SlimeHutch(string m, string name)
- - public override void OnParentBuildingUpgraded(Building building)
- - public bool isFull()
- - public override bool canSlimeMateHere()
- - public override bool canSlimeHatchHere()
- - public override void DayUpdate(int dayOfMonth)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override bool performToolAction(Tool t, int tileX, int tileY)
- - public override void UpdateWhenCurrentLocation(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected int _slimeCapacity = -1;
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
