# HatDataDefinition

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public override string Identifier => "(H)";
- - public override string StandardDescriptor => "H";
- - public override IEnumerable<string> GetAllIds()
- - public override bool Exists(string itemId)
- - public override ParsedItemData GetData(string itemId)
- - public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
- - public override Item CreateItem(ParsedItemData data)
- - public interface IHaveItemTypeId
- - public interface IItemDataDefinition

## Private Members
- *(None)*

## Protected Members
- - protected Dictionary<string, string> GetDataSheet()
- - protected string[] GetRawData(string itemId)
- - protected int GetSpriteIndex(string itemId, string[] fields)

## Internal Members
- *(None)*

## Other Members
- *(None)*
