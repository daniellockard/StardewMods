# ClickableComponent

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int ID_ignore = -500;
- - public const int CUSTOM_SNAP_BEHAVIOR = -7777;
- - public const int SNAP_AUTOMATIC = -99998;
- - public const int SNAP_TO_DEFAULT = -99999;
- - public Rectangle bounds;
- - public string name;
- - public string label;
- - public float scale = 1f;
- - public Item item;
- - public bool visible = true;
- - public bool leftNeighborImmutable;
- - public bool rightNeighborImmutable;
- - public bool upNeighborImmutable;
- - public bool downNeighborImmutable;
- - public bool fullyImmutable;
- - public int myID = -500;
- - public int myAlternateID = -500;
- - public int leftNeighborID = -1;
- - public int rightNeighborID = -1;
- - public int upNeighborID = -1;
- - public int downNeighborID = -1;
- - public int region;
- - public bool tryDefaultIfNoRightNeighborExists;
- - public bool tryDefaultIfNoDownNeighborExists;
- - public string ScreenReaderText { get; set; }
- - public string ScreenReaderDescription { get; set; }
- - public bool ScreenReaderIgnore { get; set; }
- - public ClickableComponent(Rectangle bounds, string name)
- - public ClickableComponent(Rectangle bounds, string name, string label)
- - public ClickableComponent(Rectangle bounds, Item item)
- - public virtual bool containsPoint(int x, int y)
- - public virtual bool containsPoint(int x, int y, int extraMargin)
- - public void snapMouseCursorToCenter()
- - public static void SetUpNeighbors<T>(List<T> components, int id) where T : ClickableComponent
- - public static void ChainNeighborsLeftRight<T>(List<T> components) where T : ClickableComponent
- - public static void ChainNeighborsUpDown<T>(List<T> components) where T : ClickableComponent

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
