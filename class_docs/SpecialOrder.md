# SpecialOrder

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Action<Farmer, Item, int> onItemShipped;
- - public Action<Farmer, Monster> onMonsterSlain;
- - public Action<Farmer, Item> onFishCaught;
- - public Action<Farmer, NPC, Item> onGiftGiven;
- - public Func<Farmer, NPC, Item, bool, int> onItemDelivered;
- - public Action<Farmer, Item> onItemCollected;
- - public Action<Farmer, int> onMineFloorReached;
- - public Action<Farmer, int> onJKScoreAchieved;
- - public NetStringDictionary<string, NetString> preSelectedItems = new NetStringDictionary<string, NetString>();
- - public NetStringDictionary<int, NetInt> selectedRandomElements = new NetStringDictionary<int, NetInt>();
- - public NetList<OrderObjective, NetRef<OrderObjective>> objectives = new NetList<OrderObjective, NetRef<OrderObjective>>();
- - public NetInt generationSeed = new NetInt();
- - public NetLongDictionary<bool, NetBool> seenParticipants = new NetLongDictionary<bool, NetBool>();
- - public NetLongDictionary<bool, NetBool> participants = new NetLongDictionary<bool, NetBool>();
- - public NetLongDictionary<bool, NetBool> unclaimedRewards = new NetLongDictionary<bool, NetBool>();
- - public readonly NetCollection<Item> donatedItems = new NetCollection<Item>();
- - public bool appliedSpecialRules;
- - public readonly NetMutex donateMutex = new NetMutex();
- - public NetList<OrderReward, NetRef<OrderReward>> rewards = new NetList<OrderReward, NetRef<OrderReward>>();
- - public NetString questKey = new NetString();
- - public NetString questName = new NetString("Strings\\SpecialOrders:PlaceholderName");
- - public NetString questDescription = new NetString("Strings\\SpecialOrders:PlaceholderDescription");
- - public NetString requester = new NetString();
- - public NetString orderType = new NetString("");
- - public NetString specialRule = new NetString("");
- - public NetBool readyForRemoval = new NetBool(value: false);
- - public NetString itemToRemoveOnEnd = new NetString();
- - public NetString mailToRemoveOnEnd = new NetString();
- - public NetInt dueDate = new NetInt();
- - public NetEnum<QuestDuration> questDuration = new NetEnum<QuestDuration>();
- - public NetEnum<SpecialOrderStatus> questState = new NetEnum<SpecialOrderStatus>(SpecialOrderStatus.InProgress);
- - public NetFields NetFields { get; } = new NetFields("SpecialOrder");
- - public SpecialOrder()
- - public virtual void SetDuration(QuestDuration duration)
- - public virtual void OnFail()
- - public virtual int GetCompleteObjectivesCount()
- - public virtual void ConfirmCompleteDonations()
- - public virtual void UpdateDonationCounts()
- - public bool HighlightAcceptableItems(Item item)
- - public virtual int GetAcceptCount(Item item)
- - public static bool CheckTags(string tag_list)
- - public static bool CheckTag(string tag)
- - public bool IsIslandOrder()
- - public static bool IsSpecialOrdersBoardUnlocked()
- - public static void RemoveAllSpecialOrders(string orderType)
- - public static void UpdateAvailableSpecialOrders(string orderType, bool forceRefresh)
- - public static bool CanStartOrderNow(string orderId, SpecialOrderData order)
- - public static SpecialOrder GetSpecialOrder(string key, int? generation_seed)
- - public static string MakeLocalizationReplacements(string data)
- - public virtual string Parse(string data)
- - public virtual SpecialOrderData GetData()
- - public static bool TryGetData(string id, out SpecialOrderData data)
- - public virtual void InitializeNetFields()
- - public bool UsesDropBox(string box_id)
- - public int GetMinimumDropBoxCapacity(string box_id)
- - public virtual void Update()
- - public virtual void RemoveFromParticipants()
- - public virtual void MarkForRemovalIfEmpty()
- - public virtual void HostHandleQuestEnd()
- - public virtual void AddSpecialRule(string rule)
- - public static void RemoveSpecialRuleAtEndOfDay(string rule)
- - public virtual void RemoveSpecialRule(string rule)
- - public virtual bool HasMoneyReward()
- - public virtual void Fail()
- - public virtual void AddObjective(OrderObjective objective)
- - public void CheckCompletion()
- - public override string ToString()
- - public string GetName()
- - public string GetDescription()
- - public List<string> GetObjectiveDescriptions()
- - public bool CanBeCancelled()
- - public void MarkAsViewed()
- - public bool IsHidden()
- - public bool ShouldDisplayAsNew()
- - public bool HasReward()
- - public int GetMoneyReward()
- - public bool ShouldDisplayAsComplete()
- - public bool IsTimedQuest()
- - public int GetDaysLeft()
- - public void OnMoneyRewardClaimed()
- - public bool OnLeaveQuestPage()
- - public enum SpecialOrderStatus

## Private Members
- *(None)*

## Protected Members
- - protected bool _objectiveRegistrationDirty;
- - protected int _isIslandOrder = -1;
- - protected int _moneyReward = -1;
- - protected string _localizedName;
- - protected string _localizedDescription;
- - protected List<OrderObjective> _registeredObjectives = new List<OrderObjective>();
- - protected Dictionary<Item, bool> _highlightLookup;
- - protected SpecialOrderData _orderData;
- - protected virtual void _UpdateObjectiveRegistration()
- - protected void _AddSpecialRulesIfNecessary()
- - protected void _RemoveSpecialRuleIfNecessary()

## Internal Members
- *(None)*

## Other Members
- *(None)*
