# MenuWithInventory

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_okButton = 4857;
- - public const int region_trashCan = 5948;
- - public string descriptionText = "";
- - public string hoverText = "";
- - public string descriptionTitle = "";
- - public InventoryMenu inventory;
- - public Item hoveredItem;
- - public int wiggleWordsTimer;
- - public int hoverAmount;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent trashCan;
- - public float trashCanLidRotation;
- - public ClickableComponent dropItemInvisibleButton;
- - public ItemExitBehavior HeldItemExitBehavior;
- - public bool AllowExitWithHeldItem;
- - public Item heldItem
- - public MenuWithInventory(InventoryMenu.highlightThisItem highlighterMethod = null, bool okButton = false, bool trashCan = false, int inventoryXOffset = 0, int inventoryYOffset = 0, int menuOffsetHack = 0, ItemExitBehavior heldItemExitBehavior = ItemExitBehavior.ReturnToPlayer, bool allowExitWithHeldItem = false)
- - public void movePosition(int dx, int dy)
- - public override bool readyToClose()
- - public override void emergencyShutDown()
- - public virtual void DropHeldItem()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public void receiveRightClickOnlyToolAttachments(int x, int y)
- - public override void performHoverAction(int x, int y)
- - public override void update(GameTime time)
- - public virtual void draw(SpriteBatch b, bool drawUpperPortion = true, bool drawDescriptionArea = true, int red = -1, int green = -1, int blue = -1)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void draw(SpriteBatch b)

## Private Members
- - private Item _heldItem;

## Protected Members
- - protected override void cleanupBeforeExit()
- - protected void RescueHeldItemOnExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
