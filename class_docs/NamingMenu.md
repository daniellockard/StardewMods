# NamingMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public delegate void doneNamingBehavior(string s);
- - public const int region_okButton = 101;
- - public const int region_doneNamingButton = 102;
- - public const int region_randomButton = 103;
- - public const int region_namingBox = 104;
- - public ClickableTextureComponent doneNamingButton;
- - public ClickableTextureComponent randomButton;
- - public TextBox textBox;
- - public ClickableComponent textBoxCC;
- - public doneNamingBehavior doneNaming;
- - public string title;
- - public int minLength = 1;
- - public bool FilterInput = true;
- - public NamingMenu(doneNamingBehavior b, string title, string defaultName = null)
- - public override void snapToDefaultClickableComponent()
- - public void textBoxEnter(TextBox sender)
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveKeyPress(Keys key)
- - public override void performHoverAction(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
