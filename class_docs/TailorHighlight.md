# TailorHighlight

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly bool LeftSlot;
- - public readonly bool RightSlot;
- - public readonly bool EquipmentSlot;
- - public readonly bool AnySlot;
- - public TailorHighlight()
- - public TailorHighlight(bool leftSlot, bool rightSlot, bool equipmentSlot)
- - public const int region_leftIngredient = 998;
- - public const int region_rightIngredient = 997;
- - public const int region_startButton = 996;
- - public const int region_resultItem = 995;
- - public ClickableTextureComponent needleSprite;
- - public ClickableTextureComponent presserSprite;
- - public ClickableTextureComponent craftResultDisplay;
- - public Vector2 needlePosition;
- - public Vector2 presserPosition;
- - public Vector2 leftIngredientStartSpot;
- - public Vector2 leftIngredientEndSpot;
- - public ClickableTextureComponent leftIngredientSpot;
- - public ClickableTextureComponent rightIngredientSpot;
- - public ClickableTextureComponent blankLeftIngredientSpot;
- - public ClickableTextureComponent blankRightIngredientSpot;
- - public ClickableTextureComponent startTailoringButton;
- - public const int region_shirt = 108;
- - public const int region_pants = 109;
- - public const int region_hat = 101;
- - public List<ClickableComponent> equipmentIcons = new List<ClickableComponent>();
- - public const int CRAFT_TIME = 1500;
- - public Texture2D tailoringTextures;
- - public List<TailorItemRecipe> _tailoringRecipes;
- - public Vector2 questionMarkOffset;
- - public TailoringMenu()
- - public override void snapToDefaultClickableComponent()
- - public bool IsBusy()
- - public override bool readyToClose()
- - public bool HighlightItems(Item i)
- - public void BuildHighlightCache()
- - public bool IsValidCraftIngredient(Item item)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public static Color? GetDyeColor(Item dye_object)
- - public bool DyeItems(Clothing clothing, Item dye_object, float dye_strength_override = -1f)
- - public TailorItemRecipe GetRecipeForItems(Item leftItem, Item rightItem)
- - public bool IsValidCraft(Item left_item, Item right_item)
- - public bool IsMultipleResultCraft(Item left_item, Item right_item)
- - public Item CraftItem(Item left_item, Item right_item)
- - public static string ConvertLegacyItemId(string id)
- - public void SpendRightItem()
- - public void SpendLeftItem()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public bool CanFitCraftedItem()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void emergencyShutDown()
- - public override void update(GameTime time)
- - public override void draw(SpriteBatch b)

## Private Members
- - private ICue _sewingSound;
- - private readonly Dictionary<Item, TailorHighlight> ItemHighlightCache = new Dictionary<Item, TailorHighlight>();
- - private void _leftIngredientSpotClicked()
- - private void _rightIngredientSpotClicked()
- - private bool HasRequiredTags(Item item, List<string> requiredTags)

## Protected Members
- - protected int _timeUntilCraft;
- - protected float _rightItemOffset;
- - protected bool _shouldPrismaticDye;
- - protected bool _isDyeCraft;
- - protected bool _isMultipleResultCraft;
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
