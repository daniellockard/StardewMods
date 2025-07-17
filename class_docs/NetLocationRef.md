# NetLocationRef

**Summary:** Represents a place or area in the game world.

## Public Members
- - public readonly NetString locationName = new NetString();
- - public readonly NetBool isStructure = new NetBool();
- - public Action OnLocationChanged;
- - public string LocationName => locationName.Value;
- - public bool IsStructure => isStructure.Value;
- - public GameLocation Value
- - public NetFields NetFields { get; } = new NetFields("NetLocationRef");
- - public NetLocationRef()
- - public NetLocationRef(GameLocation value)
- - public bool IsChanging()
- - public void Update(bool forceUpdate = false)
- - public void ApplyChangesIfDirty()
- - public GameLocation Get()
- - public void Set(GameLocation location)
- - public bool IsCurrentlyViewedLocation()

## Private Members
- *(None)*

## Protected Members
- - protected GameLocation _gameLocation;
- - protected bool _dirty = true;
- - protected bool _usedLocalLocation;

## Internal Members
- *(None)*

## Other Members
- *(None)*
