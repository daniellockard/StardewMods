# TransferredItemSprite

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public Item item;
- - public Vector2 position;
- - public float age;
- - public float alpha = 1f;
- - public TransferredItemSprite(Item transferred_item, int start_x, int start_y)
- - public bool Update(GameTime time)
- - public void Draw(SpriteBatch b)
- - public const int region_organizationButtons = 15923;
- - public const int region_itemsToGrabMenuModifier = 53910;
- - public const int region_fillStacksButton = 12952;
- - public const int region_organizeButton = 106;
- - public const int region_colorPickToggle = 27346;
- - public const int region_specialButton = 12485;
- - public const int region_lastShippedHolder = 12598;
- - public const int source_none = 0;
- - public const int source_chest = 1;
- - public const int source_gift = 2;
- - public const int source_fishingChest = 3;
- - public const int source_overflow = 4;
- - public const int specialButton_junimotoggle = 1;
- - public InventoryMenu ItemsToGrabMenu;
- - public TemporaryAnimatedSprite poof;
- - public bool reverseGrab;
- - public bool showReceivingMenu = true;
- - public bool drawBG = true;
- - public bool destroyItemOnClick;
- - public bool canExitOnKey;
- - public bool playRightClickSound;
- - public bool allowRightClick;
- - public bool shippingBin;
- - public string message;
- - public behaviorOnItemSelect behaviorFunction;
- - public behaviorOnItemSelect behaviorOnItemGrab;
- - public Item sourceItem;
- - public ClickableTextureComponent fillStacksButton;
- - public ClickableTextureComponent organizeButton;
- - public ClickableTextureComponent colorPickerToggleButton;
- - public ClickableTextureComponent specialButton;
- - public ClickableTextureComponent lastShippedHolder;
- - public List<ClickableComponent> discreteColorPickerCC;
- - public int source;
- - public int whichSpecialButton;
- - public object context;
- - public bool snappedtoBottom;
- - public DiscreteColorPicker chestColorPicker;
- - public bool essential;
- - public bool superEssential;
- - public int storageSpaceTopBorderOffset;
- - public List<TransferredItemSprite> _transferredItemSprites = new List<TransferredItemSprite>();
- - public bool _sourceItemInCurrentLocation;
- - public ClickableTextureComponent junimoNoteIcon;
- - public int junimoNotePulser;
- - public ItemGrabMenu(IList<Item> inventory, object context = null)
- - public virtual void DropRemainingItems()
- - public ItemGrabMenu(ItemGrabMenu menu)
- - public ItemGrabMenu(IList<Item> inventory, bool reverseGrab, bool showReceivingMenu, InventoryMenu.highlightThisItem highlightFunction, behaviorOnItemSelect behaviorOnItemSelectFunction, string message, behaviorOnItemSelect behaviorOnItemGrab = null, bool snapToBottom = false, bool canBeExitedWithKey = false, bool playRightClickSound = true, bool allowRightClick = true, bool showOrganizeButton = false, int source = 0, Item sourceItem = null, int whichSpecialButton = -1, object context = null, ItemExitBehavior heldItemExitBehavior = ItemExitBehavior.ReturnToPlayer, bool allowExitWithHeldItem = false)
- - public static ItemGrabMenu CreateOverflowMenu(IList<Item> items, behaviorOnItemSelect onCollectItem = null)
- - public virtual void RepositionSideButtons()
- - public void SetupBorderNeighbors()
- - public virtual bool CanHaveColorPicker()
- - public virtual int GetColumnCount()
- - public ItemGrabMenu setEssential(bool essential, bool superEssential = false)
- - public void initializeShippingBin()
- - public override void snapToDefaultClickableComponent()
- - public void setSourceItem(Item item)
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public void setBackgroundTransparency(bool b)
- - public void setDestroyItemOnClick(bool b)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public void FillOutStacks()
- - public static void organizeItemsInList(IList<Item> items)
- - public bool areAllItemsTaken()
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public override void emergencyShutDown()

## Private Members
- - private bool HasUpdateTicked;

## Protected Members
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
