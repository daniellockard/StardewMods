# NetDirection

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetPosition Position;
- - public NetDirection()
- - public NetDirection(int value)
- - public override void Set(int newValue)
- - public int getInterpolatedDirection()

## Private Members
- *(None)*

## Protected Members
- - protected override bool setUpInterpolation(int oldValue, int newValue)
- - protected override int interpolate(int startValue, int endValue, float factor)
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
