# PI_ItemList

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public PI_ItemList(ProfileMenu context, string name, List<Item> values)
- - public override void Unload()
- - public override float HandleLayout(float draw_y, Rectangle content_rectangle, int index)
- - public override void DrawItem(SpriteBatch b)
- - public override void performHover(int x, int y)
- - public override bool ShouldDraw()

## Private Members
- *(None)*

## Protected Members
- - protected List<Item> _items;
- - protected List<ClickableTextureComponent> _components;
- - protected float _height;
- - protected List<Vector2> _emptyBoxPositions;
- - protected void _ClearItems()
- - protected void _UpdateIcons()

## Internal Members
- *(None)*

## Other Members
- *(None)*
