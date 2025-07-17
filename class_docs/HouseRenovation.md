# HouseRenovation

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum AnimationType
- - public AnimationType animationType;
- - public List<List<Rectangle>> renovationBounds = new List<List<Rectangle>>();
- - public string placementText = "";
- - public GameLocation location;
- - public bool requireClearance = true;
- - public Action<HouseRenovation, int> onRenovation;
- - public Func<HouseRenovation, int, bool> validate;
- - public int Price;
- - public string RoomId;
- - public string TypeDefinitionId => "(Salable)";
- - public string QualifiedItemId => TypeDefinitionId + "HouseRenovation";
- - public string DisplayName => _displayName;
- - public string Name => _name;
- - public bool IsRecipe
- - public int Stack
- - public int Quality
- - public bool ShouldDrawIcon()
- - public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public string getDescription()
- - public int maximumStackSize()
- - public int addToStack(Item stack)
- - public int sellToStorePrice(long specificPlayerID = -1L)
- - public int salePrice(bool ignoreProfitMargins = false)
- - public bool appliesProfitMargins()
- - public bool actionWhenPurchased(string shopId)
- - public bool canStackWith(ISalable other)
- - public bool CanBuyItem(Farmer farmer)
- - public bool IsInfiniteStock()
- - public ISalable GetSalableInstance()
- - public void FixStackSize()
- - public void FixQuality()
- - public string GetItemTypeId()
- - public static void ShowRenovationMenu()
- - public static List<ISalable> GetAvailableRenovations()
- - public static bool EnsureNoObstructions(HouseRenovation renovation, int selected_index)
- - public static void BuildCrib(HouseRenovation renovation, int selected_index)
- - public static void RemoveCrib(HouseRenovation renovation, int selected_index)
- - public static void OpenBedroom(HouseRenovation renovation, int selected_index)
- - public static void CloseBedroom(HouseRenovation renovation, int selected_index)
- - public static void OpenSouthernRoom(HouseRenovation renovation, int selected_index)
- - public static void CloseSouthernRoom(HouseRenovation renovation, int selected_index)
- - public static void OpenCornernRoom(HouseRenovation renovation, int selected_index)
- - public static void CloseCornerRoom(HouseRenovation renovation, int selected_index)
- - public static bool OnPurchaseRenovation(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock)
- - public virtual void AddRenovationBound(Rectangle bound)
- - public virtual void AddRenovationBound(List<Rectangle> bounds)

## Private Members
- *(None)*

## Protected Members
- - protected string _displayName;
- - protected string _name;
- - protected string _description;

## Internal Members
- *(None)*

## Other Members
- *(None)*
