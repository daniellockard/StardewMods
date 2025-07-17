# MuseumMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int startingState = 0;
- - public const int placingInMuseumState = 1;
- - public const int exitingState = 2;
- - public int fadeTimer;
- - public int state;
- - public int menuPositionOffset;
- - public bool fadeIntoBlack;
- - public bool menuMovingDown;
- - public float blackFadeAlpha;
- - public SparklingText sparkleText;
- - public Vector2 globalLocationOfSparklingArtifact;
- - public LibraryMuseum Museum;
- - public bool reOrganizing;
- - public MuseumMenu(InventoryMenu.highlightThisItem highlighterMethod)
- - public override bool shouldClampGamePadCursor()
- - public override void receiveKeyPress(Keys key)
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public virtual void ReturnToDonatableItems()
- - public override void emergencyShutDown()
- - public override bool readyToClose()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void update(GameTime time)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void draw(SpriteBatch b)

## Private Members
- - private bool holdingMuseumPiece;
- - private void snapCursorToCurrentMuseumSpot()

## Protected Members
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
