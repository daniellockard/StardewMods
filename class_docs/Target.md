# Target

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static int width = 56;
- - public static int spawnRightPosition = 960;
- - public static int spawnLeftPosition = 0;
- - public static int basicTarget = 0;
- - public static int bonusTarget = 1;
- - public static int deluxeTarget = 2;
- - public static int mediumSpeed = 4;
- - public static int slowSpeed = 2;
- - public static int fastSpeed = 5;
- - public static int nearLane = 448;
- - public static int middleLane = 320;
- - public static int farLane = 128;
- - public static int superNearLane = 576;
- - public static int behindLane = 832;
- - public static int pauseFarRight = 832;
- - public static int pauseRight = 704;
- - public static int pauseMiddleRight = 576;
- - public static int pauseMiddleLeft = 384;
- - public static int pauseLeft = 256;
- - public static int pauseFarLeft = 128;
- - public Rectangle Position;
- - public Target(int countdownBeforeSpawn, int whichLane, int type = 0, int speed = 4, bool spawnFromRight = true, int pauseAndReturn = -1, int pauseTime = -1)
- - public bool update(GameTime time, GameLocation location)
- - public void shatter(GameLocation location, Projectile stone)
- - public void draw(SpriteBatch b)
- - public static int score;
- - public static int shotsFired;
- - public static int successShots;
- - public static int accuracy = -1;
- - public static int starTokensWon;
- - public List<Target> targets;
- - public TargetGame()
- - public bool overrideFreeMouseMovement()
- - public bool tick(GameTime time)
- - public void gameDoneAfterFade()
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void leftClickHeld(int x, int y)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public void draw(SpriteBatch b)
- - public static void startMe()
- - public void changeScreenSize()
- - public void unload()
- - public void addTargets()
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()
- - public bool forceQuit()

## Private Members
- - private int targetType;
- - private int countdownBeforeSpawn;
- - private int xPausePosition;
- - private int xPauseTime;
- - private int speed;
- - private bool spawned;
- - private bool atPausePosition;
- - private Rectangle sourceRect;
- - private GameLocation location;
- - private int timerToStart = 1000;
- - private int gameEndTimer = 61000;
- - private int showResultsTimer = -1;
- - private bool gameDone;
- - private bool exit;
- - private float modifierBonus;
- - private void addTwinPausers(int initialDelay, int whichLane, int pauseArea, int speed, int pauseTime, int targetType)
- - private void addRowOfTargetsOnLane(int initialDelayBeforeStarting, int whichLane, int delayBetween, int numberOfTargets, int speed, bool spawnFromRight = true, int targetType = 0)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
