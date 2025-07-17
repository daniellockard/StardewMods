# TailorRecipeListTool

**Summary:** Represents a tool used by the player (hoe, axe, etc.).

## Public Members
- - public Rectangle scrollView;
- - public List<ClickableTextureComponent> recipeComponents = new List<ClickableTextureComponent>();
- - public ClickableTextureComponent okButton;
- - public float scrollY;
- - public Dictionary<string, KeyValuePair<Item, Item>> _recipeLookup = new Dictionary<string, KeyValuePair<Item, Item>>();
- - public Item hoveredItem;
- - public string hoverText = "";
- - public Dictionary<string, string> _recipeHoverTexts = new Dictionary<string, string>();
- - public Dictionary<string, string> _recipeOutputIds = new Dictionary<string, string>();
- - public Dictionary<string, Color> _recipeColors = new Dictionary<string, Color>();
- - public TailorRecipeListTool()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public void RepositionScrollElements()
- - public override void snapToDefaultClickableComponent()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveScrollWheelAction(int direction)
- - public override void performHoverAction(int x, int y)
- - public bool canLeaveMenu()
- - public override void draw(SpriteBatch b)
- - public delegate void TextBoxEvent(TextBox sender);

## Private Members
- - private void RepositionElements()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
