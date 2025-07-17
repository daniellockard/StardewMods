# JojaCDMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public new const int width = 1280;
- - public new const int height = 576;
- - public const int buttonWidth = 147;
- - public const int buttonHeight = 30;
- - public List<ClickableComponent> checkboxes = new List<ClickableComponent>();
- - public JojaCDMenu(Texture2D noteTexture)
- - public override void snapToDefaultClickableComponent()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void update(GameTime time)
- - public int getPriceFromButtonNumber(int buttonNumber)
- - public string getDescriptionFromButtonNumber(int buttonNumber)
- - public override void performHoverAction(int x, int y)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void draw(SpriteBatch b)

## Private Members
- - private Texture2D noteTexture;
- - private string hoverText;
- - private bool boughtSomething;
- - private int exitTimer = -1;
- - private void onExitFunction()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
