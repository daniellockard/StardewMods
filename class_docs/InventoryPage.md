# InventoryPage

**Summary:** Handles player or container inventory.

## Public Members
- - public const int region_inventory = 100;
- - public const int region_hat = 101;
- - public const int region_ring1 = 102;
- - public const int region_ring2 = 103;
- - public const int region_boots = 104;
- - public const int region_trashCan = 105;
- - public const int region_organizeButton = 106;
- - public const int region_accessory = 107;
- - public const int region_shirt = 108;
- - public const int region_pants = 109;
- - public const int region_shoes = 110;
- - public const int region_trinkets = 120;
- - public InventoryMenu inventory;
- - public string hoverText = "";
- - public string hoverTitle = "";
- - public int hoverAmount;
- - public Item hoveredItem;
- - public List<ClickableComponent> equipmentIcons = new List<ClickableComponent>();
- - public ClickableComponent portrait;
- - public ClickableTextureComponent trashCan;
- - public ClickableTextureComponent organizeButton;
- - public ClickableTextureComponent junimoNoteIcon;
- - public InventoryPage(int x, int y, int width, int height)
- - public static bool ShouldShowJunimoNoteIcon()
- - public override void receiveKeyPress(Keys key)
- - public override void setUpForGamePadMode()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void snapToDefaultClickableComponent()
- - public override bool readyToClose()
- - public override void draw(SpriteBatch b)
- - public override void emergencyShutDown()

## Private Members
- - private float trashCanLidRotation;
- - private int junimoNotePulser;

## Protected Members
- - protected Pet _pet;
- - protected Horse _horse;
- - protected virtual bool checkHeldItem(Func<Item, bool> f = null)
- - protected virtual Item takeHeldItem()
- - protected virtual void setHeldItem(Item item)

## Internal Members
- *(None)*

## Other Members
- *(None)*
