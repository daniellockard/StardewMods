# ItemListMenu

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public const int region_okbutton = 101;
- - public const int region_forwardButton = 102;
- - public const int region_backButton = 103;
- - public int itemsPerCategoryPage = 8;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent forwardButton;
- - public ClickableTextureComponent backButton;
- - public ItemListMenu(string menuTitle, List<Item> itemList)
- - public override void snapToDefaultClickableComponent()
- - public override void receiveGamePadButton(Buttons button)
- - public override void performHoverAction(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void draw(SpriteBatch b)
- - public bool showBackButton()
- - public bool showForwardButton()

## Private Members
- - private List<Item> itemsToList;
- - private string title;
- - private int currentTab;
- - private int totalValueOfItems;

## Protected Members
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
