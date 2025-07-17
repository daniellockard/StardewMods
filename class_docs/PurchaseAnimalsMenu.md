# PurchaseAnimalsMenu

**Summary:** Represents a farm animal and its behaviors.

## Public Members
- - public const int region_okButton = 101;
- - public const int region_doneNamingButton = 102;
- - public const int region_randomButton = 103;
- - public const int region_namingBox = 104;
- - public const int region_upArrow = 105;
- - public const int region_downArrow = 106;
- - public static int menuHeight = 320;
- - public static int menuWidth = 384;
- - public int clickedAnimalButton = -1;
- - public List<ClickableTextureComponent> animalsToPurchase = new List<ClickableTextureComponent>();
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent doneNamingButton;
- - public ClickableTextureComponent randomButton;
- - public ClickableTextureComponent upArrow;
- - public ClickableTextureComponent downArrow;
- - public ClickableTextureComponent hovered;
- - public ClickableComponent textBoxCC;
- - public bool onFarm;
- - public bool namingAnimal;
- - public bool freeze;
- - public FarmAnimal animalBeingPurchased;
- - public TextBox textBox;
- - public TextBoxEvent textBoxEvent;
- - public Building newAnimalHome;
- - public int priceOfAnimal;
- - public bool readOnly;
- - public int currentScroll;
- - public int scrollRows;
- - public GameLocation TargetLocation;
- - public PurchaseAnimalsMenu(List<Object> stock, GameLocation targetLocation = null)
- - public static int GetOffScreenRows(int animalsToPurchase)
- - public override bool shouldClampGamePadCursor()
- - public override void snapToDefaultClickableComponent()
- - public void textBoxEnter(TextBox sender)
- - public void setUpForReturnAfterPurchasingAnimal()
- - public void marnieAnimalPurchaseMessage()
- - public void setUpForAnimalPlacement()
- - public void setUpForReturnToShopMenu()
- - public virtual void Scroll(int offset)
- - public virtual void RepositionAnimalButtons()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override bool overrideSnappyMenuCursorMovementBan()
- - public override void receiveGamePadButton(Buttons button)
- - public override void gamePadButtonHeld(Buttons b)
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public Building GetSuggestedBuilding(FarmAnimal animal)
- - public Location GetTopLeftPixelToCenterBuilding(Building building)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
