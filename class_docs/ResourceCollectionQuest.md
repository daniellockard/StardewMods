# ResourceCollectionQuest

**Summary:** Represents a quest or mission.

## Public Members
- - public readonly NetString target = new NetString();
- - public readonly NetString targetMessage = new NetString();
- - public readonly NetInt numberCollected = new NetInt();
- - public readonly NetInt number = new NetInt();
- - public readonly NetInt reward = new NetInt();
- - public readonly NetString ItemId = new NetString();
- - public readonly NetDescriptionElementList parts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementList dialogueparts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementRef objective = new NetDescriptionElementRef();
- - public ResourceCollectionQuest()
- - public void loadQuestInfo()
- - public override void reloadDescription()
- - public override void reloadObjective()
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
