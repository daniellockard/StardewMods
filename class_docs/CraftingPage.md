# CraftingPage

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int howManyRecipesFitOnPage = 40;
- - public const int numInRow = 10;
- - public const int numInCol = 4;
- - public const int region_upArrow = 88;
- - public const int region_downArrow = 89;
- - public const int region_craftingSelectionArea = 8000;
- - public const int region_craftingModifier = 200;
- - public string hoverText = "";
- - public Item hoverItem;
- - public Item lastCookingHover;
- - public InventoryMenu inventory;
- - public Item heldItem;
- - public List<Dictionary<ClickableTextureComponent, CraftingRecipe>> pagesOfCraftingRecipes = new List<Dictionary<ClickableTextureComponent, CraftingRecipe>>();
- - public int currentCraftingPage;
- - public CraftingRecipe hoverRecipe;
- - public ClickableTextureComponent upButton;
- - public ClickableTextureComponent downButton;
- - public bool cooking;
- - public ClickableTextureComponent trashCan;
- - public ClickableComponent dropItemInvisibleButton;
- - public float trashCanLidRotation;
- - public List<IInventory> _materialContainers;
- - public int hoverAmount;
- - public List<ClickableComponent> currentPageClickableComponents = new List<ClickableComponent>();
- - public CraftingPage(int x, int y, int width, int height, bool cooking = false, bool standaloneMenu = false, List<IInventory> materialContainers = null)
- - public override void snapToDefaultClickableComponent()
- - public override void receiveKeyPress(Keys key)
- - public override void receiveScrollWheelAction(int direction)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public virtual void RepositionElements()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override bool readyToClose()
- - public override void draw(SpriteBatch b)
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public override void emergencyShutDown()

## Private Members
- - private string hoverTitle = "";
- - private int craftingPageY()
- - private ClickableTextureComponent[,] createNewPageLayout()
- - private Dictionary<ClickableTextureComponent, CraftingRecipe> createNewPage()
- - private bool spaceOccupied(ClickableTextureComponent[,] pageLayout, int x, int y, CraftingRecipe recipe)
- - private void layoutRecipes(List<string> playerRecipes)
- - private void clickCraftingRecipe(ClickableTextureComponent c, bool playSound = true)

## Protected Members
- - protected bool _standaloneMenu;
- - protected virtual List<string> GetRecipesToDisplay()
- - protected virtual IList<Item> getContainerContents()
- - protected override void noSnappedComponentFound(int direction, int oldRegion, int oldID)
- - protected override void actionOnRegionChange(int oldRegion, int newRegion)
- - protected void _UpdateCurrentPageButtons()
- - protected override bool _ShouldAutoSnapPrioritizeAlignedElements()

## Internal Members
- *(None)*

## Other Members
- *(None)*
