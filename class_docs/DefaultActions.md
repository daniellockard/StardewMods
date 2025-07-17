# DefaultActions

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static bool Null(string[] args, TriggerActionContext context, out string error)
- - public static bool If(string[] args, TriggerActionContext context, out string error)
- - public static bool AddBuff(string[] args, TriggerActionContext context, out string error)
- - public static bool RemoveBuff(string[] args, TriggerActionContext context, out string error)
- - public static bool AddMail(string[] args, TriggerActionContext context, out string error)
- - public static bool RemoveMail(string[] args, TriggerActionContext context, out string error)
- - public static bool AddQuest(string[] args, TriggerActionContext context, out string error)
- - public static bool RemoveQuest(string[] args, TriggerActionContext context, out string error)
- - public static bool AddSpecialOrder(string[] args, TriggerActionContext context, out string error)
- - public static bool RemoveSpecialOrder(string[] args, TriggerActionContext context, out string error)
- - public static bool AddItem(string[] args, TriggerActionContext context, out string error)
- - public static bool RemoveItem(string[] args, TriggerActionContext context, out string error)
- - public static bool AddMoney(string[] args, TriggerActionContext context, out string error)
- - public static bool AddFriendshipPoints(string[] args, TriggerActionContext context, out string error)
- - public static bool AddConversationTopic(string[] args, TriggerActionContext context, out string error)
- - public static bool RemoveConversationTopic(string[] args, TriggerActionContext context, out string error)
- - public static bool IncrementStat(string[] args, TriggerActionContext context, out string error)
- - public static bool MarkActionApplied(string[] args, TriggerActionContext context, out string error)
- - public static bool MarkCookingRecipeKnown(string[] args, TriggerActionContext context, out string error)
- - public static bool MarkCraftingRecipeKnown(string[] args, TriggerActionContext context, out string error)
- - public static bool MarkEventSeen(string[] args, TriggerActionContext context, out string error)
- - public static bool MarkQuestionAnswered(string[] args, TriggerActionContext context, out string error)
- - public static bool MarkSongHeard(string[] args, TriggerActionContext context, out string error)
- - public static bool RemoveTemporaryAnimatedSprites(string[] args, TriggerActionContext context, out string error)
- - public static bool SetNpcInvisible(string[] args, TriggerActionContext context, out string error)
- - public static bool SetNpcVisible(string[] args, TriggerActionContext context, out string error)
- - public const string trigger_dayEnding = "DayEnding";
- - public const string trigger_dayStarted = "DayStarted";
- - public const string trigger_locationChanged = "LocationChanged";
- - public const string trigger_manual = "Manual";
- - public static void RegisterTrigger(string name)
- - public static void RegisterAction(string name, TriggerActionDelegate action)
- - public static void Raise(string trigger, object[] triggerArgs = null, GameLocation location = null, Farmer player = null, Item targetItem = null, Item inputItem = null)
- - public static CachedAction ParseAction(string action)
- - public static bool TryValidateActionExists(string action, out string error)
- - public static bool TryRunAction(string action, out string error, out Exception exception)
- - public static bool TryRunAction(string action, string trigger, object[] triggerArgs, out string error, out Exception exception)
- - public static bool TryRunAction(CachedAction action, TriggerActionContext context, out string error, out Exception exception)
- - public static bool TryRunActions(CachedTriggerAction entry, string trigger, object[] triggerArgs = null, GameLocation location = null, Farmer player = null, Item targetItem = null, Item inputItem = null)
- - public static bool TryGetActionHandler(string key, out TriggerActionDelegate handler)
- - public static IReadOnlyList<CachedTriggerAction> GetActionsForTrigger(string trigger)
- - public static bool CanApply(TriggerActionData action, GameLocation location = null, Farmer player = null, Item targetItem = null, Item inputItem = null)
- - public static void ResetDataCache()

## Private Members
- - private static readonly HashSet<string> ValidTriggerTypes;
- - private static readonly Dictionary<string, TriggerActionDelegate> ActionHandlers;
- - private static readonly Dictionary<string, List<CachedTriggerAction>> ActionsByTrigger;
- - private static readonly Dictionary<string, CachedAction> ActionCache;
- - private static readonly CachedAction NullAction;
- - private static readonly TriggerActionContext EmptyManualContext;
- - private static Dictionary<string, List<CachedTriggerAction>> GetActionsByTrigger()
- - private static bool CanApplyIgnoringRun(TriggerActionData action, GameLocation location = null, Farmer player = null, Item targetItem = null, Item inputItem = null)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- - static bool InvalidFormatError(out string outError)
- - static TriggerActionManager()
