# LetterViewerMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_backButton = 101;
- - public const int region_forwardButton = 102;
- - public const int region_acceptQuestButton = 103;
- - public const int region_itemGrabButton = 104;
- - public const int letterWidth = 320;
- - public const int letterHeight = 180;
- - public Texture2D letterTexture;
- - public Texture2D secretNoteImageTexture;
- - public int moneyIncluded;
- - public int secretNoteImage = -1;
- - public int whichBG;
- - public string questID;
- - public string specialOrderId;
- - public string learnedRecipe = "";
- - public string cookingOrCrafting = "";
- - public string mailTitle;
- - public List<string> mailMessage = new List<string>();
- - public int page;
- - public readonly List<ClickableComponent> itemsToGrab = new List<ClickableComponent>();
- - public float scale;
- - public bool isMail;
- - public bool isFromCollection;
- - public new bool destroy;
- - public Color? customTextColor;
- - public bool usingCustomBackground;
- - public ClickableTextureComponent backButton;
- - public ClickableTextureComponent forwardButton;
- - public ClickableComponent acceptQuestButton;
- - public const float scaleChange = 0.003f;
- - public bool HasQuestOrSpecialOrder
- - public LetterViewerMenu(string text)
- - public LetterViewerMenu(int secretNoteIndex)
- - public virtual void OnPageChange()
- - public LetterViewerMenu(string mail, string mailTitle, bool fromCollection = false)
- - public string HandleActionCommand(string mail)
- - public string HandleItemCommand(string mail)
- - public virtual string ApplyCustomFormatting(string text)
- - public override void snapToDefaultClickableComponent()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public virtual bool ShouldPlayExitSound()
- - public bool itemsLeftToGrab()
- - public void AcceptQuest()
- - public override void performHoverAction(int x, int y)
- - public override void update(GameTime time)
- - public virtual Color? getTextColor()
- - public override void draw(SpriteBatch b)
- - public virtual bool ShouldShowInteractable()
- - public virtual bool HasInteractable()
- - public void unload()
- - public override void receiveRightClick(int x, int y, bool playSound = true)

## Private Members
- *(None)*

## Protected Members
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
