# NetFarmerRef

**Summary:** Represents the player character, including stats, inventory, and actions.

## Public Members
- - public readonly NetBool defined = new NetBool();
- - public readonly NetLong uid = new NetLong();
- - public NetFields NetFields { get; } = new NetFields("NetFarmerRef");
- - public long UID
- - public Farmer Value
- - public NetFarmerRef()
- - public NetFarmerRef Delayed(bool interpolationWait)
- - public void Set(NetFarmerRef other)
- - public IEnumerator<long?> GetEnumerator()
- - public void Add(long? value)

## Private Members
- - private Farmer getFarmer(long uid)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
