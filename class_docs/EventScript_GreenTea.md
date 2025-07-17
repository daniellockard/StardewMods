# EventScript_GreenTea

**Summary:** Represents a game event or cutscene.

## Public Members
- - public EventScript_GreenTea(Vector2 onScreenCenterPosition, Event e)
- - public void draw(SpriteBatch b)
- - public void drawAboveAlwaysFront(SpriteBatch b)
- - public bool update(GameTime time, Event e)

## Private Members
- - private const int Phase_intro = 0;
- - private const int Phase_text1 = 1;
- - private const int Phase_text2 = 2;
- - private const int Phase_text3 = 3;
- - private const int Phase_buddy = 4;
- - private const int Phase_end = 5;
- - private int width;
- - private int height;
- - private int topLeftX;
- - private int topLeftY;
- - private int phaseTimer = 5000;
- - private int steamTimer = 100;
- - private int cupTimer = 500;
- - private int currentPhase;
- - private int buddyPhase;
- - private int buddyTimer;
- - private int textColor;
- - private string text;
- - private Texture2D tempText;
- - private Color bgColor;
- - private Color hillColor;
- - private Color lightLeafColor;
- - private Color darkLeafColor;
- - private Vector2 globalCenterPosition;
- - private TemporaryAnimatedSprite buddy;
- - private void addStar(Vector2 pos, Event e)
- - private void setBuddyFrame(int frame)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
