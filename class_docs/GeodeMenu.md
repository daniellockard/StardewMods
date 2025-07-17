# GeodeMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_geodeSpot = 998;
- - public ClickableComponent geodeSpot;
- - public AnimatedSprite clint;
- - public TemporaryAnimatedSprite geodeDestructionAnimation;
- - public TemporaryAnimatedSprite sparkle;
- - public int geodeAnimationTimer;
- - public int yPositionOfGem;
- - public int alertTimer;
- - public float delayBeforeShowArtifactTimer;
- - public Item geodeTreasure;
- - public Item geodeTreasureOverride;
- - public bool waitingForServerResponse;
- - public GeodeMenu()
- - public override void snapToDefaultClickableComponent()
- - public override bool readyToClose()
- - public bool highlightGeodes(Item i)
- - public virtual void startGeodeCrack()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void emergencyShutDown()
- - public override void update(GameTime time)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void draw(SpriteBatch b)

## Private Members
- - private TemporaryAnimatedSpriteList fluffSprites = new TemporaryAnimatedSpriteList();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
