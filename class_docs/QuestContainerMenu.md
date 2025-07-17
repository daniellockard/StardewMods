# QuestContainerMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public enum ChangeType
- - public InventoryMenu ItemsToGrabMenu;
- - public Func<Item, int> stackCapacityCheck;
- - public Action onItemChanged;
- - public Action onConfirm;
- - public QuestContainerMenu(IList<Item> inventory, int rows = 3, InventoryMenu.highlightThisItem highlight_method = null, Func<Item, int> stack_capacity_check = null, Action on_item_changed = null, Action on_confirm = null)
- - public virtual int GetDonatableAmount(Item item)
- - public virtual Item TryToGrab(Item item, int amount)
- - public virtual Item TryToPlace(Item item, int amount)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
