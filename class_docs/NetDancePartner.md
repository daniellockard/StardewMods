# NetDancePartner

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public Character Value
- - public NetFields NetFields { get; } = new NetFields("NetDancePartner");
- - public NetDancePartner()
- - public NetDancePartner(Farmer farmer)
- - public NetDancePartner(string villagerName)
- - public Character GetCharacter()
- - public void SetCharacter(Character value)
- - public NPC TryGetVillager()
- - public Farmer TryGetFarmer()
- - public bool IsFarmer()
- - public bool IsVillager()
- - public Gender GetGender()

## Private Members
- - private readonly NetFarmerRef farmer = new NetFarmerRef();
- - private readonly NetString villager = new NetString();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
