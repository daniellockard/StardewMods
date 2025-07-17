# MovieConcession

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public string TypeDefinitionId => "(Salable)";
- - public string QualifiedItemId => TypeDefinitionId + "MovieConcession." + Id;
- - public string Id => Data.Id;
- - public string Name => Data.Name;
- - public string DisplayName => TokenParser.ParseText(Data.DisplayName);
- - public bool IsRecipe
- - public int Stack
- - public int Quality
- - public List<string> Tags { get; }
- - public MovieConcession(ConcessionItemData data)
- - public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public Texture2D GetTexture()
- - public int GetSpriteIndex()
- - public bool ShouldDrawIcon()
- - public string getDescription()
- - public int maximumStackSize()
- - public int addToStack(Item stack)
- - public bool canStackWith(ISalable other)
- - public int sellToStorePrice(long specificPlayerID = -1L)
- - public int salePrice(bool ignoreProfitMargins = false)
- - public bool appliesProfitMargins()
- - public bool actionWhenPurchased(string shopId)
- - public bool CanBuyItem(Farmer farmer)
- - public bool IsInfiniteStock()
- - public ISalable GetSalableInstance()
- - public void FixStackSize()
- - public void FixQuality()
- - public string GetItemTypeId()

## Private Members
- - private readonly ConcessionItemData Data;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
