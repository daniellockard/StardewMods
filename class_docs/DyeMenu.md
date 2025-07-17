# DyeMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public List<ClickableTextureComponent> dyePots;
- - public ClickableTextureComponent dyeButton;
- - public const int DYE_POT_ID_OFFSET = 5000;
- - public Texture2D dyeTexture;
- - public const int MILLISECONDS_PER_DROP_FRAME = 50;
- - public const int TOTAL_DROP_FRAMES = 10;
- - public string[][] validPotColors = new string[6][]
- - public List<ClickableTextureComponent> dyedClothesDisplays;
- - public DyeMenu()
- - public override void snapToDefaultClickableComponent()
- - public bool IsBusy()
- - public override bool readyToClose()
- - public bool HighlightItems(Item i)
- - public void GenerateHighlightDictionary()
- - public Color GetColorForPot(int index)
- - public int GetPotIndex(Item item)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public bool CanDye()
- - public static bool IsWearingDyeable()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void emergencyShutDown()
- - public override void update(GameTime time)
- - public override void draw(SpriteBatch b)

## Private Members
- - private void _DyePotClicked(ClickableTextureComponent dyePot)

## Protected Members
- - protected int _timeUntilCraft;
- - protected Dictionary<Item, int> _highlightDictionary;
- - protected List<Vector2> _slotDrawPositions;
- - protected int _hoveredPotIndex = -1;
- - protected int[] _dyeDropAnimationFrames;
- - protected string displayedDescription = "";
- - protected Vector2 _dyedClothesDisplayPosition;
- - protected void _CreateButtons()
- - protected void _UpdateDescriptionText()
- - protected override void cleanupBeforeExit()
- - protected void _OnCloseMenu()

## Internal Members
- *(None)*

## Other Members
- *(None)*
