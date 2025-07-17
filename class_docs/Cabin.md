# Cabin

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Farmer obsolete_farmhand;
- - public readonly NetFarmerRef farmhandReference = new NetFarmerRef();
- - public readonly NetMutex inventoryMutex = new NetMutex();
- - public override Farmer owner => farmhandReference.Value;
- - public Cabin()
- - public Cabin(string map)
- - public void CreateFarmhand()
- - public void DeleteFarmhand()
- - public bool CanAssignTo(Farmer farmhand)
- - public void AssignFarmhand(Farmer farmhand)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
- - public IInventory getInventory()
- - public void openFarmhandInventory()
- - public bool isInventoryOpen()
- - public override void updateWarps()
- - public List<Item> demolish()
- - public override void DayUpdate(int dayOfMonth)
- - public override Point getPorchStandingSpot()

## Private Members
- - private void grabItemFromPlayerInventory(Item item, Farmer who)
- - private void grabItemFromFarmhandInventory(Item item, Farmer who)

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
