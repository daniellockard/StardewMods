# ChooseFromIconsMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public List<ClickableTextureComponent> icons = new List<ClickableTextureComponent>();
- - public List<ClickableTextureComponent> iconFronts = new List<ClickableTextureComponent>();
- - public Object sourceObject;
- - public ChooseFromIconsMenu(string which)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public void setUpIcons(string which)
- - public override void update(GameTime time)
- - public override void performHoverAction(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void draw(SpriteBatch b)

## Private Members
- - private Rectangle iconBackRectangle;
- - private Texture2D texture;
- - private Point iconBackHighlightPosition;
- - private Point iconFrontHighlightPositionOffset;
- - private string which;
- - private int iconXOffset;
- - private int maxTooltipHeight;
- - private int maxTooltipWidth;
- - private float destroyTimer = -1f;
- - private List<TemporaryAnimatedSprite> temporarySprites = new List<TemporaryAnimatedSprite>();
- - private bool hasTooltips = true;
- - private string title;
- - private string hoverSound;
- - private int titleStyle = 3;
- - private int selected = -1;
- - private void doIconAction(string iconName)
- - private void flairOnDestroy()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
