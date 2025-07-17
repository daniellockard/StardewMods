# WeaponDataDefinition

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public override string Identifier => "(W)";
- - public override string StandardDescriptor => "W";
- - public override IEnumerable<string> GetAllIds()
- - public override bool Exists(string itemId)
- - public override ParsedItemData GetData(string itemId)
- - public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
- - public override Item CreateItem(ParsedItemData data)
- - public interface IInventory : IList<Item>, ICollection<Item>, IEnumerable<Item>, IEnumerable

## Private Members
- *(None)*

## Protected Members
- - protected WeaponData GetRawData(string itemId)
- - protected int GetSpriteIndex(string itemId, string[] fields)

## Internal Members
- *(None)*

## Other Members
- *(None)*
