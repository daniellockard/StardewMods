# ShippingMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_okbutton = 101;
- - public const int region_forwardButton = 102;
- - public const int region_backButton = 103;
- - public const int farming_category = 0;
- - public const int foraging_category = 1;
- - public const int fishing_category = 2;
- - public const int mining_category = 3;
- - public const int other_category = 4;
- - public const int total_category = 5;
- - public const int timePerIntroCategory = 500;
- - public const int outroFadeTime = 800;
- - public const int smokeRate = 100;
- - public const int categorylabelHeight = 25;
- - public int itemsPerCategoryPage = 9;
- - public int currentPage = -1;
- - public int currentTab;
- - public List<ClickableTextureComponent> categories = new List<ClickableTextureComponent>();
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent forwardButton;
- - public ClickableTextureComponent backButton;
- - public TemporaryAnimatedSpriteList animations = new TemporaryAnimatedSpriteList();
- - public bool _activated;
- - public ShippingMenu(IList<Item> items)
- - public void RepositionItems()
- - public override void snapToDefaultClickableComponent()
- - public void parseItems(IList<Item> items)
- - public int getCategoryIndexForObject(Item item)
- - public string getCategoryName(int index)
- - public override void update(GameTime time)
- - public string getCategorySound(int which)
- - public override void applyMovementKey(int direction)
- - public override void performHoverAction(int x, int y)
- - public bool CanReceiveInput()
- - public unsafe override void receiveKeyPress(Keys key)
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public bool showForwardButton()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void draw(SpriteBatch b)

## Private Members
- - private List<int> categoryTotals = new List<int>();
- - private List<MoneyDial> categoryDials = new List<MoneyDial>();
- - private Dictionary<Item, int> itemValues = new Dictionary<Item, int>();
- - private Dictionary<Item, int> singleItemValues = new Dictionary<Item, int>();
- - private List<List<Item>> categoryItems = new List<List<Item>>();
- - private int categoryLabelsWidth;
- - private int plusButtonWidth;
- - private int itemSlotWidth;
- - private int itemAndPlusButtonWidth;
- - private int totalWidth;
- - private int centerX;
- - private int centerY;
- - private int introTimer = 3500;
- - private int outroFadeTimer;
- - private int outroPauseBeforeDateChange;
- - private int finalOutroTimer;
- - private int smokeTimer;
- - private int dayPlaqueY;
- - private int moonShake = -1;
- - private int timesPokedMoon;
- - private float weatherX;
- - private bool outro;
- - private bool newDayPlaque;
- - private bool savedYet;
- - private SaveGameMenu saveGameMenu;
- - private bool wasGreenRain;
- - private void okClicked()

## Protected Members
- - protected bool _hasFinished;
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)

## Internal Members
- *(None)*

## Other Members
- *(None)*
