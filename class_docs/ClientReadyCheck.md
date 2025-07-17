# ClientReadyCheck

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public ClientReadyCheck(string id)
- - public override void SetRequiredFarmers(List<long> farmerIds)
- - public override bool SetLocalReady(bool ready)
- - public override void Update()
- - public override void ProcessMessage(ReadyCheckMessageType messageType, IncomingMessage message)

## Private Members
- - private void ProcessLock(IncomingMessage message)
- - private void ProcessRelease(IncomingMessage message)
- - private void ProcessUpdateAmounts(IncomingMessage message)
- - private void ProcessFinish(IncomingMessage message)

## Protected Members
- - protected override void SendMessage(ReadyCheckMessageType messageType, params object[] data)

## Internal Members
- - internal enum ReadyCheckMessageType : byte
- - internal enum ReadyState : byte

## Other Members
- *(None)*
