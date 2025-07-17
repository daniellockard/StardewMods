# NetSynchronizer

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public void barrier(string name)
- - public bool isBarrierReady(string name)
- - public bool isVarReady(string varName)
- - public T waitForVar<TField, T>(string varName) where TField : NetFieldBase<T, TField>, new()
- - public void sendVar<TField, T>(string varName, T value) where TField : NetFieldBase<T, TField>, new()
- - public bool hasVar(string varName)
- - public abstract void processMessages();
- - public void receiveMessage(IncomingMessage msg)

## Private Members
- - private const byte MessageTypeVar = 0;
- - private const byte MessageTypeBarrier = 1;
- - private Dictionary<string, INetObject<INetSerializable>> variables = new Dictionary<string, INetObject<INetSerializable>>();
- - private Dictionary<string, HashSet<long>> barriers = new Dictionary<string, HashSet<long>>();
- - private HashSet<long> barrierPlayers(string name)
- - private bool barrierReady(string name)

## Protected Members
- - protected void reset()
- - protected bool shouldAbort()
- - protected abstract void sendMessage(params object[] data);

## Internal Members
- *(None)*

## Other Members
- *(None)*
