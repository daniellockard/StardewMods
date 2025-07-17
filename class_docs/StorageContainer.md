# StorageContainer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public delegate bool behaviorOnItemChange(Item i, int position, Item old, StorageContainer container, bool onRemoval = false);
- - public InventoryMenu ItemsToGrabMenu;
- - public StorageContainer(IList<Item> inventory, int capacity, int rows = 3, behaviorOnItemChange itemChangeBehavior = null, InventoryMenu.highlightThisItem highlightMethod = null)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void update(GameTime time)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private TemporaryAnimatedSprite poof;
- - private behaviorOnItemChange itemChangeBehavior;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
