# OptionsElement

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum Style
- - public const int defaultX = 8;
- - public const int defaultY = 4;
- - public const int defaultPixelWidth = 9;
- - public Rectangle bounds;
- - public string label;
- - public int whichOption;
- - public bool greyedOut;
- - public Vector2 labelOffset = Vector2.Zero;
- - public Style style;
- - public string ScreenReaderText { get; set; }
- - public string ScreenReaderDescription { get; set; }
- - public bool ScreenReaderIgnore { get; set; }
- - public OptionsElement(string label)
- - public OptionsElement(string label, int x, int y, int width, int height, int whichOption = -1)
- - public OptionsElement(string label, Rectangle bounds, int whichOption)
- - public virtual void receiveLeftClick(int x, int y)
- - public virtual void leftClickHeld(int x, int y)
- - public virtual void leftClickReleased(int x, int y)
- - public virtual void receiveKeyPress(Keys key)
- - public virtual void draw(SpriteBatch b, int slotX, int slotY, IClickableMenu context = null)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
