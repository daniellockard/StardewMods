# Woods

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int numBaubles = 25;
- - public readonly NetBool hasUnlockedStatue = new NetBool();
- - public Woods()
- - public Woods(string map, string name)
- - public static void ResetLostItemsShop()
- - public bool localPlayerHasFoundStardrop()
- - public void statueAnimation(Farmer who)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void DayUpdate(int dayOfMonth)
- - public override void cleanupBeforePlayerExit()
- - public override void MakeMapModifications(bool force = false)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public static IInventory GetLostItemsShopInventory()
- - public static NetMutex GetLostItemShopMutex()

## Private Members
- - private List<Vector2> baubles;
- - private List<WeatherDebris> weatherDebris;
- - private readonly NetBool addedSlimesToday = new NetBool();
- - private readonly NetEvent0 statueAnimationEvent = new NetEvent0();
- - private int statueTimer;
- - private void doStatueAnimation()
- - private void UpdateLostItemsShopTile()
- - private void updateStatueEyes()
- - private void OnLostItemsShopClosed(IClickableMenu shopMenu)

## Protected Members
- - protected Color _ambientLightColor = Color.White;
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected void _updateWoodsLighting()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
