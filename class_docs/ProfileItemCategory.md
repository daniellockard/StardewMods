# ProfileItemCategory

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public string categoryName;
- - public int[] validCategories;
- - public ProfileItemCategory(string name, int[] valid_categories)
- - public const int region_characterSelectors = 500;
- - public const int region_categorySelector = 501;
- - public const int region_itemButtons = 502;
- - public const int region_backButton = 101;
- - public const int region_forwardButton = 102;
- - public const int region_upArrow = 105;
- - public const int region_downArrow = 106;
- - public const int letterWidth = 320;
- - public const int letterHeight = 180;
- - public Texture2D letterTexture;
- - public Item hoveredItem;
- - public ClickableTextureComponent backButton;
- - public ClickableTextureComponent forwardButton;
- - public ClickableTextureComponent nextCharacterButton;
- - public ClickableTextureComponent previousCharacterButton;
- - public ClickableTextureComponent upArrow;
- - public ClickableTextureComponent downArrow;
- - public List<ClickableComponent> clickableProfileItems;
- - public SocialPage.SocialEntry Current;
- - public readonly List<SocialPage.SocialEntry> SocialEntries = new List<SocialPage.SocialEntry>();
- - public Rectangle _itemDisplayRect;
- - public static ProfileItemCategory[] itemCategories = new ProfileItemCategory[10]
- - public bool scrolling;
- - public ProfileMenu(SocialPage.SocialEntry subject, List<SocialPage.SocialEntry> allSocialEntries)
- - public void ChangeCharacter(int offset)
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public override void snapToDefaultClickableComponent()
- - public void UpdateButtons()
- - public override void receiveScrollWheelAction(int direction)
- - public void ChangePage(int offset)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveKeyPress(Keys key)
- - public override void applyMovementKey(int direction)
- - public override void releaseLeftClick(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public void PlayHiddenEmote()
- - public override void performHoverAction(int x, int y)
- - public void ConstrainSelectionToView()
- - public override void update(GameTime time)
- - public void SetupLayout()
- - public override void leftClickHeld(int x, int y)
- - public bool NeedsScrollBar()
- - public void Scroll(int offset)
- - public virtual void UpdateScroll()
- - public override void draw(SpriteBatch b)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public void RegisterClickable(ClickableComponent clickable)
- - public void UnregisterClickable(ClickableComponent clickable)

## Private Members
- - private int _characterSpriteRandomInt;
- - private void drawNPCSlotHeart(SpriteBatch b, float heartDrawStartX, float heartDrawStartY, SocialPage.SocialEntry entry, int hearts, bool isDating, bool isCurrentSpouse)

## Protected Members
- - protected string hoverText = "";
- - protected List<ProfileItem> _profileItems;
- - protected Rectangle characterSpriteBox;
- - protected int _currentCategory;
- - protected AnimatedSprite _animatedSprite;
- - protected float _directionChangeTimer;
- - protected float _hiddenEmoteTimer = -1f;
- - protected int _currentDirection;
- - protected int _hideTooltipTime;
- - protected SocialPage _socialPage;
- - protected string _status = "";
- - protected string _printedName = "";
- - protected Vector2 _characterEntrancePosition = new Vector2(0f, 0f);
- - protected ClickableTextureComponent scrollBar;
- - protected Rectangle scrollBarRunner;
- - protected Vector2 _characterNamePosition;
- - protected Vector2 _heartDisplayPosition;
- - protected Vector2 _birthdayHeadingDisplayPosition;
- - protected Vector2 _birthdayDisplayPosition;
- - protected Vector2 _statusHeadingDisplayPosition;
- - protected Vector2 _statusDisplayPosition;
- - protected Vector2 _giftLogHeadingDisplayPosition;
- - protected Vector2 _giftLogCategoryDisplayPosition;
- - protected Vector2 _errorMessagePosition;
- - protected Vector2 _characterSpriteDrawPosition;
- - protected Rectangle _characterStatusDisplayBox;
- - protected List<ClickableTextureComponent> _clickableTextureComponents;
- - protected int scrollPosition;
- - protected int scrollStep = 36;
- - protected int scrollSize;
- - protected Dictionary<int, List<Item>> _sortedItems;
- - protected void _SetCharacter(SocialPage.SocialEntry entry)
- - protected void _UpdateList()

## Internal Members
- *(None)*

## Other Members
- *(None)*
