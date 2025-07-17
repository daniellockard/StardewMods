# MermaidHouse

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public MermaidHouse()
- - public MermaidHouse(string mapPath, string name)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public void playClamTone(int which)
- - public void playClamTone(int which, Farmer who)
- - public override void draw(SpriteBatch b)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override void UpdateWhenCurrentLocation(GameTime time)

## Private Members
- - private Texture2D mermaidSprites;
- - private float showTimer;
- - private float curtainMovement;
- - private float curtainOpenPercent;
- - private float blackBGAlpha;
- - private float bigMermaidAlpha;
- - private float oldStopWatchTime;
- - private float finalLeftMermaidAlpha;
- - private float finalRightMermaidAlpha;
- - private float finalBigMermaidAlpha;
- - private float fairyTimer;
- - private int[] mermaidFrames;
- - private Stopwatch stopWatch;
- - private List<Vector2> bubbles;
- - private TemporaryAnimatedSpriteList sparkles;
- - private TemporaryAnimatedSpriteList alwaysFrontTempSprites;
- - private List<int> lastFiveClamTones;
- - private Farmer pearlRecipient;

## Protected Members
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
