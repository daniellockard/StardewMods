# Quest

**Summary:** Represents a quest or mission.

## Public Members
- - public const int type_basic = 1;
- - public const int type_crafting = 2;
- - public const int type_itemDelivery = 3;
- - public const int type_monster = 4;
- - public const int type_socialize = 5;
- - public const int type_location = 6;
- - public const int type_fishing = 7;
- - public const int type_building = 8;
- - public const int type_harvest = 9;
- - public const int type_resource = 10;
- - public const int type_weeding = 11;
- - public string _currentObjective = "";
- - public string _questDescription = "";
- - public string _questTitle = "";
- - public readonly NetString rewardDescription = new NetString();
- - public readonly NetBool accepted = new NetBool();
- - public readonly NetBool completed = new NetBool();
- - public readonly NetBool dailyQuest = new NetBool();
- - public readonly NetBool showNew = new NetBool();
- - public readonly NetBool canBeCancelled = new NetBool();
- - public readonly NetBool destroy = new NetBool();
- - public readonly NetString id = new NetString();
- - public readonly NetInt moneyReward = new NetInt();
- - public readonly NetInt questType = new NetInt();
- - public readonly NetInt daysLeft = new NetInt();
- - public readonly NetInt dayQuestAccepted = new NetInt(-1);
- - public readonly NetStringList nextQuests = new NetStringList();
- - public string obsolete_completionString;
- - public ModDataDictionary modData { get; } = new ModDataDictionary();
- - public ModDataDictionary modDataForSerialization
- - public NetFields NetFields { get; }
- - public string questTitle
- - public string questDescription
- - public string currentObjective
- - public Quest()
- - public static string[] GetRawQuestFields(string id)
- - public static Quest getQuestFromId(string id)
- - public virtual void reloadObjective()
- - public virtual void reloadDescription()
- - public virtual void accept()
- - public virtual bool OnBuildingExists(string buildingType, bool probe = false)
- - public virtual bool OnFishCaught(string fishId, int numberCaught, int size, bool probe = false)
- - public virtual bool OnItemReceived(Item item, int numberAdded, bool probe = false)
- - public virtual bool OnMonsterSlain(GameLocation location, Monster monster, bool killedByBomb, bool isTameMonster, bool probe = false)
- - public virtual bool OnNpcSocialized(NPC npc, bool probe = false)
- - public virtual bool OnRecipeCrafted(CraftingRecipe recipe, Item item, bool probe = false)
- - public virtual bool OnWarped(GameLocation location, bool probe = false)
- - public virtual bool OnItemOfferedToNpc(NPC npc, Item item, bool probe = false)
- - public bool hasReward()
- - public virtual bool isSecretQuest()
- - public virtual void questComplete()
- - public string GetName()
- - public string GetDescription()
- - public bool IsHidden()
- - public List<string> GetObjectiveDescriptions()
- - public bool CanBeCancelled()
- - public bool HasReward()
- - public bool HasMoneyReward()
- - public void MarkAsViewed()
- - public bool ShouldDisplayAsNew()
- - public bool ShouldDisplayAsComplete()
- - public bool IsTimedQuest()
- - public int GetDaysLeft()
- - public int GetMoneyReward()
- - public void OnMoneyRewardClaimed()
- - public bool OnLeaveQuestPage()
- - public interface IQuest

## Private Members
- - private bool _loadedDescription;

## Protected Members
- - protected bool _loadedTitle;
- - protected virtual void initNetFields()
- - protected bool HasId()
- - protected bool IsValidId(string id)
- - protected Random CreateInitializationRandom()
- - protected static bool TryParseConditions(string[] questFields, out string[] conditions, out string error, bool allowBlank = false)
- - protected static Quest LogParseError(string id, string error)
- - protected static Quest LogConditionsParseError(string id, string error)

## Internal Members
- *(None)*

## Other Members
- *(None)*
