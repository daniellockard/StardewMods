# DialogueBox

**Summary:** Handles in-game dialogue or conversations.

## Public Members
- - public List<string> dialogues = new List<string>();
- - public Dialogue characterDialogue;
- - public Stack<string> characterDialoguesBrokenUp = new Stack<string>();
- - public Response[] responses = LegacyShims.EmptyArray<Response>();
- - public const int portraitBoxSize = 74;
- - public const int nameTagWidth = 102;
- - public const int nameTagHeight = 18;
- - public const int portraitPlateWidth = 115;
- - public const int nameTagSideMargin = 5;
- - public const float transitionRate = 3f;
- - public const int characterAdvanceDelay = 30;
- - public const int safetyDelay = 750;
- - public int questionFinishPauseTimer;
- - public Rectangle friendshipJewel = Rectangle.Empty;
- - public List<ClickableComponent> responseCC;
- - public int x;
- - public int y;
- - public int transitionX = -1;
- - public int transitionY;
- - public int transitionWidth;
- - public int transitionHeight;
- - public int characterAdvanceTimer;
- - public int characterIndexInDialogue;
- - public int safetyTimer = 750;
- - public int heightForQuestions;
- - public int selectedResponse = -1;
- - public int newPortaitShakeTimer;
- - public bool transitionInitialized;
- - public bool showTyping = true;
- - public bool transitioning = true;
- - public bool transitioningBigger = true;
- - public bool dialogueContinuedOnNextPage;
- - public bool dialogueFinished;
- - public bool isQuestion;
- - public TemporaryAnimatedSprite dialogueIcon;
- - public TemporaryAnimatedSprite aboveDialogueImage;
- - public DialogueBox(int x, int y, int width, int height)
- - public DialogueBox(string dialogue)
- - public DialogueBox(string dialogue, Response[] responses, int width = 1200)
- - public DialogueBox(Dialogue dialogue)
- - public DialogueBox(List<string> dialogues)
- - public override void snapToDefaultClickableComponent()
- - public void closeDialogue()
- - public void finishTyping()
- - public void beginOutro()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int mouseX, int mouseY)
- - public bool shouldDrawFriendshipJewel()
- - public bool isPortraitBox()
- - public void drawBox(SpriteBatch b, int xPos, int yPos, int boxWidth, int boxHeight)
- - public void drawPortrait(SpriteBatch b)
- - public string getCurrentString()
- - public override void update(GameTime time)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void draw(SpriteBatch b)

## Private Members
- - private string hoverText = "";
- - private void playOpeningSound()
- - private void tryOutro()
- - private void setUpIcons()
- - private void setUpQuestionIcon()
- - private void setUpCloseDialogueIcon()
- - private void setUpNextPageIcon()
- - private void checkDialogue(Dialogue d)
- - private void setUpQuestions()
- - private bool shouldPortraitShake(Dialogue d)

## Protected Members
- - protected bool _showedOptions;

## Internal Members
- *(None)*

## Other Members
- *(None)*
