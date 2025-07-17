# Clothing

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum ClothesType
- - public const int SHIRT_SHEET_WIDTH = 128;
- - public const string DefaultShirtSheetName = "Characters\\Farmer\\shirts";
- - public const string DefaultPantsSheetName = "Characters\\Farmer\\pants";
- - public const int MinShirtId = 1000;
- - public readonly NetInt price = new NetInt();
- - public readonly NetInt indexInTileSheet = new NetInt();
- - public int? obsolete_indexInTileSheetFemale;
- - public string description;
- - public string displayName;
- - public readonly NetEnum<ClothesType> clothesType = new NetEnum<ClothesType>();
- - public readonly NetBool dyeable = new NetBool(value: false);
- - public readonly NetColor clothesColor = new NetColor(new Color(255, 255, 255));
- - public readonly NetBool isPrismatic = new NetBool(value: false);
- - public override string TypeDefinitionId
- - public int Price
- - public override string DisplayName
- - public Clothing()
- - public Clothing(string itemId)
- - public virtual void LoadData(bool applyColor = false, bool forceReload = false)
- - public override string getCategoryName()
- - public override int salePrice(bool ignoreProfitMargins = false)
- - public virtual void Dye(Color color, float strength = 0.5f)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public override int maximumStackSize()
- - public override string getDescription()
- - public override bool isPlaceable()

## Private Members
- *(None)*

## Protected Members
- - protected bool _loadedData;
- - protected override void initNetFields()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)

## Internal Members
- *(None)*

## Other Members
- *(None)*
