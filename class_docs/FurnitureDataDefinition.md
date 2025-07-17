# FurnitureDataDefinition

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public override string Identifier => "(F)";
- - public override string StandardDescriptor => "F";
- - public override IEnumerable<string> GetAllIds()
- - public override bool Exists(string itemId)
- - public override ParsedItemData GetData(string itemId)
- - public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
- - public override Item CreateItem(ParsedItemData data)

## Private Members
- - private string[] GetRawData(string itemId)

## Protected Members
- - protected Dictionary<string, string> GetDataSheet()
- - protected int GetSpriteIndex(string itemId, string[] fields)

## Internal Members
- *(None)*

## Other Members
- *(None)*
