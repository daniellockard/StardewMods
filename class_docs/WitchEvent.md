# WitchEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public string lightSourceId;
- - public bool goldenWitch;
- - public override bool setUp()
- - public override bool tickUpdate(GameTime time)
- - public void afterLastFade()
- - public override void draw(SpriteBatch b)
- - public override void makeChangesToLocation()

## Private Members
- - private Vector2 witchPosition;
- - private Building targetBuilding;
- - private Farm f;
- - private Random r;
- - private int witchFrame;
- - private int witchAnimationTimer;
- - private int animationLoopsDone;
- - private int timerSinceFade;
- - private bool animateLeft;
- - private bool terminate;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
