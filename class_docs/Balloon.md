# Balloon

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Vector2 position;
- - public Color color;
- - public Balloon(int screenWidth, int screenHeight)
- - public void update(float speed, GameTime time)
- - public int pixelScale = 4;
- - public const int skyLoopWidth = 112;
- - public const int cloudLoopWidth = 170;
- - public const int tilesBeyondViewportToSimulate = 6;
- - public const int leftFence = 0;
- - public const int centerFence = 1;
- - public const int rightFence = 2;
- - public const int busYRest = 240;
- - public const int choosingCharacterState = 0;
- - public const int panningDownFromCloudsState = 1;
- - public const int panningDownToRoadState = 2;
- - public const int drivingState = 3;
- - public const int stardewInViewState = 4;
- - public float speed = 0.1f;
- - public static ICue roadNoise;
- - public Intro()
- - public Intro(int startingGameMode)
- - public bool overrideFreeMouseMovement()
- - public void createBeginningOfLevel()
- - public void updateRoad(GameTime time)
- - public void updateUpperClouds(GameTime time)
- - public bool tick(GameTime time)
- - public void doneCreatingCharacter()
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void leftClickHeld(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public void draw(SpriteBatch b)
- - public void drawRoadArea(SpriteBatch b)
- - public void changeScreenSize()
- - public void unload()
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()
- - public bool forceQuit()

## Private Members
- - private float valleyPosition;
- - private float skyPosition;
- - private float roadPosition;
- - private float bigCloudPosition;
- - private float backCloudPosition;
- - private float globalYPan;
- - private float globalYPanDY;
- - private float drivingTimer;
- - private float fadeAlpha;
- - private float treePosition;
- - private int screenWidth;
- - private int screenHeight;
- - private int tileSize = 16;
- - private Matrix transformMatrix;
- - private Texture2D texture;
- - private Texture2D roadsideTexture;
- - private Texture2D cloudTexture;
- - private Texture2D treeStripTexture;
- - private List<Point> backClouds = new List<Point>();
- - private List<int> road = new List<int>();
- - private List<int> sky = new List<int>();
- - private List<int> roadsideObjects = new List<int>();
- - private List<int> roadsideFences = new List<int>();
- - private Color skyColor;
- - private Color roadColor;
- - private Color carColor;
- - private bool cameraCenteredOnBus = true;
- - private bool addedSign;
- - private Vector2 busPosition;
- - private Vector2 carPosition;
- - private Vector2 birdPosition = Vector2.Zero;
- - private CharacterCustomization characterCreateMenu;
- - private List<Balloon> balloons = new List<Balloon>();
- - private int birdFrame;
- - private float birdTimer;
- - private float birdXTimer;
- - private int fenceBuildStatus = -1;
- - private int currentState;
- - private bool quit;
- - private bool hasQuit;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
