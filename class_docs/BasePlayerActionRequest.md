# BasePlayerActionRequest

**Summary:** Represents a quest or mission.

## Public Members
- - public PlayerActionTarget Target { get; private set; }
- - public long? OnlyPlayerId { get; private set; }
- - public virtual void Read(BinaryReader reader)
- - public virtual void Write(BinaryWriter writer)
- - public bool MatchesPlayer(Farmer player)
- - public bool OnlyForLocalPlayer()
- - public abstract void PerformAction(Farmer farmer);

## Private Members
- *(None)*

## Protected Members
- - protected BasePlayerActionRequest()
- - protected BasePlayerActionRequest(PlayerActionTarget target, long? onlyPlayerId)

## Internal Members
- *(None)*

## Other Members
- *(None)*
