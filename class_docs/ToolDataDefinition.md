# ToolDataDefinition

**Summary:** Represents a tool used by the player (hoe, axe, etc.).

## Public Members
- - public override string Identifier => "(T)";
- - public override IEnumerable<string> GetAllIds()
- - public override bool Exists(string itemId)
- - public override ParsedItemData GetData(string itemId)
- - public override Rectangle GetSourceRect(ParsedItemData data, Texture2D texture, int spriteIndex)
- - public override Item CreateItem(ParsedItemData data)

## Private Members
- *(None)*

## Protected Members
- - protected ToolData GetRawData(string itemId)
- - protected Tool CreateToolInstance(ParsedItemData itemData, ToolData toolData)
- - protected Tool GetErrorTool(ParsedItemData data)
- - protected void TrySetProperty(Type type, Tool tool, string name, string rawValue)

## Internal Members
- *(None)*

## Other Members
- *(None)*
