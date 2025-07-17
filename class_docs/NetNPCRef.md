# NetNPCRef

**Summary:** Represents a non-player character (villager, merchant, etc.).

## Public Members
- - public NetFields NetFields { get; } = new NetFields("NetNPCRef");
- - public NetNPCRef()
- - public NPC Get(GameLocation location)
- - public void Set(GameLocation location, NPC npc)
- - public void Clear()

## Private Members
- - private readonly NetGuid guid = new NetGuid();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
