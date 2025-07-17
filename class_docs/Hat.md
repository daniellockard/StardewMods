# Hat

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum HairDrawType
- - public const int widthOfTileSheetSquare = 20;
- - public const int heightOfTileSheetSquare = 20;
- - public const int data_index_internalName = 0;
- - public const int data_index_description = 1;
- - public const int data_index_showFullHair = 2;
- - public const int data_index_ignoreHairOffset = 3;
- - public const int data_index_tags = 4;
- - public const int data_index_displayName = 5;
- - public const int data_index_texture = 7;
- - public int? obsolete_which;
- - public bool skipHairDraw;
- - public readonly NetBool ignoreHairstyleOffset = new NetBool();
- - public readonly NetInt hairDrawType = new NetInt();
- - public readonly NetBool isPrismatic = new NetBool(value: false);
- - public List<BaseEnchantment> enchantments = new List<BaseEnchantment>();
- - public List<string> previousEnchantments = new List<string>();
- - public string displayName;
- - public string description;
- - public override string TypeDefinitionId { get; } = "(H)";
- - public bool isMask
- - public override string DisplayName
- - public Hat()
- - public Hat(string itemId)
- - public void load(string id)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public void draw(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, int direction, bool useAnimalTexture = false)
- - public override string getDescription()
- - public override int maximumStackSize()
- - public override bool isPlaceable()

## Private Members
- - private bool loadDisplayFields()

## Protected Members
- - protected int _isMask = -1;
- - protected override void MigrateLegacyItemId()
- - protected override void initNetFields()
- - protected override Item GetOneNew()

## Internal Members
- *(None)*

## Other Members
- *(None)*
