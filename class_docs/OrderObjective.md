# OrderObjective

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetIntDelta currentCount = new NetIntDelta();
- - public NetInt maxCount = new NetInt(0);
- - public NetString description = new NetString();
- - public NetBool failOnCompletion = new NetBool(value: false);
- - public NetFields NetFields { get; } = new NetFields("OrderObjective");
- - public OrderObjective()
- - public virtual void OnFail()
- - public virtual void InitializeNetFields()
- - public void Register(SpecialOrder new_order)
- - public virtual void Unregister()
- - public virtual bool ShouldShowProgress()
- - public int GetCount()
- - public virtual void IncrementCount(int amount)
- - public virtual void SetCount(int new_count)
- - public int GetMaxCount()
- - public virtual void OnCompletion()
- - public virtual void CheckCompletion(bool play_sound = true)
- - public virtual bool IsComplete()
- - public virtual bool CanUncomplete()
- - public virtual bool CanComplete()
- - public virtual string GetDescription()
- - public virtual void Load(SpecialOrder order, Dictionary<string, string> data)

## Private Members
- *(None)*

## Protected Members
- - protected SpecialOrder _order;
- - protected bool _complete;
- - protected bool _registered;
- - protected void OnCurrentCountChanged(NetIntDelta field, int oldValue, int newValue)
- - protected virtual void _Register()
- - protected virtual void _Unregister()

## Internal Members
- *(None)*

## Other Members
- *(None)*
