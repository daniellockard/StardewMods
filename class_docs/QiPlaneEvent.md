# QiPlaneEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public QiPlaneEvent()
- - public override void draw(SpriteBatch b)
- - public override void drawAboveEverything(SpriteBatch b)
- - public override bool setUp()
- - public override bool tickUpdate(GameTime time)

## Private Members
- - private Vector2 qiPlanePos;
- - private List<TemporaryAnimatedSprite> tempSprites = new List<TemporaryAnimatedSprite>();
- - private float boxDropTimer;
- - private float textTimer;
- - private float finalFadeTimer;
- - private string str;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
