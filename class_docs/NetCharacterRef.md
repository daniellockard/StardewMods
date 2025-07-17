# NetCharacterRef

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetFields NetFields { get; } = new NetFields("NetCharacterRef");
- - public NetCharacterRef()
- - public Character Get(GameLocation location)
- - public void Set(GameLocation location, Character character)
- - public void Clear()

## Private Members
- - private readonly NetNPCRef npc = new NetNPCRef();
- - private readonly NetFarmerRef farmer = new NetFarmerRef();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
