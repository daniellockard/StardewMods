# SecretLostItemQuest

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public readonly NetString npcName = new NetString();
- - public readonly NetInt friendshipReward = new NetInt();
- - public readonly NetString exclusiveQuestId = new NetString();
- - public readonly NetString ItemId = new NetString();
- - public readonly NetBool itemFound = new NetBool();
- - public SecretLostItemQuest()
- - public SecretLostItemQuest(string npcName, string itemId, int friendshipReward, string exclusiveQuestId)
- - public override bool isSecretQuest()
- - public override bool OnItemReceived(Item item, int numberAdded, bool probe = false)
- - public override bool OnNpcSocialized(NPC npc, bool probe = false)
- - public override void questComplete()

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
