# AnimalQueryMenu

**Summary:** Represents a farm animal and its behaviors.

## Public Members
- - public const int region_okButton = 101;
- - public const int region_love = 102;
- - public const int region_sellButton = 103;
- - public const int region_moveHomeButton = 104;
- - public const int region_noButton = 105;
- - public const int region_allowReproductionButton = 106;
- - public const int region_loveHover = 109;
- - public const int region_textBoxCC = 110;
- - public new static int width = 384;
- - public new static int height = 512;
- - public FarmAnimal animal;
- - public TextBox textBox;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent love;
- - public ClickableTextureComponent sellButton;
- - public ClickableTextureComponent moveHomeButton;
- - public ClickableTextureComponent yesButton;
- - public ClickableTextureComponent noButton;
- - public ClickableTextureComponent allowReproductionButton;
- - public ClickableComponent loveHover;
- - public ClickableComponent textBoxCC;
- - public double loveLevel;
- - public bool confirmingSell;
- - public bool movingAnimal;
- - public string hoverText = "";
- - public string parentName;
- - public AnimalQueryMenu(FarmAnimal animal)
- - public override bool shouldClampGamePadCursor()
- - public override void snapToDefaultClickableComponent()
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)
- - public void finishedPlacingAnimal()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override bool overrideSnappyMenuCursorMovementBan()
- - public void prepareForAnimalPlacement()
- - public void prepareForReturnFromPlacement()
- - public override bool readyToClose()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
