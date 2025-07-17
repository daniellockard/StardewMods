# IClickableMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public delegate void onExit();
- - public const int upperRightCloseButton_ID = 9175502;
- - public const int currency_g = 0;
- - public const int currency_starTokens = 1;
- - public const int currency_qiCoins = 2;
- - public const int currency_qiGems = 4;
- - public const int greyedOutSpotIndex = 57;
- - public const int presentIconIndex = 58;
- - public const int itemSpotIndex = 10;
- - public static int borderWidth = 40;
- - public static int tabYPositionRelativeToMenuY = -48;
- - public static int spaceToClearTopBorder = 96;
- - public static int spaceToClearSideBorder = 16;
- - public const int spaceBetweenTabs = 4;
- - public int xPositionOnScreen;
- - public int yPositionOnScreen;
- - public int width;
- - public int height;
- - public Action<IClickableMenu> behaviorBeforeCleanup;
- - public onExit exitFunction;
- - public ClickableTextureComponent upperRightCloseButton;
- - public bool destroy;
- - public List<ClickableComponent> allClickableComponents;
- - public ClickableComponent currentlySnappedComponent;
- - public static StringBuilder HoverTextStringBuilder = new StringBuilder();
- - public Vector2 Position => new Vector2((float)xPositionOnScreen, (float)yPositionOnScreen);
- - public IClickableMenu()
- - public IClickableMenu(int x, int y, int width, int height, bool showUpperRightCloseButton = false)
- - public void initialize(int x, int y, int width, int height, bool showUpperRightCloseButton = false)
- - public IClickableMenu GetChildMenu()
- - public IClickableMenu GetParentMenu()
- - public void SetChildMenu(IClickableMenu menu)
- - public void AddDependency()
- - public void RemoveDependency()
- - public bool HasDependencies()
- - public virtual bool areGamePadControlsImplemented()
- - public virtual void receiveGamePadButton(Buttons button)
- - public void drawMouse(SpriteBatch b, bool ignore_transparency = false, int cursor = -1)
- - public virtual void populateClickableComponentList()
- - public virtual void applyMovementKey(int direction)
- - public virtual void snapToDefaultClickableComponent()
- - public void applyMovementKey(Keys key)
- - public virtual void setCurrentlySnappedComponentTo(int id)
- - public void moveCursorInDirection(int direction)
- - public virtual void snapCursorToCurrentSnappedComponent()
- - public virtual bool IsActive()
- - public virtual void automaticSnapBehavior(int direction, int oldRegion, int oldID)
- - public virtual bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public ClickableComponent getComponentWithID(int id)
- - public void initializeUpperRightCloseButton()
- - public virtual void drawBackground(SpriteBatch b)
- - public virtual bool showWithoutTransparencyIfOptionIsSet()
- - public virtual void clickAway()
- - public virtual void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public virtual void setUpForGamePadMode()
- - public virtual bool shouldClampGamePadCursor()
- - public virtual void releaseLeftClick(int x, int y)
- - public virtual void leftClickHeld(int x, int y)
- - public virtual void receiveLeftClick(int x, int y, bool playSound = true)
- - public virtual bool overrideSnappyMenuCursorMovementBan()
- - public virtual void receiveRightClick(int x, int y, bool playSound = true)
- - public virtual void receiveKeyPress(Keys key)
- - public virtual void gamePadButtonHeld(Buttons b)
- - public virtual ClickableComponent getCurrentlySnappedComponent()
- - public virtual void receiveScrollWheelAction(int direction)
- - public virtual void performHoverAction(int x, int y)
- - public virtual void draw(SpriteBatch b, int red, int green, int blue)
- - public virtual void draw(SpriteBatch b)
- - public virtual bool isWithinBounds(int x, int y)
- - public virtual void update(GameTime time)
- - public virtual bool shouldDrawCloseButton()
- - public void exitThisMenuNoSound()
- - public void exitThisMenu(bool playSound = true)
- - public virtual void emergencyShutDown()
- - public virtual bool readyToClose()
- - public static void drawTextureBox(SpriteBatch b, int x, int y, int width, int height, Color color)
- - public static void drawTextureBox(SpriteBatch b, Texture2D texture, Rectangle sourceRect, int x, int y, int width, int height, Color color, float scale = 1f, bool drawShadow = true, float draw_layer = -1f)
- - public void drawBorderLabel(SpriteBatch b, string text, SpriteFont font, int x, int y)
- - public static void drawToolTip(SpriteBatch b, string hoverText, string hoverTitle, Item hoveredItem, bool heldItem = false, int healAmountToDisplay = -1, int currencySymbol = 0, string extraItemToShowIndex = null, int extraItemToShowAmount = -1, CraftingRecipe craftingIngredients = null, int moneyAmountToShowAtBottom = -1, IList<Item> additionalCraftMaterials = null)
- - public static void drawHoverText(SpriteBatch b, string text, SpriteFont font, int xOffset = 0, int yOffset = 0, int moneyAmountToDisplayAtBottom = -1, string boldTitleText = null, int healAmountToDisplay = -1, string[] buffIconsToDisplay = null, Item hoveredItem = null, int currencySymbol = 0, string extraItemToShowIndex = null, int extraItemToShowAmount = -1, int overrideX = -1, int overrideY = -1, float alpha = 1f, CraftingRecipe craftingIngredients = null, IList<Item> additional_craft_materials = null, Texture2D boxTexture = null, Rectangle? boxSourceRect = null, Color? textColor = null, Color? textShadowColor = null, float boxScale = 1f, int boxWidthOverride = -1, int boxHeightOverride = -1)
- - public static void drawHoverText(SpriteBatch b, StringBuilder text, SpriteFont font, int xOffset = 0, int yOffset = 0, int moneyAmountToDisplayAtBottom = -1, string boldTitleText = null, int healAmountToDisplay = -1, string[] buffIconsToDisplay = null, Item hoveredItem = null, int currencySymbol = 0, string extraItemToShowIndex = null, int extraItemToShowAmount = -1, int overrideX = -1, int overrideY = -1, float alpha = 1f, CraftingRecipe craftingIngredients = null, IList<Item> additional_craft_materials = null, Texture2D boxTexture = null, Rectangle? boxSourceRect = null, Color? textColor = null, Color? textShadowColor = null, float boxScale = 1f, int boxWidthOverride = -1, int boxHeightOverride = -1)

## Private Members
- *(None)*

## Protected Members
- - protected IClickableMenu _childMenu;
- - protected IClickableMenu _parentMenu;
- - protected string closeSound = "bigDeSelect";
- - protected int _dependencies;
- - protected virtual void noSnappedComponentFound(int direction, int oldRegion, int oldID)
- - protected virtual void customSnapBehavior(int direction, int oldRegion, int oldID)
- - protected virtual bool _ShouldAutoSnapPrioritizeAlignedElements()
- - protected virtual void actionOnRegionChange(int oldRegion, int newRegion)
- - protected virtual void cleanupBeforeExit()
- - protected void drawHorizontalPartition(SpriteBatch b, int yPosition, bool small = false, int red = -1, int green = -1, int blue = -1)
- - protected void drawVerticalPartition(SpriteBatch b, int xPosition, bool small = false, int red = -1, int green = -1, int blue = -1, int heightOverride = -1)
- - protected void drawVerticalIntersectingPartition(SpriteBatch b, int xPosition, int yPosition, int red = -1, int green = -1, int blue = -1)
- - protected void drawVerticalUpperIntersectingPartition(SpriteBatch b, int xPosition, int partitionHeight, int red = -1, int green = -1, int blue = -1)

## Internal Members
- *(None)*

## Other Members
- *(None)*
