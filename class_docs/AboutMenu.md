# AboutMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_upArrow = 94444;
- - public const int region_downArrow = 95555;
- - public new const int height = 700;
- - public ClickableComponent backButton;
- - public ClickableTextureComponent upButton;
- - public ClickableTextureComponent downButton;
- - public List<ICreditsBlock> credits = new List<ICreditsBlock>();
- - public AboutMenu()
- - public void SetUpCredits()
- - public override void snapToDefaultClickableComponent()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void update(GameTime time)
- - public override void receiveScrollWheelAction(int direction)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)

## Private Members
- - private int currentCreditsIndex;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
