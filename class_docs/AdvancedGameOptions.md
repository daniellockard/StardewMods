# AdvancedGameOptions

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int itemsPerPage = 7;
- - public List<ClickableComponent> optionSlots = new List<ClickableComponent>();
- - public int currentItemIndex;
- - public ClickableTextureComponent okButton;
- - public List<Action> applySettingCallbacks = new List<Action>();
- - public Dictionary<OptionsElement, string> tooltips = new Dictionary<OptionsElement, string>();
- - public int ID_okButton = 10000;
- - public List<OptionsElement> options = new List<OptionsElement>();
- - public const int WINDOW_WIDTH = 800;
- - public const int WINDOW_HEIGHT = 500;
- - public bool initialMonsterSpawnAtValue;
- - public AdvancedGameOptions()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public virtual void PopulateOptions()
- - public virtual void CloseAndApply()
- - public virtual void AddHeader(string label)
- - public virtual void AddTextEntry(string label, string tooltip, bool labelOnSeparateLine, Func<string> get, Action<string> set, Action<OptionsTextEntry> configure = null)
- - public virtual void AddDropdown<T>(string label, string tooltip, bool labelOnSeparateLine, Func<T> get, Action<T> set, params KeyValuePair<string, T>[] dropdown_options)
- - public virtual void AddCheckbox(string label, string tooltip, Func<bool> get, Action<bool> set)
- - public override bool readyToClose()
- - public override void snapToDefaultClickableComponent()
- - public override void applyMovementKey(int direction)
- - public override void snapCursorToCurrentSnappedComponent()
- - public virtual void SetScrollFromY(int y)
- - public override void leftClickHeld(int x, int y)
- - public override void setCurrentlySnappedComponentTo(int id)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveScrollWheelAction(int direction)
- - public override void releaseLeftClick(int x, int y)
- - public bool IsDropdownActive()
- - public virtual void UnsubscribeFromSelectedTextbox()
- - public void preWindowSizeChange()
- - public void postWindowSizeChange()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private string hoverText = "";
- - private ClickableTextureComponent upArrow;
- - private ClickableTextureComponent downArrow;
- - private ClickableTextureComponent scrollBar;
- - private bool scrolling;
- - private Rectangle scrollBarBounds;
- - private int optionsSlotHeld = -1;
- - private void ResetComponents()
- - private void setScrollBarToCurrentIndex()
- - private void downArrowPressed()
- - private void upArrowPressed()

## Protected Members
- - protected static int _lastSelectedIndex;
- - protected static int _lastCurrentItemIndex;
- - protected int _lastHoveredIndex;
- - protected int _hoverDuration;
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)

## Internal Members
- *(None)*

## Other Members
- *(None)*
