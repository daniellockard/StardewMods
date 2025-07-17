# NetPausableField

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public readonly TField Field;
- - public T Value
- - public bool Paused
- - public abstract NetFields NetFields { get; }
- - public NetPausableField(TField field)
- - public NetPausableField()
- - public virtual T Get()
- - public void Set(T value)
- - public bool IsPausePending()
- - public bool IsInterpolating()

## Private Members
- - private bool paused;
- - private readonly NetEvent1Field<bool, NetBool> pauseEvent = new NetEvent1Field<bool, NetBool>();

## Protected Members
- - protected virtual void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
