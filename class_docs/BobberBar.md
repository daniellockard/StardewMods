# BobberBar

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int timePerFishSizeReduction = 800;
- - public const int bobberTrackHeight = 548;
- - public const int bobberBarTrackHeight = 568;
- - public const int xOffsetToBobberTrack = 64;
- - public const int yOffsetToBobberTrack = 12;
- - public const int mixed = 0;
- - public const int dart = 1;
- - public const int smooth = 2;
- - public const int sink = 3;
- - public const int floater = 4;
- - public const int CHALLENGE_BAIT_MAX_FISHES = 3;
- - public bool handledFishResult;
- - public float difficulty;
- - public int motionType;
- - public string whichFish;
- - public float distanceFromCatchPenaltyModifier = 1f;
- - public string setFlagOnCatch;
- - public float bobberPosition = 548f;
- - public float bobberSpeed;
- - public float bobberAcceleration;
- - public float bobberTargetPosition;
- - public float scale;
- - public float everythingShakeTimer;
- - public float floaterSinkerAcceleration;
- - public float treasurePosition;
- - public float treasureCatchLevel;
- - public float treasureAppearTimer;
- - public float treasureScale;
- - public bool bobberInBar;
- - public bool buttonPressed;
- - public bool flipBubble;
- - public bool fadeIn;
- - public bool fadeOut;
- - public bool treasure;
- - public bool treasureCaught;
- - public bool perfect;
- - public bool bossFish;
- - public bool beginnersRod;
- - public bool fromFishPond;
- - public bool goldenTreasure;
- - public int bobberBarHeight;
- - public int fishSize;
- - public int fishQuality;
- - public int minFishSize;
- - public int maxFishSize;
- - public int fishSizeReductionTimer;
- - public int challengeBaitFishes = -1;
- - public List<string> bobbers;
- - public Vector2 barShake;
- - public Vector2 fishShake;
- - public Vector2 everythingShake;
- - public Vector2 treasureShake;
- - public float reelRotation;
- - public float bobberBarPos;
- - public float bobberBarSpeed;
- - public float distanceFromCatching = 0.3f;
- - public static ICue reelSound;
- - public static ICue unReelSound;
- - public BobberBar(string whichFish, float fishSize, bool treasure, List<string> bobbers, string setFlagOnCatch, bool isBossFish, string baitID = "", bool goldenTreasure = false)
- - public virtual void Reposition()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void update(GameTime time)
- - public override bool readyToClose()
- - public override void emergencyShutDown()
- - public override void receiveKeyPress(Keys key)
- - public override void draw(SpriteBatch b)

## Private Members
- - private SparklingText sparkleText;
- - private Item fishObject;
- - private static int SafeNext(Random random, int minValue, int maxValue)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
