# DayTimeMoneyBox

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public new const int width = 300;
- - public new const int height = 284;
- - public Vector2 position;
- - public MoneyDial moneyDial = new MoneyDial(8);
- - public int timeShakeTimer;
- - public int moneyShakeTimer;
- - public int questPulseTimer;
- - public int whenToPulseTimer;
- - public ClickableTextureComponent questButton;
- - public ClickableTextureComponent zoomOutButton;
- - public ClickableTextureComponent zoomInButton;
- - public bool questsDirty;
- - public int questPingTimer;
- - public static int Width => 300;
- - public DayTimeMoneyBox()
- - public override bool isWithinBounds(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public void gotGoldCoin(int amount)
- - public void pingQuest(Quest quest)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public void drawMoneyBox(SpriteBatch b, int overrideX = -1, int overrideY = -1)
- - public override void update(GameTime time)
- - public virtual void PingQuestLog()
- - public virtual void DismissQuestPing()
- - public override void draw(SpriteBatch b)

## Private Members
- - private Rectangle sourceRect;
- - private StringBuilder _hoverText = new StringBuilder();
- - private StringBuilder _timeText = new StringBuilder();
- - private StringBuilder _dateText = new StringBuilder();
- - private StringBuilder _hours = new StringBuilder();
- - private StringBuilder _padZeros = new StringBuilder();
- - private StringBuilder _temp = new StringBuilder();
- - private int _lastDayOfMonth = -1;
- - private string _lastDayOfMonthString;
- - private string _amString;
- - private string _pmString;
- - private int questNotificationTimer;
- - private Texture2D questPingTexture;
- - private Rectangle questPingSourceRect;
- - private string questPingString;
- - private int goldCoinCounter;
- - private int goldCoinTimer;
- - private string goldCoinString;
- - private LocalizedContentManager.LanguageCode _languageCode = (LocalizedContentManager.LanguageCode)(-1);
- - private void updatePosition()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
