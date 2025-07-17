# LevelUpMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_okButton = 101;
- - public const int region_leftProfession = 102;
- - public const int region_rightProfession = 103;
- - public const int basewidth = 768;
- - public const int baseheight = 512;
- - public bool informationUp;
- - public bool isActive;
- - public bool isProfessionChooser;
- - public bool hasUpdatedProfessions;
- - public ClickableTextureComponent starIcon;
- - public ClickableTextureComponent okButton;
- - public ClickableComponent leftProfession;
- - public ClickableComponent rightProfession;
- - public bool hasMovedSelection;
- - public LevelUpMenu()
- - public LevelUpMenu(int skill, int level)
- - public bool CanReceiveInput()
- - public override void snapToDefaultClickableComponent()
- - public override void applyMovementKey(int direction)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public virtual void RepositionOkButton()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public List<string> getExtraInfoForLevel(int whichSkill, int whichLevel)
- - public static List<string> getProfessionDescription(int whichProfession)
- - public static string getProfessionTitleFromNumber(int whichProfession)
- - public override void performHoverAction(int x, int y)
- - public override void receiveGamePadButton(Buttons button)
- - public static void AddMissedProfessionChoices(Farmer farmer)
- - public static void removeImmediateProfessionPerk(int whichProfession)
- - public void getImmediateProfessionPerk(int whichProfession)
- - public static void RevalidateHealth(Farmer farmer)
- - public override void update(GameTime time)
- - public void okButtonClicked()
- - public virtual void RemoveLevelFromLevelList()
- - public override void receiveKeyPress(Keys key)
- - public void getLevelPerk(int skill, int level)
- - public override void draw(SpriteBatch b)

## Private Members
- - private int currentLevel;
- - private int currentSkill;
- - private int timerBeforeStart;
- - private Color leftProfessionColor = Game1.textColor;
- - private Color rightProfessionColor = Game1.textColor;
- - private MouseState oldMouseState;
- - private List<CraftingRecipe> newCraftingRecipes = new List<CraftingRecipe>();
- - private List<string> extraInfoForLevel = new List<string>();
- - private List<string> leftProfessionDescription = new List<string>();
- - private List<string> rightProfessionDescription = new List<string>();
- - private Rectangle sourceRectForLevelIcon;
- - private string title;
- - private List<int> professionsToChoose = new List<int>();
- - private TemporaryAnimatedSpriteList littleStars = new TemporaryAnimatedSpriteList();
- - private static void addProfessionDescriptions(List<string> descriptions, string professionName)
- - private static string getProfessionName(int whichProfession)

## Protected Members
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
