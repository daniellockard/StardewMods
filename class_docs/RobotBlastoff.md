# RobotBlastoff

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float backGroundSpeed = 0.25f;
- - public const float robotSpeed = 0.3f;
- - public const int skyLength = 2560;
- - public int millisecondsSinceStart;
- - public int backgroundPosition = -2560 + (int)((float)Game1.game1.localMultiplayerWindow.Height / Game1.options.zoomLevel);
- - public int smokeTimer = 500;
- - public Vector2 robotPosition = new Vector2((float)(Game1.game1.localMultiplayerWindow.Width / 2) / Game1.options.zoomLevel, (float)Game1.game1.localMultiplayerWindow.Height / Game1.options.zoomLevel);
- - public TemporaryAnimatedSpriteList tempSprites = new TemporaryAnimatedSpriteList();
- - public bool overrideFreeMouseMovement()
- - public bool tick(GameTime time)
- - public void afterFade()
- - public bool forceQuit()
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
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
