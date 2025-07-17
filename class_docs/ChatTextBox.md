# ChatTextBox

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public IClickableMenu parentMenu;
- - public List<ChatSnippet> finalText = new List<ChatSnippet>();
- - public float currentWidth;
- - public ChatTextBox(Texture2D textBoxTexture, Texture2D caretTexture, SpriteFont font, Color textColor)
- - public void reset()
- - public void setText(string text)
- - public override void RecieveTextInput(string text)
- - public override void RecieveTextInput(char inputChar)
- - public override void RecieveCommandInput(char command)
- - public void backspace()
- - public void receiveEmoji(int emoji)
- - public void updateWidth()
- - public override void Draw(SpriteBatch spriteBatch, bool drawShadow = true)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
