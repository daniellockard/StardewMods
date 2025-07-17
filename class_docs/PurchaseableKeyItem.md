# PurchaseableKeyItem

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public string TypeDefinitionId => "(Salable)";
- - public string QualifiedItemId => TypeDefinitionId + "PurchaseableKeyItem." + id;
- - public string DisplayName => _displayName;
- - public int id => _id;
- - public List<string> tags => _tags;
- - public string Name => _name;
- - public bool IsRecipe
- - public int Stack
- - public int Quality
- - public PurchaseableKeyItem(string display_name, string display_description, int parent_sheet_index, Action<Farmer> on_purchase = null)
- - public string GetItemTypeId()
- - public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
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
- - public struct RainDrop
- - public int frame;
- - public int accumulator;
- - public Vector2 position;
- - public RainDrop(int x, int y, int frame, int accumulator)

## Private Members
- *(None)*

## Protected Members
- - protected string _displayName = "";
- - protected string _name = "";
- - protected string _description = "";
- - protected int _price;
- - protected int _id;
- - protected List<string> _tags;
- - protected Action<Farmer> _onPurchase;

## Internal Members
- *(None)*

## Other Members
- *(None)*
