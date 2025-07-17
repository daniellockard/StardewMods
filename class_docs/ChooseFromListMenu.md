# ChooseFromListMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public delegate void actionOnChoosingListOption(string s);
- - public const int region_backButton = 101;
- - public const int region_forwardButton = 102;
- - public const int region_okButton = 103;
- - public const int region_cancelButton = 104;
- - public const int w = 640;
- - public const int h = 192;
- - public ClickableTextureComponent backButton;
- - public ClickableTextureComponent forwardButton;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent cancelButton;
- - public ChooseFromListMenu(List<string> options, actionOnChoosingListOption chooseAction, bool isJukebox = false, string default_selection = null)
- - public override void snapToDefaultClickableComponent()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public static void playSongAction(string s)
- - public override void performHoverAction(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void draw(SpriteBatch b)

## Private Members
- - private List<string> options = new List<string>();
- - private int index;
- - private actionOnChoosingListOption chooseAction;
- - private bool isJukebox;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
