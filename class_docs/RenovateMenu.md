# RenovateMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_okButton = 101;
- - public const int region_randomButton = 103;
- - public static int menuHeight = 320;
- - public static int menuWidth = 448;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent hovered;
- - public RenovateMenu(HouseRenovation renovation)
- - public override bool shouldClampGamePadCursor()
- - public override void snapToDefaultClickableComponent()
- - public void SetupForReturn()
- - public void FinalizeReturn()
- - public void SetupForRenovationPlacement()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public virtual void AnimateRenovation()
- - public virtual void CompleteRenovation(int selected_index)
- - public override bool overrideSnappyMenuCursorMovementBan()
- - public override void receiveGamePadButton(Buttons button)
- - public override bool readyToClose()
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private bool freeze;

## Protected Members
- - protected HouseRenovation _renovation;
- - protected string _oldLocation;
- - protected Point _oldPosition;
- - protected int _selectedIndex = -1;
- - protected int _animatingIndex = -1;
- - protected int _buildAnimationTimer;
- - protected int _buildAnimationCount;

## Internal Members
- *(None)*

## Other Members
- *(None)*
