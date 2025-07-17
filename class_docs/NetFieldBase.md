# NetFieldBase

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public bool InterpolationEnabled
- - public bool ExtrapolationEnabled
- - public bool InterpolationWait
- - public T TargetValue => targetValue;
- - public T Value
- - public event FieldChange<TSelf, T> fieldChangeEvent;
- - public event FieldChange<TSelf, T> fieldChangeVisibleEvent;
- - public NetFieldBase()
- - public NetFieldBase(T value)
- - public TSelf Interpolated(bool interpolate, bool wait)
- - public bool IsInterpolating()
- - public bool IsChanging()
- - public void CancelInterpolation()
- - public T Get()
- - public abstract void Set(T newValue);
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void WriteFull(BinaryWriter writer)
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void Write(BinaryWriter writer)
- - public override string ToString()
- - public override bool Equals(object obj)
- - public bool Equals(TSelf other)
- - public static bool operator ==(NetFieldBase<T, TSelf> self, TSelf other)
- - public static bool operator !=(NetFieldBase<T, TSelf> self, TSelf other)
- - public override int GetHashCode()

## Private Members
- *(None)*

## Protected Members
- - protected enum NetFieldBaseBool : byte
- - protected NetFieldBaseBool _bools;
- - protected uint interpolationStartTick;
- - protected T value;
- - protected T previousValue;
- - protected T targetValue;
- - protected bool notifyOnTargetValueChange
- - protected virtual int InterpolationTicks()
- - protected float InterpolationFactor()
- - protected override bool tickImpl()
- - protected virtual T interpolate(T startValue, T endValue, float factor)
- - protected bool canShortcutSet()
- - protected virtual void targetValueChanged(T oldValue, T newValue)
- - protected void cleanSet(T newValue)
- - protected virtual bool setUpInterpolation(T oldValue, T newValue)
- - protected void setInterpolationTarget(T newValue)
- - protected abstract void ReadDelta(BinaryReader reader, NetVersion version);
- - protected abstract void WriteDelta(BinaryWriter writer);

## Internal Members
- *(None)*

## Other Members
- *(None)*
