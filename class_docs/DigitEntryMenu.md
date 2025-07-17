# DigitEntryMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public List<ClickableComponent> digits = new List<ClickableComponent>();
- - public DigitEntryMenu(string message, behaviorOnNumberSelect behaviorOnSelection, int price = -1, int minValue = 0, int maxValue = 99, int defaultNumber = 0)
- - public override bool isWithinBounds(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private int calculatorX;
- - private int calculatorY;
- - private int calculatorWidth;
- - private int calculatorHeight;
- - private static string clear = "c";
- - private void onDigitPressed(string digit)

## Protected Members
- - protected override Vector2 centerPosition => new Vector2((float)(((Rectangle)(ref Game1.uiViewport)).Width / 2), (float)(((Rectangle)(ref Game1.uiViewport)).Height / 2 + 128));

## Internal Members
- *(None)*

## Other Members
- *(None)*
