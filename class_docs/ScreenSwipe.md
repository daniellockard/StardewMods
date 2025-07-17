# ScreenSwipe

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int swipe_bundleComplete = 0;
- - public const int swipe_raccoon = 1;
- - public const int borderPixelWidth = 7;
- - public ScreenSwipe(int which, float swipeVelocity = -1f, int durationAfterSwipe = -1, int w = -1, int h = -1)
- - public bool update(GameTime time)
- - public Rectangle getAdjustedSourceRect(Rectangle sourceRect, float xStartPosition)
- - public void draw(SpriteBatch b)

## Private Members
- - private Rectangle bgSource;
- - private Rectangle flairSource;
- - private Rectangle messageSource;
- - private Rectangle movingFlairSource;
- - private Rectangle bgDest;
- - private int yPosition;
- - private int durationAfterSwipe;
- - private int originalBGSourceXLimit;
- - private List<Vector2> flairPositions = new List<Vector2>();
- - private Vector2 messagePosition;
- - private Vector2 movingFlairPosition;
- - private Vector2 movingFlairMotion;
- - private float swipeVelocity;
- - private Texture2D texture;
- - private int width;
- - private int height;
- - private int ViewportWidth => ((Rectangle)(ref Game1.uiViewport)).Width;
- - private int ViewportHeight => ((Rectangle)(ref Game1.uiViewport)).Height;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
