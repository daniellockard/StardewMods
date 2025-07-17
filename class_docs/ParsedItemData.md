# ParsedItemData

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public readonly IItemDataDefinition ItemType;
- - public readonly string ItemId;
- - public readonly string QualifiedItemId;
- - public readonly int SpriteIndex;
- - public readonly string TextureName;
- - public readonly string InternalName;
- - public readonly string DisplayName;
- - public readonly string Description;
- - public readonly int Category;
- - public readonly string ObjectType;
- - public readonly object RawData;
- - public readonly bool IsErrorItem;
- - public readonly bool ExcludeFromRandomSale;
- - public ParsedItemData(IItemDataDefinition itemType, string itemId, int spriteIndex, string textureName, string internalName, string displayName, string description, int category, string objectType, object rawData, bool isErrorItem = false, bool excludeFromRandomSale = false)
- - public string GetItemTypeId()
- - public virtual Texture2D GetTexture()
- - public virtual string GetTextureName()
- - public virtual Rectangle GetSourceRect(int offset = 0, int? spriteIndex = null)
- - public virtual bool HasCategory()

## Private Members
- - private bool LoadedTexture;
- - private Texture2D Texture;
- - private Rectangle DefaultSourceRect;

## Protected Members
- - protected virtual void LoadTextureIfNeeded()
- - protected virtual Texture2D TryLoadTexture()

## Internal Members
- *(None)*

## Other Members
- *(None)*
