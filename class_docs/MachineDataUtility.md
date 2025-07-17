# MachineDataUtility

**Summary:** Utility or helper class.

## Public Members
- - public delegate string GetOutputTokenValueDelegate(string key, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who);
- - public static readonly IDictionary<string, GetOutputTokenValueDelegate> OutputTokens = new Dictionary<string, GetOutputTokenValueDelegate>
- - public static bool HasAdditionalRequirements(IInventory inventory, IList<MachineItemAdditionalConsumedItems> requirements, out MachineItemAdditionalConsumedItems failedRequirement)
- - public static bool CanApplyOutput(Object machine, MachineOutputRule rule, MachineOutputTrigger trigger, Item inputItem, Farmer who, GameLocation location, out MachineOutputTriggerRule triggerRule, out bool matchesExceptCount)
- - public static bool TryGetMachineOutputRule(Object machine, MachineData machineData, MachineOutputTrigger trigger, Item inputItem, Farmer who, GameLocation location, out MachineOutputRule rule, out MachineOutputTriggerRule triggerRule, out MachineOutputRule ruleIgnoringCount, out MachineOutputTriggerRule triggerIgnoringCount)
- - public static MachineItemOutput GetOutputData(Object machine, MachineData machineData, MachineOutputRule outputRule, Item inputItem, Farmer who, GameLocation location)
- - public static MachineItemOutput GetOutputData(List<MachineItemOutput> outputs, bool useFirstValidOutput, Item inputItem, Farmer who, GameLocation location)
- - public static Item GetOutputItem(Object machine, MachineItemOutput outputData, Item inputItem, Farmer who, bool probe, out int? overrideMinutesUntilReady)
- - public static void UpdateStats(List<StatIncrement> stats, Item item, int amount)
- - public static bool PlayEffects(Object machine, MachineEffects effect, bool playSounds = true)
- - public static string FormatOutputId(string id, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who)
- - public static string GetNearbyFlowerItemId(Object machine)
- - public struct DisposableList<T>
- - public struct Enumerator : IDisposable
- - public T Current
- - public Enumerator(DisposableList<T> parent)
- - public bool MoveNext()
- - public void Reset()
- - public void Dispose()
- - public DisposableList(List<T> list)
- - public Enumerator GetEnumerator()

## Private Members
- - private static string GetTokenValue(string key, Object machine, MachineItemOutput outputData, Item inputItem, Farmer who)
- - private readonly DisposableList<T> _parent;
- - private int _index;
- - private readonly List<T> _list;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
