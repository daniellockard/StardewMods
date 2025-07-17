# AnimalHouse

**Summary:** Represents a farm animal and its behaviors.

## Public Members
- - public readonly NetInt animalLimit = new NetInt(4);
- - public readonly NetLongList animalsThatLiveHere = new NetLongList();
- - public bool hasShownIncubatorBuildingFullMessage;
- - public AnimalHouse()
- - public AnimalHouse(string mapPath, string name)
- - public override void OnParentBuildingUpgraded(Building building)
- - public bool isFull()
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public void addNewHatchedAnimal(string name)
- - public void adoptAnimal(FarmAnimal animal)
- - public void resetPositionsOfAllAnimals()
- - public override bool dropObject(Object obj, Vector2 location, Rectangle viewport, bool initialPlacement, Farmer who = null)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override void DayUpdate(int dayOfMonth)
- - public void feedAllAnimals()
- - public enum CollisionMask : byte

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void resetSharedState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
