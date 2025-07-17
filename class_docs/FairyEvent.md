# FairyEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public string lightSourceId;
- - public override bool setUp()
- - public override bool tickUpdate(GameTime time)
- - public void afterLastFade()
- - public override void draw(SpriteBatch b)
- - public override void makeChangesToLocation()
- - public interface FarmEvent : INetObject<NetFields>

## Private Members
- - private Vector2 fairyPosition;
- - private Vector2 targetCrop;
- - private Farm f;
- - private int fairyFrame;
- - private int fairyAnimationTimer;
- - private int animationLoopsDone;
- - private int timerSinceFade;
- - private bool animateLeft;
- - private bool terminate;

## Protected Members
- - protected Vector2 ChooseCrop()

## Internal Members
- *(None)*

## Other Members
- *(None)*
