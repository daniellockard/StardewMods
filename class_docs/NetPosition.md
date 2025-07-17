# NetPosition

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public bool ExtrapolationEnabled;
- - public readonly NetBool moving = new NetBool().Interpolated(interpolate: false, wait: false);
- - public override NetFields NetFields { get; } = new NetFields("NetPosition");
- - public float X
- - public float Y
- - public event FieldChange<NetPosition, Vector2> fieldChangeEvent;
- - public event FieldChange<NetPosition, Vector2> fieldChangeVisibleEvent;
- - public NetPosition()
- - public NetPosition(NetVector2 field)
- - public override Vector2 Get()
- - public Vector2 CurrentInterpolationDirection()
- - public float CurrentInterpolationSpeed()
- - public void UpdateExtrapolation(float extrapolationSpeed)

## Private Members
- - private const float SmoothingFudge = 0.8f;
- - private const ushort DefaultDeltaAggregateTicks = 0;

## Protected Members
- - protected override void initNetFields()
- - protected bool IsMaster()

## Internal Members
- *(None)*

## Other Members
- *(None)*
