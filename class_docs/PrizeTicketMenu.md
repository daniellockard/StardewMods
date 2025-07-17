# PrizeTicketMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int WIDTH = 116;
- - public const int HEIGHT = 94;
- - public Texture2D texture;
- - public ClickableTextureComponent mainButton;
- - public float pressedButtonTimer;
- - public List<Item> currentPrizeTrack = new List<Item>();
- - public float getRewardTimer;
- - public float moveRewardTrackTimer;
- - public float moveRewardTrackPreTimer;
- - public bool gettingReward;
- - public bool movingRewardTrack;
- - public PrizeTicketMenu()
- - public override void performHoverAction(int x, int y)
- - public static Item getPrizeItem(int prizeLevel)
- - public override bool readyToClose()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void update(GameTime time)
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
