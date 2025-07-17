# OptionsInputListener

**Summary:** Handles player input or controls.

## Public Members
- - public List<string> buttonNames = new List<string>();
- - public static Rectangle setButtonSource = new Rectangle(294, 428, 21, 11);
- - public OptionsInputListener(string label, int whichOption, int slotWidth, int x = -1, int y = -1)
- - public override void receiveLeftClick(int x, int y)
- - public override void receiveKeyPress(Keys key)
- - public override void draw(SpriteBatch b, int slotX, int slotY, IClickableMenu context = null)

## Private Members
- - private string listenerMessage;
- - private bool listening;
- - private Rectangle setbuttonBounds;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
