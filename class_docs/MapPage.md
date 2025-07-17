# MapPage

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum WorldMapDebugLineType
- - public static WorldMapDebugLineType EnableDebugLines;
- - public readonly MapAreaPositionWithContext? mapPosition;
- - public readonly MapRegion mapRegion;
- - public readonly MapArea[] mapAreas;
- - public readonly string scrollText;
- - public readonly int defaultComponentID;
- - public Rectangle mapBounds;
- - public readonly Dictionary<string, ClickableComponent> points = new Dictionary<string, ClickableComponent>(StringComparer.OrdinalIgnoreCase);
- - public string hoverText = "";
- - public MapPage(int x, int y, int width, int height)
- - public override void populateClickableComponentList()
- - public void SetNeighborId(ClickableComponent component, string direction, string neighborKeys)
- - public bool TryGetNeighborId(string keys, out int id, out bool foundIgnore, bool isAlias = false)
- - public override void snapToDefaultClickableComponent()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public override void receiveKeyPress(Keys key)
- - public virtual void drawMiniPortraits(SpriteBatch b, float alpha = 1f)
- - public virtual void drawScroll(SpriteBatch b)
- - public virtual void drawMap(SpriteBatch b, bool drawBorders = true, float alpha = 1f)
- - public virtual void drawTooltip(SpriteBatch b)
- - public Point GetNormalizedPlayerTile(Farmer player)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
