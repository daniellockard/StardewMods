# BaseReadyCheck

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public string Id { get; }
- - public int ActiveLockId { get; protected set; }
- - public ReadyState State { get; protected set; }
- - public int NumberReady { get; protected set; }
- - public int NumberRequired { get; protected set; }
- - public bool IsReady { get; protected set; }
- - public bool IsCancelable => State != ReadyState.Locked;
- - public abstract void SetRequiredFarmers(List<long> farmerIds);
- - public virtual bool SetLocalReady(bool ready)
- - public abstract void Update();
- - public abstract void ProcessMessage(ReadyCheckMessageType messageType, IncomingMessage message);

## Private Members
- *(None)*

## Protected Members
- - protected BaseReadyCheck(string id)
- - protected abstract void SendMessage(ReadyCheckMessageType messageType, params object[] data);
- - protected OutgoingMessage CreateSyncMessage(ReadyCheckMessageType messageType, params object[] data)

## Internal Members
- *(None)*

## Other Members
- *(None)*
