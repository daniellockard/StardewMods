# ObjectDataDefinition

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public override string Identifier => "(O)";
- - public override string StandardDescriptor => "O";
- - public override IEnumerable<string> GetAllIds()
- - public override bool Exists(string itemId)
- - public override ParsedItemData GetData(string itemId)
- - public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
- - public override Item CreateItem(ParsedItemData data)
- - public static bool HasExplicitCategory(ParsedItemData data)
- - public static int GetRawPrice(ParsedItemData data)
- - public bool CanHaveRoe(Item fish)
- - public virtual ColoredObject CreateFlavoredAgedRoe(Object ingredient)
- - public virtual Object CreateFlavoredHoney(Object ingredient)
- - public virtual Object CreateFlavoredJelly(Object ingredient)
- - public virtual Object CreateFlavoredJuice(Object ingredient)
- - public virtual Object CreateFlavoredPickle(Object ingredient)
- - public virtual ColoredObject CreateFlavoredRoe(Object ingredient)
- - public virtual Object CreateFlavoredWine(Object ingredient)
- - public virtual Object CreateFlavoredBait(Object ingredient)
- - public virtual Object CreateFlavoredDriedFruit(Object ingredient)
- - public virtual Object CreateFlavoredDriedMushroom(Object ingredient)
- - public virtual Object CreateFlavoredSmokedFish(Object ingredient)
- - public virtual Object CreateFlavoredItem(Object.PreserveType preserveType, Object ingredient)
- - public string GetBaseItemIdForFlavoredItem(Object.PreserveType preserveType, string ingredientItemId)

## Private Members
- *(None)*

## Protected Members
- - protected ObjectData GetRawData(string itemId)

## Internal Members
- *(None)*

## Other Members
- *(None)*
