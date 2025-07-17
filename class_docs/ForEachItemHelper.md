# ForEachItemHelper

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public GetForEachItemPathDelegate getParentPath;
- - public IList<TItem> list;
- - public bool leaveNullSlotsOnRemoval;
- - public Action<Item, Item, int> onChanged;
- - public static bool ForEachItemInWorld(ForEachItemDelegate handler)
- - public static bool ForEachItemInLocation(GameLocation location, ForEachItemDelegate handler)
- - public static bool ApplyToItem<TItem>(TItem item, ForEachItemDelegate handler, Action remove, Action<Item> replaceWith, GetForEachItemPathDelegate getParentPath) where TItem : Item
- - public static bool ApplyToField<TItem>(NetRef<TItem> field, ForEachItemDelegate handler, GetForEachItemPathDelegate getParentPath, Action<Item, Item> onChanged = null) where TItem : Item
- - public static bool ApplyToList<TItem>(IList<TItem> list, ForEachItemDelegate handler, GetForEachItemPathDelegate getParentPath, bool leaveNullSlotsOnRemoval = false, Action<Item, Item, int> onChanged = null) where TItem : Item
- - public static IList<object> CombinePath(GetForEachItemPathDelegate parentPath, params object[] pathValues)

## Private Members
- - private sealed class <>c__DisplayClass4_0<TItem> where TItem : Item
- - private static TItem PrepareForReplaceWith<TItem>(TItem previousItem, TItem newItem) where TItem : Item

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- - static IList<object> GetParentPathForTeam()
