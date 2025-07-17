# SocializeQuest

**Summary:** Represents a quest or mission.

## Public Members
- - public readonly NetStringList whoToGreet = new NetStringList();
- - public readonly NetInt total = new NetInt();
- - public readonly NetDescriptionElementList parts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementRef objective = new NetDescriptionElementRef();
- - public SocializeQuest()
- - public void loadQuestInfo()
- - public override void reloadDescription()
- - public override void reloadObjective()
- - public override bool OnNpcSocialized(NPC npc, bool probe = false)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
