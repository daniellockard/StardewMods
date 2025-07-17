# JunimoNoteMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_ingredientSlotModifier = 250;
- - public const int region_ingredientListModifier = 1000;
- - public const int region_bundleModifier = 5000;
- - public const int region_areaNextButton = 101;
- - public const int region_areaBackButton = 102;
- - public const int region_backButton = 103;
- - public const int region_purchaseButton = 104;
- - public const int region_presentButton = 105;
- - public const string noteTextureName = "LooseSprites\\JunimoNote";
- - public Texture2D noteTexture;
- - public bool specificBundlePage;
- - public const int baseWidth = 320;
- - public const int baseHeight = 180;
- - public InventoryMenu inventory;
- - public Item partialDonationItem;
- - public List<Item> partialDonationComponents = new List<Item>();
- - public BundleIngredientDescription? currentPartialIngredientDescription;
- - public int currentPartialIngredientDescriptionIndex = -1;
- - public Item heldItem;
- - public Item hoveredItem;
- - public static bool canClick = true;
- - public int whichArea;
- - public int gameMenuTabToReturnTo = -1;
- - public IClickableMenu menuToReturnTo;
- - public bool bundlesChanged;
- - public static ScreenSwipe screenSwipe;
- - public static string hoverText = "";
- - public List<Bundle> bundles = new List<Bundle>();
- - public static TemporaryAnimatedSpriteList tempSprites = new TemporaryAnimatedSpriteList();
- - public List<ClickableTextureComponent> ingredientSlots = new List<ClickableTextureComponent>();
- - public List<ClickableTextureComponent> ingredientList = new List<ClickableTextureComponent>();
- - public bool fromGameMenu;
- - public bool fromThisMenu;
- - public bool scrambledText;
- - public ClickableTextureComponent backButton;
- - public ClickableTextureComponent purchaseButton;
- - public ClickableTextureComponent areaNextButton;
- - public ClickableTextureComponent areaBackButton;
- - public ClickableAnimatedComponent presentButton;
- - public Action<int> onIngredientDeposit;
- - public Action<JunimoNoteMenu> onBundleComplete;
- - public Action<JunimoNoteMenu> onScreenSwipeFinished;
- - public Bundle currentPageBundle;
- - public JunimoNoteMenu(bool fromGameMenu, int area = 1, bool fromThisMenu = false)
- - public JunimoNoteMenu(int whichArea, Dictionary<int, bool[]> bundlesComplete)
- - public JunimoNoteMenu(Bundle b, string noteTexturePath)
- - public override void snapToDefaultClickableComponent()
- - public void setUpMenu(int whichArea, Dictionary<int, bool[]> bundlesComplete)
- - public virtual bool HighlightObjects(Item item)
- - public override bool readyToClose()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public virtual void ReturnPartialDonation(Item item, bool play_sound = true)
- - public virtual void ReturnPartialDonations(bool to_hand = true)
- - public virtual void ResetPartialDonation()
- - public virtual bool CanBePartiallyOrFullyDonated(Item item)
- - public virtual void HandlePartialDonation(Item item, ClickableTextureComponent slot)
- - public bool isReadyToCloseMenuOrBundle()
- - public override void receiveGamePadButton(Buttons button)
- - public void SwapPage(int direction)
- - public override void receiveKeyPress(Keys key)
- - public static string GetRepresentativeItemId(BundleIngredientDescription ingredient)
- - public static void GetBundleRewards(int area, List<Item> rewards)
- - public void checkForRewards()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void update(GameTime time)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public string getRewardNameForArea(int whichArea)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public void takeDownBundleSpecificPage()

## Private Members
- - private bool singleBundleMenu;
- - private int oldTriggerSpot;
- - private void closeBundlePage()
- - private void reOpenThisMenu()
- - private void updateIngredientSlots()
- - private void openRewardsMenu()
- - private void rewardGrabbed(Item item, Farmer who)
- - private void checkIfBundleIsComplete()
- - private void restoreaAreaOnExit_AbandonedJojaMart()
- - private void restoreAreaOnExit()
- - private void setUpBundleSpecificPage(Bundle b)
- - private void addRectangleRowsToList(List<Rectangle> toAddTo, int numberOfItems, int centerX, int centerY)
- - private List<Rectangle> createRowOfBoxesCenteredAt(int xStart, int yStart, int numBoxes, int boxWidth, int boxHeight, int horizontalGap)
- - private Point getBundleLocationFromNumber(int whichBundle)

## Protected Members
- - protected override bool _ShouldAutoSnapPrioritizeAlignedElements()
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
