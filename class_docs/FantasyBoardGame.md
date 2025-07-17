# FantasyBoardGame

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int borderSourceWidth = 138;
- - public int borderSourceHeight = 74;
- - public int slideSourceWidth = 128;
- - public int slideSourceHeight = 64;
- - public int whichSlide;
- - public int shakeTimer;
- - public int endTimer;
- - public FantasyBoardGame()
- - public bool overrideFreeMouseMovement()
- - public bool tick(GameTime time)
- - public void end()
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void leftClickHeld(int x, int y)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public void draw(SpriteBatch b)
- - public void changeScreenSize()
- - public void unload()
- - public void afterFade()
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()
- - public bool forceQuit()

## Private Members
- - private LocalizedContentManager content;
- - private Texture2D slides;
- - private Texture2D border;
- - private string grade = "";

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
