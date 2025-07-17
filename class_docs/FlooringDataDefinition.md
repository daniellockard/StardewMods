# FlooringDataDefinition

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public override string Identifier => "(FL)";
- - public override IEnumerable<string> GetAllIds()
- - public override bool Exists(string itemId)
- - public override ParsedItemData GetData(string itemId)
- - public override Item CreateItem(ParsedItemData data)
- - public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)

## Private Members
- - private const int LegacyFlooringCount = 88;

## Protected Members
- - protected bool TryParseLegacyId(string raw, out int legacyId)
- - protected void ParseStandardId(string raw, out string id, out int index)
- - protected ModWallpaperOrFlooring GetFlooringSet(string setId)
- - protected ParsedItemData GetData(string itemId, int spriteIndex, string textureName, object rawData)

## Internal Members
- *(None)*

## Other Members
- *(None)*
