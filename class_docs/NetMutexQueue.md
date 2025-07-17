# NetMutexQueue

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public Action<T> Processor = delegate
- - public NetFields NetFields { get; } = new NetFields("NetMutexQueue");
- - public NetMutexQueue()
- - public void Add(T job)
- - public bool Contains(T job)
- - public void Clear()
- - public void Update(GameLocation location)

## Private Members
- - private readonly NetLongDictionary<bool, NetBool> requests = new NetLongDictionary<bool, NetBool>
- - private readonly NetLong currentOwner = new NetLong
- - private readonly List<T> localJobs = new List<T>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
