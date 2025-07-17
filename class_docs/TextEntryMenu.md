# TextEntryMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int borderSpace = 4;
- - public const int buttonSize = 16;
- - public const int windowWidth = 168;
- - public const int windowHeight = 88;
- - public string[][] letterMaps = new string[3][]
- - public List<ClickableTextureComponent> keys = new List<ClickableTextureComponent>();
- - public ClickableTextureComponent backspaceButton;
- - public ClickableTextureComponent spaceButton;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent upperCaseButton;
- - public ClickableTextureComponent symbolsButton;
- - public int _currentKeyboard;
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveKeyPress(Keys key)
- - public TextEntryMenu(TextBox target)
- - public override bool readyToClose()
- - public void ShowKeyboard(int index, bool play_sound = true)
- - public override void snapToDefaultClickableComponent()
- - public void RepositionElements()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void performHoverAction(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public void OnSubmit()
- - public void OnSpaceBar()
- - public void OnBackSpace()
- - public void OnLetter(string letter)
- - public void Close()
- - public override void draw(SpriteBatch b)
- - public override void update(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected int _lettersPerRow;
- - protected TextBox _target;

## Internal Members
- *(None)*

## Other Members
- *(None)*
