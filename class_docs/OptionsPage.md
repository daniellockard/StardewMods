# OptionsPage

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int itemsPerPage = 7;
- - public List<ClickableComponent> optionSlots = new List<ClickableComponent>();
- - public int currentItemIndex;
- - public List<OptionsElement> options = new List<OptionsElement>();
- - public int lastRebindTick = -1;
- - public OptionsPage(int x, int y, int width, int height)
- - public override bool readyToClose()
- - public override void snapToDefaultClickableComponent()
- - public override void applyMovementKey(int direction)
- - public override void snapCursorToCurrentSnappedComponent()
- - public override void leftClickHeld(int x, int y)
- - public override void setCurrentlySnappedComponentTo(int id)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveScrollWheelAction(int direction)
- - public override void releaseLeftClick(int x, int y)
- - public bool IsDropdownActive()
- - public virtual void UnsubscribeFromSelectedTextbox()
- - public void postWindowSizeChange(IClickableMenu oldPage)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private string hoverText = "";
- - private ClickableTextureComponent upArrow;
- - private ClickableTextureComponent downArrow;
- - private ClickableTextureComponent scrollBar;
- - private bool scrolling;
- - private Rectangle scrollBarRunner;
- - private int optionsSlotHeld = -1;
- - private void waitForServerConnection(Action onConnection)
- - private void offerInvite()
- - private void showInviteCode()
- - private void setScrollBarToCurrentIndex()
- - private void downArrowPressed()
- - private void upArrowPressed()

## Protected Members
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)

## Internal Members
- - internal static int _lastSelectedIndex;
- - internal static int _lastCurrentItemIndex;

## Other Members
- *(None)*
