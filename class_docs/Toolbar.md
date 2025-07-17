# Toolbar

**Summary:** Represents a tool used by the player (hoe, axe, etc.).

## Public Members
- - public List<ClickableComponent> buttons = new List<ClickableComponent>();
- - public new int yPositionOnScreen;
- - public Item hoverItem;
- - public float transparency = 1f;
- - public string[] slotText = new string[12]
- - public Rectangle toolbarTextSource = new Rectangle(0, 256, 60, 60);
- - public Toolbar()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public void shifted(bool right)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override bool isWithinBounds(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private bool hoverDirty = true;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
