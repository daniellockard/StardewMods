# ItemDeliveryQuest

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public string targetMessage;
- - public readonly NetString target = new NetString();
- - public readonly NetString ItemId = new NetString();
- - public readonly NetInt number = new NetInt(1);
- - public readonly NetDescriptionElementList parts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementList dialogueparts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementRef objective = new NetDescriptionElementRef();
- - public ItemDeliveryQuest()
- - public ItemDeliveryQuest(string target, string itemId)
- - public ItemDeliveryQuest(string target, string itemId, string questTitle, string questDescription, string objective, string returnDialogue)
- - public List<NPC> GetValidTargetList()
- - public void loadQuestInfo()
- - public override void reloadDescription()
- - public override void reloadObjective()
- - public override bool OnItemOfferedToNpc(NPC npc, Item item, bool probe = false)
- - public int GetGoldRewardPerItem(Item item)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
