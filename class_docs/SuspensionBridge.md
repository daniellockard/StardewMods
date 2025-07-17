# SuspensionBridge

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Rectangle bridgeBounds;
- - public List<Rectangle> bridgeEntrances = new List<Rectangle>();
- - public List<Rectangle> bridgeSortRegions = new List<Rectangle>();
- - public const float BRIDGE_SORT_OFFSET = 0.0256f;
- - public float shakeTime;
- - public SuspensionBridge()
- - public SuspensionBridge(int tile_x, int tile_y)
- - public virtual bool InEntranceArea(int x, int y)
- - public virtual bool InEntranceArea(Rectangle rectangle)
- - public virtual bool CheckPlacementPrevention(Vector2 tileLocation)
- - public virtual void OnFootstep(Vector2 position)
- - public virtual void Update(GameTime time)
- - public virtual void Draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected Texture2D _texture;

## Internal Members
- *(None)*

## Other Members
- *(None)*
