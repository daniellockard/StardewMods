# DiscreteColorPicker

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int sizeOfEachSwatch = 7;
- - public Item itemToDrawColored;
- - public bool visible = true;
- - public static int totalColors = 21;
- - public int colorSelection;
- - public DiscreteColorPicker(int xPosition, int yPosition, int startingColor = 0, Item itemToDrawColored = null)
- - public DiscreteColorPicker(int xPosition, int yPosition, Color startingColor, Item itemToDrawColored = null)
- - public static int getSelectionFromColor(Color c)
- - public Color getCurrentColor()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public static Color getColorFromSelection(int selection)
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
