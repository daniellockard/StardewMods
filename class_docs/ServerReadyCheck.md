# ServerReadyCheck

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public ServerReadyCheck(string id)
- - public override void SetRequiredFarmers(List<long> farmerIds)
- - public override bool SetLocalReady(bool ready)
- - public override void Update()
- - public override void ProcessMessage(ReadyCheckMessageType messageType, IncomingMessage message)

## Private Members
- - private readonly Dictionary<long, ReadyState> ReadyStates = new Dictionary<long, ReadyState>();
- - private bool Locking;
- - private readonly HashSet<long> RequiredFarmers = new HashSet<long>();
- - private bool IncludesAll => RequiredFarmers.Count == 0;
- - private void ProcessReady(IncomingMessage message)
- - private void ProcessCancel(IncomingMessage message)
- - private void ProcessAcceptLock(IncomingMessage message)
- - private void ProcessRejectLock(IncomingMessage message)
- - private void ProcessRequireFarmers(IncomingMessage message)
- - private void RequireFarmers(ICollection<long> farmerIds)
- - private bool IsFarmerRequired(long uid)

## Protected Members
- - protected override void SendMessage(ReadyCheckMessageType messageType, params object[] data)

## Internal Members
- *(None)*

## Other Members
- *(None)*
