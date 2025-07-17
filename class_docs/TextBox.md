# TextBox

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool numbersOnly;
- - public int textLimit = -1;
- - public bool limitWidth = true;
- - public SpriteFont Font => _font;
- - public Color TextColor => _textColor;
- - public int X { get; set; }
- - public int Y { get; set; }
- - public int Width { get; set; }
- - public int Height { get; set; }
- - public bool PasswordBox { get; set; }
- - public string Text
- - public string TitleText { get; set; }
- - public bool Selected
- - public event TextBoxEvent OnEnterPressed;
- - public event TextBoxEvent OnTabPressed;
- - public event TextBoxEvent OnBackspacePressed;
- - public TextBox(Texture2D textBoxTexture, Texture2D caretTexture, SpriteFont font, Color textColor)
- - public void SelectMe()
- - public void Update()
- - public virtual void Draw(SpriteBatch spriteBatch, bool drawShadow = true)
- - public virtual void RecieveTextInput(char inputChar)
- - public virtual void RecieveTextInput(string text)
- - public virtual void RecieveCommandInput(char command)
- - public void RecieveSpecialInput(Keys key)
- - public void Hover(int x, int y)

## Private Members
- - private string _text = "";
- - private bool _showKeyboard;
- - private bool _selected;

## Protected Members
- - protected Texture2D _textBoxTexture;
- - protected Texture2D _caretTexture;
- - protected SpriteFont _font;
- - protected Color _textColor;

## Internal Members
- *(None)*

## Other Members
- *(None)*
