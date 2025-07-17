# CraneGameObject

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Vector2 position = Vector2.Zero;
- - public float rotation;
- - public Vector2 scale = new Vector2(1f, 1f);
- - public bool flipX;
- - public bool flipY;
- - public Rectangle spriteRect;
- - public Texture2D texture;
- - public Vector2 spriteAnchor;
- - public Color color = Color.White;
- - public float layerDepth = -1f;
- - public int width = 16;
- - public int height = 16;
- - public float zPosition;
- - public bool visible = true;
- - public List<DrawEffect> drawEffects;
- - public CraneGameObject(CraneGame game)
- - public void SetSpriteFromIndex(int index = 0)
- - public bool IsDestroyed()
- - public virtual void Destroy()
- - public virtual void Move(float x, float y)
- - public Rectangle GetBounds()
- - public virtual void Update(GameTime time)
- - public float GetRendererLayerDepth()
- - public void ApplyDrawEffect(DrawEffect new_effect)
- - public virtual void Draw(SpriteBatch b, float layer_depth)

## Private Members
- *(None)*

## Protected Members
- - protected CraneGame _game;
- - protected bool _destroyed;

## Internal Members
- *(None)*

## Other Members
- *(None)*
