# EmoteMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public Texture2D menuBackgroundTexture;
- - public List<string> emotes;
- - public bool _hasSelectedEmote;
- - public bool gamepadMode;
- - public EmoteMenu()
- - public static Rectangle GetEmoteSpriteRect(int emote_index)
- - public static Rectangle GetEmoteNonBubbleSpriteRect(int emote_index)
- - public override void applyMovementKey(int direction)
- - public override void performHoverAction(int x, int y)
- - public override void update(GameTime time)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public void ConfirmSelection()
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected Point _mouseStartPosition;
- - protected List<ClickableTextureComponent> _emoteButtons;
- - protected string _selectedEmote;
- - protected int _selectedIndex = -1;
- - protected int _oldSelection;
- - protected int _selectedTime;
- - protected float _alpha;
- - protected int _menuCloseGracePeriod = -1;
- - protected int _age;
- - protected int _expandTime = 200;
- - protected int _expandedButtonRadius = 24;
- - protected int _buttonRadius;
- - protected void _CreateEmoteButtons()
- - protected override void cleanupBeforeExit()
- - protected void _RepositionButtons()
- - protected void _SnapToPlayerPosition()

## Internal Members
- *(None)*

## Other Members
- *(None)*
