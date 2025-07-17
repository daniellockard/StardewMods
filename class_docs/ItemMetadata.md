# ItemMetadata

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public string LocalItemId { get; }
- - public string QualifiedItemId { get; }
- - public string TypeIdentifier { get; private set; }
- - public ItemMetadata(string qualifiedItemId, string localItemId, string typeIdentifier)
- - public IItemDataDefinition GetTypeDefinition()
- - public ParsedItemData GetParsedData()
- - public ParsedItemData GetParsedOrErrorData()
- - public bool Exists()
- - public Item CreateItem(int amount = 1, int quality = 0)
- - public Item CreateItemOrErrorItem(int amount = 1, int quality = 0)

## Private Members
- - private ParsedItemData ParsedData;
- - private bool IsParsedDataLoaded;
- - private IItemDataDefinition TypeDefinition;
- - private bool IsTypeResolveAttempted;
- - private bool TypeDefinitionContainsItem;

## Protected Members
- *(None)*

## Internal Members
- - internal void SetTypeDefinition(string typeIdentifier, IItemDataDefinition typeDefinition, bool? itemExists = null)

## Other Members
- *(None)*
