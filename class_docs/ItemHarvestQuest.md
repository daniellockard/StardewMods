# ItemHarvestQuest

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public readonly NetString ItemId = new NetString();
- - public readonly NetInt Number = new NetInt();
- - public ItemHarvestQuest()
- - public ItemHarvestQuest(string itemId, int number = 1)
- - public override bool OnItemReceived(Item item, int numberAdded, bool probe = false)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
