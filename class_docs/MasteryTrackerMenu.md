# MasteryTrackerMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int MASTERY_EXP_PER_LEVEL = 10000;
- - public const int WIDTH = 200;
- - public const int HEIGHT = 80;
- - public ClickableTextureComponent mainButton;
- - public MasteryTrackerMenu(int whichSkill = -1)
- - public override void performHoverAction(int x, int y)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public static void addSpiritCandles(bool instant = false)
- - public static void addSkillFlairPlaque(int which)
- - public static bool hasCompletedAllMasteryPlaques()
- - public override void update(GameTime time)
- - public static int getMasteryExpNeededForLevel(int level)
- - public static int getCurrentMasteryLevel()
- - public static void drawBar(SpriteBatch b, Vector2 topLeftSpot, float widthScale = 1f)
- - public override void draw(SpriteBatch b)

## Private Members
- - private float pressedButtonTimer;
- - private float destroyTimer;
- - private List<ClickableTextureComponent> rewards = new List<ClickableTextureComponent>();
- - private int which;
- - private bool canClaim;
- - private void claimReward()
- - private static void addCandle(int x, int y, int delay)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
