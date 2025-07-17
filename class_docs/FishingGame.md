# FishingGame

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool exit;
- - public bool gameDone;
- - public int score;
- - public int fishCaught;
- - public int starTokensWon;
- - public int perfections;
- - public int perfectionBonus;
- - public GameLocation originalLocation;
- - public FishingGame()
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
- - public virtual void EmergencyCancel()
- - public void draw(SpriteBatch b)
- - public static void startMe()
- - public void changeScreenSize()
- - public void unload()
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()
- - public bool forceQuit()

## Private Members
- - private GameLocation location;
- - private LocalizedContentManager content;
- - private int timerToStart = 1000;
- - private int gameEndTimer;
- - private int showResultsTimer;
- - private void handleCastInput()
- - private void handleCastInputReleased()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
