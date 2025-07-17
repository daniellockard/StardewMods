# InventoryMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public delegate bool highlightThisItem(Item i);
- - public enum BorderSide
- - public const int region_inventorySlot0 = 0;
- - public const int region_inventorySlot1 = 1;
- - public const int region_inventorySlot2 = 2;
- - public const int region_inventorySlot3 = 3;
- - public const int region_inventorySlot4 = 4;
- - public const int region_inventorySlot5 = 5;
- - public const int region_inventorySlot6 = 6;
- - public const int region_inventorySlot7 = 7;
- - public const int region_dropButton = 107;
- - public const int region_inventoryArea = 9000;
- - public string hoverText = "";
- - public string hoverTitle = "";
- - public string descriptionTitle = "";
- - public string descriptionText = "";
- - public List<ClickableComponent> inventory = new List<ClickableComponent>();
- - public IList<Item> actualInventory;
- - public highlightThisItem highlightMethod;
- - public ItemGrabMenu.behaviorOnItemSelect onAddItem;
- - public bool playerInventory;
- - public bool drawSlots;
- - public bool showGrayedOutSlots;
- - public int capacity;
- - public int rows;
- - public int horizontalGap;
- - public int verticalGap;
- - public ClickableComponent dropItemInvisibleButton;
- - public string moveItemSound = "dwop";
- - public InventoryMenu(int xPosition, int yPosition, bool playerInventory, IList<Item> actualInventory = null, highlightThisItem highlightMethod = null, int capacity = -1, int rows = 3, int horizontalGap = 0, int verticalGap = 0, bool drawSlots = true)
- - public List<ClickableComponent> GetBorder(BorderSide side)
- - public static bool highlightAllItems(Item i)
- - public static bool highlightNoItems(Item i)
- - public void SetPosition(int x, int y)
- - public void movePosition(int x, int y)
- - public void ShakeItem(Item item)
- - public void ShakeItem(int index)
- - public Item tryToAddItem(Item toPlace, string sound = "coin")
- - public int getInventoryPositionOfClick(int x, int y)
- - public Item leftClick(int x, int y, Item toPlace, bool playSound = true)
- - public Vector2 snapToClickableComponent(int x, int y)
- - public Item getItemAt(int x, int y)
- - public Item getItemFromClickableComponent(ClickableComponent c)
- - public Item rightClick(int x, int y, Item toAddTo, bool playSound = true, bool onlyCheckToolAttachments = false)
- - public Item hover(int x, int y, Item heldItem)
- - public override void setUpForGamePadMode()
- - public override void draw(SpriteBatch b)
- - public override void draw(SpriteBatch b, int red, int green, int blue)
- - public List<Vector2> GetSlotDrawPositions()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)

## Private Members
- *(None)*

## Protected Members
- - protected Dictionary<int, double> _iconShakeTimer = new Dictionary<int, double>();

## Internal Members
- *(None)*

## Other Members
- *(None)*
