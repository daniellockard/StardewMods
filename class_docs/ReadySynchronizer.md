# ReadySynchronizer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public void SetLocalRequiredFarmers(string id, List<Farmer> requiredFarmers)
- - public void SetLocalReady(string id, bool ready)
- - public bool IsReady(string id)
- - public bool IsReadyCheckCancelable(string id)
- - public int GetNumberReady(string id)
- - public int GetNumberRequired(string id)
- - public void Update()
- - public void Reset()
- - public void ProcessMessage(IncomingMessage message)

## Private Members
- - private readonly Dictionary<string, BaseReadyCheck> ReadyChecks = new Dictionary<string, BaseReadyCheck>();
- - private BaseReadyCheck GetIfExists(string id)
- - private BaseReadyCheck GetOrCreate(string id)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
