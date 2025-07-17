# NetWitnessedLock

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetFields NetFields { get; } = new NetFields("NetWitnessedLock");
- - public NetWitnessedLock()
- - public void RequestLock(Action acquired, Action failed)
- - public bool IsLocked()
- - public void Update()

## Private Members
- - private readonly NetBool requested = new NetBool().Interpolated(interpolate: false, wait: false);
- - private readonly NetFarmerCollection witnesses = new NetFarmerCollection();
- - private Action acquired;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
