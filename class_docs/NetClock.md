# NetClock

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetVersion netVersion;
- - public int LocalId;
- - public int InterpolationTicks;
- - public List<bool> blanks = new List<bool>();
- - public NetClock()
- - public int AddNewPeer()
- - public void RemovePeer(int id)
- - public uint GetLocalTick()
- - public void Tick()
- - public void Clear()
- - public override string ToString()
- - public interface INetRoot
- - public interface INetSerializable
- - public interface INetObject<out T> where T : INetSerializable
- - public interface InterpolationCancellable

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
