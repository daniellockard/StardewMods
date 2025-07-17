# WallpaperDataDefinition

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public override string Identifier => "(WP)";
- - public override IEnumerable<string> GetAllIds()
- - public override bool Exists(string itemId)
- - public override ParsedItemData GetData(string itemId)
- - public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
- - public override Item CreateItem(ParsedItemData data)

## Private Members
- *(None)*

## Protected Members
- - protected const int LegacyWallpaperCount = 112;
- - protected bool TryParseLegacyId(string raw, out int legacyId)
- - protected void ParseStandardId(string raw, out string id, out int index)
- - protected ModWallpaperOrFlooring GetWallpaperSet(string setId)
- - protected ParsedItemData GetData(string itemId, int spriteIndex, string textureName, object rawData)

## Internal Members
- *(None)*

## Other Members
- *(None)*
