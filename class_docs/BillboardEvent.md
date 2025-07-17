# BillboardEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public bool locked;
- - public BillboardEventType Type { get; }
- - public string[] Arguments { get; }
- - public string DisplayName { get; }
- - public Texture2D Texture { get; }
- - public Rectangle TextureSourceRect { get; }
- - public BillboardEvent(BillboardEventType type, string[] arguments, string displayName, Texture2D texture = null, Rectangle sourceRect = default(Rectangle))
- - public const int basewidth = 338;
- - public const int baseWidth_calendar = 301;
- - public const int baseheight = 198;
- - public ClickableComponent acceptQuestButton;
- - public List<ClickableTextureComponent> calendarDays;
- - public readonly Dictionary<int, BillboardDay> calendarDayData = new Dictionary<int, BillboardDay>();
- - public Billboard(bool dailyQuest = false)
- - public virtual Dictionary<int, List<NPC>> GetBirthdays()
- - public virtual List<BillboardEvent> GetEventsForDay(int day, Dictionary<int, List<NPC>> birthdays)
- - public override void snapToDefaultClickableComponent()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public void UpdateDailyQuestButton()

## Private Members
- - private Texture2D billboardTexture;
- - private bool dailyQuestBoard;
- - private string hoverText = "";
- - private List<int> booksellerdays;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
