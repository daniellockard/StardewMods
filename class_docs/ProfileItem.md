# ProfileItem

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public string itemName = "";
- - public ProfileItem(ProfileMenu context, string name)
- - public virtual void Unload()
- - public virtual string GetName()
- - public virtual void performHover(int x, int y)
- - public virtual float HandleLayout(float draw_y, Rectangle content_rectangle, int index)
- - public virtual void DrawItemName(SpriteBatch b)
- - public virtual void Draw(SpriteBatch b)
- - public virtual void DrawItem(SpriteBatch b)
- - public virtual bool ShouldDraw()

## Private Members
- *(None)*

## Protected Members
- - protected ProfileMenu _context;
- - protected Vector2 _nameDrawPosition;

## Internal Members
- *(None)*

## Other Members
- *(None)*
