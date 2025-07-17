# NetFarmerCollection

**Summary:** Represents the player character, including stats, inventory, and actions.

## Public Members
- - public delegate void FarmerEvent(Farmer f);
- - public NetFields NetFields { get; } = new NetFields("NetFarmerCollection");
- - public int Count => farmers.Count;
- - public bool IsReadOnly => false;
- - public event FarmerEvent FarmerAdded;
- - public event FarmerEvent FarmerRemoved;
- - public NetFarmerCollection()
- - public bool RetainOnlinePlayers()
- - public void Add(Farmer item)
- - public void Clear()
- - public bool Contains(Farmer item)
- - public void CopyTo(Farmer[] array, int arrayIndex)
- - public bool Remove(Farmer item)
- - public IEnumerator<Farmer> GetEnumerator()

## Private Members
- - private List<Farmer> farmers = new List<Farmer>();
- - private NetLongDictionary<bool, NetBool> uids = new NetLongDictionary<bool, NetBool>();
- - private static bool playerIsOnline(long uid)
- - private Farmer getFarmer(long uid)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
