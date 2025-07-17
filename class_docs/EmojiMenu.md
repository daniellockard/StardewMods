# EmojiMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int EMOJI_SIZE = 9;
- - public static int totalEmojis;
- - public static int totalVisibleEmojis;
- - public EmojiMenu(ChatBox chatBox, Texture2D emojiTexture, Texture2D chatBoxTexture)
- - public void leftClick(int x, int y, ChatBox cb)
- - public override void receiveScrollWheelAction(int direction)
- - public override void draw(SpriteBatch b)

## Private Members
- - private Texture2D chatBoxTexture;
- - private Texture2D emojiTexture;
- - private ChatBox chatBox;
- - private List<ClickableComponent> emojiSelectionButtons = new List<ClickableComponent>();
- - private int pageStartIndex;
- - private ClickableComponent upArrow;
- - private ClickableComponent downArrow;
- - private ClickableComponent sendArrow;
- - private void upArrowPressed(int amountToScroll = 30)
- - private void downArrowPressed(int amountToScroll = 30)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
