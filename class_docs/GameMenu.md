# GameMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public static readonly int inventoryTab = 0;
- - public static readonly int skillsTab = 1;
- - public static readonly int socialTab = 2;
- - public static readonly int mapTab = 3;
- - public static readonly int craftingTab = 4;
- - public static readonly int animalsTab = 5;
- - public static readonly int powersTab = 6;
- - public static readonly int collectionsTab = 7;
- - public static readonly int optionsTab = 8;
- - public static readonly int exitTab = 9;
- - public const int region_inventoryTab = 12340;
- - public const int region_skillsTab = 12341;
- - public const int region_socialTab = 12342;
- - public const int region_mapTab = 12343;
- - public const int region_craftingTab = 12344;
- - public const int region_animalsTab = 12345;
- - public const int region_powersTab = 12346;
- - public const int region_collectionsTab = 12347;
- - public const int region_optionsTab = 12348;
- - public const int region_exitTab = 12349;
- - public static readonly int numberOfTabs = 9;
- - public int currentTab;
- - public int lastOpenedNonMapTab = inventoryTab;
- - public string hoverText = "";
- - public string descriptionText = "";
- - public List<ClickableComponent> tabs = new List<ClickableComponent>();
- - public List<IClickableMenu> pages = new List<IClickableMenu>();
- - public bool invisible;
- - public static bool forcePreventClose;
- - public static bool bundleItemHovered;
- - public GameMenu(bool playOpeningSound = true)
- - public void AddTabsToClickableComponents(IClickableMenu menu)
- - public GameMenu(int startingTab, int extra = -1, bool playOpeningSound = true)
- - public override void automaticSnapBehavior(int direction, int oldRegion, int oldID)
- - public override void snapToDefaultClickableComponent()
- - public override void receiveGamePadButton(Buttons button)
- - public override void setUpForGamePadMode()
- - public override ClickableComponent getCurrentlySnappedComponent()
- - public override void setCurrentlySnappedComponentTo(int id)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public static string getLabelOfTabFromIndex(int index)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void receiveScrollWheelAction(int direction)
- - public override void performHoverAction(int x, int y)
- - public int getTabNumberFromName(string name)
- - public override void update(GameTime time)
- - public override void releaseLeftClick(int x, int y)
- - public override void leftClickHeld(int x, int y)
- - public override bool readyToClose()
- - public void changeTab(int whichTab, bool playSound = true)
- - public IClickableMenu GetCurrentPage()
- - public void setTabNeighborsForCurrentPage()
- - public override void draw(SpriteBatch b)
- - public override bool areGamePadControlsImplemented()
- - public override void receiveKeyPress(Keys key)
- - public override void emergencyShutDown()

## Private Members
- - private static readonly Dictionary<int, string> TabTranslationKeys = new Dictionary<int, string>

## Protected Members
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
