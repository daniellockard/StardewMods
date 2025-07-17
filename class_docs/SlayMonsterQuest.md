# SlayMonsterQuest

**Summary:** Represents a quest or mission.

## Public Members
- - public string targetMessage;
- - public readonly NetString monsterName = new NetString();
- - public readonly NetString target = new NetString();
- - public readonly NetRef<Monster> monster = new NetRef<Monster>();
- - public readonly NetInt numberToKill = new NetInt();
- - public readonly NetInt reward = new NetInt();
- - public readonly NetInt numberKilled = new NetInt();
- - public readonly NetDescriptionElementList parts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementList dialogueparts = new NetDescriptionElementList();
- - public readonly NetDescriptionElementRef objective = new NetDescriptionElementRef();
- - public readonly NetBool ignoreFarmMonsters = new NetBool(value: true);
- - public SlayMonsterQuest()
- - public void loadQuestInfo()
- - public override void reloadDescription()
- - public override void reloadObjective()
- - public override bool OnMonsterSlain(GameLocation location, Monster monster, bool killedByBomb, bool isTameMonster, bool probe = false)
- - public override bool OnNpcSocialized(NPC npc, bool probe = false)

## Private Members
- - private bool isSlimeName(string s)

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
