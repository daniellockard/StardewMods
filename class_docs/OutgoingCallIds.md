# OutgoingCallIds

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const string AdventureGuild = "AdventureGuild";
- - public const string AnimalShop = "AnimalShop";
- - public const string Blacksmith = "Blacksmith";
- - public const string Carpenter = "Carpenter";
- - public const string Saloon = "Saloon";
- - public const string SeedShop = "SeedShop";
- - public string CheckForIncomingCall(Random random)
- - public bool TryHandleIncomingCall(string callId, out Action showDialogue)
- - public IEnumerable<KeyValuePair<string, string>> GetOutgoingNumbers()
- - public bool TryHandleOutgoingCall(string callId)
- - public void CallAdventureGuild()
- - public void CallAnimalShop()
- - public void CallBlacksmith()
- - public void CallCarpenter()
- - public void CallSaloon()
- - public void CallSeedShop()
- - public interface IPhoneHandler

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
