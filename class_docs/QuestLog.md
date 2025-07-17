# QuestLog

**Summary:** Represents a quest or mission.

## Public Members
- - public const int questsPerPage = 6;
- - public const int region_forwardButton = 101;
- - public const int region_backButton = 102;
- - public const int region_rewardBox = 103;
- - public const int region_cancelQuestButton = 104;
- - public List<ClickableComponent> questLogButtons;
- - public ClickableTextureComponent forwardButton;
- - public ClickableTextureComponent backButton;
- - public ClickableTextureComponent rewardBox;
- - public ClickableTextureComponent cancelQuestButton;
- - public float scrollAmount;
- - public ClickableTextureComponent upArrow;
- - public ClickableTextureComponent downArrow;
- - public ClickableTextureComponent scrollBar;
- - public Rectangle scrollBarBounds;
- - public QuestLog()
- - public override void snapToDefaultClickableComponent()
- - public override void receiveGamePadButton(Buttons button)
- - public bool NeedsScroll()
- - public override void receiveScrollWheelAction(int direction)
- - public override void performHoverAction(int x, int y)
- - public override void receiveKeyPress(Keys key)
- - public override void leftClickHeld(int x, int y)
- - public override void releaseLeftClick(int x, int y)
- - public virtual void SetScrollFromY(int y)
- - public void UpArrowPressed()
- - public void DownArrowPressed()
- - public override void applyMovementKey(int direction)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public bool HasReward()
- - public bool HasMoneyReward()
- - public void exitQuestPage()
- - public override void update(GameTime time)
- - public override void draw(SpriteBatch b)

## Private Members
- - private string hoverText = "";
- - private void nonQuestPageForwardButton()
- - private void nonQuestPageBackButton()
- - private void SetScrollBarFromAmount()

## Protected Members
- - protected List<List<IQuest>> pages;
- - protected int currentPage;
- - protected int questPage = -1;
- - protected IQuest _shownQuest;
- - protected List<string> _objectiveText;
- - protected float _contentHeight;
- - protected float _scissorRectHeight;
- - protected bool scrolling;
- - protected override void customSnapBehavior(int direction, int oldRegion, int oldID)
- - protected virtual void paginateQuests()
- - protected virtual IList<IQuest> GetAllQuests()

## Internal Members
- *(None)*

## Other Members
- *(None)*
