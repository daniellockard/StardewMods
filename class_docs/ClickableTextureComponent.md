# ClickableTextureComponent

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Texture2D texture;
- - public Rectangle sourceRect;
- - public Rectangle startingSourceRect;
- - public float baseScale;
- - public string hoverText = "";
- - public bool drawLabel = true;
- - public bool drawShadow;
- - public bool drawLabelWithShadow;
- - public ClickableTextureComponent(string name, Rectangle bounds, string label, string hoverText, Texture2D texture, Rectangle sourceRect, float scale, bool drawShadow = false)
- - public ClickableTextureComponent(Rectangle bounds, Texture2D texture, Rectangle sourceRect, float scale, bool drawShadow = false)
- - public Vector2 getVector2()
- - public void setPosition(Vector2 position)
- - public void setPosition(int x, int y)
- - public virtual void tryHover(int x, int y, float maxScaleIncrease = 0.1f)
- - public virtual void draw(SpriteBatch b)
- - public virtual void draw(SpriteBatch b, Color c, float layerDepth, int frameOffset = 0, int xOffset = 0, int yOffset = 0)
- - public virtual void drawItem(SpriteBatch b, int xOffset = 0, int yOffset = 0, float alpha = 1f)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
