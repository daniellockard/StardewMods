# LobbyUpdateCallback

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public LobbyUpdateCallback(Action<object> callback)
- - public void OnLobbyUpdate(object lobby)
- - public const int region_refresh = 810;
- - public const int region_joinTab = 811;
- - public const int region_hostTab = 812;
- - public const int region_tabs = 1000;
- - public ClickableComponent refreshButton;
- - public ClickableComponent joinTab;
- - public ClickableComponent hostTab;
- - public Tab currentTab;
- - public bool tooManyFarms;
- - public static string lastEnteredInviteCode;
- - public override List<MenuSlot> MenuSlots
- - public CoopMenu(bool tooManyFarms, bool splitScreen = false, Tab initialTab = Tab.JOIN_TAB, string filter = null)
- - public override bool readyToClose()
- - public override void receiveGamePadButton(Buttons button)
- - public override void UpdateButtons()
- - public override void update(GameTime time)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public virtual void SetTab(Tab newTab, bool playSound = true)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void snapToDefaultClickableComponent()

## Private Members
- - private Action<object> callback;
- - private LobbyUpdateListener lobbyUpdateListener;
- - private bool smallScreenFormat;
- - private bool isSetUp;
- - private int updateCounter;
- - private string Filter;
- - private float _refreshDelay = -1f;
- - private readonly bool _splitScreen;
- - private StringBuilder _stringBuilder = new StringBuilder();
- - private void enterIPPressed()
- - private void enterInviteCodePressed()
- - private bool tabClick(int x, int y)
- - private void drawTabs(SpriteBatch b)

## Protected Members
- - protected List<MenuSlot> hostSlots = new List<MenuSlot>();
- - protected override bool hasDeleteButtons()
- - protected override void startListPopulation(string filter)
- - protected virtual void connectionFinished()
- - protected override void saveFileScanComplete()
- - protected virtual FriendFarmData readLobbyFarmData(object lobby)
- - protected virtual bool checkFriendFarmCompatibility(FriendFarmData farm)
- - protected virtual void onLobbyUpdate(object lobby)
- - protected override void addSaveFiles(List<Farmer> files)
- - protected virtual void setMenu(IClickableMenu menu)
- - protected override string getStatusText()
- - protected override void drawBefore(SpriteBatch b)
- - protected override void drawExtra(SpriteBatch b)
- - protected override void drawStatusText(SpriteBatch b)
- - protected override void Dispose(bool disposing)

## Internal Members
- *(None)*

## Other Members
- *(None)*
