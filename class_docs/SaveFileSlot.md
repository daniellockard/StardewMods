# SaveFileSlot

**Summary:** Handles saving or loading game data.

## Public Members
- - public Farmer Farmer;
- - public int? SlotNumber;
- - public double redTimer;
- - public int versionComparison;
- - public SaveFileSlot(LoadGameMenu menu, Farmer farmer, int? slotNumber)
- - public override void Activate()
- - public virtual float getSlotAlpha()
- - public virtual void drawVersionMismatchSlot(SpriteBatch b, int i)
- - public override void Draw(SpriteBatch b, int i)
- - public new void Dispose()
- - public const int region_upArrow = 800;
- - public const int region_downArrow = 801;
- - public const int region_okDelete = 802;
- - public const int region_cancelDelete = 803;
- - public const int region_slots = 900;
- - public const int region_deleteButtons = 901;
- - public const int region_navigationButtons = 902;
- - public const int region_deleteConfirmations = 903;
- - public const int itemsPerPage = 4;
- - public List<ClickableComponent> slotButtons = new List<ClickableComponent>();
- - public List<ClickableTextureComponent> deleteButtons = new List<ClickableTextureComponent>();
- - public int currentItemIndex;
- - public int timerToLoad;
- - public int selected = -1;
- - public int selectedForDelete = -1;
- - public ClickableTextureComponent upArrow;
- - public ClickableTextureComponent downArrow;
- - public ClickableTextureComponent scrollBar;
- - public ClickableTextureComponent okDeleteButton;
- - public ClickableTextureComponent cancelDeleteButton;
- - public ClickableComponent backButton;
- - public bool scrolling;
- - public bool deleteConfirmationScreen;
- - public bool loading;
- - public bool drawn;
- - public bool deleting;
- - public virtual List<MenuSlot> MenuSlots
- - public bool IsDoingTask()
- - public override bool readyToClose()
- - public LoadGameMenu(string filter = null)
- - public virtual void UpdateButtons()
- - public override void receiveGamePadButton(Buttons button)
- - public override void snapToDefaultClickableComponent()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void performHoverAction(int x, int y)
- - public override void leftClickHeld(int x, int y)
- - public override void releaseLeftClick(int x, int y)
- - public override void receiveScrollWheelAction(int direction)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void update(GameTime time)
- - public override void draw(SpriteBatch b)
- - public void Dispose()
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)

## Private Members
- - private Rectangle scrollBarRunner;
- - private int _updatesSinceLastDeleteConfirmScreen;
- - private Task<List<Farmer>> _initTask;
- - private Task _deleteTask;
- - private bool disposedValue;
- - private static List<Farmer> FindSaveGames(string filter)
- - private void downArrowPressed()
- - private void upArrowPressed()
- - private void deleteFile(int which)
- - private static void LogFsio(string format, params object[] args)

## Protected Members
- - protected virtual void drawSlotSaveNumber(SpriteBatch b, int i)
- - protected virtual string slotName()
- - protected virtual void drawSlotName(SpriteBatch b, int i)
- - protected virtual void drawSlotShadow(SpriteBatch b, int i)
- - protected virtual Vector2 portraitOffset()
- - protected virtual void drawSlotFarmer(SpriteBatch b, int i)
- - protected virtual void drawSlotDate(SpriteBatch b, int i)
- - protected virtual string slotSubName()
- - protected virtual void drawSlotSubName(SpriteBatch b, int i)
- - protected virtual void drawSlotMoney(SpriteBatch b, int i)
- - protected virtual void drawSlotTimer(SpriteBatch b, int i)
- - protected const int CenterOffset = 0;
- - protected List<MenuSlot> menuSlots = new List<MenuSlot>();
- - protected string hoverText = "";
- - protected virtual bool hasDeleteButtons()
- - protected virtual void startListPopulation(string filter)
- - protected virtual void addSaveFiles(List<Farmer> files)
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
- - protected void setScrollBarToCurrentIndex()
- - protected virtual void saveFileScanComplete()
- - protected virtual bool checkListPopulation()
- - protected virtual string getStatusText()
- - protected virtual void drawExtra(SpriteBatch b)
- - protected virtual void drawSlotBackground(SpriteBatch b, int i, MenuSlot slot)
- - protected virtual void drawBefore(SpriteBatch b)
- - protected virtual void drawStatusText(SpriteBatch b)
- - protected virtual void Dispose(bool disposing)
- - protected override bool _ShouldAutoSnapPrioritizeAlignedElements()

## Internal Members
- *(None)*

## Other Members
- - static TData TryReadFile<TData>(string path, out Exception reference, Func<Stream, TData> load)
