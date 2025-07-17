# MultipleMutexRequest

**Summary:** Represents a quest or mission.

## Public Members
- - public MultipleMutexRequest(List<NetMutex> mutexes, Action<MultipleMutexRequest> success_callback = null, Action<MultipleMutexRequest> failure_callback = null)
- - public MultipleMutexRequest(NetMutex[] mutexes, Action<MultipleMutexRequest> success_callback = null, Action<MultipleMutexRequest> failure_callback = null)
- - public void ReleaseLocks()

## Private Members
- *(None)*

## Protected Members
- - protected int _reportedCount;
- - protected List<NetMutex> _acquiredLocks;
- - protected List<NetMutex> _mutexList;
- - protected Action<MultipleMutexRequest> _onSuccess;
- - protected Action<MultipleMutexRequest> _onFailure;
- - protected void _RequestMutexes()
- - protected void _OnLockAcquired(NetMutex mutex)
- - protected void _OnLockFailed(NetMutex mutex)
- - protected void _Finalize()

## Internal Members
- *(None)*

## Other Members
- *(None)*
