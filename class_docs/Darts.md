# Darts

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum GameState
- - public GameState currentGameState;
- - public float stateTimer;
- - public float pixelScale = 4f;
- - public bool gamePaused;
- - public Vector2 upperLeft;
- - public Vector2 cursorPosition = new Vector2(0f, 0f);
- - public Vector2 aimPosition = new Vector2(0f, 0f);
- - public Vector2 dartBoardCenter = Vector2.Zero;
- - public float chargeTime;
- - public float chargeDirection = 1f;
- - public float hangTime;
- - public int previousPoints;
- - public int points;
- - public float nextPointTransferTime;
- - public static ICue chargeSound;
- - public Vector2 throwStartPosition;
- - public Vector2 dartPosition;
- - public float dartTime = -1f;
- - public string lastHitString = "";
- - public int lastHitAmount;
- - public bool shakeScore;
- - public int startingDartCount = 20;
- - public int dartCount = 20;
- - public int throwsCount;
- - public string alternateTextString = "";
- - public string gameOverString = "";
- - public bool lastHitWasDouble;
- - public bool overrideFreeMouseMovement()
- - public Darts(int dart_count = 20)
- - public virtual void SetGameState(GameState new_state)
- - public bool WasButtonHeld()
- - public bool WasButtonPressed()
- - public bool tick(GameTime time)
- - public virtual bool IsAiming()
- - public float GetRadiusFromCharge()
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public virtual int GetPointsForAim()
- - public virtual void FireDart(float radius)
- - public void releaseRightClick(int x, int y)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public unsafe void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public void QuitGame()
- - public void draw(SpriteBatch b)
- - public float GetPixelScale()
- - public Rectangle TransformDraw(Rectangle dest)
- - public Vector2 TransformDraw(Vector2 dest)
- - public bool IsPerfectVictory()
- - public void changeScreenSize()
- - public void unload()
- - public bool forceQuit()
- - public void leftClickHeld(int x, int y)
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()

## Private Members
- - private int screenWidth;
- - private int screenHeight;
- - private Texture2D texture;

## Protected Members
- - protected bool canCancelShot = true;

## Internal Members
- *(None)*

## Other Members
- *(None)*
