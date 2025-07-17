# FishingQuest

**Summary:** Represents a quest or mission.

## Public Members
- - public readonly NetString target = new NetString();
- - public string targetMessage;
- - public readonly NetInt numberToFish = new NetInt();
- - public readonly NetInt reward = new NetInt();
- - public readonly NetInt numberFished = new NetInt();
- - public readonly NetString ItemId = new NetString();
- - public readonly NetDescriptionElementList parts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementList dialogueparts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementRef objective = new NetDescriptionElementRef();
- - public FishingQuest()
- - public FishingQuest(string itemId, int numberToFish, string target, string questTitle, string questDescription, string returnDialogue)
- - public void loadQuestInfo()
- - public override void reloadDescription()
- - public override void reloadObjective()
- - public override bool OnFishCaught(string fishId, int numberCaught, int size, bool probe = false)
- - public override bool OnNpcSocialized(NPC npc, bool probe = false)

## Private Members
- - private int GetGoldRewardPerItem(Item item)

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
