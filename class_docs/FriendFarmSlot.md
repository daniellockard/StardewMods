# FriendFarmSlot

**Summary:** Represents the player's farm, its state, and related locations.

## Public Members
- - public FriendFarmData Farm;
- - public FriendFarmSlot(CoopMenu menu, FriendFarmData farm)
- - public bool MatchAddress(object Lobby)
- - public void Update(FriendFarmData newData)
- - public override void Activate()
- - public override void Draw(SpriteBatch b, int i)

## Private Members
- *(None)*

## Protected Members
- - protected virtual string slotName()
- - protected virtual void drawSlotName(SpriteBatch b, int i)
- - protected virtual void drawSlotDate(SpriteBatch b, int i)
- - protected virtual void drawSlotFarm(SpriteBatch b, int i)
- - protected virtual void drawSlotOwnerName(SpriteBatch b, int i)

## Internal Members
- *(None)*

## Other Members
- *(None)*
