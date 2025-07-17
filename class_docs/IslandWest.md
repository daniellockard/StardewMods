# IslandWest

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetRef<SandDuggy> sandDuggy = new NetRef<SandDuggy>();
- - public readonly NetBool farmhouseRestored = new NetBool
- - public readonly NetBool farmhouseMailbox = new NetBool
- - public readonly NetBool farmObelisk = new NetBool
- - public Point shippingBinPosition = new Point(90, 39);
- - public override void SetBuriedNutLocations()
- - public override bool CanPlantSeedsHere(string itemId, int tileX, int tileY, bool isGardenPot, out string deniedMessage)
- - public override bool CanPlantTreesHere(string itemId, int tileX, int tileY, out string deniedMessage)
- - public IslandWest()
- - public override bool performToolAction(Tool t, int tileX, int tileY)
- - public override List<Vector2> GetAdditionalWalnutBushes()
- - public override void draw(SpriteBatch b)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public IslandWest(string map, string name)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public override bool leftClick(int x, int y, Farmer who)
- - public void showShipment(Item item, bool playThrowSound = true)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public static bool IsQiWalnutRoomDoorUnlocked(out int actualFoundWalnutsCount)
- - public override bool isActionableTile(int xTile, int yTile, Farmer who)
- - public void ApplyFarmObeliskBuild()
- - public void ApplyFarmHouseRestore()
- - public override void monsterDrop(Monster monster, int x, int y, Farmer who)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override void spawnObjects()
- - public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
- - public override void DayUpdate(int dayOfMonth)
- - public override double GetDirtDecayChance(Vector2 tile)
- - public override void MakeMapModifications(bool force = false)

## Private Members
- - private readonly NetBool addedSlimesToday = new NetBool();
- - private TemporaryAnimatedSprite shippingBinLid;
- - private Rectangle shippingBinLidOpenArea;
- - private void openShippingBinLid()
- - private void closeShippingBinLid()
- - private void updateShippingBinLid(GameTime time)
- - private bool isShippingBinLidOpen(bool requiredToBeFullyOpen = false)

## Protected Members
- - protected override void initNetFields()
- - protected override bool breakStone(string stoneId, int x, int y, Farmer who, Random r)
- - protected override void resetLocalState()
- - protected override void resetSharedState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
