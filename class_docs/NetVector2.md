# NetVector2

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public bool AxisAlignedMovement;
- - public float ExtrapolationSpeed;
- - public float MinDeltaForDirectionChange = 8f;
- - public float MaxInterpolationDistance = 320f;
- - public float X
- - public float Y
- - public NetVector2()
- - public NetVector2(Vector2 value)
- - public void Set(float x, float y)
- - public override void Set(Vector2 newValue)
- - public Vector2 InterpolationDelta()
- - public Vector2 CurrentInterpolationDirection()
- - public float CurrentInterpolationSpeed()

## Private Members
- - private bool interpolateXFirst;
- - private bool isExtrapolating;
- - private bool isFixingExtrapolation;

## Protected Members
- - protected override bool setUpInterpolation(Vector2 oldValue, Vector2 newValue)
- - protected override Vector2 interpolate(Vector2 startValue, Vector2 endValue, float factor)
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
