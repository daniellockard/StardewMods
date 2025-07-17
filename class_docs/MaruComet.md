# MaruComet

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public MaruComet()
- - public void changeScreenSize()
- - public bool doMainGameUpdates()
- - public bool tick(GameTime time)
- - public void draw(SpriteBatch b)
- - public void leftClickHeld(int x, int y)
- - public string minigameId()
- - public bool overrideFreeMouseMovement()
- - public void receiveEventPoke(int data)
- - public void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public void unload()
- - public bool forceQuit()

## Private Members
- - private const int telescopeCircleWidth = 143;
- - private const int flybyRepeater = 200;
- - private const float flybySpeed = 0.8f;
- - private LocalizedContentManager content;
- - private Vector2 centerOfScreen;
- - private Vector2 cometColorOrigin;
- - private Texture2D cometTexture;
- - private List<Vector2> flybys = new List<Vector2>();
- - private List<Vector2> flybysClose = new List<Vector2>();
- - private List<Vector2> flybysFar = new List<Vector2>();
- - private string currentString = "";
- - private int zoom;
- - private int flybyTimer;
- - private int totalTimer;
- - private int currentStringCharacter;
- - private int characterAdvanceTimer;
- - private float fade = 1f;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
