# OptionsDropDown

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int pixelsHigh = 11;
- - public static OptionsDropDown selected;
- - public List<string> dropDownOptions = new List<string>();
- - public List<string> dropDownDisplayOptions = new List<string>();
- - public int selectedOption;
- - public int recentSlotY;
- - public int startingSelected;
- - public Rectangle dropDownBounds;
- - public static Rectangle dropDownBGSource = new Rectangle(433, 451, 3, 3);
- - public static Rectangle dropDownButtonSource = new Rectangle(437, 450, 10, 11);
- - public OptionsDropDown(string label, int whichOption, int x = -1, int y = -1)
- - public virtual void RecalculateBounds()
- - public override void leftClickHeld(int x, int y)
- - public override void receiveLeftClick(int x, int y)
- - public override void leftClickReleased(int x, int y)
- - public override void receiveKeyPress(Keys key)
- - public override void draw(SpriteBatch b, int slotX, int slotY, IClickableMenu context = null)

## Private Members
- - private bool clicked;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
