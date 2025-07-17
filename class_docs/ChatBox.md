# ChatBox

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int chatMessage = 0;
- - public const int errorMessage = 1;
- - public const int userNotificationMessage = 2;
- - public const int privateMessage = 3;
- - public const int defaultMaxMessages = 10;
- - public const int timeToDisplayMessages = 600;
- - public const int chatboxWidth = 896;
- - public const int chatboxHeight = 56;
- - public const int region_chatBox = 101;
- - public const int region_emojiButton = 102;
- - public ChatTextBox chatBox;
- - public ClickableComponent chatBoxCC;
- - public List<ChatMessage> messages = new List<ChatMessage>();
- - public int maxMessages = 10;
- - public static Texture2D emojiTexture;
- - public ClickableTextureComponent emojiMenuIcon;
- - public EmojiMenu emojiMenu;
- - public bool choosingEmoji;
- - public ChatBox()
- - public override void snapToDefaultClickableComponent()
- - public virtual void textBoxEnter(string text_to_send)
- - public virtual void textBoxEnter(TextBox sender)
- - public virtual void addInfoMessage(string message)
- - public virtual void globalInfoMessage(string messageKey, params string[] args)
- - public virtual void addErrorMessage(string message)
- - public virtual void listPlayers(bool otherPlayersOnly = false, bool onlineOnly = true)
- - public virtual void cheat(string command, bool isDebug = false)
- - public void replyPrivateMessage(string[] command)
- - public Farmer findMatchingFarmer(string[] command, ref int matchingIndex, bool allowMatchingByUserName = false, bool onlineOnly = true)
- - public void sendPrivateMessage(string[] command)
- - public bool isActive()
- - public void activate()
- - public override void clickAway()
- - public override bool isWithinBounds(int x, int y)
- - public virtual void setText(string text)
- - public override void receiveKeyPress(Keys key)
- - public override bool readyToClose()
- - public override void receiveGamePadButton(Buttons button)
- - public bool isHoveringOverClickable(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public static string formattedUserName(Farmer farmer)
- - public static string formattedUserNameLong(Farmer farmer)
- - public string formatMessage(long sourceFarmer, int chatKind, string message)
- - public virtual Color messageColor(int chatKind)
- - public virtual void receiveChatMessage(long sourceFarmer, int chatKind, LocalizedContentManager.LanguageCode language, string message)
- - public virtual void addMessage(string message, Color color)
- - public void addNiceTryEasterEggMessage()
- - public override void performHoverAction(int x, int y)
- - public override void update(GameTime time)
- - public override void receiveScrollWheelAction(int direction)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public static SpriteFont messageFont(LocalizedContentManager.LanguageCode language)
- - public int getOldMessagesBoxHeight()
- - public override void draw(SpriteBatch b)

## Private Members
- - private readonly IGameLogger CheatCommandChatLogger;
- - private KeyboardState oldKBState;
- - private List<string> cheatHistory = new List<string>();
- - private int cheatHistoryPosition = -1;
- - private long lastReceivedPrivateMessagePlayerId;
- - private void updatePosition()

## Protected Members
- - protected virtual void runCommand(string commandText)

## Internal Members
- *(None)*

## Other Members
- *(None)*
