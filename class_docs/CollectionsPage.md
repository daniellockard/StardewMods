# CollectionsPage

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int region_sideTabShipped = 7001;
- - public const int region_sideTabFish = 7002;
- - public const int region_sideTabArtifacts = 7003;
- - public const int region_sideTabMinerals = 7004;
- - public const int region_sideTabCooking = 7005;
- - public const int region_sideTabAchivements = 7006;
- - public const int region_sideTabSecretNotes = 7007;
- - public const int region_sideTabLetters = 7008;
- - public const int region_forwardButton = 707;
- - public const int region_backButton = 706;
- - public static int widthToMoveActiveTab = 8;
- - public const int organicsTab = 0;
- - public const int fishTab = 1;
- - public const int archaeologyTab = 2;
- - public const int mineralsTab = 3;
- - public const int cookingTab = 4;
- - public const int achievementsTab = 5;
- - public const int secretNotesTab = 6;
- - public const int lettersTab = 7;
- - public const int distanceFromMenuBottomBeforeNewPage = 128;
- - public ClickableTextureComponent backButton;
- - public ClickableTextureComponent forwardButton;
- - public Dictionary<int, ClickableTextureComponent> sideTabs = new Dictionary<int, ClickableTextureComponent>();
- - public int currentTab;
- - public int currentPage;
- - public int secretNoteImage = -1;
- - public Dictionary<int, List<List<ClickableTextureComponent>>> collections = new Dictionary<int, List<List<ClickableTextureComponent>>>();
- - public Dictionary<int, string> secretNotesData;
- - public Texture2D secretNoteImageTexture;
- - public LetterViewerMenu letterviewerSubMenu;
- - public CollectionsPage(int x, int y, int width, int height)
- - public override void snapToDefaultClickableComponent()
- - public void postWindowSizeChange(IClickableMenu oldPage)
- - public override bool readyToClose()
- - public override void update(GameTime time)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override bool shouldDrawCloseButton()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void applyMovementKey(int direction)
- - public override void gamePadButtonHeld(Buttons b)
- - public override void receiveGamePadButton(Buttons button)
- - public override void performHoverAction(int x, int y)
- - public string createDescription(string id)
- - public override void draw(SpriteBatch b)

## Private Members
- - private string hoverText = "";
- - private Item hoverItem;
- - private CraftingRecipe hoverCraftingRecipe;
- - private int value;
- - private bool farmerHasAchievements(string listOfAchievementNumbers)

## Protected Members
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)

## Internal Members
- *(None)*

## Other Members
- *(None)*
