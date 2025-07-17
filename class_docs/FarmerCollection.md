# FarmerCollection

**Summary:** Represents the player character, including stats, inventory, and actions.

## Public Members
- - public struct Enumerator : IEnumerator<Farmer>, IEnumerator, IDisposable
- - public Farmer Current => _current;
- - public Enumerator(GameLocation locationFilter)
- - public bool MoveNext()
- - public void Dispose()
- - public int Count
- - public FarmerCollection(GameLocation locationFilter = null)
- - public bool Any()
- - public bool Contains(Farmer farmer)
- - public Enumerator GetEnumerator()
- - public interface IGameServer : IBandwidthMonitor

## Private Members
- - private GameLocation _locationFilter;
- - private Dictionary<long, NetRoot<Farmer>>.Enumerator _enumerator;
- - private Farmer _player;
- - private Farmer _current;
- - private int _done;
- - private GameLocation _locationFilter;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
