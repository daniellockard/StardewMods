# ForgeMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public enum CraftState
- - public const int region_leftIngredient = 998;
- - public const int region_rightIngredient = 997;
- - public const int region_startButton = 996;
- - public const int region_resultItem = 995;
- - public const int region_unforgeButton = 994;
- - public ClickableTextureComponent craftResultDisplay;
- - public ClickableTextureComponent leftIngredientSpot;
- - public ClickableTextureComponent rightIngredientSpot;
- - public ClickableTextureComponent startTailoringButton;
- - public ClickableComponent unforgeButton;
- - public List<ClickableComponent> equipmentIcons = new List<ClickableComponent>();
- - public const int region_ring_1 = 110;
- - public const int region_ring_2 = 111;
- - public const int CRAFT_TIME = 1600;
- - public Texture2D forgeTextures;
- - public Vector2 questionMarkOffset;
- - public ForgeMenu()
- - public override void snapToDefaultClickableComponent()
- - public bool IsBusy()
- - public override bool readyToClose()
- - public bool HighlightItems(Item i)
- - public virtual void GenerateHighlightDictionary()
- - public virtual bool IsValidCraftIngredient(Item item)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public virtual int GetForgeCostAtLevel(int level)
- - public virtual int GetForgeCost(Item left_item, Item right_item)
- - public virtual bool IsValidCraft(Item left_item, Item right_item)
- - public virtual Item CraftItem(Item left_item, Item right_item, bool forReal = false)
- - public void SpendRightItem()
- - public void SpendLeftItem()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public bool CanFitCraftedItem()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void emergencyShutDown()
- - public override void update(GameTime time)
- - public virtual bool IsValidUnforge(bool ignore_right_slot_occupancy = false)
- - public override void draw(SpriteBatch b)

## Private Members
- - private bool unforging;
- - private void _leftIngredientSpotClicked()
- - private void _rightIngredientSpotClicked()

## Protected Members
- - protected int _timeUntilCraft;
- - protected int _clankEffectTimer;
- - protected int _sparklingTimer;
- - protected Dictionary<Item, bool> _highlightDictionary;
- - protected TemporaryAnimatedSpriteList tempSprites = new TemporaryAnimatedSpriteList();
- - protected string displayedDescription = "";
- - protected CraftState _craftState;
- - protected void _CreateButtons()
- - protected void _ValidateCraft()
- - protected void _UpdateDescriptionText()
- - protected override void cleanupBeforeExit()
- - protected void _OnCloseMenu()

## Internal Members
- *(None)*

## Other Members
- *(None)*
