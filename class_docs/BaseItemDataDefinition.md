# BaseItemDataDefinition

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public Dictionary<string, ParsedItemData> ParsedItemCache = new Dictionary<string, ParsedItemData>();
- - public abstract string Identifier { get; }
- - public virtual string StandardDescriptor => null;
- - public abstract IEnumerable<string> GetAllIds();
- - public abstract bool Exists(string itemId);
- - public abstract ParsedItemData GetData(string itemId);
- - public ParsedItemData GetErrorData(string itemId)
- - public abstract Item CreateItem(ParsedItemData data);
- - public abstract Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex);
- - public virtual Texture2D GetErrorTexture()
- - public virtual string GetErrorTextureName()
- - public virtual Rectangle GetErrorSourceRect()

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
