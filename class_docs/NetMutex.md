# NetMutex

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public const long NoOwner = -1L;
- - public NetFields NetFields { get; } = new NetFields("NetMutex");
- - public NetMutex()
- - public void RequestLock(Action acquired = null, Action failed = null)
- - public void ReleaseLock()
- - public bool IsLocked()
- - public bool IsLockHeld()
- - public void Update(GameLocation location)
- - public void Update(FarmerCollection farmers)

## Private Members
- - private long prevOwner = -1L;
- - private readonly NetLong owner = new NetLong(-1L)
- - private readonly NetEvent1Field<long, NetLong> lockRequest = new NetEvent1Field<long, NetLong>
- - private Action onLockAcquired;
- - private Action onLockFailed;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
