# LostItemQuest

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public readonly NetString npcName = new NetString();
- - public readonly NetString locationOfItem = new NetString();
- - public readonly NetString ItemId = new NetString();
- - public readonly NetInt tileX = new NetInt();
- - public readonly NetInt tileY = new NetInt();
- - public readonly NetBool itemFound = new NetBool();
- - public readonly NetDescriptionElementRef objective = new NetDescriptionElementRef();
- - public LostItemQuest()
- - public LostItemQuest(string npcName, string locationOfItem, string itemId, int tileX, int tileY)
- - public override bool OnWarped(GameLocation location, bool probe = false)
- - public new void reloadObjective()
- - public override bool OnItemReceived(Item item, int numberAdded, bool probe = false)
- - public override bool OnNpcSocialized(NPC npc, bool probe = false)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
