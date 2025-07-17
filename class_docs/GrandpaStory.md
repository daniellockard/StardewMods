# GrandpaStory

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int sceneWidth = 1294;
- - public const int sceneHeight = 730;
- - public const int scene_beforeGrandpa = 0;
- - public const int scene_grandpaSpeech = 1;
- - public const int scene_timePass = 3;
- - public const int scene_jojaCorpOverhead = 4;
- - public const int scene_jojaCorpPan = 5;
- - public const int scene_desk = 6;
- - public GrandpaStory()
- - public bool tick(GameTime time)
- - public void afterFade()
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void onLetterExit()
- - public void leftClickHeld(int x, int y)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public void receiveKeyPress(Keys k)
- - public bool overrideFreeMouseMovement()
- - public void receiveKeyRelease(Keys k)
- - public void draw(SpriteBatch b)
- - public void changeScreenSize()
- - public void unload()
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()
- - public bool forceQuit()

## Private Members
- - private LocalizedContentManager content;
- - private Texture2D texture;
- - private float foregroundFade;
- - private float backgroundFade;
- - private float foregroundFadeChange;
- - private float backgroundFadeChange;
- - private float panX;
- - private float letterScale = 0.5f;
- - private float letterDy;
- - private float letterDyDy;
- - private int scene;
- - private int totalMilliseconds;
- - private int grandpaSpeechTimer;
- - private int parallaxPan;
- - private int letterOpenTimer;
- - private bool drawGrandpa;
- - private bool letterReceived;
- - private bool mouseActive;
- - private bool clickedLetter;
- - private bool quit;
- - private bool fadingToQuit;
- - private Queue<string> grandpaSpeech;
- - private Vector2 letterPosition = new Vector2(477f, 345f);
- - private LetterViewerMenu letterView;
- - private Rectangle clickableGrandpaLetterRect()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
