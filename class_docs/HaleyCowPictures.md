# HaleyCowPictures

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public HaleyCowPictures()
- - public bool overrideFreeMouseMovement()
- - public bool tick(GameTime time)
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void leftClickHeld(int x, int y)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public void draw(SpriteBatch b)
- - public void changeScreenSize()
- - public void unload()
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()
- - public bool forceQuit()

## Private Members
- - private const int pictureWidth = 416;
- - private const int pictureHeight = 496;
- - private const int sourceWidth = 104;
- - private const int sourceHeight = 124;
- - private int numberOfPhotosSoFar;
- - private int betweenPhotoTimer = 1000;
- - private LocalizedContentManager content;
- - private Vector2 centerOfScreen;
- - private Texture2D pictures;
- - private float fadeAlpha;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
