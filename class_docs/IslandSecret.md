# IslandSecret

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public List<SuspensionBridge> suspensionBridges = new List<SuspensionBridge>();
- - public IslandSecret()
- - public IslandSecret(string map, string name)
- - public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void DayUpdate(int dayOfMonth)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public override void SetBuriedNutLocations()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void draw(SpriteBatch b)
- - public override bool IsLocationSpecificPlacementRestriction(Vector2 tileLocation)

## Private Members
- - private readonly NetBool addedSlimesToday = new NetBool();
- - private void gorillaReachedShrine(int extra)
- - private void gorillaGrabBanana(int extra)
- - private void gorillaEatBanana(int extra)
- - private void gorillaAfterEat(int extra)
- - private void gorillaSpawnNut(int extra)
- - private void gorillaReturn(int extra)

## Protected Members
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
