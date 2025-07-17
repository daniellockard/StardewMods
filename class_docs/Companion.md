# Companion

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetInt direction = new NetInt();
- - public readonly NetInt whichVariant = new NetInt();
- - public float lerp = -1f;
- - public Vector2 startPosition;
- - public Vector2 endPosition;
- - public float height;
- - public float gravity;
- - public NetEvent1Field<float, NetFloat> hopEvent = new NetEvent1Field<float, NetFloat>();
- - public NetFields NetFields { get; } = new NetFields("Companion");
- - public Farmer Owner
- - public Vector2 Position
- - public Vector2 OwnerPosition
- - public bool IsLocal => Owner.IsLocalPlayer;
- - public Companion()
- - public virtual void InitializeCompanion(Farmer farmer)
- - public virtual void CleanupCompanion()
- - public virtual void InitNetFields()
- - public virtual void Hop(float amount)
- - public virtual void Update(GameTime time, GameLocation location)
- - public virtual void Draw(SpriteBatch b)
- - public virtual void OnOwnerWarp()

## Private Members
- *(None)*

## Protected Members
- - protected readonly NetPosition _position = new NetPosition();
- - protected readonly NetFarmerRef _owner = new NetFarmerRef();

## Internal Members
- *(None)*

## Other Members
- *(None)*
