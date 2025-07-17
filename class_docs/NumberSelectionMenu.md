# NumberSelectionMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public delegate void behaviorOnNumberSelect(int number, int price, Farmer who);
- - public const int region_leftButton = 101;
- - public const int region_rightButton = 102;
- - public const int region_okButton = 103;
- - public const int region_cancelButton = 104;
- - public ClickableTextureComponent leftButton;
- - public ClickableTextureComponent rightButton;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent cancelButton;
- - public NumberSelectionMenu(string message, behaviorOnNumberSelect behaviorOnSelection, int price = -1, int minValue = 0, int maxValue = 99, int defaultNumber = 0)
- - public override void snapToDefaultClickableComponent()
- - public override void gamePadButtonHeld(Buttons b)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public override void receiveRightClick(int x, int y, bool playSound = true)

## Private Members
- - private string message;
- - private behaviorOnNumberSelect behaviorFunction;

## Protected Members
- - protected int price;
- - protected int minValue;
- - protected int maxValue;
- - protected int currentValue;
- - protected int priceShake;
- - protected int heldTimer;
- - protected TextBox numberSelectedBox;
- - protected virtual Vector2 centerPosition => new Vector2((float)(((Rectangle)(ref Game1.uiViewport)).Width / 2), (float)(((Rectangle)(ref Game1.uiViewport)).Height / 2));

## Internal Members
- *(None)*

## Other Members
- *(None)*
