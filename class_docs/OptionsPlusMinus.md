# OptionsPlusMinus

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int pixelsWide = 7;
- - public List<string> options = new List<string>();
- - public List<string> displayOptions = new List<string>();
- - public int selected;
- - public bool isChecked;
- - public static bool snapZoomPlus;
- - public static bool snapZoomMinus;
- - public Rectangle minusButton;
- - public Rectangle plusButton;
- - public static Rectangle minusButtonSource = new Rectangle(177, 345, 7, 8);
- - public static Rectangle plusButtonSource = new Rectangle(184, 345, 7, 8);
- - public OptionsPlusMinus(string label, int whichOption, List<string> options, List<string> displayOptions, int x = -1, int y = -1)
- - public override void receiveLeftClick(int x, int y)
- - public override void receiveKeyPress(Keys key)
- - public override void draw(SpriteBatch b, int slotX, int slotY, IClickableMenu context = null)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
