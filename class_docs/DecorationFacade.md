# DecorationFacade

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public delegate void ChangeEvent(int whichRoom, int which);
- - public readonly NetIntDictionary<int, NetInt> Field = new NetIntDictionary<int, NetInt>
- - public static bool warnedDeprecated;
- - public int this[int whichRoom]
- - public int Count
- - public event ChangeEvent OnChange;
- - public DecorationFacade()
- - public void Set(DecorationFacade other)
- - public void SetCountAtLeast(int targetCount)
- - public void Update()
- - public virtual void WarnDeprecation()

## Private Members
- - private List<Action> pendingChanges = new List<Action>();
- - private void changed(int whichRoom, int which)

## Protected Members
- - protected override List<int> Serialize()
- - protected override void DeserializeAdd(int serialValue)

## Internal Members
- *(None)*

## Other Members
- *(None)*
