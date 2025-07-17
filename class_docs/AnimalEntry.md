# AnimalEntry

**Summary:** Represents a farm animal and its behaviors.

## Public Members
- - public Character Animal;
- - public readonly string InternalName;
- - public readonly string DisplayName;
- - public readonly string AnimalType;
- - public readonly string AnimalBaseType;
- - public readonly int FriendshipLevel = -1;
- - public readonly bool ReceivedAnimalCracker;
- - public readonly int WasPetYet;
- - public readonly int special;
- - public Texture2D Texture;
- - public Rectangle TextureSourceRect;
- - public AnimalEntry(Character animal)
- - public const int slotsOnPage = 5;
- - public string hoverText = "";
- - public ClickableTextureComponent upButton;
- - public ClickableTextureComponent downButton;
- - public ClickableTextureComponent scrollBar;
- - public Rectangle scrollBarRunner;
- - public List<AnimalEntry> AnimalEntries;
- - public readonly List<ClickableTextureComponent> sprites = new List<ClickableTextureComponent>();
- - public int slotPosition;
- - public readonly List<ClickableTextureComponent> characterSlots = new List<ClickableTextureComponent>();
- - public bool scrolling;
- - public AnimalPage(int x, int y, int width, int height)
- - public void init()
- - public override void populateClickableComponentList()
- - public List<AnimalEntry> FindAnimals()
- - public IEnumerable<Character> GetAllAnimals()
- - public void CreateComponents()
- - public ClickableTextureComponent CreateSpriteComponent(AnimalEntry entry, int index)
- - public AnimalEntry GetSocialEntry(int index)
- - public override void snapToDefaultClickableComponent()
- - public void updateSlots()
- - public void addTabsToClickableComponents()
- - public void ConstrainSelectionToVisibleSlots()
- - public override void snapCursorToCurrentSnappedComponent()
- - public override void applyMovementKey(int direction)
- - public override void leftClickHeld(int x, int y)
- - public override void releaseLeftClick(int x, int y)
- - public override void receiveScrollWheelAction(int direction)
- - public void upArrowPressed()
- - public void downArrowPressed()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private void setScrollBarToCurrentIndex()
- - private bool isCharacterSlotClickable(int i)
- - private void drawNPCSlot(SpriteBatch b, int i)
- - private int rowPosition(int i)

## Protected Members
- - protected void _SelectSlot(AnimalEntry entry)
- - protected void _SelectSlot(ClickableComponent slot_component)

## Internal Members
- *(None)*

## Other Members
- *(None)*
