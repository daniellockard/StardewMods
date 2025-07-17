# SpecialItem

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public const int skullKey = 4;
- - public const int clubCard = 2;
- - public const int specialCharm = 3;
- - public const int backpack = 99;
- - public const int magnifyingGlass = 5;
- - public const int darkTalisman = 6;
- - public const int magicInk = 7;
- - public readonly NetInt which = new NetInt();
- - public override string TypeDefinitionId { get; } = "(O)";
- - public override string DisplayName => displayName;
- - public override string Name
- - public SpecialItem()
- - public SpecialItem(int which, string name = "")
- - public void actionWhenReceived(Farmer who)
- - public TemporaryAnimatedSprite getTemporarySpriteForHoldingUp(Vector2 position)
- - public override string checkForSpecialItemHoldUpMeessage()
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public override int maximumStackSize()
- - public override string getDescription()
- - public override bool isPlaceable()

## Private Members
- - private string _displayName;
- - private string displayName

## Protected Members
- - protected override void initNetFields()
- - protected override Item GetOneNew()

## Internal Members
- *(None)*

## Other Members
- *(None)*
