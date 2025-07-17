# WeaponSpeedEnchantment

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public override bool IsSecondaryEnchantment()
- - public override bool IsForge()
- - public override void AddEquipmentEffects(BuffEffects effects)
- - public override int GetMaximumLevel()
- - public override string GetName()
- - public delegate void ChatCommandHandlerDelegate(string[] command, ChatBox chat);
- - public delegate void DebugCommandHandlerDelegate(string[] command, IGameLogger log);
- - public delegate void EventCommandDelegate(Event @event, string[] args, EventContext context);
- - public delegate bool EventPreconditionDelegate(GameLocation location, string eventId, string[] args);
- - public delegate void FestivalCleanupDelegate();
- - public delegate void FestivalDailySetupDelegate();
- - public delegate bool ForEachItemDelegate(in ForEachItemContext context);
- - public readonly struct GameStateQueryContext
- - public readonly GameLocation Location;
- - public readonly GameLocation ExplicitTargetLocation;
- - public readonly Farmer Player;
- - public readonly Item TargetItem;
- - public readonly Item InputItem;
- - public readonly Random Random;
- - public readonly HashSet<string> IgnoreQueryKeys;
- - public readonly Dictionary<string, object> CustomFields;
- - public GameStateQueryContext(GameLocation location, Farmer player, Item targetItem, Item inputItem, Random random, HashSet<string> ignoreQueryKeys = null, Dictionary<string, object> customFields = null)
- - public delegate bool GameStateQueryDelegate(string[] query, GameStateQueryContext context);
- - public delegate IList<object> GetForEachItemPathDelegate();
- - public delegate bool MachineInteractDelegate(Object machine, GameLocation location, Farmer player);
- - public delegate Item MachineOutputDelegate(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady);
- - public delegate IEnumerable<ItemQueryResult> ResolveItemQueryDelegate(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError);
- - public readonly struct TriggerActionContext
- - public readonly string Trigger;
- - public readonly object[] TriggerArgs;
- - public readonly TriggerActionData Data;
- - public readonly Dictionary<string, object> CustomFields;
- - public TriggerActionContext(string trigger, object[] triggerArgs, TriggerActionData data, Dictionary<string, object> customFields = null)
- - public delegate bool TriggerActionDelegate(string[] args, TriggerActionContext context, out string error);

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
