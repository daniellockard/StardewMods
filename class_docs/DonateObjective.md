# DonateObjective

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetString dropBox = new NetString();
- - public NetString dropBoxGameLocation = new NetString();
- - public NetVector2 dropBoxTileLocation = new NetVector2();
- - public NetStringList acceptableContextTagSets = new NetStringList();
- - public NetInt minimumCapacity = new NetInt(-1);
- - public NetBool confirmed = new NetBool(value: false);
- - public virtual string GetDropboxLocationName()
- - public override void Load(SpecialOrder order, Dictionary<string, string> data)
- - public int GetAcceptCount(Item item, int stack_count)
- - public override void OnCompletion()
- - public override bool CanComplete()
- - public virtual void Confirm()
- - public override bool CanUncomplete()
- - public override void InitializeNetFields()
- - public virtual bool IsValidItem(Item item)

## Private Members
- *(None)*

## Protected Members
- - protected void OnConfirmed(NetBool field, bool oldValue, bool newValue)

## Internal Members
- *(None)*

## Other Members
- *(None)*
