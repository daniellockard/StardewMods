# TerrainFeature

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly bool NeedsTick;
- - public bool isTemporarilyInvisible;
- - public virtual GameLocation Location { get; set; }
- - public virtual Vector2 Tile { get; set; }
- - public ModDataDictionary modData { get; } = new ModDataDictionary();
- - public ModDataDictionary modDataForSerialization
- - public bool NeedsUpdate
- - public NetFields NetFields { get; }
- - public virtual void initNetFields()
- - public virtual Rectangle getBoundingBox()
- - public virtual Rectangle getRenderBounds()
- - public virtual void loadSprite()
- - public virtual bool isPassable(Character c = null)
- - public virtual void OnAddedToLocation(GameLocation location, Vector2 tile)
- - public virtual void doCollisionAction(Rectangle positionOfCollider, int speedOfCollision, Vector2 tileLocation, Character who)
- - public virtual bool performUseAction(Vector2 tileLocation)
- - public virtual bool performToolAction(Tool t, int damage, Vector2 tileLocation)
- - public virtual bool tickUpdate(GameTime time)
- - public virtual void dayUpdate()
- - public virtual bool seasonUpdate(bool onLoad)
- - public virtual bool isActionable()
- - public virtual void performPlayerEntryAction()
- - public virtual void draw(SpriteBatch spriteBatch)
- - public virtual bool forceDraw()
- - public virtual void drawInMenu(SpriteBatch spriteBatch, Vector2 positionOnScreen, Vector2 tileLocation, float scale, float layerDepth)

## Private Members
- *(None)*

## Protected Members
- - protected bool _needsUpdate = true;
- - protected TerrainFeature(bool needsTick)

## Internal Members
- *(None)*

## Other Members
- *(None)*
