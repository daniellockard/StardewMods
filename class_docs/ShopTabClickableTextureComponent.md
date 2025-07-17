# ShopTabClickableTextureComponent

**Summary:** Represents a shop or merchant interface.

## Public Members
- - public Func<ISalable, bool> Filter;
- - public ShopTabClickableTextureComponent(string name, Rectangle bounds, string label, string hoverText, Texture2D texture, Rectangle sourceRect, float scale, bool drawShadow = false)
- - public ShopTabClickableTextureComponent(Rectangle bounds, Texture2D texture, Rectangle sourceRect, float scale, bool drawShadow = false)
- - public const int region_shopButtonModifier = 3546;
- - public const int region_upArrow = 97865;
- - public const int region_downArrow = 97866;
- - public const int region_tabStartIndex = 99999;
- - public const int infiniteStock = int.MaxValue;
- - public const int itemsPerPage = 4;
- - public const int numberRequiredForExtraItemTrade = 5;
- - public string hoverText = "";
- - public string boldTitleText = "";
- - public string openMenuSound = "dwop";
- - public string purchaseSound = "purchaseClick";
- - public string purchaseRepeatSound = "purchaseRepeat";
- - public string ShopId;
- - public ShopData ShopData;
- - public InventoryMenu inventory;
- - public ISalable heldItem;
- - public ISalable hoveredItem;
- - public StackDrawType? DefaultStackDrawType;
- - public List<ISalable> forSale = new List<ISalable>();
- - public List<ClickableComponent> forSaleButtons = new List<ClickableComponent>();
- - public List<int> categoriesToSellHere = new List<int>();
- - public List<List<string>> tagsToSellHere = new List<List<string>>();
- - public Dictionary<ISalable, ItemStockInformation> itemPriceAndStock = new Dictionary<ISalable, ItemStockInformation>();
- - public int hoverPrice = -1;
- - public int currentItemIndex;
- - public int currency;
- - public ClickableTextureComponent upArrow;
- - public ClickableTextureComponent downArrow;
- - public ClickableTextureComponent scrollBar;
- - public Texture2D portraitTexture;
- - public string potraitPersonDialogue;
- - public object source;
- - public OnPurchaseDelegate onPurchase;
- - public Func<ISalable, bool> onSell;
- - public Func<int, bool> canPurchaseCheck;
- - public List<ShopTabClickableTextureComponent> tabButtons = new List<ShopTabClickableTextureComponent>();
- - public bool readOnly;
- - public HashSet<ISalable> buyBackItems = new HashSet<ISalable>();
- - public Dictionary<ISalable, ISalable> buyBackItemsToResellTomorrow = new Dictionary<ISalable, ISalable>();
- - public int safetyTimer = 250;
- - public ShopCachedTheme VisualTheme { get; private set; }
- - public ShopMenu(string shopId, ShopData shopData, ShopOwnerData ownerData, NPC owner = null, OnPurchaseDelegate onPurchase = null, Func<ISalable, bool> onSell = null, bool playOpenSound = true)
- - public ShopMenu(string shopId, Dictionary<ISalable, ItemStockInformation> itemPriceAndStock, int currency = 0, string who = null, OnPurchaseDelegate on_purchase = null, Func<ISalable, bool> on_sell = null, bool playOpenSound = true)
- - public ShopMenu(string shopId, List<ISalable> itemsForSale, int currency = 0, string who = null, OnPurchaseDelegate on_purchase = null, Func<ISalable, bool> on_sell = null, bool playOpenSound = true)
- - public void SetVisualTheme(ShopThemeData theme)
- - public void AddForSale(ISalable item, ItemStockInformation stock = null)
- - public void updateSaleButtonNeighbors()
- - public virtual void setUpStoreForContext()
- - public void UseNoTabs()
- - public void UseFurnitureCatalogueTabs()
- - public void UseCatalogueTabs()
- - public void UseDresserTabs()
- - public void repositionTabs()
- - public override void snapToDefaultClickableComponent()
- - public void setUpShopOwner(string who, string shopId)
- - public void SetUpShopOwner(ShopOwnerData ownerData, NPC owner = null)
- - public Texture2D TryLoadPortrait(ShopOwnerData ownerData, NPC owner)
- - public bool ParseDialogueSubstitution(string[] query, out string replacement, Random random, Farmer player)
- - public bool highlightItemToSell(Item i)
- - public static int getPlayerCurrencyAmount(Farmer who, int currencyType)
- - public override void leftClickHeld(int x, int y)
- - public override void releaseLeftClick(int x, int y)
- - public override void receiveScrollWheelAction(int direction)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public virtual bool CanBuyback()
- - public virtual void BuyBuybackItem(ISalable bought_item, int price, int stack)
- - public virtual ISalable AddBuybackItem(ISalable sold_item, int sell_unit_price, int stack)
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public virtual void switchTab(int new_tab)
- - public virtual void applyTab()
- - public override bool readyToClose()
- - public override void emergencyShutDown()
- - public void PlayOpenSound()
- - public bool IsOutOfStock()
- - public static void chargePlayer(Farmer who, int currencyType, int amount)
- - public virtual void HandleSynchedItemPurchase(ISalable item, Farmer who, int number_purchased)
- - public bool HasTradeItem(string itemId, int count)
- - public void ConsumeTradeItem(string itemId, int count)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void update(GameTime time)
- - public void drawCurrency(SpriteBatch b)
- - public override void receiveGamePadButton(Buttons button)
- - public void updatePosition()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public void setItemPriceAndStock(Dictionary<ISalable, ItemStockInformation> new_stock)
- - public override void draw(SpriteBatch b)
- - public StackDrawType GetStackDrawType(ItemStockInformation stockInfo, ISalable item)

## Private Members
- - private TemporaryAnimatedSprite poof;
- - private Rectangle scrollBarRunner;
- - private float sellPercentage = 1f;
- - private TemporaryAnimatedSpriteList animations = new TemporaryAnimatedSpriteList();
- - private bool scrolling;
- - private void Initialize(int currency, OnPurchaseDelegate onPurchase, Func<ISalable, bool> onSell, bool playOpenSound)
- - private void setScrollBarToCurrentIndex()
- - private void downArrowPressed()
- - private void upArrowPressed()
- - private bool tryToPurchaseItem(ISalable item, ISalable held_item, int stockToBuy, int x, int y)
- - private string getHoveredItemExtraItemIndex()
- - private int getHoveredItemExtraItemAmount()

## Protected Members
- - protected int currentTab;
- - protected bool _isStorageShop;
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)

## Internal Members
- *(None)*

## Other Members
- *(None)*
